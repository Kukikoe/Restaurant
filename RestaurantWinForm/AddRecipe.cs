using Restaurant.DBControllers;
using System;
using System.Windows.Forms;

namespace RestaurantWinForm
{
    public partial class AddRecipe : Form
    {
        static public MainForm main_form;
        public AddRecipe()
        {
            InitializeComponent();
            main_form = new MainForm();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            main_form.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            RecipeDbController.AddRecipe(textBoxName.Text, textBoxRecipe.Text);
            MessageBox.Show("Success");
        }
    }
}
