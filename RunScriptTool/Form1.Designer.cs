namespace RunScriptTool
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtFolder = new System.Windows.Forms.TextBox();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.txtConnString = new System.Windows.Forms.TextBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.btnRun = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtFolder
			// 
			this.txtFolder.Location = new System.Drawing.Point(98, 79);
			this.txtFolder.Name = "txtFolder";
			this.txtFolder.Size = new System.Drawing.Size(433, 20);
			this.txtFolder.TabIndex = 0;
			this.txtFolder.Text = "D:\\Weblite\\docs\\SqlScripts";
			// 
			// txtConnString
			// 
			this.txtConnString.Location = new System.Drawing.Point(98, 105);
			this.txtConnString.Name = "txtConnString";
			this.txtConnString.Size = new System.Drawing.Size(514, 20);
			this.txtConnString.TabIndex = 1;
			this.txtConnString.Text = "DATA SOURCE=localhost:1521/XE;PASSWORD=ixfds;PERSIST SECURITY INFO=True;USER ID=I" +
    "XFDS";
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(537, 77);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnBrowse.TabIndex = 2;
			this.btnBrowse.Text = "Browse";
			this.btnBrowse.UseVisualStyleBackColor = true;
			// 
			// btnRun
			// 
			this.btnRun.Location = new System.Drawing.Point(537, 131);
			this.btnRun.Name = "btnRun";
			this.btnRun.Size = new System.Drawing.Size(75, 23);
			this.btnRun.TabIndex = 3;
			this.btnRun.Text = "Run Scripts";
			this.btnRun.UseVisualStyleBackColor = true;
			this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(57, 82);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(57, 108);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "label2";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(746, 214);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnRun);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.txtConnString);
			this.Controls.Add(this.txtFolder);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtFolder;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.TextBox txtConnString;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.Button btnRun;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

