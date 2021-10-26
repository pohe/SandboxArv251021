using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Employee
    {

        private const int _baseSalary = 25000; 
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _address;

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        private string _tlf;

        public string Tlf
        {
            get { return _tlf; }
            set { _tlf = value; }
        }

        public Employee(int id, string name, string address, string tlf)
        {
            _id = id;
            _name = name;
            _address = address;
            _tlf = tlf;
        }

        public override string ToString()
        {
            return $"ID {_id} Name {_name} Address {_address}  Tlf {_tlf}";
        }

        ////short property
        //public int Age { get; set; }

        ////full
        //private int _age;

        //public int Age
        //{
        //    get { return _age; }
        //    set { _age = value; }
        //}

        public virtual int CalculateSalary()
        {
            return _baseSalary; 
        }

    }
}
