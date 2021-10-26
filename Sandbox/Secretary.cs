using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Secretary:Employee
    {
        private int _typingSpeed;

        public int TypingSpeed
        {
            get { return _typingSpeed; }
            set { _typingSpeed = value; }
        }

        public Secretary(int id, string name, string address, string tlf, int typingSpeed) : base(id, name, address, tlf)
        {
            _typingSpeed = typingSpeed;
        }

        public override int CalculateSalary( )
        {
            int salary = (int)(_typingSpeed <= 100 ? base.CalculateSalary() : base.CalculateSalary() * 1.5);
            return salary;
        }

        public override string ToString()
        {
            return base.ToString() + $" TypingSpeed {_typingSpeed}";
        }
    }
}
