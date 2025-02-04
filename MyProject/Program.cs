using System;
using System.Transactions;
using System.Xml.Linq;
using MyProject;
using static System.Net.Mime.MediaTypeNames;

//Console.WriteLine("Enter your name");
//String name= Console.ReadLine();
//Console.WriteLine("welcome " + name);
//Console.ReadLine();

//Console.WriteLine("enter your age");
//String age = Console.ReadLine();
//Console.WriteLine("you will be " + (Convert.ToInt32(age)+5 )+ " year old after 5 years");
//Console.ReadLine();



//Types of operators

////1. Arithmetic Operators
//int a = 10, b = 3;
//Console.WriteLine("sum " + (a + b)); 
//Console.WriteLine("sub " + (a - b)); 
//Console.WriteLine("mul " + (a * b)); 
//Console.WriteLine("div " + (a / b));
//Console.WriteLine("mod " + (a % b)); 
//Console.ReadLine();

////2. Assignment Operators
//int num = 5;
////num += 3;  
////num -= 2;
////num *= 2;
////num /= 2;
//Console.WriteLine(num);
//Console.ReadLine();

////3. Logical Operators
//bool a = true, b = false;
//Console.WriteLine(a && b);  
//Console.WriteLine(a || b);  
//Console.WriteLine(!a);
//Console.ReadLine();

////4. Relational(Comparison) Operators
//int x = 5, y = 10;
//Console.WriteLine(x == y);  
//Console.WriteLine(x != y); 
//Console.WriteLine(x > y);   
//Console.WriteLine(x < y);   
//Console.WriteLine(x >= 5);  
//Console.WriteLine(y <= 20);
//Console.ReadLine();

////5.Increment / Decrement Operators
//int a = 5;
//Console.WriteLine("++a returns: " + ++a);
//Console.WriteLine("a++ returns: " + a++);
//Console.WriteLine("Final value of a: " + a);
//Console.WriteLine("--a returns: " + --a);
//Console.WriteLine("a-- returns: " + a--);
//Console.WriteLine("Final value of a: " + a);
//Console.ReadLine();

//Math Class
//int a = Math.Max(10, 20);
//int b = Math.Min(10, 20);
//Console.WriteLine(b);
//Console.ReadLine();

//String Manipulation
//string message = " Hello, World!";

//Console.WriteLine(message.Length);
//Console.WriteLine(message.ToUpper()); 
//Console.WriteLine(message.ToLower());
//Console.WriteLine(message.Trim());
//Console.WriteLine(message.Substring(8, 5)); //Substring(startIndex, length)
//Console.WriteLine(message.Contains("World")); // T/F
//Console.WriteLine(message.Replace("World", "C#"));
//Console.WriteLine(message.StartsWith("Hello"));  // T/F
//Console.WriteLine(message.EndsWith("World!"));  // T/F
//Console.WriteLine(message.IndexOf("o"));       // 5
//Console.WriteLine(message.LastIndexOf("o"));   // 9
//Console.WriteLine(message.Remove(5, 7));

//char[] chars = message.ToCharArray();
//foreach (char c in chars)
//{
//    Console.WriteLine(c);
//}

//Escape sequence charaters

//string sentence1 = "hello,\n How are you?";
//string sentence2 = "How to add \" in string?";
//string sentence3 = "How to add \t (tab) in sentence?";
//Console.WriteLine(sentence3);

//If Else / Conditionals
//Console.WriteLine("enter your age");
//String age = Console.ReadLine();

//if (Convert.ToInt32(age) >= 18)
//{
//    Console.WriteLine("you can vote");
//}
//else
//{
//    Console.WriteLine("you are not able to vote");
//}

//Swetch
//int nitem = 5;
//switch (nitem)
//{
//    case 1:
//        Console.WriteLine("Case 1");
//        break;
//    case 5:
//        Console.WriteLine("Case 5");
//        break;
//    case 9:
//        Console.WriteLine("Case 9");
//        break;
//    default:
//        Console.WriteLine("No match found");
//        break;
//}

//Loops
//1. while loop 
//int x = 1;
//while (x <= 4)
//{
//    Console.WriteLine(x);
//    x++;
//}

//2. For Loop
//for (int x = 1; x <= 4; x++) {
//    Console.WriteLine(x);
// }

//3.Do While
//int x = 1;
//do
//{
//    Console.WriteLine(x);
//    x++;
//}
//while (x < 5);

// Jump Statements
//break statement is used to terminate the loop or statement in which it is present.


Person p1 = new Person { Name = "Radhika" };
p1.Greet();

Console.ReadLine();