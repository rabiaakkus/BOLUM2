using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bölüm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (cbKirmizi.Checked == true)
            {
                lblYaz.Text = "KİRMİZİ YAPILDI";
            }
            else
            {
                lblYaz.Text = "KİRMİZİ KALDIRILDI";
            }
        }
    }
}
