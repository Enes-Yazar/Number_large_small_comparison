using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulam2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2;   // Kısa yöntem

            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);

            if (sayi1 > sayi2)
            {
                label1.Text = Convert.ToString(sayi1);
                label2.Text = Convert.ToString(sayi2);

            }
            else
            {
                label1.Text = Convert.ToString(sayi2);
                label2.Text = Convert.ToString(sayi1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sayi3; // Uzun yöntem

            sayi1 = Convert.ToInt32(textBox3.Text);
            sayi2 = Convert.ToInt32(textBox4.Text);
            sayi3 = Convert.ToInt32(textBox5.Text);

            if ((sayi1 > sayi2) && (sayi1 > sayi3))
            {
                textBox6.Text = sayi1.ToString();
                label4.Text = "En büyük sayı  a";

                if (sayi2 < sayi3)
                {
                    textBox7.Text = sayi2.ToString();
                    label3.Text = "En küçük sayı b";
                }
                else
                {
                    textBox7.Text = sayi3.ToString();
                    label3.Text = "En küçük sayi c";
                }
            }
            else if ((sayi2 > sayi1) && (sayi2 > sayi3))
            {
                textBox6.Text = sayi2.ToString();
                label4.Text = "En büyük sayi b";

                if (sayi1 < sayi3)
                {
                    textBox7.Text = sayi1.ToString();
                    label3.Text = "En küçük sayı a";
                }
                else
                {
                    textBox7.Text = sayi2.ToString();
                    label3.Text = "En küçük sayı c";
                }
            }
            else
            {
                textBox6.Text = sayi3.ToString();
                label4.Text = "En küçük sayi c";
                if ( sayi2 < sayi1)
                {
                    textBox7.Text = sayi2.ToString();
                    label3.Text = "En küçük sayı b";
                }
                else
                {
                    textBox7 .Text = sayi1.ToString();
                    label3.Text = "En küçük sayı a";
                     
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sayi3; // Uzun yöntem 2. yol

            sayi1 = Convert.ToInt16(textBox10.Text);
            sayi2 = Convert.ToInt16(textBox11.Text);
            sayi3 = Convert.ToInt16(textBox12.Text);


            if (sayi1 > sayi2)
            {
                if (sayi2 > sayi3)
                {
                    textBox8.Text = sayi1.ToString();
                    label6.Text = "En büyük sayı sayi1";
                }
                else if (sayi3 > sayi1)
                {
                    textBox8.Text = sayi3.ToString();
                    label6.Text = "En büyük sayı sayi3";
                }
                else
                {
                    textBox8.Text = sayi2.ToString();
                    label6.Text = "En büyük sayı sayi 2";

                }
            }
            else if (sayi2 > sayi3)
            {
                textBox8.Text = sayi2.ToString();
                label6.Text = "En büyük sayı sayi2";
            }
            else if (sayi3 > sayi1)
            {
                textBox8.Text = sayi3.ToString();
                label6.Text = "En büyük sayı sayi3";
            }
        }
    }
}
