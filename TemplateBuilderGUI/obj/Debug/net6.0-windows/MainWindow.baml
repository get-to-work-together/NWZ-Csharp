   M S B A M L   `   `   `  ����M  ITemplateBuilderGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:TemplateBuilderGUITemplateBuilderGUI  5   	   #    TemplateBuilderGUI.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:TemplateBuilderGUI     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 
ResizeMode$ NoResize=�65    � DataContext 5
      &    TemplateBuilderGUI.MainViewModel  5   
   .��5      �� ���	#FFE0F38D.+�5   
   �� $	��100��6   $��20q�6"   .+�5      �� $��Doelgebied selectie��6   $��48(�62   $��Center=�6@   5      �� 5   
   $��40��6   $��20q�6!    �� Orientation$ 
Horizontal=�6-   .+�5      �� $��
Doelgebied��6   $��24(�6)   $	��300��67   �� 5      $	��300��6   $��0,0,20,0q�6$   ��66   �� *Doelgebieden+�� 5      $	��100��6   $y�Visible=�6$   ��69   �� *Zijden+5      �� 5   
   $��40��6   $��20q�6!   $ 
Horizontal=�6-   .+�5      �� $��Dosisschema selectie��6   $��24(�63   $	��300��6A   �� 5      $	��420��6   ��6#   �� *DosisSchemas+5      �� 5   
   $��40��6   $��0,50,0,0q�6!   $ 
Horizontal=�63   $��Center=�6L   .+�5      �� $��OK��6   $	��200��6#   $��0,0,20,0q�6/   $��18(�6A   �� 5      $��	Annuleren��6   $	��200��6)   $��18(�65   5      5       5!      