using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryUWP.Models
{
    public class Departments:ObservableCollection<string>
    {
        public Departments() // färdig lista-har populera department
        {
            Add("Administrator");
            Add("Development");
            Add("Elev");
        }
    }

   /* public class Departments : ObservableCollection<EmployeeModel>
    {
        public Departments()
        {
            Add(new EmployeeModel("Hans", "ggggg", "dev"));
        }
    }*/
}
