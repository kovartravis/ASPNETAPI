using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercisesAPI.Models
{
    public class Act
    {
        private UInt32 id;
        private String name;

        public uint Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
