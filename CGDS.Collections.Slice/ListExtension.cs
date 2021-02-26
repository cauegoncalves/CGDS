using System;
using System.Collections.Generic;

namespace CGDS.Collections.Slice
{
    public static class ListExtension
    {

        /// <summary>
        /// Slices the list in multiple lists of a determined size.
        /// </summary>
        /// <typeparam name="T">Type of the list.</typeparam>
        /// <param name="list">The list.</param>
        /// <param name="sliceSize">Maximum size of each slice.</param>
        /// <returns></returns>
        public static IEnumerable<List<T>> Slice<T>(this List<T> list, int sliceSize)
        {
            for (int i = 0; i < list.Count; i += sliceSize)
                yield return list.GetRange(i, Math.Min(sliceSize, list.Count - i));
        }

    }

}