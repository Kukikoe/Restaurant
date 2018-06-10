using System;
using System.Windows.Forms;
using Restaurant.DBControllers;

namespace RestaurantWinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Get
        private void dishesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = DishesDbController.GetDishes();
        }

        private void recipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = RecipeDbController.GetRecipes();
        }

        private void purchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = PurchaseDbController.GetPurchases();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = SaleDbController.GetSales();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = ProductDbController.GetProducts();
        }
        
        private void layoutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = LayoutDbController.GetLayouts();
        }
        #endregion

        private void productAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct addProduct_form = new AddProduct();
            addProduct_form.Show();
            this.Hide();
        }

        private void dishAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDish addDish_form = new AddDish();
            addDish_form.Show();
            this.Hide();
        }

        private void recipeAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRecipe addRecipe_form = new AddRecipe();
            addRecipe_form.Show();
            this.Hide();
        }

        private void saleAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSale addSale_form = new AddSale();
            addSale_form.Show();
            this.Hide();
        }

        private void layoutAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLayout addLayout_form = new AddLayout();
            addLayout_form.Show();
            this.Hide();
        }

        private void purchaseAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPurchase addPurchase_form = new AddPurchase();
            addPurchase_form.Show();
            this.Hide();
        }

        #region Deleting 
        private void productDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deleting deleting_form = new Deleting();
            deleting_form.GetNumberOfDeletion(1);
            deleting_form.Show();
            this.Hide();
        }

        private void dishDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deleting deleting_form = new Deleting();
            deleting_form.GetNumberOfDeletion(2);
            deleting_form.Show();
            this.Hide();
        }

        private void layoutDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deleting deleting_form = new Deleting();
            deleting_form.GetNumberOfDeletion(3);
            deleting_form.Show();
            this.Hide();
        }

        private void recipeDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deleting deleting_form = new Deleting();
            deleting_form.GetNumberOfDeletion(4);
            deleting_form.Show();
            this.Hide();
        }

        private void purchaDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deleting deleting_form = new Deleting();
            deleting_form.GetNumberOfDeletion(5);
            deleting_form.Show();
            this.Hide();
        }

        private void saleDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deleting deleting_form = new Deleting();
            deleting_form.GetNumberOfDeletion(6);
            deleting_form.Show();
            this.Hide();
        }
        #endregion

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }      
    }
}
