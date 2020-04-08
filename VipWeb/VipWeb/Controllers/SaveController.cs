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
    public class SaveController : ControllerBase
    {
        [HttpPost]
        // public IActionResult Post(int id,string name,string surname, List<string> shoes,bool hungry,int age)
        public IActionResult PostPeople(Person personModel)
        {
            List<Person> people = new List<Person>();
            JSONReadWrite readWrite = new JSONReadWrite();
            people = JsonConvert.DeserializeObject<List<Person>>(readWrite.Read("people.json", "data"));

            // Person personModel = new Person { Id = id, Name = name, Surname = surname, Shoes = shoes, Hungry = hungry, Age = age };
            Person person = people.FirstOrDefault(x => x.Id == personModel.Id);

            if (person == null)
            {
                people.Add(personModel);
            }
            else
            {
                int index = people.FindIndex(x => x.Id == personModel.Id);
                people[index] = personModel;
            }

            string jSONString = JsonConvert.SerializeObject(people);
            readWrite.Write("people.json", "data", jSONString);

            return Ok();
        }

    }
}