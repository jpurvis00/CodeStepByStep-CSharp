Vim�UnDo� .�	%#ka�c�	G��rx_ T����F���@k   a   !                    a[i + 1] = 0;   2         -       -   -   -    f���    _�                    #       ����                                                                                                                                                                                                                                                                                                                            #          @                 f���     �   #   A   B      	        {   .            for (int i = 0; i < a.Length; i++)               {   *                var sum = a[i] + a[i + 1];       /                if ((a[i] + a[i + 1]) % 2 == 0)                   {                       a[i] = sum;   !                    a[i + 1] = 0;                   }                   else                   {                       a[i] = 0;   #                    a[i + 1] = sum;                   }                       i++;               }                   DisplayNewArray(a);   	        }       4        private static void DisplayNewArray(int[] a)   	        {   -            for(int i = 0; i < a.Length; ++i)               {   +                Console.Write($"{a[i]}, ");               }   	        }�   "   $   B      4        public static void RunCollapsePairs(int[] a)5��    "                     �                     �    #                                          �    $                                          �    %                     L                     �    &                     \                     �    (                     �                     �    )                     �                     �    *                     �                     �    +                     �                     �    ,                                          �    -                     *                     �    .                     A                     �    /                     U                     �    0                     u                     �    1                     �                     �    3                     �                     �    4                     �                     �    6                     �                     �    7                     �                     �    9                     	                     �    :                     >	                     �    ;                     J	                     �    <                     z	                     �    =                     �	                     �    >                     �	                     �    ?                     �	                     5�_�                    "       ����                                                                                                                                                                                                                                                                                                                            #          @                 f���     �   "   (   C               public static void RunCo�   #   $   C    �   !   $   B          {5��    !                    �                     �    "                     �                    �    "                    �                    �    "                  	   �              y       5�_�                    '   	    ����                                                                                                                                                                                                                                                                                                                            (          E                 f���     �   &   )   G      	        }5��    &   	                 i              	       �    '                      j                     5�_�                    #   ,    ����                                                                                                                                                                                                                                                                                                                            )          F                 f���     �   "   $   H      -        public static void RunCollapsePairs()5��    "   ,                  �                     �    "   0                                        �    "   /                  �                     �    "   .                  �                     �    "   -                  �                     �    "   ,                 �                    �    "   /                 �                    5�_�                    %   /    ����                                                                                                                                                                                                                                                                                                                            )          F                 f���     �   $   %          9            int[] a = { 7, 2, 8, 9, 4, 22, 7, 1, 9, 10 };5��    $                            :               5�_�                    %       ����                                                                                                                                                                                                                                                                                                                            (          E                 f���     �   $   %                      CollapsePairs(a);5��    $                                           5�_�      	              $       ����                                                                                                                                                                                                                                                                                                                            '          D                 f��     �   $   &   G                  �   $   &   F    5��    $                                    	       �    $                                         5�_�      
           	   %       ����                                                                                                                                                                                                                                                                                                                            (          E                 f��D     �   $   &   G                   15��    $                                          5�_�   	              
   %       ����                                                                                                                                                                                                                                                                                                                            (          E                 f��k     �   $   )   G                   5��    $                                        �    $                                          �    $                                        �    $                                        �    $                                        �    $                     +                     �    $                     *                     �    $                     )                     �    $                    (                    �    $                    -                    �    $                    -                    �    $   #                  2                     �    $   "                 1                    �    $   %                  4                     �    $   $                  3                     �    $   #                  2                     �    $   "                  1                     �    $   !                 0                    �    $   !                 0                    �    $   !                 0                    �    $   -                  <                     �    $   -                <                    �    %                     =                    �    %                     =                    �    %                    J                     �    &                     K                    �    &                      K                     �    &                     K                     �    '                     \                     �    '                     L                    5�_�   
                 '        ����                                                                                                                                                                                                                                                                                                                            +          H                 f���     �   &   )   J       5��    &                      K                     �    &                    g                     �    '                     x                     �    '                    �                    �    '                    �                    5�_�                    (       ����                                                                                                                                                                                                                                                                                                                            ,          I                 f���     �   '   )   K                      a[i] + a[i +1];5��    '                     x                     5�_�                    (       ����                                                                                                                                                                                                                                                                                                                            ,          I                 f���     �   $   &   K      -            for(int i = 0; i < a.Length; i++)�   '   )   K      %                sum = a[i] + a[i +1];5��    '   "                  �                     �    $                                          5�_�                    (       ����                                                                                                                                                                                                                                                                                                                            ,          I                 f���     �   (   ,   L                      �   (   *   K    5��    (                      �                     �    (                      �                     �    (                     �                     �    )                     �                     �    )                     �                     �    *                     �                    �    *                     �                    �    *                     �                     5�_�                    ,       ����                                                                                                                                                                                                                                                                                                                            /          L                 f���     �   +   .   N                  }5��    +                    �                     �    ,                      �                     5�_�                    +       ����                                                                                                                                                                                                                                                                                                                            0          M                 f���     �   *   -   O                      {}5��    *                    �                     5�_�                    +       ����                                                                                                                                                                                                                                                                                                                            1          N                 f���     �   *   .   P                      {5��    *                    �                     �    +                     �                    �    +                    �                     �    ,                  	   �              	       �    ,                     �                     �    ,                     �                     �    ,                     �                     �    ,                     �                     �    ,                     �                     �    ,                    �                    �    ,                    �                    �    ,                    �                    5�_�                    .       ����                                                                                                                                                                                                                                                                                                                            3          P                 f���     �   .   2   S                      else�   -   0   R                      }5��    -                                         �    .                     (                     �    .                     +                     �    .                     *                     �    .                     )                     �    .                    (                    �    .                    (                    �    .                    (                    �    .                    ,                     �    /                     -                    �    /                     -                    �    /                    >                     �    0                     ?                    �    0                      ?                     5�_�                    0       ����                                                                                                                                                                                                                                                                                                                            6          S                 f��     �   0   3   U    �   0   1   U    5��    0                      ?              B       5�_�                    1       ����                                                                                                                                                                                                                                                                                                                            8          U                 f��     �   0   2   W                          a[i] = 0;5��    0                     Z                     5�_�                    1       ����                                                                                                                                                                                                                                                                                                                            8          U                 f��     �   0   2   W                          a[i] = ;5��    0                     Z                     5�_�                    2       ����                                                                                                                                                                                                                                                                                                                            8          U                 f��
     �   1   3   W      #                    a[i + 1] = sum;5��    1                    ~                    5�_�                    2   !    ����                                                                                                                                                                                                                                                                                                                            8          U                 f��     �   1   4   W      !                    a[i + 1] = 0;5��    1   !                 �                     �    2                     �                     �    2                     �                    5�_�                    4        ����                                                                                                                                                                                                                                                                                                                            9          V                 f��     �   3   4           5��    3                      �                     5�_�                    3       ����                                                                                                                                                                                                                                                                                                                            8          U                 f��     �   3   5   X                      �   3   5   W    5��    3                      �                     �    3                     �                     �    3                    �                    5�_�                    *       ����                                                                                                                                                                                                                                                                                                                            9          V                 f��&     �   )   +   X                       if(sum % 2 == 0)5��    )                     �                     5�_�                    '       ����                                                                                                                                                                                                                                                                                                                            9          V                 f��,     �   &   (   X                      int sum = 0;5��    &                     c                     5�_�                    '       ����                                                                                                                                                                                                                                                                                                                            9          V                 f��,     �   &   (   X                      int sum= 0;5��    &                     c                     5�_�                    '       ����                                                                                                                                                                                                                                                                                                                            9          V                 f��,     �   &   (   X                      int sum 0;5��    &                     c                     5�_�                    '       ����                                                                                                                                                                                                                                                                                                                            9          V                 f��-     �   &   (   X                      int sum0;5��    &                     c                     5�_�                     6        ����                                                                                                                                                                                                                                                                                                                            9          V                 f��;     �   5   8   X       5��    5                      �                     �    6                      �                     �    6                    �                    5�_�      !               7       ����                                                                                                                                                                                                                                                                                                                            :          W                 f��T     �   7   ]   Y       	        }       6        //public static void RunCollapsePairs(int[] a)           //{   0        //    for (int i = 0; i < a.Length; i++)           //    {   ,        //        var sum = a[i] + a[i + 1];       1        //        if ((a[i] + a[i + 1]) % 2 == 0)           //        {   !        //            a[i] = sum;   #        //            a[i + 1] = 0;           //        }           //        else           //        {           //            a[i] = 0;   %        //            a[i + 1] = sum;           //        }               //        i++;           //    }       !        //    DisplayNewArray(a);           //}       6        //private static void DisplayNewArray(int[] a)           //{   /        //    for(int i = 0; i < a.Length; ++i)           //    {   -        //        Console.Write($"{a[i]}, ");           //    }           //}5��    7   	         $      �      �      ~      5�_�       "           !   <       ����                                                                                                                                                                                                                                                                                                                            8          8                 f��W     �   ;   <          0            throw new NotImplementedException();5��    ;                      *	      1               5�_�   !   #           "   ;   	    ����                                                                                                                                                                                                                                                                                                                            8          8                 f��W     �   ;   ?   ^      '            for(int i = 0; i < a.Length�   :   =   ]      	        {5��    :   	                 )	              	       �    ;                     *	                    �    ;                     B	                     �    ;                 
   A	             
       �    ;                     J	                    �    ;   "                  L	                     �    ;   !                 K	                    �    ;   !                 K	                    �    ;   -                 W	                     �    <                     X	                    �    <                     X	                    �    <                    e	                     �    =                     f	                    �    =                     f	                    5�_�   "   $           #   =       ����                                                                                                                                                                                                                                                                                                                            8          8                 f��l     �   <   ?   `                  {5��    <                    e	                     �    =                     f	                    �    =                     x	                     �    =                     w	                     �    =                    v	                    �    =                     w	                     �    =                    v	                    �    =                     |	                     �    =                    {	                    �    =                    {	                    �    =                    ~	                    �    =   "                 �	                    5�_�   #   %           $   >   $    ����                                                                                                                                                                                                                                                                                                                            8          8                 f���     �   =   ?   a      '                Console.WriteLine($"");5��    =   $                  �	                     5�_�   $   &           %   >       ����                                                                                                                                                                                                                                                                                                                            8          8                 f���    �   =   ?   a      -                Console.WriteLine($"a[i], ");5��    =                     �	                     5�_�   %   '           &   >        ����                                                                                                                                                                                                                                                                                                                            8          8                 f���     �   =   ?   a      )                Console.Write($"a[i], ");5��    =                      �	                     5�_�   &   (           '   >   %    ����                                                                                                                                                                                                                                                                                                                            8          8                 f���    �   =   ?   a      *                Console.Write($"{a[i], ");5��    =   %                  �	                     5�_�   '   )           (   ,       ����                                                                                                                                                                                                                                                                                                                            8          8                 f���     �   +   -   a                          a[i] = 0;5��    +                     �                     5�_�   (   *           )   ,       ����                                                                                                                                                                                                                                                                                                                            8          8                 f���     �   +   -   a                          a[i] = ;5��    +                     �                     5�_�   )   +           *   -       ����                                                                                                                                                                                                                                                                                                                            8          8                 f���     �   ,   .   a      #                    a[i + 1] = sum;5��    ,                                         5�_�   *   ,           +   1       ����                                                                                                                                                                                                                                                                                                                            8          8                 f���     �   0   2   a                          a[i] = sum;5��    0                    W                    5�_�   +   -           ,   2       ����                                                                                                                                                                                                                                                                                                                            8          8                 f���     �   1   3   a      !                    a[i + 1] = 0;5��    1                     y                     5�_�   ,               -   2       ����                                                                                                                                                                                                                                                                                                                            8          8                 f���    �   1   3   a                           a[i + 1] = ;5��    1                     y                     5�_�                     !       ����                                                                                                                                                                                                                                                                                                                            !          A                 f���     �       "   B      "    //internal class CollapsePairs�   !   B   B           //{   6    //    public static void RunCollapsePairs(int[] a)       //    {   0    //        for (int i = 0; i < a.Length; i++)       //        {   ,    //            var sum = a[i] + a[i + 1];       1    //            if ((a[i] + a[i + 1]) % 2 == 0)       //            {   !    //                a[i] = sum;   #    //                a[i + 1] = 0;       //            }       //            else       //            {       //                a[i] = 0;   %    //                a[i + 1] = sum;       //            }           //            i++;       //        }       !    //        DisplayNewArray(a);       //    }       6    //    private static void DisplayNewArray(int[] a)       //    {   /    //        for(int i = 0; i < a.Length; ++i)       //        {   -    //            Console.Write($"{a[i]}, ");       //        }       //    }       //}5��                          �                     �    !                     �                     �    "                     �                     �    #                                          �    $                                          �    %                     L                     �    &                     \                     �    (                     �                     �    )                     �                     �    *                     �                     �    +                     �                     �    ,                                          �    -                     *                     �    .                     A                     �    /                     U                     �    0                     u                     �    1                     �                     �    3                     �                     �    4                     �                     �    6                     �                     �    7                     �                     �    9                     	                     �    :                     >	                     �    ;                     J	                     �    <                     z	                     �    =                     �	                     �    >                     �	                     �    ?                     �	                     �    @                     �	                     5��