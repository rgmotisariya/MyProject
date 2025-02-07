using System;
using System.Collections;
using System.Transactions;
using System.Xml.Linq;
using MyProject;
using static System.Net.Mime.MediaTypeNames;

// // Data Type

//byte b = 255; //1
//bool b1= true; //1
//char a = 'G'; //2
//int i = 89;   //2
//short s = 56;  //2
//long l = 4564;   //8   
//double d = 8.358674532;  //8 
//float f = 3.7330645f; //4
//decimal dec = 389.5m; //16

//Console.WriteLine("byte: " + b);
//Console.WriteLine("bool: " + b1);
//Console.WriteLine("char: " + a);
//Console.WriteLine("integer: " + i);
//Console.WriteLine("short: " + s);
//Console.WriteLine("long: " + l);
//Console.WriteLine("float: " + f);
//Console.WriteLine("double: " + d);
//Console.WriteLine("decimal: " + dec);

////type conversion

//Console.WriteLine("Enter your name");
//String name= Console.ReadLine();
//Console.WriteLine("welcome " + name);
//Console.ReadLine();

//Console.WriteLine("enter your age");
//String age = Console.ReadLine();
//Console.WriteLine("you will be " + (Convert.ToInt32(age)+5 )+ " year old after 5 years");
//Console.ReadLine();



//Types of operators
// 1.implicit type conversion -no data lose
// byte -> int -> float 

//explicite type coversion  -data lose
//int -> byte

//int i = 1;
//byte b = (byte) i;
//Console.WriteLine("b = "+ b); //1

//float f =1.0f;
//int n =(int) f;
//Console.WriteLine("n = "+ n); //1

//non compatible
//string s = "35";
//int i= Convert.ToInt32(s);
//int j= int.Parse(s);
//Console.WriteLine(i);
//Console.WriteLine(j);
//Tobyte() ToInt16() ToInt64()

////1. Arithmetic Operators
//int a = 10, b = 3;
//Console.WriteLine("sum " + (a + b)); 
//Console.WriteLine("sub " + (a - b)); 
//Console.WriteLine("mul " + (a * b)); 
//Console.WriteLine("div " + (a / b));
//Console.WriteLine("mod " + (a % b)); 


////2. Assignment Operators
//int num = 5;
////num += 3;  
////num -= 2;
////num *= 2;
////num /= 2;
//Console.WriteLine(num);


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




//oop concepts

// class and object

//ex-1
//Person p1 = new Person { name = "Radhika" };
//p1.Greet();

//ex-2
//Dog d1 = new Dog("tommy", Convert.ToInt16(3), "brown");
//Console.WriteLine(d1.GetAge());
//Console.WriteLine(d1.GetName());
//Console.WriteLine(d1.GetColor());
//Console.WriteLine(d1.ToString());

//int[] arr1 = new int[5];
//int[] arr2 = new int[5] { 1, 2, 3, 4, 5 };
//int[] arr3 = { 1, 2, 3, 4, 5 };

////traversal of array element
//for (int i = 0; i < arr3.Length; i++)
//{
//    Console.Write(" " + arr3[i]);
//}

//properties of array
//Console.WriteLine("\n");
//Console.WriteLine("Length " +  arr3.Length);
//Console.WriteLine("Rank of the array: " + arr3.Rank);

//methods of array
//int[] numbers = { 5, 2, 8, 3, 9, 1, 7, 4 };
//static void PrintArray<T>(T[] array)
//{
//    foreach (var item in array) Console.Write(item + " ");
//    Console.WriteLine();
//}

//// AsReadOnly
//var readOnlyNumbers = Array.AsReadOnly(numbers);
//Console.WriteLine("Read-Only Array:");
//foreach (var num in readOnlyNumbers) 
//    Console.Write(num + " ");
//Console.WriteLine();

//// BinarySearch
//Array.Sort(numbers); // Required for BinarySearch
//int index = Array.BinarySearch(numbers, 7);
//Console.WriteLine($"Index of 7 after BinarySearch: {index}");

//// Clear
//Array.Clear(numbers, 2, 2); // Clears two elements starting at index 2
//Console.WriteLine("After Clear:");
//PrintArray(numbers);

//// Clone
//var clonedArray = (int[])numbers.Clone(); //Creates a shallow copy of the Array.
//Console.WriteLine("Cloned Array:");
//PrintArray(clonedArray);

//// ConstrainedCopy
//int[] destinationArray = new int[5];
//Array.ConstrainedCopy(numbers, 1, destinationArray, 0, 5);
//Console.WriteLine("After ConstrainedCopy:");
//PrintArray(destinationArray);

//// ConvertAll
//string[] stringNumbers = Array.ConvertAll(numbers, x => x.ToString()); //Converts an array of one type to an array of another type.
//Console.WriteLine("Converted to String Array:");
//PrintArray(stringNumbers);

//// Copy
//int[] copiedArray = new int[4];
//Array.Copy(numbers, 1, copiedArray, 0, 4);
//Console.WriteLine("Copied Array:");
//PrintArray(copiedArray);

//// CopyTo
//int[] copiedToArray = new int[10];
//numbers.CopyTo(copiedToArray, 2);
//Console.WriteLine("Copied to new array using CopyTo:");
//PrintArray(copiedToArray);

//// Empty
//int[] emptyArray = Array.Empty<int>();
//Console.WriteLine($"Empty array length: {emptyArray.Length}");

//// Exists
//bool hasEven = Array.Exists(numbers, x => x % 2 == 0);
//Console.WriteLine($"Array contains an even number: {hasEven}");

//// Find
//int firstEven = Array.Find(numbers, x => x % 2 == 0);
//Console.WriteLine($"First even number: {firstEven}");

//// FindAll
//int[] allOdds = Array.FindAll(numbers, x => x % 2 != 0);
//Console.WriteLine("All odd numbers:");
//PrintArray(allOdds);

//// ForEach
//Console.WriteLine("Array elements using ForEach:");
//Array.ForEach(numbers, x => Console.Write(x + " "));
//Console.WriteLine();

//// GetLength
//Console.WriteLine($"Length of array: {numbers.GetLength(0)}");

//// GetUpperBound
//Console.WriteLine($"Upper bound of array: {numbers.GetUpperBound(0)}");

//// GetLowerBound
//Console.WriteLine($"Lower bound of array: {numbers.GetLowerBound(0)}");

//// GetValue
//Console.WriteLine($"Value at index 3: {numbers.GetValue(3)}");

//// IndexOf
//int indexOfValue = Array.IndexOf(numbers, 8);
//Console.WriteLine($"Index of 8: {indexOfValue}");

//// Resize
//Array.Resize(ref numbers, 10);
//Console.WriteLine("Resized Array:");
//PrintArray(numbers);

//// Reverse
//Array.Reverse(numbers);
//Console.WriteLine("Reversed Array:");
//PrintArray(numbers);

//// SetValue
//numbers.SetValue(99, 0);
//Console.WriteLine("After SetValue:");
//PrintArray(numbers);

//// Sort
//Array.Sort(numbers);
//Console.WriteLine("Sorted Array:");
//PrintArray(numbers);

//// ToString
//Console.WriteLine("ToString for array: " + numbers.ToString());


//Array List 

//ArrayList arrayList = new ArrayList();
//arrayList.Add(123);
//arrayList.Add("hello");
//arrayList.Add(3.14);

//foreach (var item in arrayList)
//{
//    Console.WriteLine(item);
//}
//Console.WriteLine("number of elements: " + arrayList.Count);
//Console.WriteLine("Capacity of an ArrayList : " + arrayList.Capacity);

Console.ReadLine();