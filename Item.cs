using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine_Blake_Hunt
{
    class Item
    {
        public Item(string itemName, int itemNumber)
        {
            this.ItemName = itemName;
            this.ItemNumber = itemNumber;
        }

        [Required]
        public string ItemName {  get; set; }
        [Required]
        public int ItemNumber {  get; set; }
    }
}
