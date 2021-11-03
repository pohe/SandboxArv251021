using System;
using System.Collections.Generic;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            // ny kommentar

            //Erklæret type   Aktuel type
            //Employee e1 = new Employee(1, "Poul", "Gade 123", "1212121");
            //Console.WriteLine(e1.ToString());
            //Console.WriteLine("Salary for e1 " + e1.CalculateSalary() );
            Teacher t1 = new Teacher(2, "Charlotte", "Street 123", "1212323", "SWD");
            Console.WriteLine(t1.ToString());
            Console.WriteLine("Salary for t1 " + t1.CalculateSalary());

            Secretary s1 = new Secretary(3, "Karin", "Allen 10", "232344", 110);
            Console.WriteLine(s1);
            Console.WriteLine("Salary for s1 " + s1.CalculateSalary());

            //Erklæret type   aktuel type
            Employee e2 = new Teacher(4, "Peter", "Street 3434", " 44545", "SWD");
            Console.WriteLine(e2);
            Console.WriteLine($"Salary for e2 {e2.CalculateSalary()}");

            //Erklæret type    og Aktuel type
            Employee e3 = new Secretary(5, "Kurt", "Hovedgaden 123", "232323", 105);
            ((Secretary)e3).NewMethodNotOverriden();

            //e3 = e2;

            List<Employee> ansatte = new List<Employee>();
            //ansatte.Add(e1);
            ansatte.Add(t1);
            ansatte.Add(s1);
            ansatte.Add(e2);
            foreach (Employee employee in ansatte) //Polymorfi
            {
                Console.WriteLine(employee.ToString()  + " " + employee.CalculateSalary());
            }

            IGeometryDraw draw = new GeometryDraw();
            // The LAST line of code should be ABOVE this line
        }
    }
}
