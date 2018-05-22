using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace TestForm.DAL
{
    public interface IDbTools
    {
        DataTable GetDataTable(string sql);
        /// <summary>
        /// получить таблицу из БД
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="prms"></param>
        /// <returns></returns>
        DataTable ExecuteSqlDataTable(string sql, params object[] prms);
        /// <summary>
        /// получить id новой записи
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="prms"></param>
        /// <returns></returns>
        int ExecuteSql(string sql, params object[] prms);
    }
}
