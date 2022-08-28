using Order.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.BLL.Extensions
{
    public static class AutoMapperExtensions
    {
        public static T MapTo<T>(this object ob)
        {
            return AutoMapperConfig.Instance.Map<T>(ob);
        }

        public static IEnumerable<T> MapTo<T>(this IEnumerable<object> collection)
        {
            foreach (var ob in collection)
            {
                yield return AutoMapperConfig.Instance.Map<T>(ob);
            }
        }
    }
}
