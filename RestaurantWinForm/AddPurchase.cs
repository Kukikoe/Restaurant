using Restaurant.DBControllers;
using System;
using System.Windows.Forms;

namespace RestaurantWinForm
{
    public partial class AddPurchase : Form
    {
        static public MainForm main_form;
        public AddPurchase()
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
            PurchaseDbController.AddPurchase(int.Parse(textBoxProductId.Text), double.Parse(textBoxQuantity.Text), double.Parse(textBoxPrice.Text), textBoxUnit.Text);
        }
    }
}
