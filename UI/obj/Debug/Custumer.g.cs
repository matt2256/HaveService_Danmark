﻿#pragma checksum "..\..\Custumer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "769F4CEF8C4A4CD095E58697ECB26E75B08020D216380036DDBD45CD392AA282"
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
using UI;


namespace UI {
    
    
    /// <summary>
    /// Custumer
    /// </summary>
    public partial class Custumer : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Custumer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRent;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Custumer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRenovation;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Custumer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbName;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Custumer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbAddress;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Custumer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbPhoneNumber;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Custumer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbZipcode;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Custumer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnName;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Custumer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPhoneNumber;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Custumer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddress;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Custumer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnZipcode;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Custumer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dtgClientInfoShow;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Custumer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnShowDB;
        
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
            System.Uri resourceLocater = new System.Uri("/UI;component/custumer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Custumer.xaml"
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
            this.btnRent = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\Custumer.xaml"
            this.btnRent.Click += new System.Windows.RoutedEventHandler(this.BtnRent_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnRenovation = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\Custumer.xaml"
            this.btnRenovation.Click += new System.Windows.RoutedEventHandler(this.BtnRenovation_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tbName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.tbAddress = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.tbPhoneNumber = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tbZipcode = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnName = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Custumer.xaml"
            this.btnName.Click += new System.Windows.RoutedEventHandler(this.BtnName_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnPhoneNumber = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Custumer.xaml"
            this.btnPhoneNumber.Click += new System.Windows.RoutedEventHandler(this.BtnPhoneNumber_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnAddress = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\Custumer.xaml"
            this.btnAddress.Click += new System.Windows.RoutedEventHandler(this.BtnAddress_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.btnZipcode = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\Custumer.xaml"
            this.btnZipcode.Click += new System.Windows.RoutedEventHandler(this.BtnZipcode_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.dtgClientInfoShow = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 12:
            this.btnShowDB = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\Custumer.xaml"
            this.btnShowDB.Click += new System.Windows.RoutedEventHandler(this.BtnShowDB_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

