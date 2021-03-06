﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Returns an empty sequence that has the specified type argument.
        /// </summary>
        /// <returns>An empty sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IList<TResult> EmptyF<TResult>()
        {
            return Array.Empty<TResult>();
        }
        
        /// <summary>
        /// Returns an empty sequence that has the specified type argument.
        /// </summary>
        /// <returns>An empty sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IList<TResult> EmptyF<TResult>(this IList<TResult> _)
        {
            return Array.Empty<TResult>();
        }
    }
}