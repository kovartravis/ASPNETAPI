using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExercisesAPI.Database;
using ExercisesAPI.Models;
using ExercisesAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExercisesAPI.Controllers
{
    [Route("api/[controller]")]
    public class ActionsController : Controller
    {
        private ActionsService actionsService;

        public ActionsController(ApiContext context)
        {
            this.actionsService = new ActionsService(context);
        }

        // GET api/actions
        [HttpGet]
        public IEnumerable<Act> Get()
        {
            return this.actionsService.getAllActions();
        }

        // GET api/actions/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/actions
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/actions/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/actions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}