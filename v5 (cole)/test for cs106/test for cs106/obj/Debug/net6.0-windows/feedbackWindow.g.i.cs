﻿#pragma checksum "..\..\..\feedbackWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86B16C4A018BEBE641D952CB8D2C3253FA3D1E33"
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
    /// TicketWindow
    /// </summary>
    public partial class TicketWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\feedbackWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Usertext;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\feedbackWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchBar;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\feedbackWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button dashboard;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\feedbackWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Ticket;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\feedbackWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Inbox;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\feedbackWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Notifications;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\feedbackWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Feedback;
        
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
            System.Uri resourceLocater = new System.Uri("/test for cs106;V1.0.0.0;component/feedbackwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\feedbackWindow.xaml"
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
            this.Usertext = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.SearchBar = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\..\feedbackWindow.xaml"
            this.SearchBar.GotFocus += new System.Windows.RoutedEventHandler(this.EGainedL);
            
            #line default
            #line hidden
            
            #line 39 "..\..\..\feedbackWindow.xaml"
            this.SearchBar.LostFocus += new System.Windows.RoutedEventHandler(this.ELostL);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dashboard = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\feedbackWindow.xaml"
            this.dashboard.Click += new System.Windows.RoutedEventHandler(this.dashboardC);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Ticket = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\feedbackWindow.xaml"
            this.Ticket.Click += new System.Windows.RoutedEventHandler(this.TicketC);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Inbox = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\feedbackWindow.xaml"
            this.Inbox.Click += new System.Windows.RoutedEventHandler(this.InboxC);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Notifications = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\..\feedbackWindow.xaml"
            this.Notifications.Click += new System.Windows.RoutedEventHandler(this.NotificationsC);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Feedback = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\feedbackWindow.xaml"
            this.Feedback.Click += new System.Windows.RoutedEventHandler(this.FeedbackC);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

