﻿#pragma checksum "..\..\..\FinalizeBillWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D8001F9B0814F157B044AECFD22250C035990319"
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
    /// FinalizeBillWindow
    /// </summary>
    public partial class FinalizeBillWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\FinalizeBillWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnBillNext;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\FinalizeBillWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboPaymentType;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\FinalizeBillWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboMonth;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\FinalizeBillWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboYear;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\FinalizeBillWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCVC;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\FinalizeBillWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPaymentCardNumber;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\FinalizeBillWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblReservationBill;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\FinalizeBillWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblCurrentBill;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\FinalizeBillWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblFoodBill;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\FinalizeBillWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTax;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\FinalizeBillWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTotal;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\FinalizeBillWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblCardType;
        
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
            System.Uri resourceLocater = new System.Uri("/Start;component/finalizebillwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\FinalizeBillWindow.xaml"
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
            this.BtnBillNext = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\FinalizeBillWindow.xaml"
            this.BtnBillNext.Click += new System.Windows.RoutedEventHandler(this.OnClickBtnBillNext);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ComboPaymentType = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.ComboMonth = ((System.Windows.Controls.ComboBox)(target));
            
            #line 12 "..\..\..\FinalizeBillWindow.xaml"
            this.ComboMonth.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OnChangingMonth);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ComboYear = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.txtCVC = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtPaymentCardNumber = ((System.Windows.Controls.TextBox)(target));
            
            #line 15 "..\..\..\FinalizeBillWindow.xaml"
            this.txtPaymentCardNumber.LostFocus += new System.Windows.RoutedEventHandler(this.OnLeaveCardNumber);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lblReservationBill = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.lblCurrentBill = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.lblFoodBill = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.lblTax = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.lblTotal = ((System.Windows.Controls.Label)(target));
            return;
            case 12:
            this.lblCardType = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
