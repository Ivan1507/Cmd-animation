using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace AllThings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Program Files (x86)\Microsoft Visual Studio 9.0\3082";
            Cmd(path);
            //for (byte r=70,g=130,b=180;r<=135 & g<=206 & b<=250;r+=3,g+=4,b+=4,await Task.Delay(30))
            //{
            //    label1.ForeColor = Color.FromArgb(r,g,b);
            //}

            //for (byte r = 135, g = 206, b = 250; r >= 70 & g >= 130 & b >= 180; r -= 3, g -= 4, b -= 4, await Task.Delay(30))
            //{
            //    label1.ForeColor = Color.FromArgb(r, g, b);
            //}
            //label1.ForeColor = Color.FromArgb(70, 130, 180);
        }
        void Cmd(string line)
        {
            Process.Start(new ProcessStartInfo { FileName = "explorer", Arguments = $"/n, /select,{line}" });
        }
        //string[] files = Directory.GetFiles(@"C:\Users\кро2\Desktop\Temp", "*.txt");
        //int kolvo= files.Length;
        //progressBar1.Maximum = kolvo;


        //while(kolvo>0)
        //{
        //    File.Delete(files[kolvo - 1]);
        //    label1.Text = files[kolvo-1];
        //    progressBar1.Value++;
        //    kolvo--;
        //    await Task.Delay(1000);

        //}
    }
}

