using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button.ornek._28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int gunNo = comboBox1.SelectedIndex;
            gunNo++;
            if (gunNo==1 || gunNo==2 || gunNo==3 || gunNo==4 || gunNo == 5)
            {
                label2.Text = "Çalışma Saati 09:00-17:00 arasıdır";
            }
            else if (gunNo==6)
                {
                label2.Text = "Çalışma Saati 09:00-13:00 arasıdır";
            }
            

                
            
            else
            {
                label2.Text = "Tatil";
            }
        }
    }
}
