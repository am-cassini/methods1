Methods
> Subject: ITN114 Wireless Internet and Pervasive Computing

> Language: C#

> IDE: Visual Studio 2019 

--- Instructions ---
Problem: Min Method (Return the Smaller Number)
Create a method GetMin(int a, int b), which returns the smaller of two numbers. Write a program, which takes as input three numbers and prints the smallest of them. Use the method GetMin(…), which you have already created.

Sample Input and Output
Input	Output	Input	Output
1
2
3	1	-100
-101
-102	-102
Hints and Guidelines
Define a method GetMin(int a, int b) and implement it, after which invoke it from the main program as shown below. In order to find the minimum of three numbers, first, find the minimum of the first two and then the minimum of the result and the third number:

var min = GetMin(GetMin(num1, num2), num3);
