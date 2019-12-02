using SQLite;
using System;

namespace paper.Models
{
    public class Item
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Idd { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public bool Done { get; set; }
    }
}