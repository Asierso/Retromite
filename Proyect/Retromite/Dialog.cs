using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
namespace Retromite
{
	public class Dialog
	{
		#region Normal Dialog
		public static void CreateDialog(string title,string content)
		{
			MessageBox.Show(content,title,MessageBoxButtons.OK);
		}
		public static void CreateIconDialog(string title,string content,MessageBoxIcon icon)
		{
			MessageBox.Show(content,title,MessageBoxButtons.OK,icon);
		}
		#endregion Normal Dialog
		#region Result Return
		public static bool CreateResultDialog(string title,string content)
		{
			bool returnValue = false;
			if(MessageBox.Show(content,title,MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				returnValue = true;
			}
			return returnValue;
		}
		public static bool CreateIconResultDialog(string title,string content,MessageBoxIcon icon)
		{
			bool returnValue = false;
			if(MessageBox.Show(content,title,MessageBoxButtons.YesNo,icon) == DialogResult.Yes)
			{
				returnValue = true;
			}
			return returnValue;
		}
		#endregion Result Return
		#region Error Logs
		public static void ErrorLogs(string logInfo,string path = "")
		{
			StreamWriter stw = new StreamWriter(path + "clogs.log");
			stw.Write("Error: " + logInfo);
			stw.Close();
		}
		#endregion Error Logs
	}
}
