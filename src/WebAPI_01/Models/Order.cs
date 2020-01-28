using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_01.Models
{
    /// <summary>
    /// 注文
    /// </summary>
    public class Order
    {
        /// <summary>
        /// 注文ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 注文日
        /// </summary>
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// 注文アイテム
        /// </summary>
        public List<Item> Items { get; set; }
    }
}
