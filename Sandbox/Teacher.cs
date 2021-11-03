using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Teacher:Employee
    {
        private string _subject;

        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        public Teacher(int id, string name, string address, string tlf, string subject):base(id, name, address, tlf)
        {
            this._subject = subject;
        }

        public override int CalculateSalary()
        {
            //if (_subject == "SWD")
            //{
            //    return (int)(base.CalculateSalary()* 1.10);
            //}
            //else
            //{
            //    return base.CalculateSalary();
            //}
            return _subject == "SWD"? (int)(base.CalculateSalary() * 1.10) : base.CalculateSalary();
        }

        public override int CalculatePension()
        {
            return 100000;
        }
        public override string ToString()
        {
            return base.ToString()  + $" Subject {_subject}";
        }
    }
}
