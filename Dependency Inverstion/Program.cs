namespace Dependency_Inverstion
{
    class Program
    {
        static void Main(string[] args)
        {
            DataAccessLayer dataAccessLayer = new DataAccessLayer(new Service.FileLogger());
            dataAccessLayer.Add("Adir");

            //dependency injection
            DataAccessLayer dataAccessLayer1 = new DataAccessLayer();
        }
    }
}