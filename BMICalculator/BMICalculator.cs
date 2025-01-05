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
    public partial class BMICalculator : Form
    {
        public BMICalculator()
        {
            InitializeComponent();
        }

        private void RBTNMetric_CheckedChanged(object sender, EventArgs e)
        {
            if (RBTNMetric.Checked == true)
            {
                LBHeight.Text = "Height (cm) :";
                LBWeight.Text = "Weight (kg) :";
            }
        }

        private void RBTNImperial_CheckedChanged(object sender, EventArgs e)
        {
            if (RBTNImperial.Checked == true)
            {
                LBHeight.Text = "Height (lbs) :";
                LBWeight.Text = "Weight (inches) :";
            }
        }

        bool IsAllFieldsFilled()
        {
            if ((RBTNMetric.Checked == false && RBTNImperial.Checked == false)
                || string.IsNullOrWhiteSpace(TxTBHeight.Text) || string.IsNullOrWhiteSpace(TxTBWeight.Text))
                return false;
            else 
                return true;
        }

        bool IsFieldsValid()
        {
            if (Convert.ToDouble(TxTBWeight.Text) < 0 || Convert.ToDouble(TxTBHeight.Text) < 0)
                return false;
            else
                return true;
        }

        void DetermineHealthStatus(double BMIResult)
        {
            if (BMIResult < 18.5)
            {
                LBHealthStatus.Text = "Underweight";
                LBHealthStatus.BackColor = Color.FromArgb(192, 192, 255);
            }
            else if (BMIResult >= 18.5 && BMIResult <= 24.9)
            {
                LBHealthStatus.Text = "Normal weight";
                LBHealthStatus.BackColor = Color.FromArgb(192, 255, 192);
            }
            else if (BMIResult >= 25 && BMIResult <= 29.9)
            {
                LBHealthStatus.Text = "Overweight";
                LBHealthStatus.BackColor = Color.FromArgb(255, 224, 192);
            }
            else if (BMIResult >= 30)
            {
                LBHealthStatus.Text = "Obese";
                LBHealthStatus.BackColor = Color.FromArgb(255, 192, 192);
            }
        }

        private void BTNCalculateBMI_Click(object sender, EventArgs e)
        {
            if (!IsAllFieldsFilled())
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsFieldsValid())
            {
                MessageBox.Show("Invalid fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double BMIResult, Height, Weight;

            Weight = Convert.ToDouble(TxTBWeight.Text);
            Height = Convert.ToDouble(TxTBHeight.Text); 

            if (RBTNMetric.Checked == true)
            {               
                BMIResult = Weight / ((Height / 100) * (Height / 100));
                
                LBBMIResult.Text = BMIResult.ToString("F1");
                DetermineHealthStatus(Convert.ToDouble(LBBMIResult.Text));
                LBBMIResult.BackColor = LBHealthStatus.BackColor;
            }
            else if (RBTNImperial.Checked == true)
            {
                BMIResult = (Weight * 703) / (Height * Height);

                LBBMIResult.Text = BMIResult.ToString("F1");
                DetermineHealthStatus(Convert.ToDouble(LBBMIResult.Text));
                LBBMIResult.BackColor = LBHealthStatus.BackColor;
            }
        }

        private void TxTBHeight_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxTBHeight.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(TxTBHeight, "Enter The Height");
            }
        }

        private void TxTBWeight_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxTBWeight.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(TxTBWeight, "Enter The Weight");
            }
        }
    }
}
