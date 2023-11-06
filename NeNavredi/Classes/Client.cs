using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeNavredi.Models
{
    public partial class Client
    {
        public string Name { get { return this.LastName + " " + this.FirstName + " " + this.Patronomic; } }
    }
}
