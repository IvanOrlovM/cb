namespace L2T3EmployeeApp
{
    public class Employee
    {
        private string _firstName;
        private string _lastName;
        private Positions _position;

        public Employee(string firstName, string lastName, Positions position)
        {
            _firstName = firstName;
            _lastName = lastName;
            _position = position;
        }

        public decimal GetSallary()
        {
            decimal rate = 2000;
            var surchargePercent = 0.2;
            var taxChargePercent = (decimal)0.8;

            var years = GetYears();

            // надбавка за стаж
            decimal surcharge = rate * (decimal) surchargePercent*years;
            decimal sallary = rate + surcharge;
            // налоговый сбор
            return sallary * taxChargePercent;
        }

        private static int GetYears()
        {
            int years = 2;
            return years;
        }

        public override string ToString()
        {
            return $"{nameof(_firstName)}: {_firstName}, {nameof(_lastName)}: {_lastName}, {nameof(_position)}: {_position}";
        }
    }
}