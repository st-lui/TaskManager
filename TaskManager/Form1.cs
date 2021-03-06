﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;
using System.Collections;
using System.Threading;
using System.Management;

namespace TaskManager
{
	public partial class Form1 : Form
	{
		ProcessList processList;
		BindingSource processBindingSource;
		private void Initialize()
		{
			processBindingSource = new BindingSource();
			processGridView.AutoGenerateColumns = false;
			Updater.Start();
			processBindingSource.DataSource = typeof(Process);
			processGridView.DataSource = processBindingSource;
			processName.DataPropertyName = "ProcessName";
			timer1.Enabled = true;
			UpdateInterface();
		}

		public Form1()
		{
			InitializeComponent();
			Initialize();
		}
		/// <summary>
		/// Обновление интерфейса в соответствии со списком процессов
		/// </summary>
		private void UpdateInterface()
		{
			int scrollTo = processGridView.FirstDisplayedScrollingRowIndex;
			long pid = -1;
			if (processBindingSource.Current!=null)
				pid=((Process)processBindingSource.Current).Id;
			processList = ProcessList.TryGetInstance();
			if (processList != null && processList.List.Count > 0)
			{
				processBindingSource.Clear();
				foreach (Process p in processList.List)
					processBindingSource.Add(p);
				ProcessList.Unlock();
				int position = 0;
				for (int i = 0; i < processBindingSource.Count; i++)
				{
					if (((Process)processBindingSource[i]).Id == pid)
						position = i;
				}
				processBindingSource.Position = position;
				processGridView.FirstDisplayedScrollingRowIndex = Math.Min(processGridView.RowCount, Math.Max(0, scrollTo));
				totalProcessToolStripStatusLabel.Text = processBindingSource.Count.ToString();
			}
			else
				LogClass.GetInstance().Warn("Список процессов заблокирован для доступа");
		}

		/// <summary>
		/// Получение имени пользователя - владельца процесса
		/// </summary>
		/// <param name="processId">Идендификатор процесса (pid)</param>
		/// <returns></returns>
		public string GetProcessOwner(int processId)
		{
			try
			{
				string query = "Select * From Win32_Process Where ProcessID = " + processId;
				ManagementObjectSearcher wmiSearcher = new ManagementObjectSearcher(query);
				ManagementObjectCollection processList = wmiSearcher.Get();

				foreach (ManagementObject obj in processList)
				{
					string[] arr = new string[] { string.Empty, string.Empty };
					int result = Convert.ToInt32(obj.InvokeMethod("GetOwner", arr));
					if (result == 0)
						return arr[1] + "\\" + arr[0];
				}
				return "Нет владельца";
			}
			catch (Exception e)
			{
				StringBuilder sb = new StringBuilder();
				sb.AppendLine("Ошибка при получении владельца процесса.");
				sb.AppendLine(string.Format("Сообщение исключения {0}", e.Message));
				sb.AppendLine(string.Format("Тип исключения {0}", e.GetType().ToString()));
				sb.AppendLine(string.Format("Стек вызовов {0}", e.StackTrace));
				LogClass.GetInstance().Error(sb.ToString());
			}
			return "ошибка";
		}

		/// <summary>
		/// Получение подробной информации о процессе
		/// </summary>
		private void GetProcessInfo()
		{
			if (processBindingSource.Current != null)
			{
				try
				{
					processNameLabel.Text = pidLabel.Text = memoryLabel.Text = cpuTimeLabel.Text = threadsLabel.Text = ownerNameLabel.Text = "";
					Process process = (Process)processBindingSource.Current;
					LogClass.GetInstance().Info(string.Format("Запрос на получение данных о процессе {0} pid {1}", process.ProcessName, process.Id));
					processNameLabel.Text = process.ProcessName;
					pidLabel.Text = process.Id.ToString();
					long memory = process.PrivateMemorySize64 / 1024;
					memoryLabel.Text = (process.PrivateMemorySize64 / 1024).ToString("#,# КБ");
					cpuTimeLabel.Text = process.TotalProcessorTime.ToString(@"hh\:mm\:ss");
					threadsLabel.Text = process.Threads.Count.ToString();
					ownerNameLabel.Text = GetProcessOwner(process.Id);
				}
				catch (Exception e)
				{
					StringBuilder sb = new StringBuilder();
					sb.AppendLine("Ошибка при получении информации о процессе.");
					sb.AppendLine(string.Format("Сообщение исключения {0}", e.Message));
					sb.AppendLine(string.Format("Тип исключения {0}", e.GetType().ToString()));
					sb.AppendLine(string.Format("Стек вызовов {0}", e.StackTrace));
					LogClass.GetInstance().Error(sb.ToString());
				}
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			UpdateInterface();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			LogClass.GetInstance().Info("Запрос на выход из программы");
			Updater.Abort();
		}

		private void resumeToolStripButton_Click(object sender, EventArgs e)
		{
			Updater.Resume();
			timer1.Enabled = true;
			resumeToolStripButton.Enabled = false;
			suspendToolStripButton.Enabled = true;
		}

		private void suspendToolStripButton_Click(object sender, EventArgs e)
		{
			Updater.Suspend();
			timer1.Enabled = false;
			resumeToolStripButton.Enabled = true;
			suspendToolStripButton.Enabled = false;
		}

		private void выходToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void processInfo_Click(object sender, EventArgs e)
		{
			GetProcessInfo();
		}

		private void processGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			GetProcessInfo();
		}
	}
}
