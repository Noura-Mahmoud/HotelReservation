﻿#pragma checksum "..\..\..\..\Login\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9A9A5A45FB4A4CC917D66A992BFE069760663999"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Start;
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


namespace Start {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\..\Login\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnLicense;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Login\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUsername;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Login\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSignIn;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Login\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtPassword;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Login\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtBlockUsrnm;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Login\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblError;
        
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
            System.Uri resourceLocater = new System.Uri("/Start;component/login/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Login\MainWindow.xaml"
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
            
            #line 9 "..\..\..\..\Login\MainWindow.xaml"
            ((Start.MainWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.OnClosing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnLicense = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\Login\MainWindow.xaml"
            this.btnLicense.Click += new System.Windows.RoutedEventHandler(this.ShowLicense);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtUsername = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\..\..\Login\MainWindow.xaml"
            this.txtUsername.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.UsernameChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnSignIn = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\Login\MainWindow.xaml"
            this.btnSignIn.Click += new System.Windows.RoutedEventHandler(this.btnSigninClicked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtPassword = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 37 "..\..\..\..\Login\MainWindow.xaml"
            this.txtPassword.TargetUpdated += new System.EventHandler<System.Windows.Data.DataTransferEventArgs>(this.PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtBlockUsrnm = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.lblError = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

