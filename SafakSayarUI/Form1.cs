using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafakSayarUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime tarih1 = dateTimePicker1.Value;

            // İkinci tarihi al
            DateTime tarih2 = dateTimePicker2.Value;

            // Gün sayısını hesapla
            TimeSpan fark = tarih2 - tarih1;
            int gunSayisi = fark.Days;

            // Label'da göster
            label1.Text = $"Atarsa {gunSayisi} gün ";
        }

        
    }
}
