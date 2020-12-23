using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Katas.BE.BE2
{
    public class UniqueAndOrdered
    {
        public List<Tout> FindUniqueVals<Tin, Tout>(IEnumerable<Tin> values)
        {
            var list = new List<Tout>();
            
            if (values == null)
            {
                return list;
            }

            Tin prevVal = default(Tin);

            foreach (Tin value in values)
            {
                if (IsEqual(value, prevVal))
                {

                }
                else
                {
                    list.Add((Tout)Convert.ChangeType(value, typeof(Tout)));
                    prevVal = value;
                }
            }

            return list;
        }

        static bool IsEqual<T>(T a, T b)
        {
            return object.Equals(a, b);
        }
    }
}
