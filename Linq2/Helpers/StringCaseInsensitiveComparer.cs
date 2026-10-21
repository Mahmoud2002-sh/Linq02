using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2.Helpers
{
    public class StringCaseInsensitiveComparer : IEqualityComparer<string>
    {
        public bool Equals(string? x, string? y)
        {
            return string.Equals(x,y,StringComparison.OrdinalIgnoreCase);
        }

        public int GetHashCode(string obj)
        {
            return StringComparer.OrdinalIgnoreCase.GetHashCode(obj);
        }
    }
}
