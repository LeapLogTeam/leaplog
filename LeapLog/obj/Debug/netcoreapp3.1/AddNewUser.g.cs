﻿#pragma checksum "..\..\..\AddNewUser.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59517F1B40BE8803135786E06AEA9429A8EA9FD0"
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
    /// AddNewUser
    /// </summary>
    public partial class AddNewUser : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\AddNewUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button createButton;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\AddNewUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backToLogin;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\AddNewUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\AddNewUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\AddNewUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label_Copy;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\AddNewUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox newUsername;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\AddNewUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button exitButton;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\AddNewUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox newPass;
        
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
            System.Uri resourceLocater = new System.Uri("/LeapLog;component/addnewuser.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddNewUser.xaml"
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
            
            #line 12 "..\..\..\AddNewUser.xaml"
            ((LeapLog.AddNewUser)(target)).KeyUp += new System.Windows.Input.KeyEventHandler(this.Window_KeyUp);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\AddNewUser.xaml"
            ((LeapLog.AddNewUser)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.createButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\AddNewUser.xaml"
            this.createButton.Click += new System.Windows.RoutedEventHandler(this.createButton_Click);
            
            #line default
            #line hidden
            
            #line 26 "..\..\..\AddNewUser.xaml"
            this.createButton.KeyUp += new System.Windows.Input.KeyEventHandler(this.createButton_KeyUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.backToLogin = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\AddNewUser.xaml"
            this.backToLogin.Click += new System.Windows.RoutedEventHandler(this.backToLogin_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.image = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.label = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.label_Copy = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.newUsername = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.exitButton = ((System.Windows.Controls.Button)(target));
            
            #line 44 "..\..\..\AddNewUser.xaml"
            this.exitButton.Click += new System.Windows.RoutedEventHandler(this.exitButton_Click_1);
            
            #line default
            #line hidden
            return;
            case 9:
            this.newPass = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 51 "..\..\..\AddNewUser.xaml"
            this.newPass.KeyUp += new System.Windows.Input.KeyEventHandler(this.newPass_KeyUp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

