using System.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;

namespace TestForm.DAL.Repositories
{
    public class ProductRepository : BaseRepository<Product>
    {
        public ProductRepository(DataManager parent) : base(parent)
        {
        }

        /// <summary>
        /// добавить новый продукт
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        //public int Add(Product product)
        //{
        //    var sql = "Insert into Product (name, categoryId, about, price, isAvailable) Values (@name, @categoryId, @about, @price, @isAvailable) SELECT SCOPE_IDENTITY();";

        //    var id = this.DbTools.ExecuteSql(sql, "Name", product.Name, "CategoryId", product.CategoryId, "About", product.About, "Price", product.Price, "IsAvailable", product.IsAvailable);

        //    return id;
        //}

        /// <summary>
        /// изменить категорию
        /// </summary>
        /// <param name="product"></param>
        /// 
        ///
        //public void Edit(Product product)
        //{
        //    var sql = "UPDATE Product SET name = @name, categoryId = @categoryId, about = @about , price = @price, isAvailable = @isAvailable WHERE Id = @Id;";

        //    this.DbTools.ExecuteSql(sql, "Id", product.Id, "Name", product.Name, "CategoryId", product.CategoryId, "About", product.About, "Price", product.Price, "IsAvailable", product.IsAvailable);
        //}

    }
}
