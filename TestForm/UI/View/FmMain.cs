using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using TestForm.UI;

namespace TestForm
{

    public partial class FmMain : Form
    {
        public int CategoryId { get; set; }
        public int ParentId { get; set; }

        public FmMain()
        {
            InitializeComponent();
        }

        private void FmMain_Load(object sender, EventArgs e)
        {
            List<DAL.Repositories.ProductRepository> products = new List<DAL.Repositories.ProductRepository>(); 
            var categoryList = DAL.DataManager.Active.Category.GetList();
            LoadTvCategory(categoryList);
            dgvProduct.DataSource = DAL.DataManager.Active.Product.GetList();
            //var pr = DAL.DataManager.Active.Product.GetById(47);
            //listBox1.Items.Add(pr.Name);
            ViewTable();
        }

        private void LoadTvCategory(List<DAL.Repositories.Category> categories)
        {
            foreach (var category in categories)
            {
                if (category.ParentId == 0)
                    tvCategory.Nodes.Add(Convert.ToString(category.Id), category.Name);
                else tvCategory.Nodes.Find(Convert.ToString(category.ParentId), true)[0].Nodes.Add(Convert.ToString(category.Id), category.Name);
            }

        }

        private void ViewTable()
        {
            this.dgvProduct.Columns[0].Visible = false;
            this.dgvProduct.Columns[1].HeaderText = "Товар";
            this.dgvProduct.Columns[2].HeaderText = "Номер категории";
            this.dgvProduct.Columns[3].HeaderText = "Описание";
            this.dgvProduct.Columns[4].HeaderText = "Цена";
            this.dgvProduct.Columns[5].HeaderText = "Доступность";
        }

        private void BtnEditCategoryFm_Click(object sender, EventArgs e)
        {
            FmCategory category = new FmCategory();
            category.Id = Convert.ToInt32(tvCategory.SelectedNode.Name);
            category.ShowDialog();
        }

        private void BtnEditProductFm_Click(object sender, EventArgs e)
        {
            FmProduct product = new FmProduct();
            var rowIndex = this.dgvProduct.CurrentRow.Index;
            product.Id = (int)this.dgvProduct[0, rowIndex].Value;
            product.ShowDialog();
        }

        private void BtnAddCategoryFm_Click(object sender, EventArgs e)
        {
            FmCategory category = new FmCategory();
            category.ParentId = Convert.ToInt32(tvCategory.SelectedNode.Name);
            category.ShowDialog();
        }

        private void BtnAddProductFm_Click(object sender, EventArgs e)
        {
            FmProduct AddProduct = new FmProduct();
            AddProduct.ShowDialog();
        }

        private void BtnDeleteCategory_Click(object sender, EventArgs e)
        {
            string name = "Удалить категорию " + (string)this.tvCategory.SelectedNode.Text + " ?";
            int id = Convert.ToInt32(tvCategory.SelectedNode.Name);
            if (DialogResult.Yes == MessageBox.Show(name, "Удаление", MessageBoxButtons.YesNo))
            {
                DAL.DataManager.Active.Category.DeleteById(id);
            }
        }

        private void BtnDeleteProduct_Click(object sender, EventArgs e)
        {
            var rowIndex = this.dgvProduct.CurrentRow.Index;
            int id = (int)this.dgvProduct[0, rowIndex].Value;
            string name = (string)this.dgvProduct[1, rowIndex].Value;
            string deleting = "Удалить товар " + (string)this.dgvProduct[1, rowIndex].Value + " ?";
            if (DialogResult.Yes == MessageBox.Show(deleting, "Удаление", MessageBoxButtons.YesNo))
            {
                DAL.DataManager.Active.Product.DeleteById(id);
            }
        }

        private void tvCategory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int categoryId = Convert.ToInt32(tvCategory.SelectedNode.Name);
            this.dgvProduct.DataSource = DAL.DataManager.Active.Product.GetById(categoryId);//возможно неправильно
        }
    }
}