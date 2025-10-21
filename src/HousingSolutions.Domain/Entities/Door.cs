using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingSolutions.Domain.Entities
{
    public class Door
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public bool IsLocked { get; set; } = true;
    }

}
