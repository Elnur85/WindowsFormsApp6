using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /*1*/
            //MessageBox.Show(radioButton1.ToString());

            StringBuilder stringBuilder = new StringBuilder();

            var b = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked);
            var a = groupBox2.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked);
            var c = groupBox3.Controls.OfType<RadioButton>().FirstOrDefault(x => x.Checked);
             
            if (a.Text == "Baki")
            {
                stringBuilder.AppendLine("1-Dogru");
                
            }
            else
            {
                stringBuilder.AppendLine("1-Yanlis");
            } 

            if (b.Text == "9 milyon +")
            {
                stringBuilder.AppendLine("2-Dogru"); 
                
            }
            else
            {
                stringBuilder.AppendLine("2-Yanlis");
            }

            if (c.Text == "Paraguay")
            {
                stringBuilder.AppendLine("3-Dogru");

            }
            else
            {
                stringBuilder.AppendLine("3-Yanlis");
            }

            MessageBox.Show(stringBuilder.ToString());
        }

    }




}
