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
            thinkLbl.Visible = true;
            timer1.Start();


            //inputsend();

        }

       


        private void py_run()
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "python",
                    Arguments = @"..\..\..\..\..\Python\test.py",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                }
            };

            process.Start();
            string outputt = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            run_cmd();

            //outputTxtBox.Text = outputt;
        }

        private void run_cmd()
        {
            string currentDirectory = Environment.CurrentDirectory;
            string filePath = Path.Combine(currentDirectory, @"..\..\..\..\..\Python\outputpy.txt");
            string text = File.ReadAllText(filePath);
            outputTxtBox.Text = text; 
            }
        private void inputsend()
        {
            // Get the text from the textbox
            string textboxInput = inputTxtBox.Text.ToString();

            // Set the path for the text file
            string path = @"..\..\..\..\..\Python\inputcs.txt";

            // Check if the file exists
            if (File.Exists(path))
            {
                // If the file exists, delete it
                File.Delete(path);
            }

            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(textboxInput);
            }


            py_run();

        }


            private void timer1_Tick(object sender, EventArgs e)
        {
            thinkLbl.Visible = false;
            
            inputsend();
            timer1.Stop();
        }
    }

    
}
