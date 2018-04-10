using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Collections;

namespace TaskManager
{
	public class ProcessList
	{
		private List<Process> processList=new List<Process>();
		private static bool lockFlag=false;
		public List<Process> List { get { return processList; } }
		private static ProcessList _processList;

		public static ProcessList TryGetInstance()
		{
			if (lockFlag)
				return null;
			lockFlag = true;
			if (_processList == null)
				_processList = new ProcessList();
			return _processList;
		}
		public static void Unlock()
		{
			lockFlag = false;
		}
	}
}
