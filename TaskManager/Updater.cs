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

		public static void Start()
		{
			ThreadStart threadStart = new ThreadStart(UpdateRunner);
			isRunning = true;
			updaterThread = new Thread(threadStart);
			updaterThread.Start();
		}

		public static void Abort()
		{
			updaterThread.Abort();
		}

		public static void Resume()
		{
			isRunning = true;
		}

		public static void Suspend()
		{
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
			}
			ProcessList.Unlock();
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
