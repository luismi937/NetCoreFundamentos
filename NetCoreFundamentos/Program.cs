namespace NetCoreFundamentos
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
            ApplicationConfiguration.Initialize();
            Application.Run(new Form06EMail()/*Fom05Char()*/ /*Form04DateTime()*//*Form03DiaNacimiento()*//*Form02ColoresPosicion()*//*Form01SumarNumeros()*/);

        }
    }
}