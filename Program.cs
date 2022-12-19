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
            var db = new Controller.MainContext();

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}