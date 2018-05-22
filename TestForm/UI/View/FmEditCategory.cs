using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestForm.UI;

namespace TestForm.UI
{
    public partial class FmCategory : Form
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        FmCategory Item { get; set; }

        public FmCategory()
        {
            InitializeComponent();
        }

        //public static bool Execute(FmCategory categories)
        //{
        //    using (var fm = new FmCategory())
        //    {
        //        fm.Item = categories;
        //        return fm.ShowDialog() == DialogResult.OK;
        //    }
        //}

        private void FmEditCategory_Load(object sender, EventArgs e)
        {

            if (Id != 0)
            {
                var category = DAL.DataManager.Active.Category.GetById(Id);
                btnCategory.Text = "Изменить";
                //this.tbCategory.Text = DAL.DataManager.Active.Category.Name;
                //this.tbParentId.Text = Convert.ToString(DAL.DataManager.Active.Category.ParentId);
            }
            else
            {
                btnCategory.Text = "Добавить";
                //DAL.DataManager.Active.Category.LoadCategory(Id);
                //this.tbParentId.Text = Convert.ToString(ParentId);
            }
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            //string name = tbCategory.Text;
            //int parentId = Convert.ToInt32(tbParentId.Text);
            //if (Id != 0)
            //{
            //    DAL.DataManager.Active.Category.EditCategoryInDb(Id, parentId, name);
            //}
            //else
            //{
            //    DAL.DataManager.Active.Category.AddCategoryInDb(parentId, name);
            //}
            //tbCategory.Clear();
        }
    }
}
