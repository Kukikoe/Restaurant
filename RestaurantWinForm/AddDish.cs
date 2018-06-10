using Restaurant.DBControllers;
using System;
using System.Windows.Forms;

namespace RestaurantWinForm
{
    public partial class AddDish : Form
    {
        static public MainForm main_form;
        public AddDish()
        {
            InitializeComponent();
            main_form = new MainForm();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DishesDbController.AddDish(textBoxName.Text, int.Parse(textBoxRecipeId.Text), int.Parse(textBoxPortionSize.Text), textBoxUnit.Text, double.Parse(textBoxPrice.Text));
            MessageBox.Show("Success");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            main_form.Show();
        }
    }
}
