using ExercisesAPI.Database;
using ExercisesAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ExercisesAPI.Repositories
{
    public class ActionsRepository
    {
        private ApiContext apiContext;

        public ActionsRepository(ApiContext context)
        {
            this.apiContext = context;
        }

        public IQueryable<Act> FindAll()
        {
            return from Act in apiContext.Actions select Act;
        }

        public IQueryable<Act> FindById(UInt32 id)
        {
            return from Act in apiContext.Actions where Act.Id == id select Act; ;
        }
    }
}
