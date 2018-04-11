using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TaskManager
{
	public class ProcessDiffer
	{
		HashSet<string>[] hashSet;
		int oldId, newId;

		public ProcessDiffer()
		{
			hashSet = new HashSet<string>[2];
			oldId = 0;
			newId = 1;
		}

		void FillHash(int hashId, List<Process> processes)
		{
			hashSet[hashId].Clear();
			foreach (Process process in processes)
			{
				hashSet[hashId].Add(string.Format("{0} {1}", process.ProcessName, process.Id));
			}
		}

		public void CompareHashes()
		{
			if (hashSet[oldId] != null && hashSet[newId] != null)
			{
				foreach (string oldProcess in hashSet[oldId])
					if (!hashSet[newId].Contains(oldProcess))
						LogClass.GetInstance().Info(string.Format("Завершился процесс {0}", oldProcess));

				foreach (string newProcess in hashSet[newId])
				{
					if (!hashSet[oldId].Contains(newProcess))
						LogClass.GetInstance().Info(string.Format("Новый процесс {0}", newProcess));
				}
				oldId = 1 - oldId;
				newId = 1 - newId;
			}
		}

		public void Add(List<Process> processes)
		{
			if (hashSet[0] == null)
			{
				hashSet[0] = new HashSet<string>();
				FillHash(0, processes);
			}
			else
				if (hashSet[1] == null)
			{
				hashSet[1] = new HashSet<string>();
				FillHash(1, processes);
			}
			else
			{
				FillHash(newId, processes);
			}
			
		}
	}
}