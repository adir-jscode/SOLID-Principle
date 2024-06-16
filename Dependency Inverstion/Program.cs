namespace Dependency_Inverstion
{
    class Program
    {

        /*
        1. High-level modules should not depend on low-level modules. Both should depend on abstractions.
        2. Abstractions should not depend on details. Details should depend on abstractions.
        3. Dependency Inversion Principle is a set of guidelines to follow to implement Dependency Inversion Principle.
        4. Dependency Injection is a design pattern that implements the Dependency Inversion Principle.
         */
        static void Main(string[] args)
        {
            DataAccessLayer dataAccessLayer = new DataAccessLayer(new Service.FileLogger());
            dataAccessLayer.Add("Adir");

            //dependency injection
            DataAccessLayer dataAccessLayer1 = new DataAccessLayer();
        }
    }
}