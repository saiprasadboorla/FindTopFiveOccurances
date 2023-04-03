using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TopFiveWebApp
{
	public partial class Contact : Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

        }
        protected void UploadBtn_Click(object sender, EventArgs e)
        {       
            if (fileUpLoader.HasFile)
            {
                string fileExtension = Path.GetExtension(fileUpLoader.FileName);

                if (fileExtension.ToLower() != ".txt")
                {
                    lblFileUploaded.Text = "Only .txt file allowed";
                    lblFileUploaded.ForeColor = System.Drawing.Color.Red;
                }
				else
				{
                    StreamReader reader = new StreamReader(fileUpLoader.FileContent);
                    string content = reader.ReadToEnd().Trim();
                    string[] read = content.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    List<Int64> lstNumbers = read.Select(Int64.Parse).ToList();
                    var commonNumbers = lstNumbers.GroupBy(m => m).Select(g => new { Value = g.Key, Count = g.Count() }).OrderByDescending(m => m.Count).Take(5);
                    string result = string.Empty;
                    foreach (var num in commonNumbers)
                    {
                        result += num.Value + "<br>";
                    }
                    lblResult.Text = "<b>Result: </b>" + "<br>" + result;
                    lblFileUploaded.Visible = false;
                }             
                
            }
            else
            {
                lblFileUploaded.Text = "No File Uploaded.";
                lblFileUploaded.ForeColor = System.Drawing.Color.Red;
            }

        }
    }
}