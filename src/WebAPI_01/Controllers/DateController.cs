using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI_01.Controllers
{
    /// <summary>
    /// 日付API
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class DateController : ControllerBase
    {

        /// <summary>
        /// 今日の日付を取得します
        /// </summary>
        /// <returns>今日の日付</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(DateTime.Today);
        }

        /// <summary>
        /// 未来の日付を取得します
        /// </summary>
        /// <param name="diff">何日後か</param>
        /// <returns>未来の日付</returns>
        [HttpGet("{diff}")]
        public IActionResult Get(int diff)
        {
            if (diff < 0)
            {
                return BadRequest("過去は指定できません。");
            }

            if (diff > 100)
            {
                return NotFound("未来過ぎます。");
            }

            return Ok(DateTime.Today.AddDays(diff));
        }

    }
}