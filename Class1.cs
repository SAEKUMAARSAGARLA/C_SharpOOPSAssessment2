using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{ 
    public class employee
    {

        // Instance Variables
        int id;
        String name;
        int salary;

        // Constructor Declaration of Class
        public employee(int id,String name, int salary)
        {
            this.id = id;
            this.name = name;
           
            this.salary = salary;
        }
       
        public int Getid()
        {
            return id;
        }
       
        public String GetName()
        {
            return name;
        }

        public int Getsalary()
        {
            return salary;
        }

        public String ToString()
        {
            return ("Hi my name is " + this.GetName()
                    + ".\nMy id, age and salary are " + this.Getid()
                    + "," + this.Getsalary());
        }
        public static void Main(String[] args)
        {

            employee saekumaar = new employee( 1001,"saekumaar", 20000);
            Console.WriteLine(saekumaar.ToString());
        }
    }
}
