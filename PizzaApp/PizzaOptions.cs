using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaApp
{
    public partial class PizzaOptions : Form
    {
        public PizzaOptions()
        {
            InitializeComponent();
        }

        float GetSelectedSizePrice()
        {
            if (RDBTNSmall.Checked)
            {
                return Convert.ToSingle(RDBTNSmall.Tag);
            }
            else if (RDBTNMedium.Checked)
            {
                return Convert.ToSingle(RDBTNMedium.Tag);
            }
            else
                return Convert.ToSingle(RDBTNLarge.Tag);
        }

        float GetSelectedCrustTypePrice()
        {
            if (RDBTNThikCrust.Checked)
            {
                return Convert.ToSingle(RDBTNThikCrust.Tag);
            }
            else 
            {
                return Convert.ToSingle(RDBTNThinCrust.Tag);
            }
        }

        float GetSelectedToppingsPrice()
        {
            float Toppings = 0;

            if (CHBExtraChees.Checked)
            {
                Toppings += Convert.ToSingle(CHBExtraChees.Tag);
            }

            if (CHBTomatoes.Checked)
            {
                Toppings += Convert.ToSingle(CHBTomatoes.Tag);
            }

            if (CHBMushroums.Checked)
            {
                Toppings += Convert.ToSingle(CHBMushroums.Tag);
            }

            if (CHBOnion.Checked)
            {
                Toppings += Convert.ToSingle(CHBOnion.Tag);
            }

            if (CHBOlives.Checked)
            {
                Toppings += Convert.ToSingle(CHBOlives.Tag);
            }

            if (CHBGreenPeppers.Checked)
            {
                Toppings += Convert.ToSingle(CHBGreenPeppers.Tag);
            }

            return Toppings;
        }

        float GetSelectedWhereToEatPrice()
        {
            if (RDBTNHomeDelivery.Checked)
            {
                return Convert.ToSingle(RDBTNHomeDelivery.Tag);
            }
            else
                return Convert.ToSingle(RDBTNInRestaurant.Tag);
        }

        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + GetSelectedCrustTypePrice() + GetSelectedToppingsPrice() + GetSelectedWhereToEatPrice();
        }

        void UpdateTotalPrice()
        {
            LBTotalPrice.Text = CalculateTotalPrice().ToString();
        }

        void UpdateSize()
        {
            UpdateTotalPrice();

            if (RDBTNSmall.Checked)
            {
                LBSize.Text = "Small";
            }

            if (RDBTNMedium.Checked)
            {
                LBSize.Text = "Medium";
            }

            if (RDBTNLarge.Checked)
            {
                LBSize.Text = "Large";
            }
        }

        void UpdateCrustType()
        {
            UpdateTotalPrice();

            if (RDBTNThikCrust.Checked)
            {
                LBCrustType.Text = "Thik Crust";
            }
            else if (RDBTNThinCrust.Checked)
            {
                LBCrustType.Text = "Thin Crust";
            }
        }

        void UpdateToppings()
        {
            UpdateTotalPrice();

            string Toppings = "";
            byte ToppingCount = 0;

            if (CHBExtraChees.Checked)
            {
                Toppings = "Extra Chees";
                ToppingCount++; 

                if (ToppingCount == 3)
                    Toppings += "\n";
            }
            if (CHBTomatoes.Checked)
            {
                Toppings += ", Tomatoes";
                ToppingCount++;

                if (ToppingCount == 3)
                    Toppings += "\n";
            }
            if (CHBMushroums.Checked)
            {
                Toppings += ", Mushroums";
                ToppingCount++;

                if (ToppingCount == 3)
                    Toppings += "\n";
            }
            if (CHBOnion.Checked)
            {
                Toppings += ", Onion";
                ToppingCount++;

                if (ToppingCount == 3)
                    Toppings += "\n";
            }
            if (CHBOlives.Checked)
            {
                Toppings += ", Olives";
                ToppingCount++;

                if (ToppingCount == 3)
                    Toppings += "\n";
            }
            if (CHBGreenPeppers.Checked)
            {
                Toppings += ", GreenPeppers";
                ToppingCount++;

                if (ToppingCount == 3)
                    Toppings += "\n";
            }

            if (Toppings.StartsWith(","))
            {
                Toppings = Toppings.Substring(1, Toppings.Length - 1).Trim();
            }

            if (Toppings == "")
                Toppings = "No Toppings";

            LBToppings.Text = Toppings;
        }

        void UpdateWhereToEat()
        {
            UpdateTotalPrice();
            if (RDBTNHomeDelivery.Checked)
                LBWhereToEat.Text = "Home Delivery";
            else if (RDBTNInRestaurant.Checked)
                LBWhereToEat.Text = "In Restaurant";
        }

        bool IsValidOrder()
        {
            if (RDBTNSmall.Checked != true && RDBTNMedium.Checked != true && RDBTNLarge.Checked != true)
            {
                MessageBox.Show("Please choose a size!", "Size", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (RDBTNThinCrust.Checked != true && RDBTNThikCrust.Checked != true)
            {
                MessageBox.Show("Please choose a crust type!", "Crust Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (RDBTNHomeDelivery.Checked != true && RDBTNInRestaurant.Checked != true)
            {
                MessageBox.Show("Please choose where to eat!", "Where To Eat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (CHBExtraChees.Checked != true && CHBTomatoes.Checked != true && CHBMushroums.Checked != true && CHBOnion.Checked != true && CHBOlives.Checked != true && CHBGreenPeppers.Checked != true)
            {
                MessageBox.Show("Please choose Toppings!", "Toppings", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                byte ChoosedToppings = 0;

                if (CHBExtraChees.Checked == true) { ChoosedToppings++; }
                if (CHBTomatoes.Checked == true) { ChoosedToppings++; }
                if (CHBMushroums.Checked == true) { ChoosedToppings++; }
                if (CHBOnion.Checked == true) { ChoosedToppings++; }
                if (CHBOlives.Checked == true) { ChoosedToppings++; }
                if (CHBGreenPeppers.Checked == true) { ChoosedToppings++; }

                if (ChoosedToppings < 3)
                {
                    MessageBox.Show("Please at least choose 3 Toppings!", "Toppings", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private void RDBTNSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void RDBTNMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void RDBTNLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void RDBTNThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void RDBTNThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void CHBExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void CHBTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void CHBMushroums_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void CHBOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void CHBOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void CHBGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void RDBTNHomeDelivery_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void RDBTNInRestaurant_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void BTNOrder_Click(object sender, EventArgs e)
        {
            if (!IsValidOrder())
                return;
            
            if (MessageBox.Show("Confirm Order", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {                
                MessageBox.Show("Order Placed Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);             
                
                GBSize.Enabled = false;
                GBCrustType.Enabled = false;
                GBToppings.Enabled = false;
                GBWhereToEat.Enabled = false;
                BTNOrder.Enabled = false;               
            }
        }

        private void BTNReset_Click(object sender, EventArgs e)
        {
            // Reset Size Group 
            GBSize.Enabled = true;

            // Reset Crust Type Group
            GBCrustType.Enabled = true;

            // Reset Toppings Group
            GBToppings.Enabled = true;

            GBWhereToEat.Enabled = true;

            // Set Size Medium as Default
            RDBTNMedium.Checked = true;

            // Set ThinCrust as Default
            RDBTNThinCrust.Checked = true;

            // Set Home Delivery as Default
            RDBTNHomeDelivery.Checked = true;

            // Reset Toppings
            CHBExtraChees.Checked = false;
            CHBTomatoes.Checked = false;
            CHBMushroums.Checked = false;
            CHBOnion.Checked = false;
            CHBOlives.Checked = false;
            CHBGreenPeppers.Checked = false;

            // Reset Button Order
            BTNOrder.Enabled = true;
        }

    }
}
