using System.Collections;

namespace OfType
{
    public class OfType : IOfType
    {
        public IEnumerable<T> GetOfType<T>(IEnumerable enumerable)
        {
            foreach (var item in enumerable)
            {
                if (item is T itemAsT)
                {
                    yield return itemAsT;
                }
            }
        }

        public IEnumerable<TOutput> GetOfType<TSource, TOutput>(IEnumerable<TSource> enumerable)
        {
            return GetOfType<TOutput>(enumerable);
        }

        public IEnumerable<TBase> OfBase<TBase, TDerived>(IEnumerable<TDerived> derivedItems) where TDerived : TBase
        {
            return (IEnumerable<TBase>)derivedItems;
        }
    }
}
