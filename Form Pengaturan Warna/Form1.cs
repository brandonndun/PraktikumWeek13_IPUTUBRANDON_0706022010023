using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Pengaturan_Warna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (labelNama.Text == "[EMPTY]")
            {
                labelNama.Text = namaGanti.Text;
            }
            if (labelNama.Text != "[EMPTY]")
            {
                if (namaGanti.Text == "DELETE")
                {
                    labelNama.Text = "[EMPTY]";
                }

            }
            if (labelNama.Text != "[EMPTY]")
            {
                if (namaGanti.Text == "HIDE")
                {
                    labelNama.Visible = false;

                }
                if (namaGanti.Text == "SHOWN")
                {
                    labelNama.Visible = true;
                }
                    
            }
            if (labelNama.Text != "[EMPTY]")
            {
                if (namaGanti.Text == "BLUE")
                {
                    labelNama.ForeColor = Color.Blue;
                }
                else if (namaGanti.Text == "RED") 
                {
                    labelNama.ForeColor = Color.Red;
                }
                else if(namaGanti.Text == "GREEN")
                {
                    labelNama.ForeColor = Color.Green;
                }
            }
            
        }
    }
}
