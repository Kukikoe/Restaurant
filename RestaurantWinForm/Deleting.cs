using Restaurant.DBControllers;
using System;
using System.Windows.Forms;


namespace RestaurantWinForm
{
    public partial class Deleting : Form
    {
        private int number;
        public Deleting()
        {
            InitializeComponent();
        }

        public void GetNumberOfDeletion(int x)
        {
            number = x;
            if (number == 1)
            {
                labelTittle.Text = "Delete row from table tbProducts";
            }
            if (number == 2)
            {
                labelTittle.Text = "Delete row from table tbDishes";
            }
            if (number == 3)
            {
                labelTittle.Text = "Delete row from table tbLayout";
            }
            if (number == 4)
            {
                labelTittle.Text = "Delete row from table tbRecipes";
            }
            if (number == 5)
            {
                labelTittle.Text = "Delete row from table tbPurchases";
            }
            if (number == 6)
            {
                labelTittle.Text = "Delete row from table tbSales";
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (textBoxId.Text != "")
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
            else
            {
                MessageBox.Show("All fields must be filled! Please try again)");
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
