using SplitScreen.Views;

namespace SplitScreen
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Home());
        }
    }
}