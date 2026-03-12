using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

////1
//Stack stack = new Stack();
//stack.Push(1);
//stack.Push(2);
//int a = (int)stack.Pop();
//int b = (int)stack.Pop();
//Console.WriteLine($"값: {a}, 값2: {b}");

////2
//Stack<int> stack = new Stack<int>();
//stack.Push(1);
//stack.Push(2);
//int a = stack.Pop();
//int b = stack.Pop();
//Console.WriteLine($"값: {a}, 값2: {b}");


////3
//Cup<string> textCup = new Cup<string>();
//textCup.Content = "커피";
//Cup<int> numberCup = new Cup<int>();
//numberCup.Content = 500;
//Console.WriteLine($"음료: {textCup.Content}");
//Console.WriteLine($"용량: {numberCup.Content}ml");

//class Cup<T>
//{
//    public T Content { get; set; }
//}

////4
//Pair<string, int> name = new Pair<string, int>("용사", 100);
//Pair<int, double> score = new Pair<int, double>(1, 95.5);

//Console.WriteLine($"이름: {name.First}, HP: {name.Second}");
//Console.WriteLine($"순위: {score.First}등, 점수: {score.Second}점");


//class Pair<TFirst, TSecond>
//{
//    public TFirst First { get; set; }
//    public TSecond Second { get; set; }
//    public Pair(TFirst first, TSecond second)
//    {
//        First = first;
//        Second = second;
//    }
//}

////5
//int x = 10;
//int y = 20;
//Console.WriteLine($"교환전: x = {x}, y = {y}");
//Swap(ref x, ref y);
//Console.WriteLine($"교환후: x = {x}, y = {y}");
//string first = "사과";
//string second = "바나나";
//Console.WriteLine($"교환전: first = {first}, second = {second}");
//Swap(ref first, ref second);
//Console.WriteLine($"교환후: first = {first}, second = {second}");
//void Swap<T>(ref T a, ref T b)
//{
//    T temp = a;
//    a = b;
//    b = temp;
//}

////6
//var intContainer = new NumberContainer<int>();
//intContainer.Value = 100;
//var floatContainer = new NumberContainer<float>();
//floatContainer.Value = 3.14f;
//Console.WriteLine($"정수값: {intContainer.Value}");
//Console.WriteLine($"실수값: {floatContainer.Value}");

//class NumberContainer<T> where T : struct
//{
//    public T Value { get; set; }
//}

////7
//Monster monster = CreateInstance<Monster>();
//Console.WriteLine($"생성된 몬스터: {monster.Name}, HP: {monster.HP}");
//T CreateInstance<T>() where T : new()
//{
//    return new T();
//}

//public class Monster
//{
//    public string Name { get; set; } = "슬라임";
//    public int HP { get; set; } = 50;
//}

////8
//int maxInt = GetMax<int>(10, 25);
//Console.WriteLine($"더 큰 정수: {maxInt}");
//string maxString = GetMax<string>("apple", "banana");
//Console.WriteLine($"사전순 뒤: {maxString}");

//T GetMax<T>(T a, T b) where T: IComparable<T>
//{
//    return a.CompareTo(b) > 0 ? a : b;
//}

////9
//T GetDefaultValue<T>()
//{
//    return default;
//}
//int number = GetDefaultValue<int>();
//bool defaultBool = GetDefaultValue<bool>();
//string defaultStirng = GetDefaultValue<string>();

//Console.WriteLine($"int의 기본값: {number}");
//Console.WriteLine($"bool의 기본값: {defaultBool}");
//Console.WriteLine($"string의 기본값: {defaultStirng ?? "(null)"}");

////10
//List<string> people = new List<string>();
//people.Add("철수");
//people.Add("영희");
//people.Add("민수");
//Console.WriteLine("이름 목록");
//foreach(var p in people)
//{
//    Console.WriteLine($"  -{p}");
//}
//Dictionary<string, int> scores = new Dictionary<string, int>();
//scores["철수"] = 95;
//scores["영희"] = 88;
//scores["민수"] = 92;
//Console.WriteLine("점수:");
//foreach(var score in scores)
//{
//    Console.WriteLine($"  -{score.Key}: {score.Value}점");
//}

////11
//var special = new SpecialContainer<string>();
//special.Item = "특별한 아이템";
//special.Description = "레어 등급";
//Console.WriteLine($"{special.Item} ({special.Description})");

//var intBox = new IntContainer();
//intBox.Item = 50;
//Console.WriteLine($"값: {intBox.Item}, 두 배: {intBox.Double()}");
//public class Container<T>
//{
//    public T Item { get; set;  }
//}

//public class SpecialContainer<T> : Container<T>
//{
//    public string Description { get; set; }
//}

//public class IntContainer : Container<int>
//{
//    public int Double() => Item * 2;
//}

//12
Counter<int>.Count++;
Counter<int>.Count++;
Counter<string>.Count++;
Console.WriteLine($"Counter<int>.Count: {Counter<int>.Count}");
Console.WriteLine($"Counter<string>.Count: {Counter<string>.Count}");

class Counter<T>
{
    public static int Count = 0;
}