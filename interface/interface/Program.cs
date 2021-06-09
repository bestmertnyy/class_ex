using System;

namespace interface23
{
    class Program
    {
        
        abstract class Class
        {
            public string GName;
            public Class(string gn)
            {
                GName = gn;
            }
        }
        class Group : Class
        {
            public int Number;
            public string Cname;

            public Group(string gn,int n, string c):base(gn)
            {
                Number = n;
                Cname = c;
                
            }
            public void Writenew()
            {
                Console.WriteLine($"Group:{GName} Number:{Number} Cname:{Cname} ");
            }
        }
        class Visiting : Class
        {
            public string Surname;
            public int Pass;
            public int Greason;

            public Visiting(string gn,string s, int p, int gr):base(gn)
            {
                Surname = s;
                Pass = p;
                Greason = gr;
               
            }
            public void Writenew()
            {
                Console.WriteLine($"Group:{GName} Surname:{Surname} Pass:{Pass} Greason:{Greason} ");
            }
            public int Subtract()
            {
                return Pass - Greason;
            }
            public int Subtract1()
            {
                int x;
                x = (Greason * 100) / Pass;
                return 100-x;
            }
        }
            static void Main(string[] args)
            {
                Group group = new Group("PMa-21",4,"Dykyy" );
                Visiting visiting = new Visiting("PMa-21","Shevchuk",4,2);
                Visiting visiting2 = new Visiting("PMa-21", "Bereziak", 3, 2);
                Visiting visiting3 = new Visiting("PMa-21", "Boretska", 5, 2);
                Visiting visiting4 = new Visiting("PMa-21", "Babiy", 1, 1);
           
                int a = visiting.Subtract();
                int b = visiting2.Subtract();
                int d = visiting3.Subtract();
                int f = visiting4.Subtract();
                int a1 = visiting.Subtract1();
                int b1 = visiting2.Subtract1();
                int d1 = visiting3.Subtract1();
                int f1 = visiting4.Subtract1();
                group.Writenew();
                visiting.Writenew();
                visiting2.Writenew();
                visiting3.Writenew();
                visiting4.Writenew();
                Console.WriteLine($"Pass without reason:{a} - {a1}%");
                Console.WriteLine($"Pass without reason:{b} - {b1}%");
                Console.WriteLine($"Pass without reason:{d} - {d1}%");
                Console.WriteLine($"Pass without reason:{f} - {f1}%");
             


        }
        
    }
}