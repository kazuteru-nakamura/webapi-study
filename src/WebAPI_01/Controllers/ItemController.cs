using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_01.Models;

namespace WebAPI_01.Controllers
{
    /// <summary>
    /// アイテムAPI
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {

        /// <summary>
        /// 仮想のデータベース
        /// </summary>
        private static readonly List<Item> ItemDB = new List<Item>();

        /// <summary>
        /// アイテムを全件取得します
        /// </summary>
        /// <returns>アイテム</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(ItemDB);
        }

        /// <summary>
        /// アイテムを新規登録します
        /// </summary>
        /// <param name="item">アイテム</param>
        /// <returns>実行結果</returns>
        [HttpPost]
        public IActionResult Post(Item item)
        {
            if (ItemDB.Where(x => x.Id == item.Id).Any())
            {
                return BadRequest("データが既に存在します");
            }

            ItemDB.Add(item);

            return Accepted(item);
        }
        
        /// <summary>
        /// アイテムを削除します
        /// </summary>
        /// <param name="id">アイテムID</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var target = ItemDB.Where(x => x.Id == id).FirstOrDefault();

            if (target == null)
            {
                return NotFound("データが存在しません");
            }

            ItemDB.Remove(target);

            return Accepted();
        }

    }
}