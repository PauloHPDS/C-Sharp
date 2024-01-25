using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_Explorando.models
{
    public static class IntExtensions
    {
        public static bool EPar(this int n)
        {
            return n %2==0;
        }
    }
}