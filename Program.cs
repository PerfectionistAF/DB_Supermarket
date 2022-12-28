namespace DBProject
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // creates the database if not created.
            Controller.MainContext mainContext = new Controller.MainContext();
            ApplicationConfiguration.Initialize();
            Application.Run(new MainMenu());
        }
    }
}