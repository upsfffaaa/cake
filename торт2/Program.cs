using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using Microsoft.VisualBasic;
using торт2;
namespace fff
{
	class Program
	{
		static void Main(string[] args)
		{
			Menu2 tort = new Menu2();
			while (true)
			{
				tort.Menu1();
				Console.Clear();
				Console.SetCursorPosition(2, 11);
				Console.Write("Ваш торт: ");
				Console.Write(tort.forma);
				Console.Write(tort.razmer);
				Console.Write(tort.dekor);
				Console.Write(tort.glazur);
				Console.WriteLine(tort.vkus);
				tort.zena = (tort.razmerzena + tort.formazena + tort.dekorzena + tort.glazurzena + tort.vkuszena)*tort.kol;
				Console.Write("Конечная цена: ");
				Console.Write(tort.zena);
			}
		}
	}
}

