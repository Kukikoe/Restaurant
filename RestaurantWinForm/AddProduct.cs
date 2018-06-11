using Restaurant.DBControllers;
using System;
using System.Windows.Forms;

namespace RestaurantWinForm
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && textBoxUnit.Text != "")
            {
                ProductDbController.AddProduct(textBoxName.Text, textBoxUnit.Text);
            MessageBox.Show("Success");
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
