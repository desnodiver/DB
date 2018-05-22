using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForm.DAL
{
    public class DataManager
    {
        public static DataManager Active { get; set; }

        public static void Init(string connectionString)
        {
            DataManager.Active = new DataManager(connectionString);
        }

        public IDbTools DbTools { get; set; }

        public string ConnectionString { get; private set; }

        private DataManager(string connectionString)
        {
            this.DbTools = new DbTools(connectionString);

            this.ConnectionString = connectionString;

            Category = new Repositories.CategoryRepository(this);

            Product = new Repositories.ProductRepository(this);


        }

        public Repositories.CategoryRepository Category { get; private set; }

        public Repositories.ProductRepository Product { get; private set; }

    }
}
