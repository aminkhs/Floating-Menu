﻿#pragma checksum "C:\Users\Amin\OneDrive\RAYA SOFT\App\Universal app\Floating Menu\Floating Menu\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C1A8E142C230B79829776B23E9794547"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Floating_Menu
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.None = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 2:
                {
                    this.Compact = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 3:
                {
                    this.Wide = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 4:
                {
                    this.UWide = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 5:
                {
                    this.seters = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 6:
                {
                    this.Background = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 7:
                {
                    this.Topmenu = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 8:
                {
                    this.Menu1txtblk = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 75 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.Menu1txtblk).Tapped += this.Menu1txtblk_Tapped;
                    #line default
                }
                break;
            case 9:
                {
                    this.Menu2txtblk = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 76 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.Menu2txtblk).Tapped += this.Menu2txtblk_Tapped;
                    #line default
                }
                break;
            case 10:
                {
                    this.Menu3txtblk = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 77 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.Menu3txtblk).Tapped += this.Menu3txtblk_Tapped;
                    #line default
                }
                break;
            case 11:
                {
                    this.MenuSelect = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 12:
                {
                    this.FloatSelect1 = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                }
                break;
            case 13:
                {
                    this.FloatSelect2 = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

