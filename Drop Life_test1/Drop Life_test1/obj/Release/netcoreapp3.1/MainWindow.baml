   M S B A M L   `   `   `  ���� J  FDrop Life_test1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Drop_Life_test1Drop_Life_test1       Drop_Life_test1.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:Drop_Life_test1       � Title$  
MainWindow��$	��800��$
��1280��.��� -    �Name$ MyWindow��.+�r� -    r�Name$ Video�� r� UnloadedBehavior$
 stop=� r� Source$ ToTHeBottom.wmv?� r� LoadedBehavior$
 Play=��� -    ��Name$ 
btn_action��$��Безделье��$��1024,552,43,0q�$��70��$	��Top=� J� RenderTransformOrigin$ 0.486,0.514&�$��Center=�$��Center=�$��24(�$��Comic Sans MS)�$
��Bold"��� -   $ btn_skip��$��
Спать��$��Right=�$��	0,0,38,31q�$��Bottom=�$��92��$	��223��${�False��$
��Bold"�$��Comic Sans MS)�$��24(��� -    ��Name$ lb_day_nomber��$��12 may 2021��$��Right=�$	��109��$��	0,56,-7,0q�$	��Top=�$	��269��$��36(�$��Brussels)����	#FFBF1C1C$ 0.5,0.5&���Z� z�V� .~��� �� �� 	 �� Angle$	 14.669Q�T� �� -   $ lb_day_name��$��Mondey��$��Right=�$	��138��$��0,111,-29,0q�$	��Top=�$	��347��$��72(�$��Brussels)����	#FFBF1C1C$ 0.5,0.5&���Z� z�V� .~��� �� �� $	 -2.455Q�T� �� -   
 ��Name$
 lb_clock��$
��Left=�$	��131��$��1091,182,0,0q�$��10:00��$
��Wrap=�$	��Top=�$	��236��$��72(����	#FF16C990$��
QuiverItal)�$ 0.5,0.5&� �� Padding$ 0,0,0,0q� �� TextAlignment$
 Left=�z�V� .~��� �� �� $	 0.225Q�T� �� -   $ btn_home��$��Дом��$
��Left=�$��	51,79,0,0q�$	��Top=�$��37��$��98��$��Comic Sans MS)�$
��Bold"�$��20(��� -	   $ 
btn_garage��$��Гарагуе��$
��Left=�$��
175,79,0,0q�$	��Top=�$��37��$��98��$��20(�$
��Bold"�$��Comic Sans MS)��� -
   $ btn_hair��$��Волоса��$
��Left=�$��
51,143,0,0q�$	��Top=�$��37��$��98��$��20(�$��Comic Sans MS)�$
��Bold"��� -   $ btn_clothet��$��Одёжка��$
��Left=�$��175,143,0,0q�$	��Top=�$��37��$��98��$��Comic Sans MS)�$��20(�$
��Bold"��� -   $ 	btn_Boots��$��Боты��$
��Left=�$��
51,203,0,0q�$	��Top=�$��37��$��98��$��20(�$��Comic Sans MS)�$
��Bold"��� -   $ 	btn_phone��$��Мобила��$
��Left=�$��175,203,0,0q�$	��Top=�$��37��$��98��$��20(�$
��Bold"�$��Comic Sans MS)��� -   $ btn_computer��$��
Комок��$
��Left=�$��
51,267,0,0q�$	��Top=�$��37��$��98��$
��Bold"�$��Comic Sans MS)�$��20(��� -   $ btn_activity��$��Движухи��$��190,281,941,0q�$	��Top=�$��83�� �� 	IsDefault$
 True��$��24(�$��Comic Sans MS)�$
��Bold"��� -   $ 
btn_Status��$��Статус��$��51,661,1080,0q�$	��Top=�$��83��$
 True��$��Comic Sans MS)�$��24(�$
��Bold"��� -   $ lb_day_fall��$��0��$��Right=�$	��134��$��
0,38,521,0q�$	��Top=�$	��266��$��72(�$��Brussels)����	#FFBF1C1C$ 0.5,0.5&�$��Center=���Z� z�V� .~��� �� �� $	 -2.455Q�T� �� -   $ lbdayFallsay��$��Days in fall��$��Right=�$��62��$��
0,10,540,0q�$	��Top=�$	��216��$��36(�$��Brussels)����	#FFBF1C1C$ 0.5,0.5&���Z� z�V� .~��� �� �� $	 -13.885Q�T� � -    �Name$ progressBar��$
��Left=�$��59��$��224,678,0,0q�$	��Top=�$	��768�� J� Opacity$	 0.8Q�$ 0.503,0.533&�
����� �$��20(�$��Comic Sans MS)���Z� ����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ 	#FFFFB0D8��� $ 	#FF96EEF7�� � Offset$ 1Q�� $ 	#FF4CECF3��$ 0.507Q� J� Effect -  'System.Windows.Media.Effects.BlurEffect  �� -   $ 
lb_raiting��$��10��$��Right=�$��70��$��0,676,526,0q�$	��Top=�$	��263��$��36(�$��Brussels)����	#FFBF1C1C$ 0.5,0.5&�$��Center=���Z� z�V� .~��� ��  �� AngleX$ -0.179Q��� $	 2.211Q�T�  T� X$ -0.17Q� T� Y$ -0.007Q��� -   $ 	lb_status��$��Бос��$
��Left=�$��464,634,0,0q�$	��Top=�$	��328��$��20(�$��Comic Sans MS)�${�False��$��Center=�$��Center=��� -   $ 	lbl_babos��$��
Бабос��$
��Left=�$��
34,399,0,0q�$	��Top=�$��Comic Sans MS)�$��48(�$
��Bold"����	#FF1DC992$ 0.5,0.5&�z�V� .~��� �� �� $	 -23.879Q�T� �� -   $ lb_money��$
��1000��$
��Left=�$��
38,464,0,0q�$	��Top=�$ 0.5,0.5&�$	��128��$	��548�����	#FF1DC992$��72(�$��
QuiverItal)�$
��Left=�$��Bottom=�z�V� .~��� �� �� $	 1.044Q�T� 