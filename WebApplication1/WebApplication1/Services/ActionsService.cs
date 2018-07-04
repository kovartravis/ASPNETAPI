using ExercisesAPI.Database;
using ExercisesAPI.Models;
using ExercisesAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercisesAPI.Services
{
    public class ActionsService
    {
        private ActionsRepository actionsRepository;

        public ActionsService(ApiContext context)
        {
            this.actionsRepository = new ActionsRepository(context);
        }

        public IEnumerable<Act> getAll()
        {
            return actionsRepository.FindAll();
        }

        public Act getById(UInt32 id)
        {
            return actionsRepository.FindById(id).FirstOrDefault();
        }
    }
}
