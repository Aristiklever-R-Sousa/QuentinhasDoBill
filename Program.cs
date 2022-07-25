namespace QuentinhasDoBill;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        /*using (var context = new Data.QuentinhasDoBillContext())
        {
            foreach (var quentinha in context.Quentinhas)
            {
                System.Console.WriteLine(quentinha);
            }
        }*/

        ApplicationConfiguration.Initialize();
        Application.Run(new Home());
    }    
}