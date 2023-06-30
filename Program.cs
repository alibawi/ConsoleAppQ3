using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static void Main(string[] args)
    {
        Q1();
        Q2();
        Q3();
        Q4();
        Q5();
        Q6();
        Q7();
        Q8();
        Q9();
        Q10();
        Q11();
        Q12();
        Q13();
        Q14();
        Q15();
        Q16();
        Q17();
        Q18();
        Q19();
        Q20();
        Q21();
        Q22();
        Q23();
    }


    /// <summary>
    /// 1. Write a program in C# Sharp to input a string and print it.
    /// Test Data :
    /// Input the string : Welcome,     halalAlmashakl
    /// Expected Output :
    /// The string you entered is : Welcome,     halalAlmashakl
    /// </summary>
    public static void Q1()
    {
        Console.WriteLine("Test Question 1");
        Console.Write("Input the string:");
        string? str = Console.ReadLine();
        Console.WriteLine($"The string you entered is : {str}");
    }

    /// <summary>
    /// 2. Write a C# Sharp program to find the length of a string without using a library function.
    /// Test Data :
    /// Input the string :     halalAlmashakl.com
    /// Expected Output :
    /// Length of the string is : 15
    /// </summary>
    public static void Q2()
    {
        Console.WriteLine("Test Question 2");
        Console.Write("Input the string:");
        string str = Console.ReadLine();
        Console.WriteLine($"Length of The string is : {str.Length}");
    }

    /// <summary>
    /// 3. Write a C# Sharp program to separate individual characters from a string.
    /// Test Data :
    /// Input the string :     halalAlmashakl.com
    /// Expected Output :
    /// The characters of the string are : 
    /// w  3  r e  s o  u r  c e.c  o m
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static void Q3()
    {
        Console.WriteLine("Test Question 3");
        Console.Write("Input the string:");
        string str = Console.ReadLine();
        for(int i=0; i<str.Length; i++) 
        {
            Console.Write($"{str[i]} ");
        }
        Console.WriteLine("\n\n");
    }

    /// <summary>
    /// 4. Write a program in C# Sharp to print individual characters of the string in reverse order.
    /// Test Data :
    /// Input the string :     halalAlmashakl.com
    /// Expected Output :
    /// The characters of the string in reverse are : 
    /// m o  c.e c  r u  o s  e r  3  w
    /// </summary>
    public static void Q4()
    {
        Console.WriteLine("Test Question 4");
        Console.Write("Input the string:");
        string str = Console.ReadLine();
        for(int i=str.Length-1; i>=0; i--)
        {
            Console.Write($"{str[i]} ");
        }

        Console.WriteLine("\n\n");
    }

    /// <summary>
    /// 5. Write a program in C# Sharp to count the total number of words in a string.
    /// Test Data :
    /// Input the string : This is     halalAlmashakl.com
    /// Expected Output :
    /// Total number of words in the string is : 3
    /// </summary>
    public static void Q5()
    {
        Console.WriteLine("Test Question 5");
        Console.Write("Input the string:");
        string str = Console.ReadLine();
        int cnt = 1;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == ' ' || str[i] == '\n' || str[i] == '\t')
            {
                cnt++;
            }
        }

        Console.WriteLine($"Total number of words in the string is : {cnt}\n\n");
    }

    /// <summary>
    /// 6. Write a program in C# Sharp to compare two strings without using a string library functions.
    /// Test Data :
    /// Input the 1st string : This is first string
    /// Input the 2nd string : This is first string
    /// Expected Output :
    /// The length of both strings are equal and
    /// also, both strings are equal.
    /// </summary>
    public static void Q6()
    {
        Console.WriteLine("Test Question 6");
        Console.Write("Input the 1st string:");
        string str1 = Console.ReadLine();
        Console.Write("Input the string:");
        string str2 = Console.ReadLine();
        bool equal = true;
        if(str1.Length == str2.Length)
        {
            for(int i=0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i]) { equal = false; break; }
            }
        }
        else
        {
            equal = false;
        }
        if (equal)
        {
            Console.WriteLine("The length of both strings are equal and also, both strings are equal");
        }
        else
        {
            if(str1.Length == str2.Length)
            {
                Console.WriteLine("The length of both strings are equal and but the two strings are not equal");
            }
            else
            {
                Console.WriteLine("The length of both strings are not equal and also, both strings are not equal");
            }
        }
    }
    /// <summary>
    /// 7. Write a program in C# Sharp to count the number of alphabets, digits and special characters in a string.
    /// Test Data :
    /// Input the string : Welcome to     halalAlmashakl.com
    /// Expected Output :
    /// Number of Alphabets in the string is : 21 
    /// Number of Digits in the string is : 1 
    /// Number of Special characters in the string is : 4
    /// </summary>
    public static void Q7()
    {
        Console.WriteLine("Test Question 7");
        Console.Write("Input the string:");
        string str = Console.ReadLine();
        int c = 0;
        int dgt = 0;
        int sp = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if ((str[i] >= 'a' && str[i] == 'z') || (str[i] >= 'A' && str[i] == 'Z'))
            {
                c++;
            }
            else if (str[i] >= '0' && str[i] <= '9')
            {
                dgt++;
            }
            else { sp++; }
        }
        Console.WriteLine($"Number of Alphabets in the string is : {c}");
        Console.WriteLine($"Number of Digits in the string is : {dgt}");
        Console.WriteLine($"Number of Special characters in the string is : {sp}\n\n");
    }

    /// <summary>
    /// 8. Write a program in C# Sharp to copy one string to another string.
    /// Test Data :
    /// Input the string : This is a string to be copied.
    /// Expected Output :
    /// The First string is : This is a string to be copied. 
    /// The Second string is : This is a string to be copied. 
    /// Number of characters copied : 31
    /// </summary>
    public static void Q8()
    {
        Console.WriteLine("Test Question 8");
        Console.Write("Input the string:");
        string str = Console.ReadLine();
        int lngth = str.Length;
        string[] str2 = new string[lngth];
        int cnt = 0;
        for(int i = 0;i < lngth; i++)
        {
            string t = str[i].ToString();
            str2[i] = t;
            cnt++;
        }
        Console.WriteLine($"The First string is : {str}");
        Console.WriteLine($"The Second string is : {string.Join("",str2)}");
        Console.WriteLine($"Number of characters copied : {cnt}");
    }

    /// <summary>
    /// 9. Write a C# Sharp program to count the number of vowels or consonants in a string.
    /// Test Data :
    /// Input the string : Welcome to     halalAlmashakl.com
    /// Expected Output :
    /// The total number of vowel in the string is : 9 
    /// The total number of consonant in the string is : 12
    /// </summary>
    public static void Q9()
    {
        Console.WriteLine("Test Question 9");
        Console.Write("Input the string:");
        string str = Console.ReadLine();

        int vowel = 0;
        int consonant = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == 'a' || str[i] == 'i' || str[i] == 'e' || str[i] == 'o' || str[i] == 'u')
            {
                vowel++;
            }
            else
            {
                consonant++;
            }
        }

        Console.WriteLine($"The total number of vowel in the string is : {vowel}");
        Console.WriteLine($"The total number of consonant in the string is : {consonant}");
    }

    /// <summary>
    /// 10. Write a C# Sharp program to find the maximum number of characters in a string.
    /// Test Data :
    /// Input the string : Welcome to     halalAlmashakl.com
    /// Expected Output :
    /// The Highest frequency of character 'e' 
    /// appears number of times : 4
    /// </summary>
    public static void Q10()
    {
        Console.WriteLine("Test Question 10");
        Console.Write("Input the string:");
        string str = Console.ReadLine();
        int freq = 1;
        char hf = str[0];
        for(int i = 0; i < str.Length-1;i++)
        {
            char tmp = str[i];
            int f = 1;
            for(int j = i +1; j < str.Length;j++)
            {
                if(tmp == str[j])
                {
                    f++;
                }
            }
            if(f > freq)
            {
                freq = f;
                hf = tmp;
            }
        }

        Console.WriteLine($"The Highest frequency of character '{hf}'");
        Console.WriteLine($"appears number of times :{freq}");

    }

    /// <summary>
    /// 11. Write a C# Sharp program to sort a string array in ascending order.
    /// Test Data :
    /// Input the string : this is a string
    /// Expected Output :
    /// After sorting the string appears like : 
    /// a g h i i i n r s s s t t
    /// </summary>
    public static void Q11()
    {
        Console.WriteLine("Test Question 11");
        Console.Write("Input the string:");
        string str = Console.ReadLine();

        int l = str.Length;
        char[] sorting = new char[l];
        char tmp;
        sorting = str.ToCharArray(0, l);
        for( int i = 1; i < l;i++)
        {
            for(int j = 0;j < l-i; j++)
            {
                if (sorting[j] > sorting[j + 1])
                {
                    tmp = sorting[j];
                    sorting[j] = sorting[j + 1];
                    sorting[j + 1] = tmp;
                }
            }
        }

        Console.WriteLine("After sorting the string appers like :");
        foreach(char c in sorting)
        {
            Console.Write($"{c} ");
        }
    }

    /// <summary>
    /// 12. Write a C# Sharp program to read a string through the keyboard and sort it using bubble sort.
    /// Test Data :
    /// Input number of strings :3
    /// Input 3 strings below :
    /// abcd
    /// zxcv
    /// mnop
    /// Expected Output :
    /// After sorting the array appears like : 
    /// abcd
    /// mnop
    /// zxcv
    /// </summary>
    public static void Q12()
    {
        Console.WriteLine("Test Question 12");
        Console.Write("Input the number of string:");
        int num = Convert.ToInt32(Console.ReadLine());

        string[] str = new string[num];

        Console.WriteLine($"Input {num} strings below");
        for( int i = 0; i < num; i++)
        {
            str[i] = Console.ReadLine();
        }

        string tmp = "";
        for(int i = 0; i < num; i++)
        {
            for(int j = 0; j < num - 1; j++)
            {
                if (str[j].CompareTo(str[j+1]) > 0)
                {
                    tmp = str[j];
                    str[j] = str[j+1];
                    str[j+1] = tmp;
                }
            }
        }

        Console.WriteLine("After sorting the array appears like :");
        foreach (string item in str)
        {
            Console.WriteLine(item);
        }
    }

    /// <summary>
    /// Write a program in C# Sharp to extract a substring from a given string without using the library function.
    /// Test Data :
    /// Input the string : This is a test string
    /// Input the position to start extraction :5
    /// Input the length of substring :5
    /// Expected Output :
    /// The substring retrieve from the string is :  is a
    /// </summary>
    public static void Q13()
    {
        Console.WriteLine("Test Question 13");
        Console.Write("Input the string:");
        string str = Console.ReadLine();
        Console.Write("Input the position to srart extraction :");
        int pos = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the length to substring:");
        int l = Convert.ToInt32(Console.ReadLine());
        int i = 0;

        Console.Write("The substring retrieve from the string is :");
        while ( i < l)
        {
            Console.Write(str[pos + i - 1]);
            i++;
        }
        Console.WriteLine("\n\n");
    }


    /// <summary>
    /// 14. Write a C# Sharp program to check whether a given substring is present in the given string.
    /// Test Data :
    /// Input the string : This is a Test String
    /// Input the substring to search : Test
    /// Expected Output :
    /// The substring exists in the string
    /// </summary>
    public static void Q14()
    {
        Console.WriteLine("Test Question 14");
        Console.Write("Input the string:");
        string str = Console.ReadLine();
        Console.Write("Input the substring to search :");
        string substr = Console.ReadLine();

        if (str.Contains(substr))
        {
            Console.WriteLine("The substring exists in the string");
        }
        else
        {
            Console.WriteLine("The substring is not exists in the string");
        }
    }

    /// <summary>
    /// 15. Write a C# Sharp program to read a sentence and replace lowercase characters with uppercase and vice-versa.
    /// Test Data :
    /// Input the string : This is a string
    /// Expected Output :
    /// After conversion, the string is : tHIS IS A STRING
    /// </summary>
    public static void Q15()
    {
        Console.WriteLine("Test Question 15");
        Console.Write("Input the string:");
        string str = Console.ReadLine();

        Console.Write("After conversion, the string is :");
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] >= 'a' && str[i] <= 'z')
            {
                Console.Write(str[i].ToString().ToUpper());
            }else if (str[i] >= 'A' && str[i] <= 'Z')
            {
                Console.Write(str[i].ToString().ToLower());
            }
            else
            {
                Console.Write(str[i]);
            }
        }

        Console.WriteLine("\n\n");
    }

    /// <summary>
    /// 16. Write a program in C# Sharp to check the username and password.
    /// Test Data :
    /// Input a username: uesr
    /// Input a password: pass
    /// Input a username: abcd
    /// Input a password: 1234
    /// Expected Output :
    /// Password entered successfully!
    /// </summary>
    public static void Q16()
    {
        Console.WriteLine("Test Question 16");
        Console.Write("Enter a User Name: ");
        string un = Console.ReadLine();
        Console.Write("Enter a password: ");
        string pw = Console.ReadLine();

        if(un == "abcd" && pw == "1234")
        {
            Console.WriteLine("Password you entered successfully!");
        }
        else
        {
            Console.WriteLine("Invalid Username and Password");
        }
    }

    /// <summary>
    /// 17. Write a program in C# Sharp to search for the position of a substring within a string.
    /// Test Data :
    /// Input a String: this is a string
    /// Input a substring to be found in the string: is
    /// Expected Output :
    /// Found 'is' in 'this is a string' at position 2
    /// </summary>
    public static void Q17()
    {
        Console.WriteLine("Test Question 17");
        Console.Write("Input a String: ");
        string str = Console.ReadLine();
        Console.Write("Input a substring to be found in the string: ");
        string search = Console.ReadLine();

        int pos = str.IndexOf(search);
        if(pos > 0)
        {
            Console.WriteLine($"Found '{search}' in '{str}' at position {pos}");
        }
        else if( pos == -1)
        {
            Console.WriteLine($"The substring '{search}' is not found in the string '{str}'");
        }
        else
        {
            Console.WriteLine($"The substring is empty");
        }
    }

    /// <summary>
    /// 18. Write a C# Sharp program to check whether a character is an alphabet and not and if so, check for the case.
    /// Test Data :
    ///Input a character: Z
    ///Expected Output :
    ///The character is uppercase.
    /// </summary>
    public static void Q18()
    {
        Console.WriteLine("Test Question 18");
        Console.Write("Input a character: ");
        char ch = (char)Console.Read();
        if (ch >= 'a' && ch <= 'z')
        {
            Console.WriteLine($"The character is alphabet and lowercase");
        }
        else if(ch >= 'A' && ch <= 'Z')
        {
            Console.WriteLine($"The character is alphabet and uppercase");
        }
        else
        {
            Console.WriteLine("The character is not alphabet");
        }
    }

    /// <summary>
    /// 19. Write a program in C# Sharp to find the number of times a substring appears in a given string.
    /// Test Data :
    /// Input the original string : this is original string
    /// Input the string to be searched for : str
    /// Expected Output :
    /// The string 'str' occurs 1 times
    /// </summary>
    public static void Q19()
    {
        Console.WriteLine("Test Question 19");
        Console.Write("Input the original String: ");
        string str = Console.ReadLine();

        Console.Write("Input the String to be searched for: ");
        string srch = Console.ReadLine();

        int s = 0;
        int count = -1;
        int i = -1;

        while( s > -1 )
        {
            s = str.IndexOf(srch, i + 1);
            count++;
            i = s;
        }

        Console.WriteLine($"The string '{srch}' occurs {count} times");
    }

    /// <summary>
    /// 20. Write a program in C# Sharp to insert a substring before the first occurrence of a string.
    /// Test Data :
    /// Input the original string : this is a string
    /// Input the string to be searched for : a
    /// Input the string to be inserted : test
    /// Expected Output :
    /// The modified string is : this is  test a string
    /// </summary>
    public static void Q20()
    {
        Console.WriteLine("Test Question 20");
        Console.Write("Input the original String: ");
        string str = Console.ReadLine();

        Console.Write("Input the String to be searched for: ");
        string srch = Console.ReadLine();

        Console.Write("Input the string to be inserted: ");
        string inserted = Console.ReadLine();

        int pos = str.IndexOf(srch);

        string mod = str.Substring(0, pos) + inserted + " " + str.Substring(pos);

        Console.WriteLine($"The modified string is : {mod}");
    }

    /// <summary>
    /// 21. Write a C# Sharp program to compare (less than, greater than, equal to) two substrings.
    /// Expected Output :
    /// str1 = 'computer', str2 = 'system'                                               
    /// Substring 'mp' in 'computer' is less than substring 'sy' in 'system'. 
    /// </summary>
    public static void Q21()
    {
        Console.WriteLine("Test Question 21");
        Console.Write("Input 1st String: ");
        string str1 = Console.ReadLine();

        Console.Write("Input 2ne String: ");
        string str2 = Console.ReadLine();

        int pos = string.Compare(str1, 2, str2, 0, 2);

        string comp = (pos < 0 ? "less than" : pos > 0 ? "greater than" : "equal to");

        Console.WriteLine($"Substring '{str1.Substring(2, 2)}' in '{str1}' is {comp} substring '{str2.Substring(0, 2)}' in '{str2}'");
    }

    /// <summary>
    /// 22. Write a C# Sharp program to compare two substrings that only differ in case. The first comparison ignores case and the second comparison considers case.
    /// Expected Output :
    /// str1 = 'COMPUTER', str2 = 'computer'                                             
    /// Ignore case:                                                                     
    /// Substring 'MP' in 'COMPUTER' is equal to substring 'mp' in 'compu                                                                              
    /// Honor case:                                                                      
    /// Substring 'MP' in 'COMPUTER' is greater than substring 'mp' in 'computer'.  
    /// </summary>
    public static void Q22()
    {
        Console.WriteLine("Test Question 21");
        Console.Write("Str1 = 'COMPUTER', str2 = 'computer' ");
        string str1 = "COMPUTER";
        string str2 = "computer";

        int pos = string.Compare(str1, 2, str2, 2, 2, true);

        string comp = (pos < 0 ? "less than" : pos > 0 ? "greater than" : "equal to");
        Console.WriteLine("Ignore case:");
        Console.WriteLine($"Substring '{str1.Substring(2, 2)}' in '{str1}' is {comp} substring '{str2.Substring(2, 2)}' in '{str2}'");

        pos = string.Compare(str1, 2, str2, 2, 2, false);

        comp = (pos < 0 ? "less than" : pos > 0 ? "greater than" : "equal to");
        Console.WriteLine("Hono case:");
        Console.WriteLine($"Substring '{str1.Substring(2, 2)}' in '{str1}' is {comp} substring '{str2.Substring(2, 2)}' in '{str2}'");
    }

    /// <summary>
    /// 23. Write a C# Sharp program to compare two substrings using different cultures and ignore the substring case.
    /// Expected Output :
    /// str1 = 'COMPUTER', str2 = 'computer'                                             
    /// Ignore case, Turkish culture:                                                    
    /// Substring 'UT' in 'COMPUTER' is equal to substring 'ut' in 'computer'.                                                                                         
    /// Ignore case, invariant culture:                                                  
    /// Substring 'UT' in 'COMPUTER' is equal to substring 'ut' in 'computer'.  
    /// </summary>
    public static void Q23()
    {
        Console.WriteLine("Test Question 21");
        Console.Write("Str1 = 'COMPUTER', str2 = 'computer' ");
        string str1 = "COMPUTER";
        string str2 = "computer";

        int pos = string.Compare(str1, 4, str2, 4, 2, true, new CultureInfo("tr-TR"));

        string comp = (pos < 0 ? "less than" : pos > 0 ? "greater than" : "equal to");
        Console.WriteLine("Ignore case:");
        Console.WriteLine($"Substring '{str1.Substring(4, 2)}' in '{str1}' is {comp} substring '{str2.Substring(4, 2)}' in '{str2}'");

        pos = string.Compare(str1, 4, str2, 4, 2, true, CultureInfo.InvariantCulture);

        comp = (pos < 0 ? "less than" : pos > 0 ? "greater than" : "equal to");
        Console.WriteLine("Hono case:");
        Console.WriteLine($"Substring '{str1.Substring(4, 2)}' in '{str1}' is {comp} substring '{str2.Substring(4, 2)}' in '{str2}'");
    }

    /// <summary>
    /// 24. Write a C# Sharp program to compare the last names of two people. It then lists them in alphabetical order.
    /// Expected Output :
    /// Sorted alphabetically by last name:                                              
    /// Michel Jhonson
    /// John Peterson
    /// </summary>
    public static void Q24()
    {

    }

    public static void Q25()
    {
    }
}