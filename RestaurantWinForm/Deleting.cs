using Restaurant.DBControllers;
using System;
using System.Windows.Forms;


namespace RestaurantWinForm
{
    public partial class Deleting : Form
    {
        static public MainForm main_form;
        private int number;
        public Deleting()
        {
            InitializeComponent();
            main_form = new MainForm();
        }

        public void GetNumberOfDeletion(int x)
        {
            number = x;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {     
            if (number == 1)
            {
                ProductDbController.DeleteProduct(int.Parse(textBoxId.Text));
            }
            if (number == 2)
            {
                DishesDbController.DeleteDish(int.Parse(textBoxId.Text));
            }
            if (number == 3)
            {
                LayoutDbController.DeleteLayout(int.Parse(textBoxId.Text));
            }
            if (number == 4)
            {
                RecipeDbController.DeleteRecipe(int.Parse(textBoxId.Text));
            }
            if (number == 5)
            {
                PurchaseDbController.DeletePurchase(int.Parse(textBoxId.Text));
            }
            if (number == 6)
            {
                SaleDbController.DeleteSale(int.Parse(textBoxId.Text));
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            main_form.Show();
        }
    }
}
