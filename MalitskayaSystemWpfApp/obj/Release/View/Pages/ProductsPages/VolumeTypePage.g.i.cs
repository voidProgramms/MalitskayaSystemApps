﻿#pragma checksum "..\..\..\..\..\View\Pages\ProductsPages\VolumeTypePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DDD4E615BD6555817864714AAF76EE8C4CA3C9019A3FDEAC277F145D3C46BDFB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MalitskayaSystemWpfApp.View.Pages.ProductsPages;
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


namespace MalitskayaSystemWpfApp.View.Pages.ProductsPages {
    
    
    /// <summary>
    /// VolumeTypePage
    /// </summary>
    public partial class VolumeTypePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\..\View\Pages\ProductsPages\VolumeTypePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid volumes;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\..\View\Pages\ProductsPages\VolumeTypePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddBtnVolume;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\..\View\Pages\ProductsPages\VolumeTypePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditBtnVolume;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\..\..\View\Pages\ProductsPages\VolumeTypePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteBtnVolume;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\..\..\View\Pages\ProductsPages\VolumeTypePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackBtnVolume;
        
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
            System.Uri resourceLocater = new System.Uri("/MalitskayaSystemWpfApp;component/view/pages/productspages/volumetypepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\View\Pages\ProductsPages\VolumeTypePage.xaml"
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
            this.volumes = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.AddBtnVolume = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.EditBtnVolume = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.DeleteBtnVolume = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.BackBtnVolume = ((System.Windows.Controls.Button)(target));
            
            #line 103 "..\..\..\..\..\View\Pages\ProductsPages\VolumeTypePage.xaml"
            this.BackBtnVolume.Click += new System.Windows.RoutedEventHandler(this.BackBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

