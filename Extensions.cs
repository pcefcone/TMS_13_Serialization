using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TMS_13_Serialization
{
    public static class Extensions
    {
        public static string ToFormatedString(this Models.Currency currency)
        {
            return string.Format("Name: {0}\nAge: {1}\nCity: {2}", currency.name, currency.age, currency.city);
        }
    }
}
