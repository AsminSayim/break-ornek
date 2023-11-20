using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace break_ornk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string aranan = txtAra.Text;
            bool kontrol= false;

            for (int i = 0; i < listBox1.Items.Count; i=i+10)
            {
                if(aranan == listBox1.Items[i].ToString())
                {
                    kontrol=true;
                    break;
                }
            }
            if (kontrol == true)
            {
                MessageBox.Show("Öğrenci bulundu.");
            }
            else
            {
                MessageBox.Show("Öğrenci bulunamadı.");
            }
            
            
        }
    }
}
