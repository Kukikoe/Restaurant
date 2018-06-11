using Restaurant.DBControllers;
using System;
using System.Windows.Forms;

namespace RestaurantWinForm
{
    public partial class AddPurchase : Form
    {
        public AddPurchase()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (textBoxProductId.Text != "" && textBoxQuantity.Text != "" && textBoxPrice.Text != "" && textBoxUnit.Text != "")
            {
                if (double.Parse(textBoxPrice.Text) > 0 && double.Parse(textBoxQuantity.Text) > 0)
                {
                    PurchaseDbController.AddPurchase(int.Parse(textBoxProductId.Text), double.Parse(textBoxQuantity.Text), double.Parse(textBoxPrice.Text), textBoxUnit.Text);
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Price/quantity can not be negative! Please try again)");
                    textBoxPrice.Text = "";
                }
            }
            else
            {
                MessageBox.Show("All fields must be filled! Please try again)");
            }
}
    }
}
