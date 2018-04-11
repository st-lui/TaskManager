using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TaskManager
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			try
			{
				LogClass.GetInstance().Info(string.Format("Старт программы. Имя пользователя {0}", Environment.UserName));
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new Form1());
				LogClass.GetInstance().Info("Завершение работы программы");
			}
			catch (Exception e)
			{
				StringBuilder sb = new StringBuilder();
				sb.AppendLine("Неустановленная ошибка в работе программы");
				sb.AppendLine(string.Format("Сообщение исключения {0}", e.Message));
				sb.AppendLine(string.Format("Тип исключения {0}", e.GetType().ToString()));
				sb.AppendLine(string.Format("Стек вызовов {0}", e.StackTrace));
				LogClass.GetInstance().Error(sb.ToString());
			}
		}
	}
}
