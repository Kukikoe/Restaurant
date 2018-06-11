using Restaurant.DBControllers;
using System;
using System.Windows.Forms;

namespace RestaurantWinForm
{
    public partial class AddLayout : Form
    {
        public AddLayout()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (textBoxDishId.Text != "" && textBoxProductId.Text != "" && textBoxQuantity.Text != "")
            {
                if (double.Parse(textBoxQuantity.Text) > 0)
                {
                    LayoutDbController.AddLayout(int.Parse(textBoxDishId.Text), int.Parse(textBoxProductId.Text), double.Parse(textBoxQuantity.Text));
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Quantity can not be negative! Please try again)");
                    textBoxQuantity.Text = "";
                }
            }
            else
            {
                MessageBox.Show("All fields must be filled! Please try again)");
            }
        }
    }
}
