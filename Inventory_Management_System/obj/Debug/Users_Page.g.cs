﻿#pragma checksum "..\..\Users_Page.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1FAC1BD146944838D61EB541DE1BCCA2C5B7420FB9770D8043309FEB69E47603"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Inventory_Management_System;
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


namespace Inventory_Management_System {
    
    
    /// <summary>
    /// Users_Page
    /// </summary>
    public partial class Users_Page : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\Users_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtUserName;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Users_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtUserPassword;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Users_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid grdUsers;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Users_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_UserAdd;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Users_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_UserEdit;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Users_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_UserDelete;
        
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
            System.Uri resourceLocater = new System.Uri("/Inventory_Management_System;component/users_page.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Users_Page.xaml"
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
            this.TxtUserName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.TxtUserPassword = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.grdUsers = ((System.Windows.Controls.DataGrid)(target));
            
            #line 18 "..\..\Users_Page.xaml"
            this.grdUsers.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.grdUsers_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Btn_UserAdd = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\Users_Page.xaml"
            this.Btn_UserAdd.Click += new System.Windows.RoutedEventHandler(this.Btn_UserAdd_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Btn_UserEdit = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\Users_Page.xaml"
            this.Btn_UserEdit.Click += new System.Windows.RoutedEventHandler(this.Btn_UserEdit_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Btn_UserDelete = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\Users_Page.xaml"
            this.Btn_UserDelete.Click += new System.Windows.RoutedEventHandler(this.Btn_UserDelete_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

