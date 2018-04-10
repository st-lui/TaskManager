using System;
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
		System.Timers.Timer globalTimer;
		ProcessList processList;
		BindingSource processBindingSource;
		private BindingSource bindingSource1;
		ArrayList states;


		private void Initialize()
		{
			//processList = new ProcessList();
			//processList.Update();
			processBindingSource = new BindingSource();
			processGridView.AutoGenerateColumns = false;
			Updater.Start();
			processBindingSource.DataSource = typeof(Process);
			////processBindingSource.DataSourceChanged += processBindingSourceData_SourceChanged;
			processGridView.DataSource = processBindingSource;
			processName.DataPropertyName = "ProcessName";
			memoryLoad.DataPropertyName = "PrivateMemorySize64";
			timer1.Enabled = true;
			UpdateInterface();
			//label2.DataBindings.Add("Text", processBindingSource.Current, "PrivateMemorySize64");
		}

		private void processBindingSourceData_SourceChanged(object sender, EventArgs e)
		{
			processBindingSource.ResetBindings(false);
		}

		private void globalTimerAction(object sender, ElapsedEventArgs args)
		{
			UpdateInterface();
		}

		public Form1()
		{
			InitializeComponent();
			Initialize();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			UpdateInterface();
		}

		private void UpdateBindable(object dataContext)
		{
			var cm = ((CurrencyManager)BindingContext[dataContext]);
			cm.Refresh();
		}

		private void UpdateInterface()
		{
			processList = ProcessList.TryGetInstance();
			if (processList != null && processList.List.Count > 0)
			{
				int scrollTo = processGridView.FirstDisplayedScrollingRowIndex;
				int position = processBindingSource.Position;
				processBindingSource.Clear();
				foreach (Process p in processList.List)
					processBindingSource.Add(p);
				//processBindingSource.ResetBindings(false);
				processBindingSource.Position = Math.Min(processGridView.RowCount, Math.Max(0, position));
				processGridView.FirstDisplayedScrollingRowIndex = Math.Min(processGridView.RowCount, Math.Max(0, scrollTo));
				totalProcessToolStripStatusLabel.Text = processList.List.Count.ToString();
				ProcessList.Unlock();
			}
		}

		private void UpdateProcessInfo()
		{

			if (processBindingSource.Current != null)
			{
				Process process = (Process)processBindingSource.Current;
				processNameLabel.Text = process.ProcessName;
				pidLabel.Text = process.Id.ToString();
				long memory = process.PrivateMemorySize64 / 1024;
				memoryLabel.Text = (process.PrivateMemorySize64 / 1024).ToString("#,# КБ");
				cpuTimeLabel.Text = process.TotalProcessorTime.ToString(@"hh\:mm\:ss");
				threadsLabel.Text = process.Threads.Count.ToString();
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			UpdateInterface();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			Updater.Abort();
		}

		private void resumeToolStripButton_Click(object sender, EventArgs e)
		{
			Updater.Resume();
			resumeToolStripButton.Enabled = false;
			suspendToolStripButton.Enabled = true;
		}

		private void suspendToolStripButton_Click(object sender, EventArgs e)
		{
			Updater.Suspend();
			resumeToolStripButton.Enabled = true;
			suspendToolStripButton.Enabled = false;
		}

		private void выходToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void processGridView_SelectionChanged(object sender, EventArgs e)
		{
			UpdateProcessInfo();
		}
	}
}
