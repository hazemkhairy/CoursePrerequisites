﻿#pragma checksum "..\..\..\UIs\RemoveAdmin.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ED1AAD36EDC66637E1E71BDEF0D7D23CF9B97CF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Course_Prerequsites_WPF.UIs;
using MahApps.Metro;
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


namespace Course_Prerequsites_WPF.UIs {
    
    
    /// <summary>
    /// RemoveAdmin
    /// </summary>
    public partial class RemoveAdmin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\UIs\RemoveAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackBTN;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\UIs\RemoveAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox AdminsCombo;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\UIs\RemoveAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Asure;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\UIs\RemoveAdmin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoveBTN;
        
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
            System.Uri resourceLocater = new System.Uri("/Course Prerequsites WPF;component/uis/removeadmin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UIs\RemoveAdmin.xaml"
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
            
            #line 9 "..\..\..\UIs\RemoveAdmin.xaml"
            ((Course_Prerequsites_WPF.UIs.RemoveAdmin)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.BackBTN = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\UIs\RemoveAdmin.xaml"
            this.BackBTN.Click += new System.Windows.RoutedEventHandler(this.BackBTN_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AdminsCombo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.Asure = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 5:
            this.RemoveBTN = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\..\UIs\RemoveAdmin.xaml"
            this.RemoveBTN.Click += new System.Windows.RoutedEventHandler(this.RemoveBTN_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

