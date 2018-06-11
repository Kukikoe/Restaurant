using Restaurant.DBControllers;
using System;
using System.Windows.Forms;

namespace RestaurantWinForm
{
    public partial class AddSale : Form
    {
        public AddSale()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (textBoxDishId.Text != "" && textBoxNumOfSales.Text != "")
            {
                SaleDbController.AddSale(int.Parse(textBoxDishId.Text), int.Parse(textBoxNumOfSales.Text));
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("All fields must be filled! Please try again)");
            }
        }
    }
}
