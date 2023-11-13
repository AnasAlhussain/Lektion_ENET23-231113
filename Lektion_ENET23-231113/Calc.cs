using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion_ENET23_231113
{
    class MyClass
    {
        
    }
    internal class Calc
    {
        

        

        [Key]
        public int ID { get;set; }
        [Required]
        public string Name { get; set; }

        [Obsolete("Dont Use this method ...... Old Method",true)]
        public static int Add(int num1,int num2)
        {
            return num1 + num2;
        }

        [Obsolete("Dont Use this method ...... Old Method",true)]
       
        public static int Add(int nu1,int num2,int nu3)
        {
            return nu1 + num2 + nu3;
        }


        public static int Add(List<int> Numbers)
        {
            int total = 0;
            foreach (int item in Numbers)
            {
                total = total + item;
            }
            return total;
        }
    }
}
