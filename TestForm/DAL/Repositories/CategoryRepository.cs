using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using TestForm.Properties;

namespace TestForm.DAL.Repositories
{
    public class CategoryRepository : BaseRepository<Category>
    {

        public CategoryRepository(DataManager parent) : base(parent)
        {
        }

        /// <summary>
        /// добавить новую категорию
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        //public int Add(Category category)
        //{
        //    var sql = "Insert into Category (name, parentId) Values (@name, @parentId) SELECT SCOPE_IDENTITY();";

        //    var id = this.DbTools.ExecuteSql(sql, "Name", category.Name, "ParentId", category.ParentId);

        //    return id;
        //}

        /// <summary>
        /// изменить категорию
        /// </summary>
        /// <param name="categories"></param>
        //public void Edit(Category category)
        //{
        //    var sql = "UPDATE Category SET name = @name WHERE Id = @Id;";

        //    this.DbTools.ExecuteSql(sql, "Name", category.Name, "Id", category.Id);
        //}

    }
}
