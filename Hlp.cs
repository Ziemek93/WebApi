using System.Collections.Generic;
using System.Linq;

namespace WebApi
{
    public static class Hlp
    {
        public static T FirstOrNull<T>(this IEnumerable<T> values) where T : class
        {
            return values.DefaultIfEmpty(null).FirstOrDefault();
        }
    }
}
