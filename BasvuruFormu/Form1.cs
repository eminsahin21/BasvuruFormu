using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasvuruFormu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] diller = { "Türkçe", "Arapça", "İngilizce", "Almanca", "İtalyanca", "Çince", "Farsça" };
            checkedListBox1.Items.AddRange(diller);
            checkedListBox1.MultiColumn = true;
            checkedListBox1.CheckOnClick = true;
            button1.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text!="")
            {
                if (checkedListBox1.Items.Contains(textBox2.Text) == false)
                    checkedListBox1.Items.Add(textBox2.Text);
                else
                    MessageBox.Show("Bu dil zaten bulunuyor");

                textBox2.Text = "";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkedListBox1.Items.Remove(checkedListBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            while(checkedListBox1.CheckedIndices.Count>0)
            {
                checkedListBox1.SetItemChecked(checkedListBox1.CheckedIndices[0], false);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = textBox1.Text;
            string diller = "";
            string mezuniyet = "";

            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                diller += ", "+checkedListBox1.CheckedItems[i];
            }
            diller = diller.Substring(1);
            label6.Text = diller;

            if (radioButton1.Checked == true)
                mezuniyet = radioButton1.Text;
            else if (radioButton2.Checked == true)
                mezuniyet = radioButton2.Text;
            else if (radioButton3.Checked == true)
                mezuniyet = radioButton3.Text;
            else
                mezuniyet = radioButton4.Text;

            label8.Text = mezuniyet;
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
