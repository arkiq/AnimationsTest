using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AnimationsTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Rectangle_Tapped(object sender, TappedRoutedEventArgs e)
        {
            myStoryboard.Begin();
        }

        private void Animation_Begin(object sender, RoutedEventArgs e)
        {
            ellipseStoryBoard.Begin();
        }
        private void Animation_Pause(object sender, RoutedEventArgs e)
        {
            ellipseStoryBoard.Pause();
        }
        private void Animation_Resume(object sender, RoutedEventArgs e)
        {
            ellipseStoryBoard.Resume();
        }
        private void Animation_Stop(object sender, RoutedEventArgs e)
        {
            ellipseStoryBoard.Stop();
        }

        private void btnRectangle_Click(object sender, RoutedEventArgs e)
        {
            sbRectangle.Visibility = Visibility.Visible;
            cvsEllipse.Visibility = Visibility.Collapsed;
            ellipseStoryBoard.Stop();
            myStoryboard.Stop();
        }

        private void btnEllipse_Click(object sender, RoutedEventArgs e)
        {
            sbRectangle.Visibility = Visibility.Collapsed ;
            cvsEllipse.Visibility = Visibility.Visible;
            ellipseStoryBoard.Stop();
            myStoryboard.Stop();

        }
    }
}
