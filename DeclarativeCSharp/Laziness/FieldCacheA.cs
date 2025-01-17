﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DeclarativeCSharp.Laziness
{
    /// <summary>
    /// Provides lazy initialization experience. Is better than the Lazy class as:
    /// 1) Is a struct
    /// 2) Does not affect record's Equals in a bad way Lazy does
    /// <code>
    /// public int MyProperty => myProperty.GetValue(static @this => @this.SomeComplexMethod(), @this);
    /// public FieldCache int myProperty;
    /// </code>
    /// </summary>
    /// <typeparam name="TThis">
    /// The type of the holder. The holder
    /// is the type inside which you are creating a lazy property. Must be a reference type.
    /// </typeparam>
    /// <typeparam name="T">
    /// The type to store inside
    /// </typeparam>
    public struct FieldCacheA<T> : IEquatable<FieldCacheA<T>>
    {
        private T? value;
        private object? holder;

        /// <summary>
        /// So that when records get compared, this field will not affect the result
        /// </summary>
        public bool Equals(FieldCacheA<T> _)
            => true;

        /// <summary>
        /// So that when records get compared, this field will not affect the result
        /// </summary>
        public override bool Equals(object _)
            => true;

        /// <summary>
        /// So that when records get compared, this field will not affect the result
        /// </summary>
        public override int GetHashCode() => 0;

        [MethodImpl(MethodImplOptions.NoInlining)]
        private T CreateValue<TThis>(Func<TThis, T> factory, TThis @this) where TThis : class
        {
            if (!ReferenceEquals(@this, holder))
                lock (@this)
                {
                    if (!ReferenceEquals(@this, holder))
                    {
                        value = factory(@this);
                        holder = @this;
                    }
                }
            return value!;
        }

        /// <summary>
        /// Return the value, returned by the factory you passed into the constructor. The factory
        /// will never run more than once. The method is thread-safe.
        /// </summary>
        /// <param name="this">
        /// To avoid reallocation, your method must be static (that is, not reading any outside variables from the instance),
        /// and instead of addressing your fields by normal this, pass this argument and address via this one
        /// (see examples on the readme)
        /// </param>
        /// <returns>The value returned by factory</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T GetValue<TThis>(Func<TThis, T> factory, TThis @this) where TThis : class
        {
            if (ReferenceEquals(@this, holder))
                return value!;

            return CreateValue(factory, @this);
        }
    }
}
