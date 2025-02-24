using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai13_Tinhcanchi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            string[] canArr = { "Canh", "Tân", "Nhâm", "Quý", "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ" };
            string[] chiaArr = { "Thân", "Dậu", "Tuất", "Hợi", "Tý", "Sửu", "Dần", "Mẹo", "Thìn", "Tỵ", "Ngọ", "Mùi" };
            string giatritrave = canArr[Convert.ToInt32(txtNam.Text)%10]+ " " + chiaArr[Convert.ToInt32(txtNam.Text) % 12];  
            txtcanchi.Text = giatritrave;
            for (int i = 2000; i <= 2050; i++)
            {
                lstkq.Items.Add(i + "-" + canArr[i % 10] + "" + chiaArr[i % 12]);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           


        }
        }
    }






