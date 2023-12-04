namespace assytraining.infrastructure.Infrastructure.Logging
{
    public class APLogger
    {
        private static APLogger? instance;

        private APLogger() { }

        public static APLogger GetInstance()
        {
            return instance ??= new APLogger();
        }

        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
