﻿#pragma checksum "..\..\..\BalanceSheet.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15888B8C055BADDBBB3B30E5A4740CA912CBD7A7"
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
    /// BalanceSheet
    /// </summary>
    public partial class BalanceSheet : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\BalanceSheet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid entryGridA;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\BalanceSheet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid entryGridTA;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\BalanceSheet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid entryGridLO;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\BalanceSheet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid entryGridTLO;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\BalanceSheet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox selectDateBox;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\BalanceSheet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid balanceHelpWindow;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\BalanceSheet.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button balanceHelpButton;
        
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
            System.Uri resourceLocater = new System.Uri("/LeapLog;component/balancesheet.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\BalanceSheet.xaml"
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
            this.entryGridA = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.entryGridTA = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.entryGridLO = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.entryGridTLO = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 5:
            this.selectDateBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 74 "..\..\..\BalanceSheet.xaml"
            this.selectDateBox.SelectionChanged += new System.Windows.RoutedEventHandler(this.selectDateBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.balanceHelpWindow = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.balanceHelpButton = ((System.Windows.Controls.Button)(target));
            
            #line 84 "..\..\..\BalanceSheet.xaml"
            this.balanceHelpButton.Click += new System.Windows.RoutedEventHandler(this.balanceHelpButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

