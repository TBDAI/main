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


namespace TBDAI
{
    public partial class tbdForm : Form
    {
        public tbdForm()
        {
            InitializeComponent();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            run_cmd();
        }
        private void run_cmd()
        {
            
            string text = File.ReadAllText("C:/Users/Realschule Boxberg 1/Desktop/Projekt/main/Root/Python/outputpy.txt");
            outputTxtBox.Text = text;

        }
    
}

    
}
