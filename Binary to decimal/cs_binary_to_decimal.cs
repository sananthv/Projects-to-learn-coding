using System;
using System.Collections;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Enter number");
		
		int num = int.Parse(Console.ReadLine());
		
		var binary = new ArrayList(); 
		
		while (num != 1) {
			binary.Insert(0,num%2);
			num = (int) num/2;
		}
		
		binary.Insert(0,1);
		
		string result = "";
		
		foreach( int i in binary) {
			result = result + i; 
		}
		
		Console.WriteLine(result);
	}
}