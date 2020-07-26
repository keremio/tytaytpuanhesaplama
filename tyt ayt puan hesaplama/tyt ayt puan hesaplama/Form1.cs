using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace tyt_ayt_puan_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";
            textBox11.Text = "0";
            textBox12.Text = "0";
            textBox13.Text = "0";
            textBox14.Text = "0";
            textBox15.Text = "0";
            textBox16.Text = "0";
            textBox17.Text = "0";
            textBox18.Text = "0";
            textBox19.Text = "0";
            textBox20.Text = "0";
            textBox21.Text = "0";
            textBox22.Text = "0";
            textBox23.Text = "0";
            textBox24.Text = "0";
            textBox25.Text = "0";
            textBox26.Text = "0";
            textBox27.Text = "0";
            textBox28.Text = "0";
            textBox29.Text = "0";
            textBox30.Text = "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label8.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) - 0.25 * Convert.ToDouble(textBox2.Text));
            label9.Text = Convert.ToString(Convert.ToDouble(textBox3.Text) - 0.25 * Convert.ToDouble(textBox4.Text));
            label10.Text = Convert.ToString(Convert.ToDouble(textBox5.Text) - 0.25 * Convert.ToDouble(textBox6.Text));
            label11.Text = Convert.ToString(Convert.ToDouble(textBox7.Text) - 0.25 * Convert.ToDouble(textBox8.Text));
          
            label45.Text = Convert.ToString((Convert.ToDouble(label8.Text)*1.32 + Convert.ToDouble(label9.Text)*1.36 + Convert.ToDouble(label10.Text)*1.32 + Convert.ToDouble(label11.Text)*1.36)*2.5 + 100);
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label18.Text = Convert.ToString(Convert.ToDouble(textBox9.Text) - 0.25 * Convert.ToDouble(textBox10.Text));
            label17.Text = Convert.ToString(Convert.ToDouble(textBox11.Text) - 0.25 * Convert.ToDouble(textBox12.Text));
            label16.Text = Convert.ToString(Convert.ToDouble(textBox13.Text) - 0.25 * Convert.ToDouble(textBox14.Text));
            
            label15.Text = Convert.ToString(Convert.ToDouble(textBox15.Text) - 0.25 * Convert.ToDouble(textBox16.Text));
            label21.Text = Convert.ToString(Convert.ToDouble(textBox17.Text) - 0.25 * Convert.ToDouble(textBox18.Text));
            label22.Text = Convert.ToString(Convert.ToDouble(textBox19.Text) - 0.25 * Convert.ToDouble(textBox20.Text));
            label23.Text = Convert.ToString(Convert.ToDouble(textBox21.Text) - 0.25 * Convert.ToDouble(textBox22.Text));
            
            label24.Text = Convert.ToString(Convert.ToDouble(textBox23.Text) - 0.25 * Convert.ToDouble(textBox24.Text));

            label25.Text = Convert.ToString(Convert.ToDouble(textBox25.Text) - 0.25 * Convert.ToDouble(textBox26.Text));
            label26.Text = Convert.ToString(Convert.ToDouble(textBox27.Text) - 0.25 * Convert.ToDouble(textBox28.Text));
            label27.Text = Convert.ToString(Convert.ToDouble(textBox29.Text) - 0.25 * Convert.ToDouble(textBox30.Text));


            label46.Text = Convert.ToString( (Convert.ToDouble(label45.Text) * 0.4) + ((Convert.ToDouble(label24.Text) * 3 + Convert.ToDouble(label25.Text) * 2.85 + Convert.ToDouble(label26.Text) * 3.07 + Convert.ToDouble(label27.Text) * 3.07) * 1.66 + 100) * 0.6);

            label47.Text = Convert.ToString( (Convert.ToDouble(label45.Text) * 0.4) + ((Convert.ToDouble(label15.Text) * 3 + Convert.ToDouble(label16.Text) * 2.8 + Convert.ToDouble(label17.Text) * 3.33 + Convert.ToDouble(label24.Text) * 3) * 1.66 + 100) * 0.6);

            label48.Text = Convert.ToString((Convert.ToDouble(label45.Text) * 0.4) + ((Convert.ToDouble(label15.Text) * 3 + Convert.ToDouble(label16.Text) * 2.8 + Convert.ToDouble(label17.Text) * 3.33 + Convert.ToDouble(label18.Text) * 2.91  + Convert.ToDouble(label21.Text) * 2.91 + Convert.ToDouble(label22.Text) * 3 + Convert.ToDouble(label23.Text) * 3.33) * 1.66 + 100) * 0.6);



        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label53_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            label53.Text = Convert.ToString(Convert.ToDouble(label45.Text) + Convert.ToDouble(textBox31.Text) * 0.6);
            label54.Text = Convert.ToString(Convert.ToDouble(label46.Text) + Convert.ToDouble(textBox31.Text) * 0.6);
            label55.Text = Convert.ToString(Convert.ToDouble(label47.Text) + Convert.ToDouble(textBox31.Text) * 0.6);
            label56.Text = Convert.ToString(Convert.ToDouble(label48.Text) + Convert.ToDouble(textBox31.Text) * 0.6);


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox31.Text = Convert.ToString(Convert.ToDouble(textBox31.Text) / 2);
        }
    }
}
