﻿#pragma checksum "..\..\..\UIs\AdminSettings.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C0522C75CA1AA81211A8F8398A936D51E07A0069"
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
    /// AdminSettings
    /// </summary>
    public partial class AdminSettings : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\UIs\AdminSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackBTN;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\UIs\AdminSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddAdmin;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\UIs\AdminSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RemoveAdmin;
        
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
            System.Uri resourceLocater = new System.Uri("/Course Prerequsites WPF;component/uis/adminsettings.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UIs\AdminSettings.xaml"
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
            this.BackBTN = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\..\UIs\AdminSettings.xaml"
            this.BackBTN.Click += new System.Windows.RoutedEventHandler(this.BackBTN_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AddAdmin = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\UIs\AdminSettings.xaml"
            this.AddAdmin.Click += new System.Windows.RoutedEventHandler(this.AddAdmin_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.RemoveAdmin = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\UIs\AdminSettings.xaml"
            this.RemoveAdmin.Click += new System.Windows.RoutedEventHandler(this.RemoveAdmin_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

