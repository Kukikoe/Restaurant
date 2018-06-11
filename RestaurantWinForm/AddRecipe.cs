using Restaurant.DBControllers;
using System;
using System.Windows.Forms;

namespace RestaurantWinForm
{
    public partial class AddRecipe : Form
    {
        public AddRecipe()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && textBoxRecipe.Text != "")
            {
                RecipeDbController.AddRecipe(textBoxName.Text, textBoxRecipe.Text);
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("All fields must be filled! Please try again)");
            }
        }
    }
}
