using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_01.Models
{
    /// <summary>
    /// アイテム
    /// </summary>
    public class Item
    {
        /// <summary>
        /// アイテムID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// アイテム名
        /// </summary>
        public string Name { get; set; }
    }
}
