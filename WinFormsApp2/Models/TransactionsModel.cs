using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Models
{
    public class TransactionsModel
    {
        public string Id { get; set; }
        public string Product_name { get; set; }
        public string Transaction { get; set; }
        public string Reason { get; set; }
        public int Amount { get; set; }
        public int Internal_code { get; set; }
        public string Validity { get; set; }
        public string Insert_date { get; set; }

        public TransactionsModel(string id, string product_name, string transaction, string reason, int amount, int internal_code, string validity , string insert_date)
        {
            Id = id;
            Product_name = product_name;
            Transaction = transaction;
            Reason = reason;
            Amount = amount;
            Internal_code = internal_code;
            Validity = validity;    
            Insert_date = insert_date;
        }
    }
}
