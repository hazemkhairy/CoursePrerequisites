   M S B A M L   `   `   `  ����R  NCourse Prerequsites WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:Course_Prerequsites_WPF.UIsCourse_Prerequsites_WPF.UIs  5   	   5    /Course_Prerequsites_WPF.UIs.ViewStudentOrCourse   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ;local)clr-namespace:Course_Prerequsites_WPF.UIs     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ Admin Controls��5	   	   $	��650��6    $	��600��6-   ���	#FFFFFFFF.��5
      �  � ColumnDefinitions 5   
   �� 5      $
��104* �6   �� 5      $
��489* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ BackBTN��5   #    � ToolTip$ Log Out��6      MetroCircleButtonStyle#���   64   $	��Top=�6e   $
��Left=�6}   $��55��6�   $��55��6�   $��0��6�   $��	10,10,0,0q�6�   .��5      �� $��30��6   $��20��6#   ��6/   �� *
Foreground+ �� RelativeSource �� *FindAncestor+ �� AncestorType" �� J� OpacityMask 5      !� 5      	 j� Stretch$
	 Fill=�6"     appbar_arrow_left
 !� Visual#
 [ 61   5      5      �� 5   
   -   5        $ StudentSettings��5      $��Student Settings��6*   $��Center=�6E   $��88��6`   $��1��6l   $��20(�6y   $��Segoe UI)�6�   $��Light"�6�   
����������	#FFF6A10C$��110,10,110,10q�6�   $��0��6�   $��2��6  $��0��6  6#  �� 5   
   -   5        $ CourseSettingsbtn��5      $��Course Settings��6,   $��Center=�6F   $��88��6a   $��1��6m   $��20(�6z   $��Segoe UI)�6�   $��Light"�6�   
����������	#FFF6A10C$��110,10,110,10q�6�   $��0��6�   $��2��6  $��1��6  6#  �� 5   
   -   5        $ AdminSettings��5      $��Admin Settings��6(   $��88��6A   $��Center=�6O   $��110,10,110,10q�6j   $��1��6�   $��20(�6�   $��Segoe UI)�6�   $��Light"�6�   
����������	#FFF6A10C$��0��6�   $��2��6�   $��2��6  6   5+      5,      