using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using SQLitePCL;

namespace paper.Models
{
    public class PaperDT
    {
        static string connstr = "server=LAPTOP-L6RB8DIE;database=paper;user id=sa;pwd=2293801448";
        public List<Item> GetItem()
        {
            List<Item> items = new List<Item>();
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            SqlCommand com = conn.CreateCommand();
            com.CommandText = "select [DiscusText],[DiscusDes] from [Discussion topic]";
            SqlDataReader rd = com.ExecuteReader();
            while (rd.Read())
            {
                Item item;
                item = new Item { Idd = Guid.NewGuid().ToString(), Text = rd.GetString(0), Description = rd.GetString(1) };
                items.Add(item);
            }
            conn.Close();
            return items;
        }
    }
}
