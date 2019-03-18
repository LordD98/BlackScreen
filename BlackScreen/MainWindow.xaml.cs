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
            this.Blackscreen.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.mouseDoubleClick);
            Mouse.OverrideCursor = Cursors.None;
            Blackscreen.WindowState = WindowState.Maximized;
        }

        private void HandleKeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key.Equals(Key.F))
            {

                Blackscreen.WindowState = WindowState.Minimized;

                //if (fullscreen)
                //{
                //    Blackscreen.WindowState = WindowState.Normal;
                //}
                //else
                //{
                //    Blackscreen.WindowState = WindowState.Maximized;
                //}
                //fullscreen = !fullscreen;
            }
            else if (e.Key.Equals(Key.C))
            {
                Blackscreen.Close();
            }

        }

        private void mouseClick(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void mouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(Blackscreen.WindowState == WindowState.Maximized)
                Blackscreen.WindowState = WindowState.Minimized;
            else if (Blackscreen.WindowState == WindowState.Normal)
                Blackscreen.WindowState = WindowState.Maximized;
        }
    }
}
