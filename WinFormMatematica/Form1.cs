using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormMatematica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* boton */
        private void button1_Click(object sender, EventArgs e)
        {
            // Declare and set array element values.
            int[] array2 = new int[] { 1, 3, 5, 7, 9 };
            var valorNume = Convert.ToDouble(textBox1.Text);
            label1.Text = Math.Sqrt(valorNume).ToString();

            if (Math.Sqrt(valorNume) > 5)
            {
                button1.BackColor = Color.Red;

            }
            else
            {
                // Declare and set array element values.
                label2.Text = array2.ToString();
                button1.BackColor = Color.Green;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("tecleaste en pictu");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("tecleaste en label");
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox1.BackColor = Color.BlueViolet;
            MessageBox.Show("Es tu chked");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           if( comboBox1.SelectedItem .ToString()=="pri"  )
            {
              Class1 clase_mia = new Class1();
            clase_mia.Presen();

                ven  venobj = new ven();
                venobj.Presen2();
            }    
            
        }
    }
}
