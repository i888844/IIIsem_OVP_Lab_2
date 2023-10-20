using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int borderWidth = groupBox1.Width;
            int borderHeight = groupBox1.Height;
            toolStripStatusLabel1.Text = $"groupBox4 - ширина {borderWidth} | высота {borderHeight}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Вы действительно хотите закрыть программу?",
                "Подтверждение",
                MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                Close();
            }
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Автор лабораторной работы №2 - Иванов В. Р.",
                "Справка",
                MessageBoxButtons.OK);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = sender as RadioButton;
            if (selectedRadioButton != null && selectedRadioButton.Checked && radioButton3.Checked)
            {
                if (selectedRadioButton == radioButton1)
                {
                    groupBox1.ForeColor = Color.Red;
                }
                else
                {
                    groupBox1.ForeColor = Color.Black;
                }
            }
        }

        private void GroupBox1_ForeColorChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = sender as RadioButton;
            if (selectedRadioButton != null && selectedRadioButton.Checked && radioButton3.Checked)
            {
                if (selectedRadioButton == radioButton2)
                {
                    groupBox1.ForeColor = Color.Blue;
                }
                else
                {
                    groupBox1.ForeColor = Color.Black;
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                if (int.TryParse(textBox1.Text, out int numberWidth))
                {
                    groupBox1.Width = numberWidth;
                    label1.Text = numberWidth.ToString();
                }
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                if (int.TryParse(textBox2.Text, out int numberHeight))
                {
                    groupBox1.Height = numberHeight;
                    label2.Text = numberHeight.ToString();
                }
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                int numberWidth = trackBar1.Value * 100;
                groupBox1.Width = numberWidth;
                label1.Text = numberWidth.ToString();
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                int numberHeight = trackBar2.Value * 100;
                groupBox1.Height = numberHeight;
                label2.Text = numberHeight.ToString();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();
            groupBox1.Text = selectedValue;
        }
        //int i = 0;
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = sender as RadioButton;
            if (selectedRadioButton != null && selectedRadioButton.Checked)
            {
                radioButton3.Checked = true;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                //if (selectedRadioButton == radioButton3)
                //{
                //    i++;
                //    if (i > 3)
                //    {
                //        i = 1;
                //    }
                //}
                //switch (i)
                //{
                //    case 0:
                //        groupBox4.ForeColor = Color.Black;
                //        break;
                //    case 1:
                //        groupBox4.ForeColor = Color.Red;
                //        break;
                //    case 2:
                //        groupBox4.ForeColor = Color.Blue;
                //        break;
                //    case 3:
                //        groupBox4.ForeColor = Color.Green;
                //        break;
                //}
            }
        }
        //int a = 0;
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = sender as RadioButton;
            if (selectedRadioButton != null && selectedRadioButton.Checked)
            {
                radioButton4.Checked = true;
                radioButton5.Checked = false;
                radioButton3.Checked = false;
                //if (selectedRadioButton == radioButton4)
                //{
                //    a++;
                //    if (a > 3)
                //    {
                //        a = 1;
                //    }
                //}
                //switch (a)
                //{
                //    case 0:
                //        groupBox4.Width = 500;
                //        break;
                //    case 1:
                //        groupBox4.Width = 1000;
                //        break;
                //    case 2:
                //        groupBox4.Width = 1500;
                //        break;
                //    case 3:
                //        groupBox4.Width = 2000;
                //        break;
                //}
            }
        }
        //int b = 0;
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = sender as RadioButton;
            if (selectedRadioButton != null && selectedRadioButton.Checked)
            {
                radioButton5.Checked = true;
                radioButton4.Checked = false;
                radioButton3.Checked = false;
                //if (selectedRadioButton == radioButton5)
                //{
                //    b++;
                //    if (b > 3)
                //    {
                //        b = 1;
                //    }
                //}
                //switch (b)
                //{
                //    case 0:
                //        groupBox4.Height = 500;
                //        break;
                //    case 1:
                //        groupBox4.Height = 1000;
                //        break;
                //    case 2:
                //        groupBox4.Height = 1500;
                //        break;
                //    case 3:
                //        groupBox4.Height = 2000;
                //        break;
                //}
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
