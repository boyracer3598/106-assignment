﻿#pragma checksum "..\..\..\MainWindow - Copy.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9479EA33461BBEEF8AE1DEF9C3B79B16245B2503"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using test_2;


namespace test_2 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\MainWindow - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FinishProgram2;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\MainWindow - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Documents.Hyperlink GoLoginbutton;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\MainWindow - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FirstName;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\MainWindow - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LastName;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\MainWindow - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Email;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\MainWindow - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Password;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\MainWindow - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox checkBox;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\MainWindow - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateAccount;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\MainWindow - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Google;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\MainWindow - Copy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Outlook;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/test for cs106;V1.0.0.0;component/mainwindow%20-%20copy.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow - Copy.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.FinishProgram2 = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\MainWindow - Copy.xaml"
            this.FinishProgram2.Click += new System.Windows.RoutedEventHandler(this.FinishProgram);
            
            #line default
            #line hidden
            return;
            case 2:
            this.GoLoginbutton = ((System.Windows.Documents.Hyperlink)(target));
            
            #line 40 "..\..\..\MainWindow - Copy.xaml"
            this.GoLoginbutton.Click += new System.Windows.RoutedEventHandler(this.GoLogin);
            
            #line default
            #line hidden
            return;
            case 3:
            this.FirstName = ((System.Windows.Controls.TextBox)(target));
            
            #line 49 "..\..\..\MainWindow - Copy.xaml"
            this.FirstName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OntextBoxTextChanged);
            
            #line default
            #line hidden
            
            #line 49 "..\..\..\MainWindow - Copy.xaml"
            this.FirstName.GotFocus += new System.Windows.RoutedEventHandler(this.FNGained);
            
            #line default
            #line hidden
            
            #line 49 "..\..\..\MainWindow - Copy.xaml"
            this.FirstName.LostFocus += new System.Windows.RoutedEventHandler(this.FNLost);
            
            #line default
            #line hidden
            return;
            case 4:
            this.LastName = ((System.Windows.Controls.TextBox)(target));
            
            #line 58 "..\..\..\MainWindow - Copy.xaml"
            this.LastName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OntextBoxTextChanged);
            
            #line default
            #line hidden
            
            #line 58 "..\..\..\MainWindow - Copy.xaml"
            this.LastName.GotFocus += new System.Windows.RoutedEventHandler(this.LNGained);
            
            #line default
            #line hidden
            
            #line 58 "..\..\..\MainWindow - Copy.xaml"
            this.LastName.LostFocus += new System.Windows.RoutedEventHandler(this.LNLost);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Email = ((System.Windows.Controls.TextBox)(target));
            
            #line 66 "..\..\..\MainWindow - Copy.xaml"
            this.Email.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OntextBoxTextChanged);
            
            #line default
            #line hidden
            
            #line 66 "..\..\..\MainWindow - Copy.xaml"
            this.Email.GotFocus += new System.Windows.RoutedEventHandler(this.EGained);
            
            #line default
            #line hidden
            
            #line 66 "..\..\..\MainWindow - Copy.xaml"
            this.Email.LostFocus += new System.Windows.RoutedEventHandler(this.ELost);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Password = ((System.Windows.Controls.TextBox)(target));
            
            #line 73 "..\..\..\MainWindow - Copy.xaml"
            this.Password.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OntextBoxTextChanged);
            
            #line default
            #line hidden
            
            #line 73 "..\..\..\MainWindow - Copy.xaml"
            this.Password.GotFocus += new System.Windows.RoutedEventHandler(this.PGained);
            
            #line default
            #line hidden
            
            #line 73 "..\..\..\MainWindow - Copy.xaml"
            this.Password.LostFocus += new System.Windows.RoutedEventHandler(this.PLost);
            
            #line default
            #line hidden
            return;
            case 7:
            this.checkBox = ((System.Windows.Controls.CheckBox)(target));
            
            #line 80 "..\..\..\MainWindow - Copy.xaml"
            this.checkBox.Click += new System.Windows.RoutedEventHandler(this.TandC);
            
            #line default
            #line hidden
            return;
            case 8:
            this.CreateAccount = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\..\MainWindow - Copy.xaml"
            this.CreateAccount.Click += new System.Windows.RoutedEventHandler(this.CreateAcc);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Google = ((System.Windows.Controls.Button)(target));
            
            #line 91 "..\..\..\MainWindow - Copy.xaml"
            this.Google.Click += new System.Windows.RoutedEventHandler(this.StartLogin);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Outlook = ((System.Windows.Controls.Button)(target));
            
            #line 99 "..\..\..\MainWindow - Copy.xaml"
            this.Outlook.Click += new System.Windows.RoutedEventHandler(this.StartLogin);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

