using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using ServiceMtk_P1_101;

namespace ClientCFC_P4_101_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BasicHttpBinding bind = new BasicHttpBinding();
            ChannelFactory<IMatematika> objChannel = new
            ChannelFactory<IMatematika>(bind, "http://localhost:1910");
            IMatematika obj = objChannel.CreateChannel();
            double hasilTambah = obj.Tambah(1, 2);
            label1.Text = "1 + 2 = " + hasilTambah; //add label1.Text + var hasilTambah
            //Console.WriteLine("1 + 2 = " + hasilTambah);
            double hasilKurang = obj.Kurang(3, 2);
            label2.Text = "3 - 2 = " + hasilKurang; //add label2.Text + var hasilKurang
            //Console.WriteLine("3 - 2 = " + hasilKurang);
            double hasilKali = obj.Kali(2, 2);
            label3.Text = "2 x 2 = " + hasilKali; //add label3.Text + var hasilKali
            //Console.WriteLine("2 x 2 = " + hasilKali);
            double hasilBagi = obj.Bagi(2, 2);
            label4.Text = "2 / 2 = " + hasilBagi; //add label4.Text + var hasilBagi
            //Console.WriteLine("2 / 2 = " + hasilBagi);
            Console.ReadLine();
            Koordinat objk = new Koordinat();
        }
    }
}
