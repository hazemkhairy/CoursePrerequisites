   M S B A M L   `   `   `  ����   Course Prerequsites WPF9    3Course_Prerequsites_WPF.UIs.ViewAllCoursesOfStudent   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -     � Title$  ViewAllCoursesOfStudent��$	��700��$	��600�� � 
ResizeMode$ NoResize=�.��� .+��� -    ��Name$$ ListOfProgressCoursesOfStudent��$
��Left=�$	��300��$	��Top=�$	��225��$��
61,152,0,0q����	#FFF5F4F4 J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     ShadowDepth$ 9Q��� -   $% ListOfCompletedCoursesOfStudent��$
��Left=�$	��300��$	��Top=�$	��225��$��345,152,0,0q����	#FFF2EDED
�������$��0q�
���   � J� SnapsToDevicePixels .     $ 8Q�   RenderingBias$ Quality=��� $��Courses in Progress��$
��Left=�$	��Top=�$��
61,121,0,0q�$��14(�$
��Bold"��� $��Completed Courses��$
��Left=�$	��Top=�$��345,121,0,0q�$��14(�$
��Bold"��� -    ��Name$ SelectStudentComboBox��$
��Left=�$	��Top=�$	��509��$��	61,40,0,0q��� -    ��Name$ 	InfoBlock��$
��Left=�$	��210��$��
10,457,0,0q�$	��Top=�$	��580��	 J� IsHitTestVisible	 . .+��� -   
 ��Name$
 NameTextBlock�� �� Left$	 230��$
��Wrap=�$��Course Name : ��
 �� Top$ 10���� -   $
 CodeTextBlock��$ 10��$
��Wrap=�$��Course Code : ��$ 30���� -   $
 CurrentstudentTextBlock��$ 10��$
��Wrap=�$#��Current Number of Students : ��$ 55���� -	   $
 MaximumStudentTextBlock��$	 284��$
��Wrap=�$#��Maximum Number of Students : ��$ 55���� -
   $
 PassingGradeTextBlock��$ 10��$
��Wrap=�$��Passing Grade : ��$ 80���� -   $
 MaxGradeTextBlock��$	 284��$
��Wrap=�$��Total Grade : ��$ 80���� -   $
 HoursTextBlock��$ 10��$
��Wrap=�$��Total Hours : ��$	 106���� -   $
 InstructorTextBlock��$ 10��$
��Wrap=�$��Instructor Name : ��$	 130���� -   $
 DescriptionTextBlock��$ 10��$
��Wrap=�$��Description : ��$	 155��