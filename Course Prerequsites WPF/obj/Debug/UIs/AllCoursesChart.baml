   M S B A M L   `   `   `  ����R  NCourse Prerequsites WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Course_Prerequsites_WPF.UIsCourse_Prerequsites_WPF.UIs  5   	   W0clr-namespace:Course_Prerequsites_WPF.ViewModels"Course_Prerequsites_WPF.ViewModels  5   	   1    +Course_Prerequsites_WPF.UIs.AllCoursesChart   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:Course_Prerequsites_WPF.UIs     5   	   >l0clr-namespace:Course_Prerequsites_WPF.ViewModels     5   	     � 
ResizeMode$  CanResizeWithGrip=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � Title$ AllCoursesChart��5   	   $	��700��6!   $	��700��6.    � DataContext 5      7   1Course_Prerequsites_WPF.ViewModels.ChartViewModel  5   
   .��5      ` \De.TorstenMandelkow.MetroChart, Version=0.9.5818.20693, Culture=neutral, PublicKeyToken=nullwTclr-namespace:De.TorstenMandelkow.MetroChart;assembly=De.TorstenMandelkow.MetroChartDe.TorstenMandelkow.MetroChart 5   	   � 5      fchartTclr-namespace:De.TorstenMandelkow.MetroChart;assembly=De.TorstenMandelkow.MetroChart     5   	    � RowDefinitions 5   
   �� 5   
   $
��0.3* �6   6(   �� 5   
   $
��3.5* �6   6(   .+�5   
   �� -   5         ��Name$ BackBTN��5   0    � ToolTip$ Back to Student Menu��6      MetroCircleButtonStyle#���   6A   $
��Left=�6r   $	��Top=�6�   $��55��6�   $��55��6�   $��0��6�   $��10,10,0,606q�6�   $��2��6�   .��5      �� $��30��6   $��20��6#   ��6/   �� *
Foreground+ �� RelativeSource �� *FindAncestor+ �� AncestorType" ��	 J� OpacityMask	 5      !� 5      
 j� Stretch$

 Fill=�6"     appbar_arrow_left !� Visual# [ 61   5      5      2  ,De.TorstenMandelkow.MetroChart.DoughnutChart  5    
   -   5          Name$ CoursesChart��5!   	     ChartStyleVariableSize#���  5"   	   .  (De.TorstenMandelkow.MetroChart.ChartBase   
ChartTitle$ All Available Courses ��5#   	      ChartSubTitle$) #This Contains All Available Courses��5$   	   $ All Available Courses ��5%   	   -  'De.TorstenMandelkow.MetroChart.PieChart   InnerRadiusRatio$
 0.77Q�5&   	   $��10,0,9.6,8.4q�5'   	   $��1��5(   	   $
��Auto��5)   	   $
��Auto��6   {�.   CourseChart   Palette# [ 5*   	      SelectedItem 5+   	   ��  �� Path$ SelectedItem� �� Mode$ TwoWay=�   Series 5.      0  *De.TorstenMandelkow.MetroChart.ChartSeries     SeriesTitle$ PieChartItem��5/         DisplayMember$ Category��50         ValueMember$ Number��51      ��52      �� $ 	ChartItem�55      57      59      