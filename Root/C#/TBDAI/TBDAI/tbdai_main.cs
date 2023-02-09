using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO.Pipes;



namespace TBDAI
{
    public partial class tbdForm : Form
    {

        public tbdForm()
        {
            InitializeComponent();
            thinkLbl.Visible = false;
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            // Get the text from the input text box
            string inputText = inputTxtBox.Text;

            // Start the Python script and pass the text as an argument
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "python.exe";
        
            start.Arguments = string.Format("\"..\\..\\..\\..\\..\\Python\\test.py\" \"{0}\"", inputText);
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();

                    // Update the text of the output text box
                    outputTxtBox.Text = result;
                }
            }

        }





        private void run_cmd()
        {
            string currentDirectory = Environment.CurrentDirectory;
            string filePath = Path.Combine(currentDirectory, @"..\..\..\..\..\Python\outputpy.txt");
            string text = File.ReadAllText(filePath);
            outputTxtBox.Text = text; 
            }
        


            private void timer1_Tick(object sender, EventArgs e)
        {
            thinkLbl.Visible = false;
            
            
            timer1.Stop();
        }
    }

    
}
