using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pp._001
{
    
    public partial class openDialog : Form
    {
        public int flagFlat = 0,flagOracle=0;
        public openDialog()
        {
            InitializeComponent();
            this.Text = "Data Wizard";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            structBox.Hide();
            if (comboBox1.Text == "Flat File" && flagFlat == 0)
            {
                /*openDialog _hide = new openDialog();
                _hide.Hide();
                _hide.DestroyHandle();
                flatForm _form = new flatForm();
                _form.ShowDialog();*/
                button1.Text = "Back";
                oraclebox.Show();
                flatBox.Show();
                flagFlat=1;
            }
            else if (comboBox1.Text == "RDBMS (Oracle)")
            {
                button1.Text = "Back";
                oraclebox.Show();
                structBox.Hide();
            }
            else if (comboBox1.Text == "Other")
            {
                structBox.Hide();
            }
            else if (flagFlat == 1)
            {
                oraclebox.Show();
                flatBox.Show();
               structBox.Show();
                flagFlat = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oraclebox.Hide();
            flatBox.Hide();
            structBox.Hide();
            button1.Text = "Cancel";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string filename = openFileDialog1.FileName;
            textBox5.Text = filename;
        }

        private void textBox5_TeChanged(object sender, EventArgs e)
        {

        }
    }
}
