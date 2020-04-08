using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using VipWeb.Model;

namespace VipWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {

        [HttpPost]
        public IActionResult Index(Reservation reservationModel)
        {
            List<Reservation> reservation = new List<Reservation>();
            JSONReadWrite readWrite = new JSONReadWrite();
            reservation = JsonConvert.DeserializeObject<List<Reservation>>(readWrite.Read("people.json", "data"));

            Reservation person = reservation.FirstOrDefault(x => x.Id == reservationModel.Id);

            if (person == null)
            {
                reservation.Add(reservationModel);
            }
            else
            {
                int index = reservation.FindIndex(x => x.Id == reservationModel.Id);
                reservation[index] = reservationModel;
            }

            string jSONString = JsonConvert.SerializeObject(reservation);
            readWrite.Write("people.json", "data", jSONString);

            return Ok();
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            List<Reservation> reservation = new List<Reservation>();
            JSONReadWrite readWrite = new JSONReadWrite();
            reservation = JsonConvert.DeserializeObject<List<Reservation>>(readWrite.Read("people.json", "data"));

            int index = reservation.FindIndex(x => x.Id == id);
            reservation.RemoveAt(index);

            string jSONString = JsonConvert.SerializeObject(reservation);
            readWrite.Write("people.json", "data", jSONString);

            return RedirectToAction("index", "Person");
        }
    }
}