using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace BackendApps.DesignPaterns.Composite
{

    interface IPerson
    {
        string Name { get; set; }

    }
    class Employee : IPerson, IEnumerable<IPerson>
    {
        public string Name { get; set; }
        List<IPerson> _subOrdinates = new List<IPerson>();
        public void AddSubIrdinate(IPerson Person)
        {
            _subOrdinates.Add(Person);
        }
        public void RemoveSubIrdinate(IPerson Person)
        {
            _subOrdinates.Remove(Person);
        }
        public IPerson GetSubordinate(int index)
        {
            return _subOrdinates[index];
        }

        public IEnumerator<IPerson> GetEnumerator()
        {
            foreach (var _subOrdinate in _subOrdinates)
            {
                yield return _subOrdinate;
            }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
