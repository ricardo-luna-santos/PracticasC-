   M S B A M L   `   `   `  ����C  ?Hospital, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:HospitalHospital  5   	       Hospital.vistatrabajador   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Hospital     5   	     � Title$  vistatranajador��5   	   $��570.336��6!   $��692.91��62    � WindowStartupLocation$ CenterScreen=�6A   .��5	      � .+�5
   
   �� -   5         ��Name$ 
cbopersona��5
      $
��Left=�6'   $��
289,66,0,0q�6B   $	��Top=�6V   $	��294��6n   �� 5   
   -   5         ��Name$ 
lblpersona��5      $��Seleccione Persona��6$   $
��Left=�6A   $��	84,63,0,0q�6\   $	��Top=�6o   $	��200��6�   �� 5   
   -   5        $ cbotrabajador��5      $
��Left=�6*   $��289,138,0,0q�6E   $	��Top=�6Z   $	��294��6r   .@�5      �� $��Doctor��6   �� 5      $��	Enfermera��6   �� 5      $��Administrativo��6   5      �� 5   
   -   5        $ lbltrabajador��5      $��Tipo de Trabajador��6'   $
��Left=�6D   $��
84,135,0,0q�6_   $	��Top=�6s   $	��200��6�   �� 5   
   -   5         ��Name$ gbdoctor��5      $��Doctor��6%   $
��Left=�65   $��
84,202,0,0q�6P   $	��Top=�6d   $	��191��6|   $	��499��6�   $y�Hidden=�6�   .��5      � $
��Left=�6   $	��181��6.   $��10,0,-2.6,-13q�6;   $	��Top=�6R   $	��479��6j   .+�5      �� -   5        $ lbladicionales��5      $��Adicionales:��60   $
��Left=�6G   $��	49,25,0,0q�6b   $	��Top=�6u   $	��117��6�   �� 5      -   5         ��Name$ txtadicionales��5      $
��Left=�62   $��23��6M   $��
171,28,0,0q�6Y    �� TextWrapping$
 Wrap=�6m   $	��Top=�6�   $	��194��6�   �� 5      -   5        $ 	lblcedula��5      $��Cedula:��6+   $
��Left=�6=   $��	49,53,0,0q�6X   $	��Top=�6k   $	��117��6�   �� 5      -	   5        $ 	txtcedula��5      $
��Left=�6-   $��23��6H   $��
171,56,0,0q�6T   $
 Wrap=�6h   $	��Top=�6|   $	��194��6�   �� 5      -
   5        $ lblespecialidad��5      $��Especialidad:��61   $
��Left=�6I   $��	49,81,0,0q�6d   $	��Top=�6w   $	��117��6�   �� 5      -   5        $ 
lblcalculo��5      $��Calculo Total:��6,   $
��Left=�6E   $��
49,109,0,0q�6`   $	��Top=�6t   $	��117��6�   �� 5      -   5        $ 
txtcalculo��5      $
��Left=�6.   $��23��6I   $��171,112,0,0q�6U   $
 Wrap=�6j   $	��Top=�6~   $	��194��6�   6�   �� 5      -   5        $ cboespecialidad��5      $
��Left=�64   $��
171,85,0,0q�6O   $	��Top=�6c   $	��194��6{   �� 5      -   5         ��Name$ btnguardard��5      $��Guardar��6.   $
��Left=�6@   $��166,153,0,0q�6[   $	��Top=�6p   $��75��6�   5      5      �� 5   
   -   5        $ gbenfermera��5      $��	Enfermera��6(   $
��Left=�6;   $��
84,202,0,0q�6V   $	��Top=�6j   $	��191��6�   $	��499��6�   $y�Hidden=�6�   .��5       � $
��Left=�6   $	��181��6.   $��10,0,-2.6,-13q�6;   $	��Top=�6R   $	��479��6j   .+�5!      �� -   5        $ lbladicionales1��5!      $��HorasAdicionales:��61   $
��Left=�6M   $��	49,25,0,0q�6h   $	��Top=�6{   $	��117��6�   �� 5"      -   5        $ txtadicionales1��5"      $
��Left=�63   $��23��6N   $��
171,28,0,0q�6Z   $
 Wrap=�6n   $	��Top=�6�   $	��194��6�   �� 5#      -   5        $ 	lblcorreo��5#      $��Correo Electronico:��6+   $
��Left=�6I   $��	49,53,0,0q�6d   $	��Top=�6w   $	��117��6�   �� 5$      -   5        $ 	txtcorreo��5$      $
��Left=�6-   $��23��6H   $��
171,57,0,0q�6T   $
 Wrap=�6h   $	��Top=�6|   $	��194��6�   �� 5%      -   5        $ lblespecialidad1��5%      $��Especialidad:��62   $
��Left=�6J   $��	49,81,0,0q�6e   $	��Top=�6x   $	��117��6�   �� 5&      -   5        $ lblcalculo1��5&      $��Calculo Total:��6-   $
��Left=�6F   $��
49,109,0,0q�6a   $	��Top=�6u   $	��117��6�   �� 5'      -   5        $ txtcalculo1��5'      $
��Left=�6/   $��23��6J   $��171,112,0,0q�6V   $
 Wrap=�6k   $	��Top=�6   $	��194��6�   6�   �� 5(      -   5        $ cboespecialidad1��5(      $
��Left=�65   $��
171,85,0,0q�6P   $	��Top=�6d   $	��194��6|   �� 5)      -   5        $ btnguardare��5)      $��Guardar��6.   $
��Left=�6@   $��171,152,0,0q�6[   $	��Top=�6p   $	��118��6�   5*      5+      �� 5,   
   -   5        $ gbadministrativo��5,      $��Administrativo��6-   $
��Left=�6E   $��
84,202,0,0q�6`   $	��Top=�6t   $	��191��6�   $	��499��6�   $y�Hidden=�6�   .��5-      � $
��Left=�6   $	��181��6.   $��10,0,-2.6,-13q�6;   $	��Top=�6R   $	��479��6j   .+�5.      �� -   5        $ lbldescuento��5.      $��
Descuento:��6.   $
��Left=�6C   $��	49,25,0,0q�6^   $	��Top=�6q   $	��117��6�   �� 5/      -   5        $ txtdescuento��5/      $
��Left=�60   $��23��6K   $��
171,28,0,0q�6W   $
 Wrap=�6k   $	��Top=�6   $	��194��6�   �� 50      -   5        $ lblcalculo2��50      $��Calculo Total:��6-   $
��Left=�6F   $��	49,56,0,0q�6a   $	��Top=�6t   $	��117��6�    J� RenderTransformOrigin$ 0.459,-0.524&�6�   �� 51      -   5        $ txtcalculo2��51      $
��Left=�6/   $��23��6J   $��
171,56,0,0q�6V   $
 Wrap=�6j   $	��Top=�6~   $	��194��6�   6�   �� 52      -   5        $ btnguardara��52      $��Guardar��6.   $
��Left=�6@   $��221,117,0,0q�6[   $	��Top=�6p   $��75��6�   53      54      56      57      