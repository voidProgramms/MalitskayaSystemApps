﻿#pragma checksum "..\..\..\..\..\View\Pages\OrdersPages\OrdersPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5AEDA554B9B6D7B7507A72E6C756026FA4A41F4B80FB4ED40975451F8F5328E9"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MalitskayaSystemWpfApp.View.Pages.OrdersPages;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using Microsoft.Xaml.Behaviors;
using Microsoft.Xaml.Behaviors.Core;
using Microsoft.Xaml.Behaviors.Input;
using Microsoft.Xaml.Behaviors.Layout;
using Microsoft.Xaml.Behaviors.Media;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace MalitskayaSystemWpfApp.View.Pages.OrdersPages {
    
    
    /// <summary>
    /// OrdersPage
    /// </summary>
    public partial class OrdersPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\..\View\Pages\OrdersPages\OrdersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGrid;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\..\View\Pages\OrdersPages\OrdersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PaymentMethodBtn;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\..\View\Pages\OrdersPages\OrdersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OrdersStatusBtn;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\..\..\View\Pages\OrdersPages\OrdersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Method;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\..\..\..\View\Pages\OrdersPages\OrdersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker Datepck;
        
        #line default
        #line hidden
        
        
        #line 121 "..\..\..\..\..\View\Pages\OrdersPages\OrdersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Status;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\..\..\View\Pages\OrdersPages\OrdersPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditBtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/MalitskayaSystemWpfApp;component/view/pages/orderspages/orderspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\Pages\OrdersPages\OrdersPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.DGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 28 "..\..\..\..\..\View\Pages\OrdersPages\OrdersPage.xaml"
            this.DGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PaymentMethodBtn = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\..\..\..\View\Pages\OrdersPages\OrdersPage.xaml"
            this.PaymentMethodBtn.Click += new System.Windows.RoutedEventHandler(this.PaymentMethodBtn_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.OrdersStatusBtn = ((System.Windows.Controls.Button)(target));
            
            #line 92 "..\..\..\..\..\View\Pages\OrdersPages\OrdersPage.xaml"
            this.OrdersStatusBtn.Click += new System.Windows.RoutedEventHandler(this.OrdersStatusBtn_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Method = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.Datepck = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 6:
            this.Status = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.EditBtn = ((System.Windows.Controls.Button)(target));
            
            #line 142 "..\..\..\..\..\View\Pages\OrdersPages\OrdersPage.xaml"
            this.EditBtn.Click += new System.Windows.RoutedEventHandler(this.EditBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

