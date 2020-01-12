using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Add_Birthday
{
    public partial class Form1 : Form
    {
 

        public Form1()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.textBox1);
            this.Text = "TextBox Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int thisMonthsDays = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

            for (int i = 1; i <= thisMonthsDays; i++)
            { 
                comboBox1.Items.Add(i);
            }

            try
            {

                for (int i = DateTime.Now.Year; i < DateTime.Now.Year + 15; i++)
                {
                    comboBox3.Items.Add(i);
                }
                //set selected item for display on startup
                comboBox3.Text = DateTime.Now.Year.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            try
            {
                //fill array from System.Globalization.DateTimeFormatInfo.InvariantInfo
                var Months = System.Globalization.DateTimeFormatInfo.InvariantInfo.MonthNames;
                //loop array for add items
                foreach (string sm in Months)
                {
                    if (sm != "")
                        comboBox2.Items.Add(sm);
                }
                //set selected item for display on startup
                comboBox2.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
              
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Multiline = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // 
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

   
}
