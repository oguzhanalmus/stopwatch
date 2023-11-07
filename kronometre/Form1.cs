using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        int saniye, dakika;

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            lblsn.Text = saniye.ToString();
            if (saniye ==60) 
            {
                dakika++;
                lbldk.Text = dakika.ToString();
                saniye = 0;
            }
        }
    }
}
