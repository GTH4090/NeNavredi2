using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeNavredi.Models
{
    public partial class User
    {
        public string Name
        {
            get
            {
                if(this.Employee != null)
                {
                    return this.Employee.LastName + " " + this.Employee.FirstName;
                }
                if (this.ExplorerEmployee != null)
                {
                    return this.ExplorerEmployee.LastName + " " + this.ExplorerEmployee.FirstName;
                }
                if(this.Bookkeeper != null)
                {
                    return this.Bookkeeper.LastName + " " + this.Bookkeeper.FirstName;
                }
                else
                {
                    return "ФИО нет";
                }
            }
        }
    }
}
