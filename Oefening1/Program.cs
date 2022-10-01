namespace Oefening1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            string message = "Welkom " + Environment.UserName + ". Het is " + DateTime.Now + " op " + DateTime.Now.ToShortDateString() + ".";
            MessageBox.Show(message);
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}