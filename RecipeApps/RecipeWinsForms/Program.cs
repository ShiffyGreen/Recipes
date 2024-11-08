using RecipeSystem;

namespace RecipeWinsForms
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
            frmMain f = new frmMain();
#if DEBUG
            f.Text = f.Text + " - DEV";
#endif
            Application.Run(f);
        }
    }
}