using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionFormation
{
    public class Foo
    {
        private int id;
        private int f1;
        private String f2;
        private String f3;

        public int Id { get; set; }
        public int F1 { get; set; }
        public String F2 { get; set; }
        public String F3 { get; set; }

        public Foo()
        {
            f1 = 0;
            f2 = "inconnue";
            f3 = "inconnue";
        }
        public Foo(int F1, String F2, String F3)
        {
            f1 = F1;
            f2 = F2;
            f3 = F3;
        }
    }
}
