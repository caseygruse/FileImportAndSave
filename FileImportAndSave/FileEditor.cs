using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace FileImportAndSave
{
	public partial class FileEditor : Form
	{
		public FileEditor()
		{
			InitializeComponent();
		}

		private string GetMyDocumentsPath()
		{
			return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnImport_Click(object sender, EventArgs e)
		{
			//create file object
			OpenFileDialog fileDialog = new OpenFileDialog();
			//makes the first directory to be displayed my documents
			fileDialog.InitialDirectory = GetMyDocumentsPath();
			//allows only .txt files
			fileDialog.Filter = "Text File|*.txt";
			//the selected file from the from the dialogbox
			if(fileDialog.ShowDialog() == DialogResult.OK)
			{
				//clear text box before importing
				rtbFileContents.Clear();
				//build a string from the contents of the file
				StringBuilder data = new StringBuilder();
				data.Append(File.ReadAllText(fileDialog.FileName).ToString());
				//displays the file contents in the ritch text box.
				rtbFileContents.AppendText(data.ToString());

			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			// make string builder
			StringBuilder data = new StringBuilder();
			//fill the string builder with the contents of the rich text box.
			data.AppendLine(rtbFileContents.Text);
			SaveFileDialog save = new SaveFileDialog();
			save.Filter = "Text File|*.txt";
			save.RestoreDirectory = true;
			if(save.ShowDialog() == DialogResult.OK)
			{
				string path = save.FileName;
				if(path == string.Empty)
				{
					return;
				}
				File.WriteAllText(path, data.ToString());
			}
		}

		private void btnEncrypt_Click(object sender, EventArgs e)
		{
			//var hash = new SHA1Managed
		}
	}
}
