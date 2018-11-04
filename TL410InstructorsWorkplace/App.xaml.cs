using System.Windows;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using TL410InstructorsWorkplace.Helpers;


namespace TL410InstructorsWorkplace
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            List<Screen> allScreensList = Screen.AllScreens.ToList();

            foreach (Screen sc in allScreensList)
            {
                MainWindow window = new MainWindow();
                Rectangle workingArea = sc.WorkingArea;
                window.Top = workingArea.Top;
                window.Left = workingArea.Left;
                window.Show();
                //window.WindowState = WindowState.Maximized;
            }
#if !DEBUG
            ///ONLY FOR DEBUG
            DebugWindow debug = new DebugWindow();
            debug.Show();

#else
            Mediator.Instance.CommunicatorStart();
#endif

        }

        protected override void OnExit(ExitEventArgs e)
        {
#if !DEBUG
            Mediator.Instance.CommunicatorStop();
#endif
            base.OnExit(e);
        }
    }
}
