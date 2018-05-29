using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLesson {
	class Program {
		struct gamer {
			public string name;
			public int favnbr;
		}
		static void Main(string[] args) {

			int a = 23 * 37;
			int b = a - 41;
			int c = b / 7;
			Console.WriteLine(c);

			int w = 23;
			int x = 37;
			int y = 41;
			int z = 7;
			int ans = ((w * x) - y) / z;

			string name = "Greg";
			int days = 6;
			string msg = "My name is " + name + " I've been in bootcamp for " + days + " days";
			Console.WriteLine(msg);

			int daysPerYear = 365;
			int daysInYrOne = 4 + 30 + 31 + 30 + 31;
			int daysInFullYears = daysPerYear * 59;
			int daysThisYear = 31 + 28 + 31 + 30 + 29;
			int daysOld = daysInYrOne + daysInFullYears + daysThisYear;
			Console.WriteLine(daysOld);

			int[] frames = new int[10];
			frames[0] = 30;
			frames[1] = 17;
			frames[2] = 10;
			frames[3] = 15;
			frames[4] = 26;
			frames[5] = 7;
			frames[6] = 28;
			frames[7] = 20;
			frames[8] = 6;
			frames[9] = 4;
			int game = 0;
			foreach(int frm in frames) {
				game = game + frm;
			}
			Console.WriteLine(game);

			string[] names = {
				"Greg", "Michael", "Dan", "Anna",
				"Marcus", "Foster", "Jermain", "Mitchell",
				"Jonathan", "Larry", "William"
			};
			foreach(string aname in names) {
				Console.WriteLine("Hi " + aname);
			}

			string[] self = {
				"Greg Doud",
				"Loveland, OH",
				"gdoud@maxtrain.com"
			};
			foreach(string str in self) {
				Console.WriteLine(str);
			}


			gamer ken;
			ken.name = "Ken";
			ken.favnbr = 10;

			gamer nick;
			nick.name = "Nick";
			nick.favnbr = 7;

			gamer[] gamers = { ken, nick };

			foreach(gamer gmr in gamers) {
				Console.WriteLine("{0} fav nbr is {1}", gmr.name, gmr.favnbr);
			}
		}
	}
}
