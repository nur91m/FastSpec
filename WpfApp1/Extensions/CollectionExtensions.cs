using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecUI.Extensions
{
    public static class Extensions
    {
        public static ObservableCollection<T> Clone<T>(this IList<T> listToClone) where T : ICloneable
        {
            return listToClone.Select(item => (T)item.Clone()).ToObservableCollection();
        }

        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> enumerableList)
        {

            return enumerableList != null ? new ObservableCollection<T>(enumerableList) : null;

        }
    }


}
