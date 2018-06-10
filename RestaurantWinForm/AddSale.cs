using Restaurant.DBControllers;
using System;
using System.Windows.Forms;

namespace RestaurantWinForm
{
    public partial class AddSale : Form
    {
        static public MainForm main_form;
        public AddSale()
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
            SaleDbController.AddSale(int.Parse(textBoxDishId.Text), int.Parse(textBoxNumOfSales.Text));
            MessageBox.Show("Success");
        }
    }
}
