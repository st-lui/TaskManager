using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NLog;
using NLog.Config;
using NLog.Targets;

namespace TaskManager
{
	/// <summary>
	/// Класс для получения объекта логгера
	/// </summary>
	public class LogClass
	{
		private static Logger log;

		public static Logger GetInstance()
		{
			return log;
		}

		static LogClass()
		{
			CreateLogger();
		}
		
		/// <summary>
		/// Создает конфигурацию логирования и логгер
		/// </summary>
		static void CreateLogger()
		{
			LoggingConfiguration config = new LoggingConfiguration();
			FileTarget fileTarget = new FileTarget
			{
				FileName = "LOGS\\current.log",
				FileNameKind = FilePathKind.Relative,
				ArchiveFileKind = FilePathKind.Relative,
				ArchiveEvery = FileArchivePeriod.Day,
				MaxArchiveFiles = 30,
				ArchiveFileName = "LOGS\\ARCH\\${shortdate}.log",
				ArchiveNumbering = ArchiveNumberingMode.Date
			};
			config.AddTarget("logfile", fileTarget);
			config.LoggingRules.Add(new LoggingRule("*", LogLevel.Trace, fileTarget));
			LogManager.Configuration = config;
			log = LogManager.GetCurrentClassLogger();
		}
	}
}
