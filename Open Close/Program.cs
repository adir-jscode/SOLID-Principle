using Open_Close;

namespace Open_Close
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new PermanentEmployee("1", "Adur");
            Employee employee1 = new TemporaryEmployee("2", "Adir");
            //Console.WriteLine(employee1);
            Console.WriteLine(string.Format("{0} Bonus : {1}", employee.ToString(), employee.CalulateBonus(100).ToString()));
            Console.WriteLine(string.Format("{0} Bonus : {1}", employee1.ToString(), employee1.CalulateBonus(24000).ToString()));

            
        }
    }
}   

