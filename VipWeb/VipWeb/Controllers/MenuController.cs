using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VipWeb.Data;
using VipWeb.Model;
using Newtonsoft.Json;

namespace VipWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {

        [HttpGet]
        public IActionResult Menus()
        {
            var menus = VipDataContext.Menus;
            List<Menu> people = new List<Menu>();
            JSONReadWrite readWrite = new JSONReadWrite();
            menus = JsonConvert.DeserializeObject<List<Menu>>(readWrite.Read("CafeData.json", "data"));
            return Ok(menus);
        }

        [HttpGet("{id}")]
        public IActionResult GetMenu(int id)
        {
            var menu = VipDataContext.Menus.FirstOrDefault(m => m.Id == id);
            if (menu == null)
            {
                return NotFound();
            }

            return Ok(menu);
        }
    }
}