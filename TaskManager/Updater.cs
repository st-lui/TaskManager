using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace TaskManager
{
	class Updater
	{
		static Thread updaterThread;
		static bool isRunning;
		static ProcessDiffer processDiffer;

		public static void Start()
		{
			processDiffer = new ProcessDiffer();
			ThreadStart threadStart = new ThreadStart(UpdateRunner);
			isRunning = true;
			updaterThread = new Thread(threadStart);
			updaterThread.Start();
			LogClass.GetInstance().Info("Запущен поток мониторинга");
		}

		public static void Abort()
		{
			updaterThread.Abort();
			LogClass.GetInstance().Info("Прекращена работа потока мониторинга");
		}

		public static void Resume()
		{
			LogClass.GetInstance().Info("Получен запрос на возобновление мониторинга");
			isRunning = true;
		}

		public static void Suspend()
		{
			LogClass.GetInstance().Info("Получен запрос на приостановку мониторинга");
			isRunning = false;
		}
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
