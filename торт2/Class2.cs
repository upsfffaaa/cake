using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
namespace торт2
{
	internal class Menu2
	{
		Menu tort = new Menu();
		ConsoleKeyInfo key;
		int position = 2;
		public string razmer;
		public string forma;
		public string dekor;
		public string glazur;
		public string vkus;
		public int razmerzena;
		public int formazena;
		public int dekorzena;
		public int glazurzena;
		public int vkuszena;
		public int zena;
		public int kol=1;
		public int N = 0;
		public void zakaz()
		{List<string> list = new List<string>();
		    list.Add(razmer);
			list.Add(forma);
			list.Add(dekor);
			list.Add(glazur);
			list.Add(vkus);
			N+= 1;
			File.AppendAllText("C:\\заказ.txt", "Заказ номер: ");
			File.AppendAllText("C:\\заказ.txt", Convert.ToString(N));
			File.AppendAllLines("C:\\заказ.txt", list);
			File.AppendAllText("C:\\заказ.txt", "\n");
			File.AppendAllText("C:\\заказ.txt", "Количество: ");
			File.AppendAllText("C:\\заказ.txt", Convert.ToString(kol));
			File.AppendAllText("C:\\заказ.txt", "\n");
			File.AppendAllText("C:\\заказ.txt", Convert.ToString(zena));
			File.AppendAllText("C:\\заказ.txt", "\n--------------------------------------------------------\n");
			while (key.Key != ConsoleKey.Escape)
			{
				Console.Clear();
				Console.WriteLine("  Ваш заказ оформлен. Если хотите сделать еще один, нажмите ESC");
				razmer="";
		        forma = "";
		        dekor = "";
		        glazur = "";
		        vkus = "";
		        razmerzena=0;
		        formazena = 0;
		        dekorzena = 0;
		        glazurzena = 0;
		        vkuszena = 0;
		        zena = 0;
		        kol = 1;
				key = Console.ReadKey();
			}
			return;
		}
		void forma1()
		{
			while (key.Key != ConsoleKey.Escape)
			{
				Console.Clear();
				foreach (var i in tort.forma)
				{
					Console.Write("  ");
					Console.WriteLine(i);
				}
				Strelka();

				key = Console.ReadKey();
				UpDown();
				if (key.Key == ConsoleKey.Enter)
				{
					switch (position)
					{
						case 0:
							forma = tort.forma[0];
							formazena = 400;
							return;
							break;
						case 1:
							forma = tort.forma[1];
							formazena = 300;
							return;
							break;
						case 2:
							forma = tort.forma[2];
							formazena = 200;
							return;
							break;

					}
				}
			}

		}
		void razmer1()
		{
			while (key.Key != ConsoleKey.Escape)
			{
				Console.Clear();
				foreach (var i in tort.razmer)
				{
					Console.Write("  ");
					Console.WriteLine(i);
				}
				Strelka();

				key = Console.ReadKey();
				UpDown();
				if (key.Key == ConsoleKey.Enter)
				{
					switch (position)
					{
						case 0:
							razmer = tort.razmer[0];
							razmerzena = 400;
							return;
							break;
						case 1:
							razmer = tort.razmer[1];
							razmerzena = 300;
							return;
							break;
						case 2:
							razmer = tort.razmer[2];
							razmerzena = 200;
							return;
							break;

					}
				}
			}

		}
		void dekor1()
		{
			while (key.Key != ConsoleKey.Escape)
			{
				Console.Clear();
				foreach (var i in tort.dekor)
				{
					Console.Write("  ");
					Console.WriteLine(i);
				}
				Strelka();

				key = Console.ReadKey();
				UpDown();
				if (key.Key == ConsoleKey.Enter)
				{
					switch (position)
					{
						case 0:
							dekor = tort.dekor[0];
							dekorzena = 400;
							return;
							break;
						case 1:
							dekor = tort.dekor[1];
							dekorzena = 300;
							return;
							break;
						case 2:
							dekor = tort.dekor[2];
							dekorzena = 200;
							return;
							break;

					}
				}
			}

		}
		void glazur1()
		{
			while (key.Key != ConsoleKey.Escape)
			{
				Console.Clear();
				foreach (var i in tort.glazur)
				{
					Console.Write("  ");
					Console.WriteLine(i);
				}
				Strelka();

				key = Console.ReadKey();
				UpDown();
				if (key.Key == ConsoleKey.Enter)
				{
					switch (position)
					{
						case 0:
							glazur = tort.glazur[0];
							glazurzena = 400;
							return;
							break;
						case 1:
							glazur = tort.glazur[1];
							glazurzena = 300;
							return;
							break;
						case 2:
							glazur = tort.glazur[2];
							glazurzena = 200;
							return;
							break;

					}
				}
			}

		}
		void vkus1()
		{
			while (key.Key != ConsoleKey.Escape)
			{
				Console.Clear();
				foreach (var i in tort.vkus)
				{
					Console.Write("  ");
					Console.WriteLine(i);
				}
				Strelka();

				key = Console.ReadKey();
				UpDown();
				if (key.Key == ConsoleKey.Enter)
				{
					switch (position)
					{
						case 0:
							vkus = tort.vkus[0];
							vkuszena = 400;
							return;
							break;
						case 1:
							vkus = tort.vkus[1];
							formazena = 300;
							return;
							break;
						case 2:
							vkus = tort.vkus[2];
							vkuszena = 200;
							return;
							break;

					}
				}
			}

		}
		void kol1()
		{
			while (key.Key != ConsoleKey.Escape)
			{
				Console.Clear();
				Console.WriteLine("Введите количество тортов: ");
				kol = Convert.ToInt32(Console.ReadLine());
				return;
			}
		}
		internal void Menu1()
		{			
			Console.SetCursorPosition(0, 0);
			Console.WriteLine("  Выберите характеристику торта");
			Console.SetCursorPosition(0, 2);
			Console.WriteLine("  форма");
			Console.WriteLine("  размер");
			Console.WriteLine("  вкус");
			Console.WriteLine("  глазурь");
			Console.WriteLine("  декор");
			Console.WriteLine("  количество");
			Console.WriteLine("  Оформить заказ");
			Strelka();
			key = Console.ReadKey();
			if (key.Key == ConsoleKey.Enter)
			{
				PodMenu();
			}
			UpDown();
		}
		void Strelka()
		{
            Console.SetCursorPosition(0, position);
			Console.WriteLine("->");
		}
		void UpDown()
		{
			if (key.Key == ConsoleKey.UpArrow)
			{
				position--;
			}
			else if (key.Key == ConsoleKey.DownArrow)
			{
				position++;
			}
		}
		void PodMenu()
		{
			switch (position)
			{
				case 6:
					dekor1();
					break;
				case 3:
					razmer1();
					break;
				case 2:
					forma1();
					break;
				case 4:
					vkus1();
					break;
				case 5:
					glazur1();
					break;
				case 7:
					kol1();
					break;
				case 8:
					zakaz();
					break;
			}
		}
	}
}
