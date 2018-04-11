using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace TaskManager
{
	/// <summary>
	/// Класс для получения списка процессов 
	/// </summary>
	class Updater
	{
		/// <summary>
		/// Поток, в котором запускается получение списка процессов
		/// </summary>
		static Thread updaterThread;
		/// <summary>
		/// Признак продолжения работы потока
		/// </summary>
		static bool isRunning;
		/// <summary>
		/// Объект для сравнения предыдущего и текущего списка процессов
		/// </summary>
		static ProcessDiffer processDiffer;

		/// <summary>
		/// Создает поток и запускает его
		/// </summary>
		public static void Start()
		{
			processDiffer = new ProcessDiffer();
			ThreadStart threadStart = new ThreadStart(UpdateRunner);
			isRunning = true;
			updaterThread = new Thread(threadStart);
			updaterThread.Start();
			LogClass.GetInstance().Info("Запущен поток мониторинга");
		}
		/// <summary>
		/// Прекращает работу потока
		/// </summary>
		public static void Abort()
		{
			updaterThread.Abort();
			LogClass.GetInstance().Info("Прекращена работа потока мониторинга");
		}
		/// <summary>
		/// Запускает приостановленную работу по получению списка процессов
		/// </summary>
		public static void Resume()
		{
			LogClass.GetInstance().Info("Получен запрос на возобновление мониторинга");
			isRunning = true;
		}
		/// <summary>
		/// Приостанавливает работу по получению списка процессов
		/// </summary>
		public static void Suspend()
		{
			LogClass.GetInstance().Info("Получен запрос на приостановку мониторинга");
			isRunning = false;
		}
		/// <summary>
		/// Обновляет список процессов, логирует изменения в списке процессов
		/// </summary>
		public static void Update()
		{
			ProcessList pl = ProcessList.TryGetInstance();
			if (pl != null)
			{
				pl.List.Clear();
				foreach (var p in Process.GetProcesses().ToList())
				{
					pl.List.Add(p);
				}
				pl.List.Sort(delegate (Process a, Process b) { return a.ProcessName.CompareTo(b.ProcessName); });
				processDiffer.Add(pl.List);
				ProcessList.Unlock();
				processDiffer.CompareHashes();
			}
		}

		/// <summary>
		/// Запускает обновление списка процессов в бесконечном цикле
		/// </summary>
		public static void UpdateRunner()
		{
			while (true)
			{
				if (isRunning)
					Update();
				Thread.Sleep(666);
			}
		}
	}
}
