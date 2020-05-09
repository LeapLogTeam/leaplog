﻿#pragma checksum "..\..\..\LoginScreen.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03F83744FDDCB5ADBF6892550F3A28DCBBC25126"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LeapLog;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace LeapLog {
    
    
    /// <summary>
    /// LoginScreen
    /// </summary>
    public partial class LoginScreen : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\LoginScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LeapLog.LoginScreen loginWindow;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\LoginScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas loginCanvas;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\LoginScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\LoginScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\LoginScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UserName;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\LoginScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button enterButton;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\LoginScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exitButton;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\LoginScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox Pass;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\LoginScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\LoginScreen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button newUser;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LeapLog;component/loginscreen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\LoginScreen.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.8.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.loginWindow = ((LeapLog.LoginScreen)(target));
            
            #line 12 "..\..\..\LoginScreen.xaml"
            this.loginWindow.KeyUp += new System.Windows.Input.KeyEventHandler(this.Window_KeyUp_1);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\LoginScreen.xaml"
            this.loginWindow.Closing += new System.ComponentModel.CancelEventHandler(this.loginWindow_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.loginCanvas = ((System.Windows.Controls.Canvas)(target));
            return;
            case 3:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.label1 = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.UserName = ((System.Windows.Controls.TextBox)(target));
            
            #line 28 "..\..\..\LoginScreen.xaml"
            this.UserName.PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.UserName_PreviewKeyUp);
            
            #line default
            #line hidden
            
            #line 28 "..\..\..\LoginScreen.xaml"
            this.UserName.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.UserName_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 6:
            this.enterButton = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\LoginScreen.xaml"
            this.enterButton.Click += new System.Windows.RoutedEventHandler(this.button_Click);
            
            #line default
            #line hidden
            
            #line 29 "..\..\..\LoginScreen.xaml"
            this.enterButton.KeyUp += new System.Windows.Input.KeyEventHandler(this.enterButton_KeyUp);
            
            #line default
            #line hidden
            return;
            case 7:
            this.exitButton = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\LoginScreen.xaml"
            this.exitButton.Click += new System.Windows.RoutedEventHandler(this.button1_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Pass = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 43 "..\..\..\LoginScreen.xaml"
            this.Pass.PreviewKeyUp += new System.Windows.Input.KeyEventHandler(this.Pass_PreviewKeyUp);
            
            #line default
            #line hidden
            
            #line 43 "..\..\..\LoginScreen.xaml"
            this.Pass.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Pass_PreviewMouseDown);
            
            #line default
            #line hidden
            
            #line 43 "..\..\..\LoginScreen.xaml"
            this.Pass.KeyUp += new System.Windows.Input.KeyEventHandler(this.Pass_KeyUp_1);
            
            #line default
            #line hidden
            return;
            case 9:
            this.image = ((System.Windows.Controls.Image)(target));
            return;
            case 10:
            this.newUser = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\LoginScreen.xaml"
            this.newUser.Click += new System.Windows.RoutedEventHandler(this.newUser_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

