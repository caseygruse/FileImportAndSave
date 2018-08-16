namespace FileImportAndSave
{
	partial class FileEditor
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
			this.btnImport = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.rtbFileContents = new System.Windows.Forms.RichTextBox();
			this.btnEncrypt = new System.Windows.Forms.Button();
			this.btnDecrypt = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnImport
			// 
			this.btnImport.Location = new System.Drawing.Point(560, 57);
			this.btnImport.Name = "btnImport";
			this.btnImport.Size = new System.Drawing.Size(98, 47);
			this.btnImport.TabIndex = 0;
			this.btnImport.Text = "Import File";
			this.btnImport.UseVisualStyleBackColor = true;
			this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(560, 129);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(98, 46);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "Save File";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// rtbFileContents
			// 
			this.rtbFileContents.Location = new System.Drawing.Point(33, 22);
			this.rtbFileContents.Name = "rtbFileContents";
			this.rtbFileContents.Size = new System.Drawing.Size(481, 372);
			this.rtbFileContents.TabIndex = 2;
			this.rtbFileContents.Text = "";
			// 
			// btnEncrypt
			// 
			this.btnEncrypt.Location = new System.Drawing.Point(560, 256);
			this.btnEncrypt.Name = "btnEncrypt";
			this.btnEncrypt.Size = new System.Drawing.Size(98, 37);
			this.btnEncrypt.TabIndex = 3;
			this.btnEncrypt.Text = "Encrypt";
			this.btnEncrypt.UseVisualStyleBackColor = true;
			this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
			// 
			// btnDecrypt
			// 
			this.btnDecrypt.Location = new System.Drawing.Point(560, 317);
			this.btnDecrypt.Name = "btnDecrypt";
			this.btnDecrypt.Size = new System.Drawing.Size(98, 40);
			this.btnDecrypt.TabIndex = 4;
			this.btnDecrypt.Text = "Decrypt";
			this.btnDecrypt.UseVisualStyleBackColor = true;
			this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
			// 
			// FileEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnDecrypt);
			this.Controls.Add(this.btnEncrypt);
			this.Controls.Add(this.rtbFileContents);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnImport);
			this.Name = "FileEditor";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnImport;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.RichTextBox rtbFileContents;
		private System.Windows.Forms.Button btnEncrypt;
		private System.Windows.Forms.Button btnDecrypt;
	}
}

