using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BlackScreen
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private bool fullscreen = false;

        public MainWindow()
        {
            InitializeComponent();
            Mouse.OverrideCursor = Cursors.None;
            MainWindow1.WindowState = WindowState.Maximized;
        }

        private void HandleKeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key.Equals(Key.F))
            {

                MainWindow1.WindowState = WindowState.Minimized;

                //if (fullscreen)
                //{
                //    MainWindow1.WindowState = WindowState.Normal;
                //}
                //else
                //{
                //    MainWindow1.WindowState = WindowState.Maximized;
                //}
                //fullscreen = !fullscreen;
            }
            else if (e.Key.Equals(Key.C))
            {
                MainWindow1.Close();
            }

        }

        private void mouseClick(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
    }
}
