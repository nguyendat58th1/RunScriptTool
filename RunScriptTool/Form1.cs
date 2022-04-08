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
			string[] fileContent = File.ReadAllLines(filePath, Encoding.UTF8);
			string sql = GetScript(fileContent);
			using (OracleConnection objConn = new OracleConnection(m_ConnString))
			{
				OracleCommand objCmd = new OracleCommand();
				objCmd.Connection = objConn;
				objCmd.CommandText = sql;
				objCmd.CommandType = CommandType.Text;
				try
				{
					objConn.Open();
					objCmd.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					return ex.ToString();
				}
			}
			return string.Empty;
		}

		private string GetScript(string[] fileContent)
		{
			return "CREATE TABLE \"FL_PRINTING_COMPANY_INFO\"(\"SID\" NUMBER(10,0) \"PRINTING_COMPANY_NAME\" VARCHAR2(100 CHAR), \"INVALIDATED\" NUMBER(1,0),\"UPDATE_USER_SID\" NUMBER(8,0),\"ENTRY_DATE\" DATE,	\"UPDATE_DATE\" DATE);";
		}
	}
}