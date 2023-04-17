using System;
using System.Collections.Immutable;
using System.Dynamic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Grand Circus Exercises list!");
        while (true)
        {
            Console.WriteLine("Please select an exercise: (1-46) ");
            int exerciseNumber = int.Parse(Console.ReadLine());

            switch (exerciseNumber)
            {
                case 1:
                    Exercise_1();
                    break;
                case 2:
                    Exercise_2();
                    break;
                case 3:
                    Exercise_3();
                    break;
                case 4:
                    Exercise_4();
                    break;
                case 5: 
                    Exercise_5();
                    break;
                case 6:
                    Exercise_6();
                    break;
                case 7:
                    Exercise_7();
                    break;
                case 8:
                    Exercise_8();
                    break;
                case 9:
                    Exercise_9();
                    break;
                case 10:
                    Exercise_10();
                    break;
                case 11:
                    Exercise_11();
                    break;
                case 12:
                    Exercise_12();
                    break;
                case 13:
                    Exercise_13();
                    break;
                case 14:
                    Exercise_14();
                    break;
                case 15:
                    Exercise_15();
                    break;
                case 16:
                    Exercise_16();
                    break;
                case 17:
                    Exercise_17();
                    break;
                case 18:
                    Exercise_18();
                    break;
                case 19:
                    Exercise_19();
                    break;
                case 20:
                    Exercise_20();
                    break;
                case 21:
                    Exercise_21();
                    break;
                case 22:
                    Exercise_22();
                    break;
                case 23:
                    Exercise_23();
                    break;
                case 24:
                    Exercise_24();
                    break;
                case 25:
                    Exercise_25();
                    break;
                case 26:
                    Exercise_26();
                    break;
                case 27:
                    Exercise_27();
                    break;
                case 28:
                    Exercise_28();
                    break;
                case 29:
                    Exercise_29();
                    break;
                case 30:
                    Exercise_30();
                    break;
                case 31:
                    Exercise_31();
                    break;
                case 32:
                    Exercise_32();
                    break;
                case 33:
                    Exercise_33();
                    break;
                case 34:
                    Exercise_34();
                    break;
                case 35:
                    Exercise_35();
                    break;
                case 36:
                    Exercise_36();
                    break;
                case 37:
                    Exercise_37();
                    break;
                case 38:
                    Exercise_38();
                    break;
                case 39:
                    Exercise_39();
                    break;
                case 40:
                    Exercise_40();
                    break;
                case 41:
                    Exercise_41();
                    break;
                case 42:
                    Exercise_42();
                    break;
                case 43:
                    Exercise_43();
                    break;
                case 44:
                    Exercise_44();
                    break;
                case 45:
                    Exercise_45();
                    break;
                case 46:
                    Exercise_46();
                    break;
                case 47:
                    Exercise_47();
                    break;
                case 48:
                    Exercise_48();
                    break;
                case 49:
                    Exercise_49();
                    break;
                case 50:
                    Exercise_50();
                    break;
                case 51:
                    Exercise_51();
                    break;
                case 52:
                    Exercise_52();
                    break;
                case 53:
                    Exercise_53();
                    break;
                case 54:
                    Exercise_54();
                    break;
                case 55:
                    Exercise_55();
                    break;
                case 56:
                    Exercise_56();
                    break;
                case 57:
                    Exercise_57();
                    break;
                case 58:
                    Exercise_58();
                    break;
                case 59:
                    Exercise_59();
                    break;
                case 60:
                    Exercise_60();
                    break;
                case 61:
                    Exercise_61();
                    break;
                case 62:
                    Exercise_62();
                    break;
                case 63:
                    Exercise_63();
                    break;
                case 64:
                    Exercise_64();
                    break;
                case 65:
                    Exercise_65();
                    break;
                case 66:
                    Exercise_66();
                    break;
                case 67:
                    Exercise_67();
                    break;
                case 68:
                    Exercise_68();
                    break;
                case 69:
                    Exercise_69();
                    break;
                case 70:
                    Exercise_70();
                    break;
                case 71:
                    Exercise_71();
                    break;
                default:
                    Exercise_1();
                    break;
            }


            Console.WriteLine();
            Console.Write("Continue to another exercise? y/n: ");
            if (Console.ReadLine() == "n")
                break;
        }
        Console.WriteLine("Goodbye!");
    }

    static void Exercise_1()
    {
        Console.Write("Exercise 1 selected, please enter some text: ");
        Console.WriteLine($"{Console.ReadLine()}");
    }
    static void Exercise_2()
    {
        Console.Write("Exercise 2 selected, please enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine($"{++number}");
    }
    static void Exercise_3()
    {
        Console.Write("Exercise 3 selected, please enter a number: ");
        decimal number = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"{0.5m + number}");
    }
    static void Exercise_4()
    {
        Console.Write("Exercise 4 selected, please enter two numbers: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Please enter a second number: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Addition result: {num1+num2}");
    }
    static void Exercise_5() 
    {
        Console.Write("Exercise 4 selected, please enter two numbers: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Please enter a second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"Multiplication result: {num1 * num2}");
    }
    static void Exercise_6()
    {
        string prompt = "";
        do
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Would you like to continue (y/n)?");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_7()
    {
        string prompt = "";
        Console.WriteLine("Exercise 7 selected. Running exercise 1 in a loop");
        do
        {
            Exercise_1();
            Console.WriteLine("Would you like to continue (y/n)?");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_8() 
    {
        string prompt = "";
        Console.WriteLine("Exercise 8 selected, running exercises 2-5 in a loop");
        do
        {
            Exercise_2();
            Exercise_3();
            Exercise_4();
            Exercise_5();
            Console.WriteLine("Would you like to continue (y/n)?");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_9() 
    {
        Console.WriteLine("Exercise 9 selected. ");
        string prompt2 = "";
        do
        {
            Console.Write("Please select a language (English/Dutch/German/Spanish): ");
            string prompt = Console.ReadLine();
            switch (prompt)
            {
                case "English":
                    Console.WriteLine("Hello World!");
                    break;
                case "Dutch":
                    Console.WriteLine("Hallo Wereld!");
                    break;
                case "German":
                    Console.WriteLine("Hallo Welt!");
                    break;
                case "Spanish":
                    Console.WriteLine("Hola Mundo!");
                    break;
                default:
                    Console.WriteLine("Unknown language inputted");
                    break;
            }
            Console.Write("Would you like to continue (y/n)? ");
            prompt2 = Console.ReadLine();
        } while (prompt2 == "y");
    }
    static void Exercise_10()
    {
        Console.Write("Exercise 10 selected. ");
        string prompt = "";
        do
        {
            Console.WriteLine("Enter your height in inches: ");
            decimal number = decimal.Parse(Console.ReadLine());
            Console.WriteLine(number >= 54 ? "Great, you can ride the Raptor!" : $"Sorry, you cannot ride the Raptor. you need {54 - number} more inches.");
            Console.Write("Would you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_11()
    {
        Console.WriteLine("Exercise 11 selected.");
        string prompt = "";
        do
        {
            for (int i=0; i<=9; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.Write("Would you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_12()
    {
        Console.WriteLine("Execise 12 selected.");
        string prompt = "";
        do
        {
            for (int i = 9; i>=0 ; i--)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.Write("Would you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_13()
    {
        Console.Write("Exercise 13 selected. ");
        string prompt = "";

        do
        {
            Console.Write("Enter a number: ");
            int value = int.Parse(Console.ReadLine());
            for (int i = value; i >= 0; i--)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.Write("Would you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_14()
    {
        Console.Write("Exercise 14 selected. ");
        string prompt = "";

        do
        {
            Console.Write("Enter a number: ");
            int value = int.Parse(Console.ReadLine());
            for (int i=1; i <= value; i++)
            {
                Console.Write($"{i * i} ");
            }
            Console.WriteLine();
            Console.Write("Would you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_15()
    {
        Console.Write("Exercise 15 selected. ");
        string prompt = "";

        do
        {
            Console.Write("Enter a number: ");
            int value = int.Parse(Console.ReadLine());
            for (int i = 1; i <= value; i++)
            {
                Console.Write($"{i * i * i} ");
            }
            Console.WriteLine();
            Console.Write("Would you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_16()
    {
        Console.WriteLine("Exercise 16 selected.");
        string triangle = "";

        for (int i = 0; i < 10; i++)
        {
            triangle += "*";
            Console.WriteLine(triangle);
        }
    }
    static void Exercise_17()
    {
        Console.WriteLine("Exercise 17 selected.");
        int height = 10;
        for (int i = 1; i <= height; i++)
        {
            for (int j = height - i; j > 0; j--)
                Console.Write(" ");
            for (int k = 1; k <= i; k++)
                Console.Write("* ");
            Console.WriteLine();
        }
    }
    static void Exercise_18() 
    {
        Console.Write("Exercise 18 selected. ");
        string prompt = "";
        do
        {
            Console.Write("Enter a number: ");
            int value = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= value; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
            Console.Write("Would you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");    
    }
    static void Exercise_19()
    {
        Console.Write("Exercise 18 selected. ");
        string prompt = "";
        do
        {
            Console.Write("Enter a number: ");
            int value1 = int.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            int value2 = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = value1; i <= value2; i++)
            {
                sum += i;
            }
            Console.WriteLine($"The sum of all numbers from {value1} to {value2} is {sum}");
            Console.Write("Would you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_20()
    {
        Console.Write("Exercise 20 selected. ");
        string prompt = "";
        do
        {
            Console.Write("Enter a number: ");
            int value = int.Parse(Console.ReadLine());
            int product = 1;
            for (int i = 0; i < 3; i++)
            {
                product *= (value - i);
            }
            Console.WriteLine($"The product of {value}, {value - 1}, {value - 2} is {product}");
            Console.Write("Would you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_21()
    {
        Console.WriteLine("Exercise 21 selected. ");
        string prompt = "";
        string prompt2 = "";
        do
        {
            string outputString = "";
            do
            {
                Console.Write("Enter a word: ");
                outputString += Console.ReadLine() + " ";
                Console.Write("Would you like to enter another word (y/n)?");
                prompt2 = Console.ReadLine();
            } while (prompt2 == "y");
            Console.WriteLine(outputString);
            Console.Write("Would you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_22()
    {
        Console.Write("Exercise 22 selected. ");
        int num1, num2, num3;
        string prompt;
        do
        {
            Console.Write("Enter a number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter a number to verify it is in the range: ");
            num3 = int.Parse(Console.ReadLine());

            if (num3 >= num1 && num3 <= num2)
                Console.WriteLine($"{num3} is in the range.");
            else
                Console.WriteLine($"{num3} is outside the range.");

            Console.Write("Would you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");


    }
    static void Exercise_23()
    {
        Console.Write("Exercise 23 selected. ");
        string prompt;
        do
        {
            Console.Write("Enter some text: ");
            string text = Console.ReadLine();
            Console.WriteLine($"{text.Substring(0,10)}");

            Console.Write("Would you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_24()
    {
        Console.Write("Exercise 24 selected. ");
        string prompt;
        do
        {
            Console.Write("Enter some text: ");
            string text = Console.ReadLine();
            Console.WriteLine($"{text.Substring(text.Length-10)}");

            Console.Write("Would you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_25()
    {
        Console.Write("Exercise 25 selected. ");
        string prompt;

        do
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            string[] arr = sentence.Trim().Split(' ');
            foreach (var e in arr)
                Console.WriteLine(e);

            Console.Write("Would you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_26()
    {
        Console.Write("Exercise 26 selected. ");
        string prompt;
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

        do
        {
            Console.Write("Enter some text: ");
            string text = Console.ReadLine();
            int count = 0;
            foreach (char c in text)
            {
                if (vowels.Contains(c))
                    count++;
            }
            Console.WriteLine($"There were {count} vowels");

            Console.Write("Would you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_27()
    {
        Console.Write("Exercise 27 selected. ");
        string prompt;
        char[] consonants = { 'q', 'w', 'r', 't', 'y', 'p', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm',
                              'Q','W','R','T','Y','P','S','D','F','G','H','J','K','L','Z','X','C','V','B','N','M' };
        do
        {
            Console.Write("Enter some text: ");
            string text = Console.ReadLine();
            int count = 0;
            foreach (char c in text)
            {
                if (consonants.Contains(c))
                    count++;
            }
            Console.WriteLine($"There were {count} consonants");

            Console.Write("Would you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }

    static void Exercise_28()
    {
        Console.Write("Exercise 28 selected. ");
        string prompt;
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

        do
        {
            Console.Write("Enter some text: ");
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                if (vowels.Contains(text[i]))
                    text = text.Remove(i,1);
            }
            Console.WriteLine(text);
            Console.Write("Would you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_29()
    {
        Console.Write("Exercise 29 selected. ");
        string prompt;
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

        do
        {
            Console.Write("Enter some text: ");
            string sentence = Console.ReadLine();
            string[] text = sentence.Trim().Split(' ');

            for (int j = 0; j<text.Length; j++)
            {
                for (int i = 1; i < text[j].Length - 1; i++)
                {
                    if (vowels.Contains(text[j][i]))
                        text[j] = text[j].Remove(i, 1);
                }
            }
            string ret = "";
            foreach (string s in text)
                { ret += s + " "; }

            Console.WriteLine(ret.Trim());
            Console.Write("Would you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_30()
    {
        Console.Write("Exercise 30 selected. ");
        string prompt;
        do
        {
            Console.Write("Enter some text: ");
            string text = Console.ReadLine();
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(new String(charArray));

            Console.Write("Would you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_31()
    {
        Console.Write("Exercise 31 selected. ");
        string prompt = "";
        int[] arr = new int[5] { 2, 8, 0, 24, 51 };
        do
        {
            Console.Write("Enter an index (0-4): ");
            int input = int.Parse(Console.ReadLine());
            if (input > 4 || input < 0)
            {
                Console.WriteLine("That is not a valid index.");
            }
            else
                Console.WriteLine($"The value at index {input} is {arr[input]}");
            Console.Write("Would you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_32()
    {
        Console.Write("Exercise 32 selected. ");
        string prompt = "";
        int[] arr = new int[5] { 2, 8, 0, 24, 51 };
        do
        {
            Console.Write("Enter a number: ");
            int input = int.Parse(Console.ReadLine());
            bool found = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == input)
                {
                    Console.WriteLine($"The value {input} can be found at index {i}.");
                    found = true;
                }
            }
            if (found == false)
                Console.WriteLine("That value cannot be found in the array.");

            Console.Write("Would you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_33()
    {
        Console.Write("Exercise 33 selected. ");
        string prompt = "y";
        int[] arr = new int[5] { 2, 8, 0, 24, 51 };
        do
        {
            Console.Write("Enter an index of the array (0-4): ");
            int input = int.Parse(Console.ReadLine());
            if (input > 4 || input < 0)
            {
                Console.WriteLine("That is not a valid index. Please try again.");
                continue;
            }
            Console.Write($"The value at index {input} is {arr[input]}. Would you like to change it (y/n)? ");
            string prompt2 = Console.ReadLine();
            if (prompt2 == "y")
            {
                Console.Write($"Enter the new value at index {input}: ");
                arr[input] = int.Parse(Console.ReadLine());

            }
            Console.Write("Would you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_34()
    {
        Console.Write("Exercise 34 selected. ");
        string prompt = "y";
        int[] arr = new int[5] { 16, 32, 64, 128, 256 };

        do
        {
            Console.Write("Enter a command (half/double): ");
            string command = Console.ReadLine();

            Console.Write("The array now contains: ");

            if (command == "half")
            {
                for (int i = 0; i<arr.Length; i++)
                {
                    arr[i] /= 2;
                    Console.Write($"{arr[i]}");
                    if (i == arr.Length-1)
                        Console.WriteLine(".");
                    else
                        Console.Write(", ");
                }
            }
            else
            {
                for (int i =0; i<arr.Length;i++)
                {
                    arr[i] *= 2;
                    Console.Write($"{arr[i]}");
                    if (i == arr.Length-1)
                        Console.WriteLine(".");
                    else
                        Console.Write(", ");
                }
            }       
            Console.Write("Would you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");    
    }
    static void Exercise_35()
    {
        string prompt = "y";
        string[] animals = { "cow", "elephant", "jaguar", "horse", "crow" };
        do
        {
            Console.Write("Enter two indices separated by a space: ");
            string[] indices = Console.ReadLine().Split(' ');
            int ind1 = int.Parse(indices[0]);
            int ind2 = int.Parse(indices[1]);

            if ((ind1 >= 0 && ind1 < 5) && (ind2 >= 0 && ind2 < animals[ind1].Length))
                Console.WriteLine($"The value at index {ind1} is {animals[ind1]}. The letter at index {ind2} is {animals[ind1][ind2]}");
            else
                Console.WriteLine("Those are not valid indices");

            Console.Write("Would you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_36()
    {
        int[] nums = new int[5] { 12, 11, 10, 9, 8 };
        string[] str = new string[5] { "Drummers Drumming", "Pipers Piping", "Lords a-Leaping", "Ladies Dancing", "Maids a-Milking" };

        Console.Write("Exercise 36 selected. Enter a command (sing/quit): ");
        string prompt = Console.ReadLine();
        while (prompt == "sing")
        {
            for (int i=0; i<5; i++)
                Console.WriteLine(nums[i] + " " + str[i]);

            Console.Write("Enter a command (sing/quit): ");
            prompt = Console.ReadLine();
        }
    }
    static void Exercise_37()
    {
        int[] nums = new int[5];
        Console.WriteLine("Exercise 37 selected.");

        string prompt = "y";
        do
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter a number: ");
                nums[i] = int.Parse(Console.ReadLine());
            }

            double sum = 0;
            foreach (int i in nums)
            {
                sum += i;
            }
            Console.WriteLine($"{nums[0]} + {nums[1]} + {nums[2]} + {nums[3]} + {nums[4]} = {sum}");

            Console.Write("Would you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_38()
    {
        int[] nums = new int[5];
        Console.WriteLine("Exercise 38 selected.");

        string prompt = "y";
        do
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter a number: ");
                nums[i] = int.Parse(Console.ReadLine());
            }

            double average = 0;
            foreach (int i in nums)
            {
                average += i;
            }
            average = average / nums.Length;
            Console.WriteLine($"{nums[0]} + {nums[1]} + {nums[2]} + {nums[3]} + {nums[4]}/5 = {average}");

            Console.Write("Would you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_39()
    {
        int[] nums = new int[5];
        Console.WriteLine("Exercise 39 selected.");

        string prompt = "y";
        do
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter a number: ");
                nums[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(nums);
            foreach (int i in nums)
            {
                Console.Write(i + " ");
            }
            Console.Write("\nWould you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_40()
    {
        int[] nums = new int[5];
        Console.WriteLine("Exercise 40 selected.");

        string prompt = "y";
        do
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter a number: ");
                nums[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(nums);
            Console.WriteLine($"The median of ({nums[0]}, {nums[1]}, {nums[2]}, {nums[3]}, {nums[4]}) is {nums[2]}");
            Console.Write("\nWould you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_41()
    {
        Console.Write("Exercise 41 selected. ");
        string prompt = "y";
        do
        {
            Console.Write("Enter a number: ");
            decimal num1 = decimal.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            decimal num2 = decimal.Parse(Console.ReadLine());
            decimal division = num1 / num2;
            Console.WriteLine(String.Format("{0}/{1} is approximately {2:0.##}", num1, num2, division));

            Console.Write("\nWould you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_42() 
    {
        Console.WriteLine("Exercise 42 selected. ");
        string prompt = "y";

        do
        {
            Console.Write("Enter an X coordinate: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter a Y coordinate: ");
            int y = int.Parse(Console.ReadLine());
            Point point = new Point(x, y);
            Console.WriteLine($"You have created a point object ({point.x}, {point.y})");

            Console.Write("\nWould you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_43()
    {
        Console.WriteLine("Exercise 43 selected. ");
        string prompt = "y";

        do
        {
            Console.Write("Enter an X coordinate: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter a Y coordinate: ");
            int y = int.Parse(Console.ReadLine());
            Point point = new Point(x, y);
            Console.Write($"You have created a point object ({point.x}, {point.y}). ");
            Console.WriteLine($"It has a distance of {Point.CalculateDistance(point)}");

            Console.Write("\nWould you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_44()
    {
        Console.WriteLine("Exercise 44 selected. ");
        string prompt = "y";

        do
        {
            Console.Write("Enter coordinates for a point (x y): ");
            int[] first = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.Write("Enter a second point: ");
            int[] second = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            Point firstPoint = new Point(first[0], first[1]);
            Point secondPoint = new Point(second[0], second[1]);

            Point midpoint = firstPoint.CalculateMidpoint(secondPoint);
            Console.WriteLine($"The midpoint between ({firstPoint.x},{firstPoint.y}) and ({secondPoint.x},{secondPoint.y}) is ({midpoint.x},{midpoint.y}).");

            Console.Write("\nWould you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_45()
    {
        Console.WriteLine("Exercise 45 selected. ");
        string prompt = "y";

        do
        {
            Console.Write("Enter a side length: ");
            int length = int.Parse(Console.ReadLine());
            Square square = new Square(length);
            Console.WriteLine($"The square has a side length {square.sideLength}. Its area is {square.CalculateArea()} and its perimeter is {square.CalculatePerimeter()}.");

            Console.Write("\nWould you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_46()
    {
        Console.WriteLine("Exercise 46 selected. ");
        string prompt = "y";

        do
        {
            Console.Write("Enter the side lengths of a triangle (a b c): ");
            int[] sides = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Triangle triangle = new Triangle(sides[0], sides[1], sides[2]);
            Console.Write("The triangle has side lengths ");
            Console.Write($"{triangle.side1Length}, {triangle.side2Length}, and {triangle.side3Length}. ");
            Console.WriteLine($"Its area is {triangle.CalculateArea()} and its perimeter is {triangle.CalculatePerimeter()}");

            Console.Write("\nWould you like to continue (y/n)? ");
            prompt = Console.ReadLine();
        } while (prompt == "y");
    }
    static void Exercise_47() { }
    static void Exercise_48() { }
    static void Exercise_49() { }
    static void Exercise_50() { }
    static void Exercise_51() { }
    static void Exercise_52() { }
    static void Exercise_53() { }
    static void Exercise_54() { }
    static void Exercise_55() { }
    static void Exercise_56() { }
    static void Exercise_57() { }
    static void Exercise_58() { }
    static void Exercise_59() { }
    static void Exercise_60() { }
    static void Exercise_61() { }
    static void Exercise_62() { }
    static void Exercise_63() { }
    static void Exercise_64() { }
    static void Exercise_65() { }
    static void Exercise_66() { }
    static void Exercise_67() { }
    static void Exercise_68() { }
    static void Exercise_69() { }
    static void Exercise_70() { }
    static void Exercise_71() { }
}

public class Triangle
{
    public int side1Length, side2Length, side3Length;

    public Triangle(int side1Length, int side2Length, int side3Length)
    {
        this.side1Length = side1Length;
        this.side2Length = side2Length;
        this.side3Length = side3Length;
    }   

    public int CalculatePerimeter()
    {
        return side1Length + side2Length + side3Length;
    }
    public int CalculateArea()
    {
        int semi = CalculatePerimeter() / 2;
        return (int)Math.Sqrt(semi * (semi - side1Length) * (semi - side2Length) * (semi - side3Length));
    }
}


public class Square
{
    public int sideLength;
    public Square(int l) { sideLength = l; }
    public int CalculatePerimeter()
    {
        return sideLength * 4;
    }
    public int CalculateArea()
    {
        return sideLength * sideLength;
    }
}

public class Point
{
    public int x, y;
    public Point(int a, int b)
    {
        x = a;
        y = b;
    }

    public static int CalculateDistance(Point p)
    {
        return (int)Math.Sqrt(Math.Pow((p.x - 0), 2) + Math.Pow((p.y - 0), 2));
    }

    public Point CalculateMidpoint(Point other)
    {
        return new Point((this.x + other.x) / 2, (this.y + other.y) / 2);
    }
}