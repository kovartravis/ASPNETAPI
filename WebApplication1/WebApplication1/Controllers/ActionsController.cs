using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using ExercisesAPI.Database;
using ExercisesAPI.Models;
using ExercisesAPI.Services;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Get()
        {
            var result = actionsService.getAll();
            
            if(result == null)
            {
                return NoContent();
            }

            return Ok(result);
        }

        // GET api/actions/5
        [HttpGet("{id}")]
        public IActionResult Get(UInt32 id)
        {
            var result = actionsService.getById(id);

            if(result == null)
            {
                return NotFound();
            }

            return Ok(result);
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