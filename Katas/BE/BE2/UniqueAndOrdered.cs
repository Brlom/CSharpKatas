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

            IEnumerable<Tin> distinctVals = values.Distinct();

            foreach (Tin value in distinctVals)
            {
                list.Add((Tout)Convert.ChangeType(value, typeof(Tout)));
            }

            return list;
        }
    }
}
