namespace L2T3EmployeeApp
{
    public class Employee
    {
        private string _firstName;
        private string _lastName;

        public Employee(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        public decimal GetSallary()
        {
            decimal rate = 2000;
            // надбавка за стаж
            int years = 2;
            decimal surcharge = rate * (decimal) 0.2*years;
            decimal sallary = rate + surcharge;
            // налоговый сбор
            decimal d = sallary * (decimal) 0.8;
            return d;
        }
    }
}