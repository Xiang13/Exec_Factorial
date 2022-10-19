using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_Factorial
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 計算數值的階乘
			Console.Write("請輸入數值: ");
			string number = Console.ReadLine();
			if (String.IsNullOrWhiteSpace(number))
			{
				Console.WriteLine("請重新輸入");
				return;
			}

			int num = Convert.ToInt32(number);
			int sum = 1;

			for(int i = 1; i <= num; i++)
			{
				sum *= i;
				Console.WriteLine(sum);
			}
		}
	}
}
