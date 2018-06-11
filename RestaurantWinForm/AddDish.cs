using Restaurant.DBControllers;
using System;
using System.Windows.Forms;

namespace RestaurantWinForm
{
    public partial class AddDish : Form
    {
        public AddDish()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && textBoxRecipeId.Text != "" && textBoxPortionSize.Text != "" && textBoxUnit.Text != "" && textBoxPrice.Text != "")
            {
                if (double.Parse(textBoxPrice.Text) > 0)
                {
                    DishesDbController.AddDish(textBoxName.Text, int.Parse(textBoxRecipeId.Text), int.Parse(textBoxPortionSize.Text), textBoxUnit.Text, double.Parse(textBoxPrice.Text));
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Price can not be negative! Please try again)");
                    textBoxPrice.Text = "";
                }
            }
            else
            {
                MessageBox.Show("All fields must be filled! Please try again)");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
