﻿#pragma checksum "..\..\..\Pages\OrganisationBill.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "66B93DFF3FB06FDE845A16B4E48112A4C795EF661A95836185BA55C7A1CB380D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using NeNavredi.Pages;
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


namespace NeNavredi.Pages {
    
    
    /// <summary>
    /// OrganisationBill
    /// </summary>
    public partial class OrganisationBill : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Pages\OrganisationBill.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid MainGrid;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Pages\OrganisationBill.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox OrganisationCbx;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Pages\OrganisationBill.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker FromDp;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Pages\OrganisationBill.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker ToDp;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Pages\OrganisationBill.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ServiceDg;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Pages\OrganisationBill.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label FinalPriceLb;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Pages\OrganisationBill.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OkBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/NeNavredi;component/pages/organisationbill.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\OrganisationBill.xaml"
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
            
            #line 9 "..\..\..\Pages\OrganisationBill.xaml"
            ((NeNavredi.Pages.OrganisationBill)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MainGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            this.OrganisationCbx = ((System.Windows.Controls.ComboBox)(target));
            
            #line 14 "..\..\..\Pages\OrganisationBill.xaml"
            this.OrganisationCbx.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OrganisationCbx_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.FromDp = ((System.Windows.Controls.DatePicker)(target));
            
            #line 19 "..\..\..\Pages\OrganisationBill.xaml"
            this.FromDp.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.FromDp_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ToDp = ((System.Windows.Controls.DatePicker)(target));
            
            #line 21 "..\..\..\Pages\OrganisationBill.xaml"
            this.ToDp.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.ToDp_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ServiceDg = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.FinalPriceLb = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.OkBtn = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\Pages\OrganisationBill.xaml"
            this.OkBtn.Click += new System.Windows.RoutedEventHandler(this.OkBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

