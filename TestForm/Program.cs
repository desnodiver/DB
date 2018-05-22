using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestForm.DAL;
using TestForm.DAL.Repositories;

namespace TestForm
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var cs = Properties.Settings.Default.connectionString;
            DAL.DataManager.Init(cs);
            TestDAL();
            Application.Run(new FmMain());
        }

        private static void TestDAL()
        {
            var hueta = DAL.DataManager.Active.Product.test();
            Console.WriteLine(hueta);
            //List<Product> listProduct = DAL.DataManager.Active.Product.GetList();
            //var pr = DAL.DataManager.Active.Product.GetById(47);

            //pr.Name = "1";
            //pr.CategoryId = 47;
            //pr.About = "1";
            //pr.Price = 1;
            //pr.IsAvailable = 0;
            //DAL.DataManager.Active.Product.Add(pr);


            //var pr1 = DAL.DataManager.Active.Product.GetById(47);
            //pr1.Name = "1";
            //pr1.CategoryId = 72;
            //pr1.About = "1";
            //pr1.Price = 3468;
            //pr1.IsAvailable += 1;

            //DAL.DataManager.Active.Product.Edit(pr1);


            //    var pr2 = DAL.DataManager.Active.Product.GetById(47);
            //    DAL.DataManager.Active.Product.Delete(pr2);



            //    List<Category> listCategory = DAL.DataManager.Active.Category.GetList();

            //    var ct = new Category();
            //    ct.Name = "vbnn";
            //    ct.ParentId = 0;
            //    DAL.DataManager.Active.Category.Add(ct);

            //    var ct1 = DAL.DataManager.Active.Category.GetById(72);
            //    ct.ParentId = 0;
            //    ct.Name += "f";
            //    DAL.DataManager.Active.Category.Edit(ct1);

            //    var ct2 = DAL.DataManager.Active.Category.GetById(82);
            //    DAL.DataManager.Active.Category.Delete(ct2);

        }
    }
}
