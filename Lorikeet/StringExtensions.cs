using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorikeet
{
    public static class StringExtensions
    {
        public static bool StartWithAny(this string s, IEnumerable<string> items)
        {
            return items.Any(i => s.StartsWith(i));
        }
    }
}
