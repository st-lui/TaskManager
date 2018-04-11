using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Collections;

namespace TaskManager
{
	/// <summary>
	/// Класс для общего доступа к списку процессов из разных потоков
	/// </summary>
	public class ProcessList
	{
		/// <summary>
		/// Внутреннее представление списка процессов
		/// </summary>
		private List<Process> processList=new List<Process>();
		/// <summary>
		/// Флаг блокировки доступа к данным
		/// </summary>
		private static bool lockFlag=false;
		// Список процессов
		public List<Process> List { get { return processList; } }
		private static ProcessList _processList;

		/// <summary>
		/// Получает экземпляр класса с проверкой блокировки
		/// </summary>
		/// <returns> null - если доступ заблокирован, объект ProcessList, если не заблокирован</returns>
		public static ProcessList TryGetInstance()
		{
			if (lockFlag)
				return null;
			lockFlag = true;
			if (_processList == null)
				_processList = new ProcessList();
			return _processList;
		}

		/// <summary>
		/// Разблокирует доступ к данным
		/// </summary>
		public static void Unlock()
		{
			lockFlag = false;
		}
	}
}
