using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Models
{
    public class ItensModel
    {
        public string Id { get; set; }
        public string Product_name { get; set; }
        public string Supplier { get; set; }
        public int Internal_code { get; set; }
        public double Ean13 { get; set; }
        public string Include_date { get; set; }

        public ItensModel(string id, string product_name, string supplier, int internal_code, double ean13, string include_date)
        {
            Id = id;
            Product_name = product_name;
            Supplier = supplier;
            Internal_code = internal_code;
            Ean13 = ean13;
            Include_date = include_date;
        }
    }
}
