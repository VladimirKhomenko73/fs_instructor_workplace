using System.Windows;
using TL410InstructorsWorkplace.Helpers;
using TL410InstructorsWorkplace.Model;
using System.Threading;
using System.Windows.Input;
using System.Windows.Shapes;

namespace TL410InstructorsWorkplace
{
    /// <summary>
    /// Логика взаимодействия для DebugWindow.xaml
    /// </summary>
    public partial class DebugWindow : Window
    {

        Point currentPoint = new Point();

        public DebugWindow()
        {
            InitializeComponent();
        }

        private void Pitch_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Mediator.Instance.NotifyColleagues("th", new Parameter("th", Pitch.Value));
            Mediator.Instance.NotifyColleagues("delk", new Parameter("delk", Pitch.Value));
        }

        private void Roll_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Mediator.Instance.NotifyColleagues("gam", new Parameter("gam", Roll.Value));
            Mediator.Instance.NotifyColleagues("delv", new Parameter("delv", Roll.Value));
        }

        private void Roll_Copy_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Mediator.Instance.NotifyColleagues("ng1", new Parameter("ng1", Speed.Value));
            Mediator.Instance.NotifyColleagues("ng2", new Parameter("ng2", Speed.Value));
            Mediator.Instance.NotifyColleagues("mk1", new Parameter("mk1", Speed.Value));
            Mediator.Instance.NotifyColleagues("mk2", new Parameter("mk2", 1000));
            Mediator.Instance.NotifyColleagues("vp", new Parameter("vp", Speed.Value));
            Mediator.Instance.NotifyColleagues("vp", new Parameter("vp", Speed.Value));
            Mediator.Instance.NotifyColleagues("vp", new Parameter("vp", Speed.Value));
            Mediator.Instance.NotifyColleagues("vp", new Parameter("vp", Speed.Value));
            Mediator.Instance.NotifyColleagues("vp", new Parameter("vp", Speed.Value));
            Mediator.Instance.NotifyColleagues("vp", new Parameter("vp", Speed.Value));
            Mediator.Instance.NotifyColleagues("vp", new Parameter("vp", Speed.Value));
            Mediator.Instance.NotifyColleagues("vp", new Parameter("vp", Speed.Value));
            Mediator.Instance.NotifyColleagues("vp", new Parameter("vp", Speed.Value));
            Mediator.Instance.NotifyColleagues("vp", new Parameter("vp", Speed.Value));
            Mediator.Instance.NotifyColleagues("vp", new Parameter("vp", Speed.Value));
            Mediator.Instance.NotifyColleagues("vp", new Parameter("vp", Speed.Value));
        }

        private void VSpeed_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Mediator.Instance.NotifyColleagues<object>("vy", new Parameter ("vy", VSpeed.Value));
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Mediator.Instance.NotifyColleagues<object>("tmt1", new Parameter("tmt1", 1000));
            Mediator.Instance.NotifyColleagues<object>("cc", new Parameter("cc", 4290));
            Mediator.Instance.NotifyColleagues<object>("ftf1", new Parameter("ftf1", 1));
            Mediator.Instance.NotifyColleagues<object>("tmt1", new Parameter("tmt1", 999));
            Mediator.Instance.NotifyColleagues<object>("cc", new Parameter("cc", 4390));
            Mediator.Instance.NotifyColleagues<object>("ftf1", new Parameter("ftf1", 0));
            Mediator.Instance.NotifyColleagues<object>("tmt1", new Parameter("tmt1", 1005));
            Mediator.Instance.NotifyColleagues<object>("cc", new Parameter("cc", 4500));
            Mediator.Instance.NotifyColleagues<object>("ftf1", new Parameter("ftf1", 1));
            Mediator.Instance.NotifyColleagues<object>("ftf1", new Parameter("ftf1", 1));
            Mediator.Instance.NotifyColleagues<object>("ftf1", new Parameter("ftf1", 1));
            Mediator.Instance.NotifyColleagues<object>("tmt1", new Parameter("tmt1", 990));
            Mediator.Instance.NotifyColleagues<object>("cc", new Parameter("cc", 4700));
            Mediator.Instance.NotifyColleagues<object>("ftf1", new Parameter("ftf1", 0));
            Mediator.Instance.NotifyColleagues<object>("ftf1", new Parameter("ftf1", 0));
            Mediator.Instance.NotifyColleagues<object>("cc", new Parameter("cc", 5700));
            Mediator.Instance.NotifyColleagues<object>("vy", new Parameter("vy", 6));
            Mediator.Instance.NotifyColleagues<object>("fvy4", new Parameter("fvy4", 1));
        }

      

        static int check = 0;

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (check == 1)
            {
                Mediator.Instance.NotifyColleagues<object>("fsc1", new Parameter("fsc1", 0));
                Mediator.Instance.NotifyColleagues<object>("fsc2", new Parameter("fsc2", 0));
                Mediator.Instance.NotifyColleagues<object>("ffi1", new Parameter("ffi1", 0));
                Mediator.Instance.NotifyColleagues<object>("ffi2", new Parameter("ffi2", 0));
                Mediator.Instance.NotifyColleagues<object>("fgp1", new Parameter("fgp1", 0));
                Mediator.Instance.NotifyColleagues<object>("fgp2", new Parameter("fgp2", 0));
                Mediator.Instance.NotifyColleagues<object>("fol1", new Parameter("fol1", 0));
                Mediator.Instance.NotifyColleagues<object>("fol2", new Parameter("fol2", 0));
                Mediator.Instance.NotifyColleagues<object>("ftp1", new Parameter("ftp1", 0));
                Mediator.Instance.NotifyColleagues<object>("ftp2", new Parameter("ftp2", 0));
                Mediator.Instance.NotifyColleagues<object>("ftf1", new Parameter("ftf1", 0));
                Mediator.Instance.NotifyColleagues<object>("ftf2", new Parameter("ftf2", 0));
                Mediator.Instance.NotifyColleagues<object>("fnis", new Parameter("fnis", 0));
                check = 0;
                Mediator.Instance.NotifyColleagues<object>("mode", new Parameter("mode", 0));
                Mediator.Instance.NotifyColleagues<object>("fgs", new Parameter("fgs", 0));
                Mediator.Instance.NotifyColleagues<object>("fkrs", new Parameter("fkrs", 0));
            }
            else
            {
                Mediator.Instance.NotifyColleagues<object>("fsc1", new Parameter("fsc1", 1));
                Mediator.Instance.NotifyColleagues<object>("fsc2", new Parameter("fsc2", 1));
                Mediator.Instance.NotifyColleagues<object>("ffi1", new Parameter("ffi1", 1));
                Mediator.Instance.NotifyColleagues<object>("ffi2", new Parameter("ffi2", 1));
                Mediator.Instance.NotifyColleagues<object>("fgp1", new Parameter("fgp1", 1));
                Mediator.Instance.NotifyColleagues<object>("fgp2", new Parameter("fgp2", 1));
                Mediator.Instance.NotifyColleagues<object>("fol1", new Parameter("fol1", 1));
                Mediator.Instance.NotifyColleagues<object>("fol2", new Parameter("fol2", 1));
                Mediator.Instance.NotifyColleagues<object>("ftp1", new Parameter("ftp1", 1));
                Mediator.Instance.NotifyColleagues<object>("ftp2", new Parameter("ftp2", 1));
                Mediator.Instance.NotifyColleagues<object>("ftf1", new Parameter("ftf1", 1));
                Mediator.Instance.NotifyColleagues<object>("ftf2", new Parameter("ftf2", 1));
                Mediator.Instance.NotifyColleagues<object>("fnis", new Parameter("fnis", 1));
                check = 1;
                Mediator.Instance.NotifyColleagues<object>("mode", new Parameter("mode", 1));
                Mediator.Instance.NotifyColleagues<object>("fgs", new Parameter("fgs", 1));
                Mediator.Instance.NotifyColleagues<object>("fkrs", new Parameter("fkrs", 1));
                
            }
            
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Mediator.Instance.NotifyColleagues<object>("psi", new Parameter("psi", slider.Value));
        }

        private void slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Mediator.Instance.NotifyColleagues<object>("car", new Parameter("car", slider1.Value));
        }

        private void slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Mediator.Instance.NotifyColleagues<object>("vor", new Parameter("vor", slider2.Value));
        }

        private void slider3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Mediator.Instance.NotifyColleagues<object>("thi", new Parameter("thi", slider3.Value));
        }

        private void slider4_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Mediator.Instance.NotifyColleagues<object>("psii", new Parameter("psii", slider4.Value));
        }

        private void slider5_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Mediator.Instance.NotifyColleagues<object>("h", new Parameter("h", slider5.Value));
            Mediator.Instance.NotifyColleagues<object>("depa", new Parameter("depa", 760));
            Mediator.Instance.NotifyColleagues<object>("pdepa", new Parameter("pdepa", 760));
        }

        private void slider6_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Mediator.Instance.NotifyColleagues<object>("alku", new Parameter("alku", slider6.Value));
        }

        private void slider7_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Mediator.Instance.NotifyColleagues<object>("psr1", new Parameter("psr1", slider7.Value));
            Mediator.Instance.NotifyColleagues<object>("psr2", new Parameter("psr2", slider7.Value));
        }

        private void slider8_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Mediator.Instance.NotifyColleagues<object>("xt", new Parameter("xt", slider8.Value));
        }
        private void slider9_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Mediator.Instance.NotifyColleagues<object>("zt", new Parameter("zt", slider9.Value));
        }

        private void Canvas_MouseDown_1(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
                currentPoint = e.GetPosition(mapTest);
        }

        private void Canvas_MouseMove_1(object sender, System.Windows.Input.MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                Line line = new Line();

                line.Stroke = SystemColors.WindowFrameBrush;
                line.X1 = currentPoint.X;
                line.Y1 = currentPoint.Y;
                line.X2 = e.GetPosition(mapTest).X;
                line.Y2 = e.GetPosition(mapTest).Y;

                currentPoint = e.GetPosition(mapTest);

                mapTest.Children.Add(line);
                Mediator.Instance.NotifyColleagues<object>("xt", new Parameter("xt", (e.GetPosition(mapTest).X-125)*2.8));
                Mediator.Instance.NotifyColleagues<object>("zt", new Parameter("zt", (e.GetPosition(mapTest).Y-125)*2.8));
            }
        }

        private void slider10_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Mediator.Instance.NotifyColleagues<object>("dep1", new Parameter("dep1", slider10.Value));
            Mediator.Instance.NotifyColleagues<object>("dep2", new Parameter("dep2", slider10.Value));
        }

        private void slider11_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Mediator.Instance.NotifyColleagues<object>("dev1", new Parameter("dev1", slider11.Value));
            Mediator.Instance.NotifyColleagues<object>("dev2", new Parameter("dev2", slider11.Value));
            Mediator.Instance.NotifyColleagues<object>("dels", new Parameter("devls", slider11.Value));
        }
    }
}
