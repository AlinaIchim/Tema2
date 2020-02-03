using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2._1
{
	public class Asignare
	{
		public static void Main(string[] args)
		{
			int a = 3;
			int b = (a = 2) * a; // b=4
			int c = b * (b = 5); // c=20
			Console.WriteLine("a =" + a + ", b =" + b + ", c =" + c);
			/* a=2 deoarece a fost reinitializat cand am calculat b
			 * b=5 deoarece a fost reinitializat cand am calculat c
			 * c=20 deoarece primul b=4, iar al 2-lea b=5
			 */


			double d = 2.95;
			int i = 4;
			Console.WriteLine(++d > i ? d : i); //d=3.95
			//rolul acestei instructiuni este de a vedea daca d>i, si cum d=3.95, ne va fi afisata valoarea lui i=4


			int x = 3;
			if (++x < 4) //x = 4
				if (x++ < 4)
					Console.WriteLine(x);
				else
					Console.WriteLine(x);
			//nu va afisa nimic deoarece verifica daca 4<4 => fals, iar ramura urmatoare de if si else nu se mai trateaza


			int suma = 0;
			for (int y = 1; y < 10; y++)
			{
				suma = suma + y; // (0+1) -> (1+2) -> (3+3) -> (6+4) -> (10+5) -> (15+6) -> (21+7) -> (28+8) -> (36+9) =45
			}
			Console.WriteLine("Suma este: " + suma);
			// suma va fi egala cu 45 => n(n+1)/2 mai exact 9(9+1)/2


			int program1 = 1;
			for (int z = 1; z < 13; z++)
			{
				program1 = program1 * z;
			}
			Console.WriteLine("n!: " + program1);


			int j= 3;
			int o = 2;
			int p = 4;
			if (j < o && j < p)
				Console.WriteLine(j);
			else if (o < p)
				Console.WriteLine(o);
			else
				Console.WriteLine(p);



			int k = 3;
			if (k % 2 == 0)

				Console.WriteLine("Numbarul este par");
			else
				Console.WriteLine("Numarul este impar");



			
				int ziuaSaptamanii= 3;

				switch (ziuaSaptamanii)
				{
					case 1:
						Console.WriteLine("Luni");
						break;
					case 2:
						Console.WriteLine("Marti");
						break;
					case 3:
						Console.WriteLine("Miercuri");
						break;
					case 4:
						Console.WriteLine("Joi");
						break;
					case 5:
						Console.WriteLine("Vineri");
						break;
					case 6:
						Console.WriteLine("Sambata");
						break;
					case 7:
						Console.WriteLine("Duminica");
						break;
					default:
						Console.WriteLine("Nu este o zi a saptamanii!");
						break;
					

				}

			Console.Read();

		}
	}

}
