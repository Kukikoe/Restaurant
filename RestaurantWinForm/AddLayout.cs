using Restaurant.DBControllers;
using System;
using System.Windows.Forms;

namespace RestaurantWinForm
{
    public partial class AddLayout : Form
    {
        static public MainForm main_form;
        public AddLayout()
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
            LayoutDbController.AddLayout(int.Parse(textBoxDishId.Text), int.Parse(textBoxProductId.Text), double.Parse(textBoxQuantity.Text));
            MessageBox.Show("Success");
        }
    }
}
