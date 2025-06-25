using System.Collections;

namespace OfType
{
    public class OfType : IOfType
    {
        public IEnumerable<T> GetOfType<T>(IEnumerable enumerable)
        {
            return enumerable.OfType<T>();
        }

        public IEnumerable<TOutput> GetOfType<TSource, TOutput>(IEnumerable<TSource> enumerable)
        {
            return GetOfType<TOutput>(enumerable);
        }

        public IEnumerable<TBase> OfBase<TBase, TDerived>(IEnumerable<TDerived> derivedItems) where TDerived : TBase
        {
            return derivedItems.Where(item => item != null && item.GetType() == typeof(TBase)).Cast<TBase>();
        }
    }
}
