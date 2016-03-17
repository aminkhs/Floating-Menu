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

namespace Floating_Menu
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

        #region
        private void Menu1txtblk_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (MenuSelect.Margin == new Thickness(144, 146, 0, 0) || MenuSelect.Margin == new Thickness(275, 146, 0, 0))
            {
                FloatSelect1.Begin();
                MenuSelect.Margin = new Thickness(20, 146, 0, 0);
            }

            if (seters.Width == 10)
            {
                if (MenuSelect.Margin == new Thickness(144, 146, 0, 0) || MenuSelect.Margin == new Thickness(265, 146, 0, 0))
                {
                    FloatSelect1.Begin();
                    MenuSelect.Margin = new Thickness(20, 146, 0, 0);

                }
            }

        }

        private void Menu2txtblk_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (MenuSelect.Margin == new Thickness(275, 146, 0, 0))
            {
                FloatSelect1.Begin();
                MenuSelect.Margin = new Thickness(144, 146, 0, 0);

            }

            if (MenuSelect.Margin == new Thickness(20, 146, 0, 0))
            {
                FloatSelect2.Begin();
                MenuSelect.Margin = new Thickness(144, 146, 0, 0);

            }

            if (seters.Width == 10)
            {
                if (MenuSelect.Margin == new Thickness(265, 146, 0, 0))
                {
                    FloatSelect1.Begin();
                    MenuSelect.Margin = new Thickness(144, 146, 0, 0);

                }

                if (MenuSelect.Margin == new Thickness(20, 146, 0, 0))
                {
                    FloatSelect2.Begin();
                    MenuSelect.Margin = new Thickness(144, 146, 0, 0);

                }
            }
        }

        private void Menu3txtblk_Tapped(object sender, TappedRoutedEventArgs e)
        {

            if (MenuSelect.Margin == new Thickness(20, 146, 0, 0) || MenuSelect.Margin == new Thickness(144, 146, 0, 0))
            {
                FloatSelect2.Begin();
                MenuSelect.Margin = new Thickness(275, 146, 0, 0);

            }

            if (seters.Width == 10)
            {
                if (MenuSelect.Margin == new Thickness(20, 146, 0, 0) || MenuSelect.Margin == new Thickness(144, 146, 0, 0))
                {
                    FloatSelect2.Begin();
                    MenuSelect.Margin = new Thickness(265, 146, 0, 0);

                }
            }
        }
        #endregion
    }
}
