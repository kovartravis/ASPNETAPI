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
        public IEnumerable<Act> findAll()
        {
            return from Act in apiContext.Actions select Act;
        }
    }
}
