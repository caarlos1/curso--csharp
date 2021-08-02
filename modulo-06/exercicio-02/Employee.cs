namespace exercicio_02
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee() { }

        public void IncreaseSalary(double percentage)
        {
            Salary += ((percentage / 100) * Salary);
        }
    }
}