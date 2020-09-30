using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryUWP.Models
{
     public class EmployeeModel
    {

        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Department { get; set; }

        public string FullName => $"{FirstName} {LastName}";// new variant att skriva


        //old variant|| bra för:köra nån speciel (f.)//typisk Java
        /*
               public string OldvariantFullName 
          {get
              {
                return $"{FirstName} {LastName}";
              }
          }*/



        /*  // f. som gör samma //oxså Java
          public string GetFullName()
          {
              return $"{FirstName} {LastName}";
          } */

        public EmployeeModel()//ctor -samma namn som class/ class har 1 eller flera ctor // var 1
        {
            // kan vara tomt
         
            
            // var employee = new Employee();     var1
            // employee.FirstName = "Hans";



            //    var2
            // var employee = new EmployeeModel() { FirstName = "Hans", LastName = "ggg", Department = "dev" };
                                             // här Id - jag kan sätta hur jag vill -- ID= sdfww382873ehc
        }



        public EmployeeModel(string firstname, string lastname)  // var2
        {

            Id = Guid.NewGuid();/* automatisk genereras åt mig--tilldela
                                 * då behöver inte matta in (string firstname, string lastname)
                                 * generera , göra saker, kalkulera???; kan ändra om FN; LN till vad jag vill*/


            FirstName = firstname;
            LastName = lastname;
        }
            
        //  ctor --stoppar inn/// var 3
            public EmployeeModel(string firstname, string lastname, string department)
        {
            Id = Guid.NewGuid();  //tilldela
            FirstName = firstname;
            LastName = lastname;
            Department=department;

            //var employee = new EmployeeModel("Hans", "GGGGG", "dev");
        }
    }
}
