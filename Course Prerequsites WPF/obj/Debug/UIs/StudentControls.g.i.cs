﻿#pragma checksum "..\..\..\UIs\StudentControls.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29716C0222F5739F625D74CC318B3132A2662E3F"
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
    /// StudentControls
    /// </summary>
    public partial class StudentControls : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\UIs\StudentControls.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackBTN;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\UIs\StudentControls.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button viewallavailablecoursesbutton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\UIs\StudentControls.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button viewmycoursesbutton;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\UIs\StudentControls.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button viewallavailablecoursesbutton_Copy;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\UIs\StudentControls.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editmydatabutton;
        
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
            System.Uri resourceLocater = new System.Uri("/Course Prerequsites WPF;component/uis/studentcontrols.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UIs\StudentControls.xaml"
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
            
            #line 17 "..\..\..\UIs\StudentControls.xaml"
            this.BackBTN.Click += new System.Windows.RoutedEventHandler(this.BackBTN_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.viewallavailablecoursesbutton = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\UIs\StudentControls.xaml"
            this.viewallavailablecoursesbutton.Click += new System.Windows.RoutedEventHandler(this.viewallavailablecoursesbutton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.viewmycoursesbutton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\UIs\StudentControls.xaml"
            this.viewmycoursesbutton.Click += new System.Windows.RoutedEventHandler(this.viewmycoursesbutton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.viewallavailablecoursesbutton_Copy = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\UIs\StudentControls.xaml"
            this.viewallavailablecoursesbutton_Copy.Click += new System.Windows.RoutedEventHandler(this.registerbutton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.editmydatabutton = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\UIs\StudentControls.xaml"
            this.editmydatabutton.Click += new System.Windows.RoutedEventHandler(this.editmydatabutton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

