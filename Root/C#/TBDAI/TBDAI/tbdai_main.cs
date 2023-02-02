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

            run_cmd();


        }


            private void timer1_Tick(object sender, EventArgs e)
        {
            thinkLbl.Visible = false;
            inputsend();
            timer1.Stop();
        }
    }

    
}
