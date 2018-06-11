using System;
using System.Windows.Forms;
using Restaurant.DBControllers;

namespace RestaurantWinForm
{
    public partial class MainForm : Form
    {
        private int x = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        #region Get
        private void dishesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTittle.Text = "Table Dishes";
            dataGridView.DataSource = DishesDbController.GetDishes();
            x = 1;
        }

        private void recipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTittle.Text = "Table Recipes";
            dataGridView.DataSource = RecipeDbController.GetRecipes();
            x = 2;
        }

        private void purchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTittle.Text = "Table Purchases";
            dataGridView.DataSource = PurchaseDbController.GetPurchases();
            x = 3;
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTittle.Text = "Table Sales";
            dataGridView.DataSource = SaleDbController.GetSales();
            x = 4;
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTittle.Text = "Table Products";
            dataGridView.DataSource = ProductDbController.GetProducts();
            x = 5;
        }
        
        private void layoutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTittle.Text = "Table Layouts";
            dataGridView.DataSource = LayoutDbController.GetLayouts();
            x = 6;
        }
        #endregion

        #region Add
        private void productAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct addProduct_form = new AddProduct();
            addProduct_form.Show();

        }

        private void dishAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDish addDish_form = new AddDish();
            addDish_form.Show();
        }

        private void recipeAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRecipe addRecipe_form = new AddRecipe();
            addRecipe_form.Show();
        }

        private void saleAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSale addSale_form = new AddSale();
            addSale_form.Show();
        }

        private void layoutAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLayout addLayout_form = new AddLayout();
            addLayout_form.Show();
        }

        private void purchaseAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPurchase addPurchase_form = new AddPurchase();
            addPurchase_form.Show();
        }
        #endregion

        #region Deleting 
        private void productDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deleting deleting_form = new Deleting();
            deleting_form.GetNumberOfDeletion(1);
            deleting_form.Show();        
        }

        private void dishDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deleting deleting_form = new Deleting();
            deleting_form.GetNumberOfDeletion(2);
            deleting_form.Show();
        }

        private void layoutDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deleting deleting_form = new Deleting();
            deleting_form.GetNumberOfDeletion(3);
            deleting_form.Show();
        }

        private void recipeDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deleting deleting_form = new Deleting();
            deleting_form.GetNumberOfDeletion(4);
            deleting_form.Show();
        }

        private void purchaDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deleting deleting_form = new Deleting();
            deleting_form.GetNumberOfDeletion(5);
            deleting_form.Show();
        }

        private void saleDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deleting deleting_form = new Deleting();
            deleting_form.GetNumberOfDeletion(6);
            deleting_form.Show();
        }
        #endregion

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {           
            if (x == 1)
            {
                dataGridView.DataSource = DishesDbController.GetDishes();
                dataGridView.Refresh();
            }
            if (x == 2)
            {
                dataGridView.DataSource = RecipeDbController.GetRecipes();
                dataGridView.Refresh();
            }
            if (x == 3)
            {
                dataGridView.DataSource = PurchaseDbController.GetPurchases();
                dataGridView.Refresh();
            }
            if (x == 4)
            {
                dataGridView.DataSource = SaleDbController.GetSales();
                dataGridView.Refresh();
            }
            if (x == 5)
            {
                dataGridView.DataSource = ProductDbController.GetProducts();
                dataGridView.Refresh();
            }
            if (x == 6)
            {
                dataGridView.DataSource = LayoutDbController.GetLayouts();
                dataGridView.Refresh();
            }
            }
    }
}
