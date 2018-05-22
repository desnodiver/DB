using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

namespace TestForm.DAL.Repositories
{
    public class BaseRepository<T>
        where T : IDdObject, new()
    {
        protected IDbTools DbTools { get { return Parent.DbTools; } }
        protected DataManager Parent { get; set; }
        public string TableName { get; }

        public BaseRepository(DataManager parent)
        {
            this.Parent = parent;
            var type = typeof(T);
            this.TableName = type.Name;
        }

        public virtual void Delete(T entity)
        {
            var sql = string.Format("Delete From {0} Where Id = @id", this.TableName);

            this.DbTools.ExecuteSql(sql, "id", entity.Id);
        }

        public virtual void DeleteById(int id)
        {
            var sql = string.Format("Delete From {0} Where Id = @id", this.TableName);

            this.DbTools.ExecuteSql(sql, "id", id);
        }

        public virtual T GetById(int id)
        {
            return GetList().FirstOrDefault(param => param.Id == id);
        }



        public virtual void Add(T entity)
        {
        }

        public virtual List<T> Edit (T entity)
        {
            //var list = new List<T>();
            var list = GetById(47);
            var res = new List<T>(); ;
            var props = typeof(T).GetProperties();
            foreach (var prop in props)
            {
                if (prop.CanRead)
                {
                    var o = prop.GetValue(res, null);                  
                }
                  
            }
            return res;
        }
        public virtual object test()
        {
            var list = GetById(47);
            var res = new List<T>();
            var o = new object();
            var props = typeof(T).GetProperties();
            foreach (var prop in props)
            {
                if (prop.CanRead)
                {

                  o = prop.GetValue(list, null);
                  o.
                }

            }
            return o;
        }


        public virtual List<T> GetList()
        {
            var sql = string.Format("SELECT * FROM {0}", this.TableName);

            var dt = this.DbTools.GetDataTable(sql);

            var res = new List<T>();

            foreach (DataRow dr in dt.Rows)
            {
                var item = new T
                {
                    Id = (int)dr["Id"],
                };

                var props = typeof(T).GetProperties();

                foreach (var prop in props)
                {
                    if (prop.Name == "Id")
                        continue;

                    var value = dr[prop.Name];

                    prop.SetValue(item, value);
                }

                res.Add(item);
            }

            return res;
        }

    }
}
