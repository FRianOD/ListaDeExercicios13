namespace ListaDeExercicios13.Entities
{
    internal class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {

        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name,hours,valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public sealed override double Payment()
        {
            return Hours * ValuePerHour + (AdditionalCharge * 1.1);
        }
    }
}
