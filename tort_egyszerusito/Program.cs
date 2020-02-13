using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tort_egyszerusito {
    class Program {
        static void Main(string[] args) {
            while (true) {
                try {
                    List<int> s = new List<int>();
                    List<int> n = new List<int>();
                    Console.WriteLine("számláló:");
                    int szamlalo = int.Parse(Console.ReadLine());
                    Console.WriteLine("nevező:");
                    int nevezo = int.Parse(Console.ReadLine());
                    for (int j = 2; j <= Math.Sqrt(szamlalo); j++) {
                        if (szamlalo % j == 0) {
                            s.Add(j);
                        }
                    }
                    for (int j = 2; j <= Math.Sqrt(nevezo); j++) {
                        if (nevezo % j == 0) {
                            n.Add(j);
                        }
                    }
                    s.Add(szamlalo);
                    n.Add(nevezo);
                    int sk = 0;
                    int nk = 0;
                    if (szamlalo < nevezo) {
                        for (int i = 0; i < n.Count; i++) {
                            if (s.Contains(n[i])) {
                                sk = szamlalo / s[i];
                                nk = nevezo / n[i];
                            }
                        }
                    } else if (szamlalo > nevezo) {
                        for (int i = 0; i < s.Count; i++) {
                            if (n.Contains(s[i])) {
                                sk = szamlalo / s[i];
                                nk = nevezo / n[i];
                            }
                        }
                    }
                    Console.WriteLine("");
                    Console.WriteLine(sk);
                    Console.WriteLine("-");
                    Console.WriteLine(nk);
                    Console.WriteLine("");
                } catch (Exception) {
                    Console.WriteLine("hiba");
                }
            }
        }
    }
}
