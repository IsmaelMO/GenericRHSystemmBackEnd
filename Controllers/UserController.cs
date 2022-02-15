using GenericRHSystemBackEnd.Contexts;
using GenericRHSystemBackEnd.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRHSystemBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AppDBContext context;

        public UserController(
            AppDBContext context
            )
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<UserEntity> Get()
        {
            return context.Usuario.ToList();
        }

        [HttpGet("{id}")]
        public UserEntity Get(
            int id
            )
        {
            var user = context.Usuario.FirstOrDefault(u => u.id == id);
            return user;
        }

        [HttpPost]
        public ActionResult Post(
            [FromBody]UserEntity user
            )
        {
            try
            {
                context.Usuario.Add(user);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception smz: ");
                Console.WriteLine(e);
                return BadRequest();
            }
            
        }

        [HttpPut("id")]
        public ActionResult Put(
            int id, 
            [FromBody] UserEntity user
            )
        {
            if(user.id == id)
            {
                context.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }

        }

        [HttpDelete("id")]
        public ActionResult Delete(
            int id
            )
        {
            var user = context.Usuario.FirstOrDefault(u => u.id == id);
            if (user != null)
            {
                context.Usuario.Remove(user);
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }

        }


        [HttpGet("[action]")]
        public IEnumerable<string> Login()
        {
            return new string[] { "this is"," a test"};
        }

    }
}
