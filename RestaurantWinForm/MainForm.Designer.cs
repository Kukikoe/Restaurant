namespace RestaurantWinForm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.seeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dishesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recipesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dishAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recipeAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dishDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layoutDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recipeDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelTittle = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seeToolStripMenuItem,
            this.addToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(657, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // seeToolStripMenuItem
            // 
            this.seeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dishesToolStripMenuItem,
            this.recipesToolStripMenuItem,
            this.purchasesToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.layoutsToolStripMenuItem});
            this.seeToolStripMenuItem.Name = "seeToolStripMenuItem";
            this.seeToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.seeToolStripMenuItem.Text = "See";
            // 
            // dishesToolStripMenuItem
            // 
            this.dishesToolStripMenuItem.Name = "dishesToolStripMenuItem";
            this.dishesToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.dishesToolStripMenuItem.Text = "Dishes";
            this.dishesToolStripMenuItem.Click += new System.EventHandler(this.dishesToolStripMenuItem_Click);
            // 
            // recipesToolStripMenuItem
            // 
            this.recipesToolStripMenuItem.Name = "recipesToolStripMenuItem";
            this.recipesToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.recipesToolStripMenuItem.Text = "Recipes";
            this.recipesToolStripMenuItem.Click += new System.EventHandler(this.recipesToolStripMenuItem_Click);
            // 
            // purchasesToolStripMenuItem
            // 
            this.purchasesToolStripMenuItem.Name = "purchasesToolStripMenuItem";
            this.purchasesToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.purchasesToolStripMenuItem.Text = "Purchases";
            this.purchasesToolStripMenuItem.Click += new System.EventHandler(this.purchasesToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.salesToolStripMenuItem.Text = "Sales";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // layoutsToolStripMenuItem
            // 
            this.layoutsToolStripMenuItem.Name = "layoutsToolStripMenuItem";
            this.layoutsToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.layoutsToolStripMenuItem.Text = "Layouts";
            this.layoutsToolStripMenuItem.Click += new System.EventHandler(this.layoutsToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productAddToolStripMenuItem,
            this.dishAddToolStripMenuItem,
            this.recipeAddToolStripMenuItem,
            this.saleAddToolStripMenuItem,
            this.layoutAddToolStripMenuItem,
            this.purchaseAddToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // productAddToolStripMenuItem
            // 
            this.productAddToolStripMenuItem.Name = "productAddToolStripMenuItem";
            this.productAddToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.productAddToolStripMenuItem.Text = "Product";
            this.productAddToolStripMenuItem.Click += new System.EventHandler(this.productAddToolStripMenuItem_Click);
            // 
            // dishAddToolStripMenuItem
            // 
            this.dishAddToolStripMenuItem.Name = "dishAddToolStripMenuItem";
            this.dishAddToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.dishAddToolStripMenuItem.Text = "Dish";
            this.dishAddToolStripMenuItem.Click += new System.EventHandler(this.dishAddToolStripMenuItem_Click);
            // 
            // recipeAddToolStripMenuItem
            // 
            this.recipeAddToolStripMenuItem.Name = "recipeAddToolStripMenuItem";
            this.recipeAddToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.recipeAddToolStripMenuItem.Text = "Recipe";
            this.recipeAddToolStripMenuItem.Click += new System.EventHandler(this.recipeAddToolStripMenuItem_Click);
            // 
            // saleAddToolStripMenuItem
            // 
            this.saleAddToolStripMenuItem.Name = "saleAddToolStripMenuItem";
            this.saleAddToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.saleAddToolStripMenuItem.Text = "Sale";
            this.saleAddToolStripMenuItem.Click += new System.EventHandler(this.saleAddToolStripMenuItem_Click);
            // 
            // layoutAddToolStripMenuItem
            // 
            this.layoutAddToolStripMenuItem.Name = "layoutAddToolStripMenuItem";
            this.layoutAddToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.layoutAddToolStripMenuItem.Text = "Layout";
            this.layoutAddToolStripMenuItem.Click += new System.EventHandler(this.layoutAddToolStripMenuItem_Click);
            // 
            // purchaseAddToolStripMenuItem
            // 
            this.purchaseAddToolStripMenuItem.Name = "purchaseAddToolStripMenuItem";
            this.purchaseAddToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.purchaseAddToolStripMenuItem.Text = "Purchase";
            this.purchaseAddToolStripMenuItem.Click += new System.EventHandler(this.purchaseAddToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productDeleteToolStripMenuItem,
            this.dishDeleteToolStripMenuItem,
            this.layoutDeleteToolStripMenuItem,
            this.recipeDeleteToolStripMenuItem,
            this.purchaDeleteToolStripMenuItem,
            this.saleDeleteToolStripMenuItem});
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // productDeleteToolStripMenuItem
            // 
            this.productDeleteToolStripMenuItem.Name = "productDeleteToolStripMenuItem";
            this.productDeleteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.productDeleteToolStripMenuItem.Text = "Product";
            this.productDeleteToolStripMenuItem.Click += new System.EventHandler(this.productDeleteToolStripMenuItem_Click);
            // 
            // dishDeleteToolStripMenuItem
            // 
            this.dishDeleteToolStripMenuItem.Name = "dishDeleteToolStripMenuItem";
            this.dishDeleteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.dishDeleteToolStripMenuItem.Text = "Dish";
            this.dishDeleteToolStripMenuItem.Click += new System.EventHandler(this.dishDeleteToolStripMenuItem_Click);
            // 
            // layoutDeleteToolStripMenuItem
            // 
            this.layoutDeleteToolStripMenuItem.Name = "layoutDeleteToolStripMenuItem";
            this.layoutDeleteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.layoutDeleteToolStripMenuItem.Text = "Layout";
            this.layoutDeleteToolStripMenuItem.Click += new System.EventHandler(this.layoutDeleteToolStripMenuItem_Click);
            // 
            // recipeDeleteToolStripMenuItem
            // 
            this.recipeDeleteToolStripMenuItem.Name = "recipeDeleteToolStripMenuItem";
            this.recipeDeleteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.recipeDeleteToolStripMenuItem.Text = "Recipe";
            this.recipeDeleteToolStripMenuItem.Click += new System.EventHandler(this.recipeDeleteToolStripMenuItem_Click);
            // 
            // purchaDeleteToolStripMenuItem
            // 
            this.purchaDeleteToolStripMenuItem.Name = "purchaDeleteToolStripMenuItem";
            this.purchaDeleteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.purchaDeleteToolStripMenuItem.Text = "Purchase";
            this.purchaDeleteToolStripMenuItem.Click += new System.EventHandler(this.purchaDeleteToolStripMenuItem_Click);
            // 
            // saleDeleteToolStripMenuItem
            // 
            this.saleDeleteToolStripMenuItem.Name = "saleDeleteToolStripMenuItem";
            this.saleDeleteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.saleDeleteToolStripMenuItem.Text = "Sale";
            this.saleDeleteToolStripMenuItem.Click += new System.EventHandler(this.saleDeleteToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 80);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(633, 285);
            this.dataGridView.TabIndex = 1;
            // 
            // labelTittle
            // 
            this.labelTittle.AutoSize = true;
            this.labelTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTittle.Location = new System.Drawing.Point(16, 39);
            this.labelTittle.Name = "labelTittle";
            this.labelTittle.Size = new System.Drawing.Size(0, 20);
            this.labelTittle.TabIndex = 2;
            this.labelTittle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Image = global::RestaurantWinForm.Properties.Resources.refresh__1_;
            this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefresh.Location = new System.Drawing.Point(568, 34);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Padding = new System.Windows.Forms.Padding(4);
            this.buttonRefresh.Size = new System.Drawing.Size(77, 35);
            this.buttonRefresh.TabIndex = 3;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 377);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.labelTittle);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem seeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dishesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recipesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layoutsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dishAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recipeAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layoutAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dishDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layoutDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recipeDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelTittle;
        private System.Windows.Forms.Button buttonRefresh;
    }
}

