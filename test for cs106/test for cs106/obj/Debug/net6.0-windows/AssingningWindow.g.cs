﻿#pragma checksum "..\..\..\AssingningWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E0D0D03DB1BC7F8BBF57D0BA0C01CD2D35788BA7"
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
    /// AssingningWindow
    /// </summary>
    public partial class AssingningWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\AssingningWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Usertext;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\AssingningWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchBar;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\AssingningWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button dashboard;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\AssingningWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Ticket;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\AssingningWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Inbox;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\AssingningWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Notifications;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\AssingningWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Feedback;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\AssingningWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Description;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\AssingningWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button user_Copy1;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/test for cs106;component/assingningwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AssingningWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
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
            
            #line 40 "..\..\..\AssingningWindow.xaml"
            this.SearchBar.GotFocus += new System.Windows.RoutedEventHandler(this.EGainedL);
            
            #line default
            #line hidden
            
            #line 40 "..\..\..\AssingningWindow.xaml"
            this.SearchBar.LostFocus += new System.Windows.RoutedEventHandler(this.ELostL);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dashboard = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\AssingningWindow.xaml"
            this.dashboard.Click += new System.Windows.RoutedEventHandler(this.dashboardC);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Ticket = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\AssingningWindow.xaml"
            this.Ticket.Click += new System.Windows.RoutedEventHandler(this.TicketC);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Inbox = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\AssingningWindow.xaml"
            this.Inbox.Click += new System.Windows.RoutedEventHandler(this.InboxC);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Notifications = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\AssingningWindow.xaml"
            this.Notifications.Click += new System.Windows.RoutedEventHandler(this.NotificationsC);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Feedback = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\AssingningWindow.xaml"
            this.Feedback.Click += new System.Windows.RoutedEventHandler(this.FeedbackC);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Description = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.user_Copy1 = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

