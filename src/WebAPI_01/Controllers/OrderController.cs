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
    /// 注文API
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        /// <summary>
        /// 注文を全件取得します
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<List<Order>> Get()
        {
            var orderlist = new List<Order>();

            var order1 = new Order();
            order1.Id = 1;
            order1.OrderDate = DateTime.Now;
            order1.Items = new List<Item>();
            order1.Items.Add(new Item() { Id = 1, Name = "Pen" });
            order1.Items.Add(new Item() { Id = 2, Name = "Note" });
            orderlist.Add(order1);

            var order2 = new Order();
            order2.Id = 2;
            order2.OrderDate = DateTime.Now;
            order2.Items = new List<Item>();
            order2.Items.Add(new Item() { Id = 3, Name = "Bread" });
            order2.Items.Add(new Item() { Id = 4, Name = "Milk" });
            orderlist.Add(order2);

            return Ok(orderlist);
        }

        /// <summary>
        /// 指定された注文を取得します
        /// </summary>
        /// <param name="id">注文ID</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult<Order> Get(int id)
        {
            var orderlist = new List<Order>();

            var order1 = new Order();
            order1.Id = 1;
            order1.OrderDate = DateTime.Now;
            order1.Items = new List<Item>();
            order1.Items.Add(new Item() { Id = 1, Name = "Pen" });
            order1.Items.Add(new Item() { Id = 2, Name = "Note" });
            orderlist.Add(order1);

            var order2 = new Order();
            order2.Id = 2;
            order2.OrderDate = DateTime.Now;
            order2.Items = new List<Item>();
            order2.Items.Add(new Item() { Id = 3, Name = "Bread" });
            order2.Items.Add(new Item() { Id = 4, Name = "Milk" });
            orderlist.Add(order2);

            if (id < 0)
            {
                return BadRequest("注文IDが不正です。");
            }

            var order = orderlist.Where(x => x.Id == id).FirstOrDefault();

            if (order == null)
            {
                return NotFound("注文が見つかりません");
            }

            return Ok(order);
        }

    }
}