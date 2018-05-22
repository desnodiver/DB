using System;
using System.Windows.Forms;
using TestForm.UI;

namespace TestForm.UI
{
    public partial class FmProduct : Form
    {
        public int Id { get; set; }

        public FmProduct()
        {
            InitializeComponent();
        }

        private void FmEditProduct_Load(object sender, EventArgs e)
        {
            if (Id != 0)
            {
                btnProduct.Text = "Изменить";
                //DAL.DataManager.Active.Product.LoadProduct(Id);
                //this.tbName.Text = DAL.DataManager.Active.Product.Name;
                //this.tbCategoryId.Text = Convert.ToString(DAL.DataManager.Active.Product.CategoryId);
                //this.tbAbout.Text = DAL.DataManager.Active.Product.About;
                //this.tbPrice.Text = Convert.ToString(DAL.DataManager.Active.Product.Price);
                //this.tbAvailiblity.Text = Convert.ToString(DAL.DataManager.Active.Product.IsAvailable);

            }
            else
            {
                btnProduct.Text = "Добавить";
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            int categoryId = Convert.ToInt32(tbCategoryId.Text);
            string about = tbAbout.Text;
            int price = Convert.ToInt32(tbPrice.Text);
            int availiblity = Convert.ToInt32(tbAvailiblity.Text);
            if (Id != 0)
            {
                //DAL.DataManager.Active.Product.EditProductInDb(Id, name, categoryId, about, price, availiblity);
            }
            else
            {
                //DAL.DataManager.Active.Product.AddProductInDb(name, categoryId, about, price, availiblity);
            }
            tbName.Clear();
            tbCategoryId.Clear();
            tbAbout.Clear();
            tbPrice.Clear();
            tbAvailiblity.Clear();
        }
    }
}