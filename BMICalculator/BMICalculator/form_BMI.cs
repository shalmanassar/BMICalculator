using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class form_BMI : Form
    {
        //------------------------------------------------------------------------- Global VARS
        int feet,
            inches,
            totInches;
        double pounds,
            centimeters,
            kilograms;

        // form ininialized
        public form_BMI()
        {
            InitializeComponent();
            tb_feet.ReadOnly = false;
            tb_lbs.ReadOnly = false;
        }

        //------------------------------------------------------------------------ Radio Buttons
        // Customary checked
        private void rd_customary_CheckedChanged(object sender, EventArgs e)
        {
            tb_cm.Clear();
            tb_kilos.Clear();
            tb_feet.Clear();
            tb_inches.Clear();
            tb_lbs.Clear();
            totInches = 0;
            if (rd_customary.Checked)
            {
                tb_feet.ReadOnly = false;
                tb_lbs.ReadOnly = false;
                tb_cm.ReadOnly = true;
                tb_kilos.ReadOnly = true;
            }
        }

        // Metric checked
        private void rd_metric_CheckedChanged(object sender, EventArgs e)
        {
            tb_cm.Clear();
            tb_kilos.Clear();
            tb_feet.Clear();
            tb_inches.Clear();
            tb_lbs.Clear();
            totInches = 0;

            if (rd_metric.Checked)
            {
                tb_cm.ReadOnly = false;
                tb_kilos.ReadOnly = false;
                tb_feet.ReadOnly = true;
                tb_inches.ReadOnly = true;
                tb_lbs.ReadOnly = true;
            }
        }


        //------------------------------------------------------------------------ Data Entry
        // Centimeters entered and verified
        private void tb_cm_TextChanged(object sender, EventArgs e)
        {
            int c;
            if (rd_metric.Checked)
            {
                if (int.TryParse(tb_cm.Text, out c))
                {
                    centimeters = c;
                    totInches = Convert.ToInt32(centimeters * .393701);
                    feet = totInches / 12;
                    inches = totInches % 12;
                    tb_feet.Text = feet.ToString();
                    tb_inches.Text = inches.ToString();

                }

                else
                {
                    if (!string.IsNullOrWhiteSpace(tb_cm.Text))
                    {
                        tb_cm.Clear();
                        MessageBox.Show("Please enter centimeters as a whole number");
                    }
                }
            }

        }

        // Feet entered and verified
        private void tb_feet_TextChanged(object sender, EventArgs e)
        {
            int f;
            if (rd_customary.Checked)
            {
                if (int.TryParse(tb_feet.Text, out f))
                {
                    feet = f;
                    tb_inches.ReadOnly = false;
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(tb_feet.Text))
                    {
                        tb_feet.Clear();
                        MessageBox.Show("Please enter feet as a whole number.");
                    }
                }
            }


        }

        // Inches entered and verified
        private void tb_inches_TextChanged(object sender, EventArgs e)
        {
            int i;
            if (rd_customary.Checked)  // it is customary data
            {
                if (int.TryParse(tb_inches.Text, out i)) // it is an integer
                {
                    inches = i;
                    totInches = (feet * 12) + inches;
                    centimeters = totInches * 2.54;
                    //MessageBox.Show("inches: " + totInches + " centimeters: " + centimeters);
                    tb_cm.Text = centimeters.ToString();

                }
                else // it is not a number
                {
                    if (!string.IsNullOrWhiteSpace(tb_inches.Text))  // it is not an empty field
                    {
                        tb_inches.Clear();
                        MessageBox.Show("Please enter centimeters as a whole number");
                    }
                }
            }


        }

        // Pounds entered and verified
        private void tb_lbs_TextChanged(object sender, EventArgs e)
        {
            double l;
            if (rd_customary.Checked)
            {
                if (double.TryParse(tb_lbs.Text, out l))
                {
                    pounds = l;
                    kilograms = pounds * .453592;
                    tb_kilos.Text = kilograms.ToString();

                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(tb_lbs.Text))
                    {
                        tb_lbs.Clear();
                        MessageBox.Show("Please enter inches as a decimal equivalent");
                    }
                }
            }

        }

        // Kilograms entered and verified
        private void tb_kilos_TextChanged(object sender, EventArgs e)
        {
            double k;
            if(rd_metric.Checked)
            {
                if(double.TryParse(tb_kilos.Text, out k))
                {
                    kilograms = k;
                    pounds = kilograms * 2.20462;
                    tb_lbs.Text = pounds.ToString(); 
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(tb_kilos.Text))
                    {
                        tb_kilos.Clear();
                        MessageBox.Show("Please enter inches as a decimal equivalent");
                    }
                }
            }


        }

        
        //------------------------------------------------------------------------- Buttons
        // CLEAR Button
        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_cm.Clear();
            tb_kilos.Clear();
            tb_feet.Clear();
            tb_inches.Clear();
            tb_lbs.Clear();
            tb_feet.ReadOnly = true;
            tb_cm.ReadOnly = true;
            tb_kilos.ReadOnly = true;
            tb_inches.ReadOnly = true;
            tb_lbs.ReadOnly = true;
            rd_customary.Checked = false;
            rd_metric.Checked = false;
            totInches = 0;
        }

        // EXIT button
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Process BMI button
        private void btn_process_Click(object sender, EventArgs e)
        {
            if (centimeters > 0 && kilograms > 0)
            {
                try
                {
                    BMI thisGuy = new BMI();
                    string outString = thisGuy.BMIString(kilograms,centimeters);
                    MessageBox.Show(outString);
                }
                catch
                {

                }
            }
            else
            {
                MessageBox.Show("Please enter data");
            }
        }






    }
}
