using Restaurant.DBControllers;
using System;
using System.Windows.Forms;

namespace RestaurantWinForm
{
    public partial class AddProduct : Form
    {
        static public MainForm main_form;
        public AddProduct()
        {
            InitializeComponent();
            main_form = new MainForm();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ProductDbController.AddProduct(textBoxName.Text, textBoxUnit.Text);
            MessageBox.Show("Success");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            main_form.Show();
        }


    }
}
