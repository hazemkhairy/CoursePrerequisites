﻿#pragma checksum "..\..\..\UIs\CourseSettings.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6CA6D56F8EC844956E8FB8D3C0C8A5AB530246A4"
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
    /// CourseSettings
    /// </summary>
    public partial class CourseSettings : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\UIs\CourseSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackBTN;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\UIs\CourseSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddCourse;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\UIs\CourseSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditCourse;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\UIs\CourseSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ViewStudentsInCoursebtn;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\UIs\CourseSettings.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button dropacoursebutton;
        
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
            System.Uri resourceLocater = new System.Uri("/Course Prerequsites WPF;component/uis/coursesettings.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UIs\CourseSettings.xaml"
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
            
            #line 22 "..\..\..\UIs\CourseSettings.xaml"
            this.BackBTN.Click += new System.Windows.RoutedEventHandler(this.BackBTN_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AddCourse = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\UIs\CourseSettings.xaml"
            this.AddCourse.Click += new System.Windows.RoutedEventHandler(this.AddCourse_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.EditCourse = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\..\UIs\CourseSettings.xaml"
            this.EditCourse.Click += new System.Windows.RoutedEventHandler(this.EditCourse_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ViewStudentsInCoursebtn = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\UIs\CourseSettings.xaml"
            this.ViewStudentsInCoursebtn.Click += new System.Windows.RoutedEventHandler(this.ViewStudentsInCourse_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.dropacoursebutton = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\UIs\CourseSettings.xaml"
            this.dropacoursebutton.Click += new System.Windows.RoutedEventHandler(this.dropacoursebutton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

