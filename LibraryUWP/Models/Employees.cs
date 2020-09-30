using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryUWP.Models
{
   public class Employees : ObservableCollection<EmployeeModel>
    {
        public Employees()
        {
            Add(new EmployeeModel("Hans", "GGGG", "admin"));  // för att visa connection
            Add(new EmployeeModel("Nata", "GGGG", "admin"));
        }
    }
}
