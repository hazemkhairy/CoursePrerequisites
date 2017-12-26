﻿#pragma checksum "..\..\..\UIs\ViewMyCourses.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56402641B70506BC3B2A4FFF0D3B8EA04A596BF0"
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
using Course_Prerequsites_WPF.ViewModels;
using De.TorstenMandelkow.MetroChart;
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
    /// ViewMyCourses
    /// </summary>
    public partial class ViewMyCourses : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\..\UIs\ViewMyCourses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackBTN;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\UIs\ViewMyCourses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal De.TorstenMandelkow.MetroChart.StackedBarChart CoursesChart;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\UIs\ViewMyCourses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CourseTitle;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\UIs\ViewMyCourses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Course_Code;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\UIs\ViewMyCourses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CourseCode;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\UIs\ViewMyCourses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Course_PassingGrade;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\UIs\ViewMyCourses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock PassingGrade;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\UIs\ViewMyCourses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock instuctor;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\UIs\ViewMyCourses.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Instuctor;
        
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
            System.Uri resourceLocater = new System.Uri("/Course Prerequsites WPF;component/uis/viewmycourses.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UIs\ViewMyCourses.xaml"
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
            
            #line 26 "..\..\..\UIs\ViewMyCourses.xaml"
            this.BackBTN.Click += new System.Windows.RoutedEventHandler(this.BackBTN_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CoursesChart = ((De.TorstenMandelkow.MetroChart.StackedBarChart)(target));
            
            #line 44 "..\..\..\UIs\ViewMyCourses.xaml"
            this.CoursesChart.MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.CoursesChart_MouseUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CourseTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.Course_Code = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.CourseCode = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.Course_PassingGrade = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.PassingGrade = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.instuctor = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.Instuctor = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

