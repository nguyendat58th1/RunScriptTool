using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace RunScriptTool
{
	public partial class Form1 : Form
	{
		private string m_ConnString = string.Empty;

		public Form1()
		{
			InitializeComponent();
		}

		private void btnRun_Click(object sender, EventArgs e)
		{
			string folder = txtFolder.Text;
			if (!Directory.Exists(folder))
			{
				MessageBox.Show("Ko ton tai folder");
			}

			//List *.sql Files
			string[] files = Directory.GetFiles(folder, "*.sql", SearchOption.AllDirectories);

			//Connection String
			m_ConnString = txtConnString.Text;
			for (int i = 0; i < files.Length; i++)
			{
				try
				{
					//Run Script to Create/Update/Delete TABLE in Oracle
					var errMsg = RunScripts(files[i]);
					if (!string.IsNullOrWhiteSpace(errMsg))
					{
						MessageBox.Show(errMsg);
					}
				}
				catch (Exception ex)
				{
					Debug.WriteLine(ex);
					MessageBox.Show(ex.ToString());
					//throw;
				}
			}
			MessageBox.Show("Done");
		}

		private string RunScripts(string filePath)
		{
			string fileContent = File.ReadAllText(filePath, Encoding.UTF8);
			string[] sql = fileContent.Split(';');
			for (int i = 0; i < sql.Length; i++)
			{
				if(!string.IsNullOrWhiteSpace(sql[i]))
				{
					using (OracleConnection objConn = new OracleConnection(m_ConnString))
					{
						objConn.Open();
						using (var objCmd = new OracleCommand(sql[i], objConn))
						{
							try
							{
								objCmd.ExecuteNonQuery();
							}
							catch (Exception ex)
							{
								return ex.ToString();
							}
						}
					}
				}
			}
			return string.Empty;
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			fbd.RootFolder = Environment.SpecialFolder.Desktop;
			fbd.ShowNewFolderButton = false;
			if(fbd.ShowDialog() == DialogResult.OK)
			{
				txtFolder.Text = fbd.SelectedPath;
			}
		}
	}
}