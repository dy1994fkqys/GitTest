﻿#pragma checksum "..\..\..\Manager\SysMonthReport.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BF36957D23B12C37DEECC3331B81030F"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18408
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using FoodSafetyMonitoring.Manager.UserControls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace FoodSafetyMonitoring.Manager {
    
    
    /// <summary>
    /// SysMonthReport
    /// </summary>
    public partial class SysMonthReport : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\Manager\SysMonthReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox _year;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\Manager\SysMonthReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox _month;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\Manager\SysMonthReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox _detect_dept;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Manager\SysMonthReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox _detect_item;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\Manager\SysMonthReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox _detect_result;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\Manager\SysMonthReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _query;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Manager\SysMonthReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _export;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Manager\SysMonthReport.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FoodSafetyMonitoring.Manager.UserControls.UcTableView _tableview;
        
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
            System.Uri resourceLocater = new System.Uri("/食品安全监测;component/manager/sysmonthreport.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Manager\SysMonthReport.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            this._year = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this._month = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this._detect_dept = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this._detect_item = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this._detect_result = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this._query = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\Manager\SysMonthReport.xaml"
            this._query.Click += new System.Windows.RoutedEventHandler(this._query_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this._export = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\Manager\SysMonthReport.xaml"
            this._export.Click += new System.Windows.RoutedEventHandler(this._export_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this._tableview = ((FoodSafetyMonitoring.Manager.UserControls.UcTableView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

