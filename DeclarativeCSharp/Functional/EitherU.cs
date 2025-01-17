﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace DeclarativeCSharp.Functional
{
    [StructLayout(LayoutKind.Auto)]
    public struct EitherU2<T1, T2>
    {
        private readonly byte index;

        private readonly T1 field1;
        private readonly T2 field2;

        public TOut Switch<TCapture, TOut>(Func<T1, TCapture, TOut> case1, Func<T2, TCapture, TOut> case2, TCapture capture)
            => index switch
            {
                1 => case1(field1, capture),
                _ => case2(field2, capture)
            };

        public TOut Switch<TOut>(Func<T1, TOut> case1, Func<T2, TOut> case2)
            => index switch
            {
                1 => case1(field1),
                _ => case2(field2)
            };

        public EitherU2(T1 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            field1 = value;
            index = 1;
        }
        public EitherU2(T2 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            field2 = value;
            index = 2;
        }
    }

    [StructLayout(LayoutKind.Auto)]
    public struct EitherU3<T1, T2, T3>
    {
        private readonly byte index;

        private readonly T1 field1;
        private readonly T2 field2;
        private readonly T3 field3;

        public TOut Switch<TCapture, TOut>(Func<T1, TCapture, TOut> case1, Func<T2, TCapture, TOut> case2, Func<T3, TCapture, TOut> case3, TCapture capture)
            => index switch
            {
                1 => case1(field1, capture),
                2 => case2(field2, capture),
                _ => case3(field3, capture)
            };

        public TOut Switch<TOut>(Func<T1, TOut> case1, Func<T2, TOut> case2, Func<T3, TOut> case3)
            => index switch
            {
                1 => case1(field1),
                2 => case2(field2),
                _ => case3(field3)
            };

        public EitherU3(T1 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            field1 = value;
            index = 1;
        }
        public EitherU3(T2 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            field2 = value;
            index = 2;
        }
        public EitherU3(T3 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            field3 = value;
            index = 3;
        }
    }

    [StructLayout(LayoutKind.Auto)]
    public struct EitherU4<T1, T2, T3, T4>
    {
        private readonly byte index;

        private readonly T1 field1;
        private readonly T2 field2;
        private readonly T3 field3;
        private readonly T4 field4;

        public TOut Switch<TCapture, TOut>(Func<T1, TCapture, TOut> case1, Func<T2, TCapture, TOut> case2, Func<T3, TCapture, TOut> case3, Func<T4, TCapture, TOut> case4, TCapture capture)
            => index switch
            {
                1 => case1(field1, capture),
                2 => case2(field2, capture),
                3 => case3(field3, capture),
                _ => case4(field4, capture)
            };

        public TOut Switch<TOut>(Func<T1, TOut> case1, Func<T2, TOut> case2, Func<T3, TOut> case3, Func<T4, TOut> case4)
            => index switch
            {
                1 => case1(field1),
                2 => case2(field2),
                3 => case3(field3),
                _ => case4(field4)
            };

        public EitherU4(T1 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            field1 = value;
            index = 1;
        }
        public EitherU4(T2 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            field2 = value;
            index = 2;
        }
        public EitherU4(T3 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            field3 = value;
            index = 3;
        }
        public EitherU4(T4 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            field4 = value;
            index = 4;
        }
    }

    [StructLayout(LayoutKind.Auto)]
    public struct EitherU5<T1, T2, T3, T4, T5>
    {
        private readonly byte index;

        private readonly T1 field1;
        private readonly T2 field2;
        private readonly T3 field3;
        private readonly T4 field4;
        private readonly T5 field5;

        public TOut Switch<TCapture, TOut>(Func<T1, TCapture, TOut> case1, Func<T2, TCapture, TOut> case2, Func<T3, TCapture, TOut> case3, Func<T4, TCapture, TOut> case4, Func<T5, TCapture, TOut> case5, TCapture capture)
            => index switch
            {
                1 => case1(field1, capture),
                2 => case2(field2, capture),
                3 => case3(field3, capture),
                4 => case4(field4, capture),
                _ => case5(field5, capture)
            };

        public TOut Switch<TOut>(Func<T1, TOut> case1, Func<T2, TOut> case2, Func<T3, TOut> case3, Func<T4, TOut> case4, Func<T5, TOut> case5)
            => index switch
            {
                1 => case1(field1),
                2 => case2(field2),
                3 => case3(field3),
                4 => case4(field4),
                _ => case5(field5)
            };

        public EitherU5(T1 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            field1 = value;
            index = 1;
        }
        public EitherU5(T2 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            field2 = value;
            index = 2;
        }
        public EitherU5(T3 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            field3 = value;
            index = 3;
        }
        public EitherU5(T4 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            field4 = value;
            index = 4;
        }
        public EitherU5(T5 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            field5 = value;
            index = 5;
        }
    }

    [StructLayout(LayoutKind.Auto)]
    public struct EitherU6<T1, T2, T3, T4, T5, T6>
    {
        private readonly byte index;

        private readonly T1 field1;
        private readonly T2 field2;
        private readonly T3 field3;
        private readonly T4 field4;
        private readonly T5 field5;
        private readonly T6 field6;

        public TOut Switch<TCapture, TOut>(Func<T1, TCapture, TOut> case1, Func<T2, TCapture, TOut> case2, Func<T3, TCapture, TOut> case3, Func<T4, TCapture, TOut> case4, Func<T5, TCapture, TOut> case5, Func<T6, TCapture, TOut> case6, TCapture capture)
            => index switch
            {
                1 => case1(field1, capture),
                2 => case2(field2, capture),
                3 => case3(field3, capture),
                4 => case4(field4, capture),
                5 => case5(field5, capture),
                _ => case6(field6, capture)
            };

        public TOut Switch<TOut>(Func<T1, TOut> case1, Func<T2, TOut> case2, Func<T3, TOut> case3, Func<T4, TOut> case4, Func<T5, TOut> case5, Func<T6, TOut> case6)
            => index switch
            {
                1 => case1(field1),
                2 => case2(field2),
                3 => case3(field3),
                4 => case4(field4),
                5 => case5(field5),
                _ => case6(field6)
            };

        public EitherU6(T1 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            field1 = value;
            index = 1;
        }
        public EitherU6(T2 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            field2 = value;
            index = 2;
        }
        public EitherU6(T3 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            field3 = value;
            index = 3;
        }
        public EitherU6(T4 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            field4 = value;
            index = 4;
        }
        public EitherU6(T5 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            field5 = value;
            index = 5;
        }
        public EitherU6(T6 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            field6 = value;
            index = 6;
        }
    }

    [StructLayout(LayoutKind.Auto)]
    public struct EitherU7<T1, T2, T3, T4, T5, T6, T7>
    {
        private readonly byte index;

        private readonly T1 field1;
        private readonly T2 field2;
        private readonly T3 field3;
        private readonly T4 field4;
        private readonly T5 field5;
        private readonly T6 field6;
        private readonly T7 field7;

        public TOut Switch<TCapture, TOut>(Func<T1, TCapture, TOut> case1, Func<T2, TCapture, TOut> case2, Func<T3, TCapture, TOut> case3, Func<T4, TCapture, TOut> case4, Func<T5, TCapture, TOut> case5, Func<T6, TCapture, TOut> case6, Func<T7, TCapture, TOut> case7, TCapture capture)
            => index switch
            {
                1 => case1(field1, capture),
                2 => case2(field2, capture),
                3 => case3(field3, capture),
                4 => case4(field4, capture),
                5 => case5(field5, capture),
                6 => case6(field6, capture),
                _ => case7(field7, capture)
            };

        public TOut Switch<TOut>(Func<T1, TOut> case1, Func<T2, TOut> case2, Func<T3, TOut> case3, Func<T4, TOut> case4, Func<T5, TOut> case5, Func<T6, TOut> case6, Func<T7, TOut> case7)
            => index switch
            {
                1 => case1(field1),
                2 => case2(field2),
                3 => case3(field3),
                4 => case4(field4),
                5 => case5(field5),
                6 => case6(field6),
                _ => case7(field7)
            };

        public EitherU7(T1 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            field1 = value;
            index = 1;
        }
        public EitherU7(T2 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            field2 = value;
            index = 2;
        }
        public EitherU7(T3 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            field3 = value;
            index = 3;
        }
        public EitherU7(T4 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            field4 = value;
            index = 4;
        }
        public EitherU7(T5 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            field5 = value;
            index = 5;
        }
        public EitherU7(T6 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            field6 = value;
            index = 6;
        }
        public EitherU7(T7 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            field7 = value;
            index = 7;
        }
    }

    [StructLayout(LayoutKind.Auto)]
    public struct EitherU8<T1, T2, T3, T4, T5, T6, T7, T8>
    {
        private readonly byte index;

        private readonly T1 field1;
        private readonly T2 field2;
        private readonly T3 field3;
        private readonly T4 field4;
        private readonly T5 field5;
        private readonly T6 field6;
        private readonly T7 field7;
        private readonly T8 field8;

        public TOut Switch<TCapture, TOut>(Func<T1, TCapture, TOut> case1, Func<T2, TCapture, TOut> case2, Func<T3, TCapture, TOut> case3, Func<T4, TCapture, TOut> case4, Func<T5, TCapture, TOut> case5, Func<T6, TCapture, TOut> case6, Func<T7, TCapture, TOut> case7, Func<T8, TCapture, TOut> case8, TCapture capture)
            => index switch
            {
                1 => case1(field1, capture),
                2 => case2(field2, capture),
                3 => case3(field3, capture),
                4 => case4(field4, capture),
                5 => case5(field5, capture),
                6 => case6(field6, capture),
                7 => case7(field7, capture),
                _ => case8(field8, capture)
            };

        public TOut Switch<TOut>(Func<T1, TOut> case1, Func<T2, TOut> case2, Func<T3, TOut> case3, Func<T4, TOut> case4, Func<T5, TOut> case5, Func<T6, TOut> case6, Func<T7, TOut> case7, Func<T8, TOut> case8)
            => index switch
            {
                1 => case1(field1),
                2 => case2(field2),
                3 => case3(field3),
                4 => case4(field4),
                5 => case5(field5),
                6 => case6(field6),
                7 => case7(field7),
                _ => case8(field8)
            };

        public EitherU8(T1 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            field1 = value;
            index = 1;
        }
        public EitherU8(T2 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            field2 = value;
            index = 2;
        }
        public EitherU8(T3 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            field3 = value;
            index = 3;
        }
        public EitherU8(T4 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            field4 = value;
            index = 4;
        }
        public EitherU8(T5 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            field5 = value;
            index = 5;
        }
        public EitherU8(T6 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            field6 = value;
            index = 6;
        }
        public EitherU8(T7 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            field7 = value;
            index = 7;
        }
        public EitherU8(T8 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            field8 = value;
            index = 8;
        }
    }

    [StructLayout(LayoutKind.Auto)]
    public struct EitherU9<T1, T2, T3, T4, T5, T6, T7, T8, T9>
    {
        private readonly byte index;

        private readonly T1 field1;
        private readonly T2 field2;
        private readonly T3 field3;
        private readonly T4 field4;
        private readonly T5 field5;
        private readonly T6 field6;
        private readonly T7 field7;
        private readonly T8 field8;
        private readonly T9 field9;

        public TOut Switch<TCapture, TOut>(Func<T1, TCapture, TOut> case1, Func<T2, TCapture, TOut> case2, Func<T3, TCapture, TOut> case3, Func<T4, TCapture, TOut> case4, Func<T5, TCapture, TOut> case5, Func<T6, TCapture, TOut> case6, Func<T7, TCapture, TOut> case7, Func<T8, TCapture, TOut> case8, Func<T9, TCapture, TOut> case9, TCapture capture)
            => index switch
            {
                1 => case1(field1, capture),
                2 => case2(field2, capture),
                3 => case3(field3, capture),
                4 => case4(field4, capture),
                5 => case5(field5, capture),
                6 => case6(field6, capture),
                7 => case7(field7, capture),
                8 => case8(field8, capture),
                _ => case9(field9, capture)
            };

        public TOut Switch<TOut>(Func<T1, TOut> case1, Func<T2, TOut> case2, Func<T3, TOut> case3, Func<T4, TOut> case4, Func<T5, TOut> case5, Func<T6, TOut> case6, Func<T7, TOut> case7, Func<T8, TOut> case8, Func<T9, TOut> case9)
            => index switch
            {
                1 => case1(field1),
                2 => case2(field2),
                3 => case3(field3),
                4 => case4(field4),
                5 => case5(field5),
                6 => case6(field6),
                7 => case7(field7),
                8 => case8(field8),
                _ => case9(field9)
            };

        public EitherU9(T1 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            field1 = value;
            index = 1;
        }
        public EitherU9(T2 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            field2 = value;
            index = 2;
        }
        public EitherU9(T3 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            field3 = value;
            index = 3;
        }
        public EitherU9(T4 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            field4 = value;
            index = 4;
        }
        public EitherU9(T5 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            field5 = value;
            index = 5;
        }
        public EitherU9(T6 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            field6 = value;
            index = 6;
        }
        public EitherU9(T7 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            field7 = value;
            index = 7;
        }
        public EitherU9(T8 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            field8 = value;
            index = 8;
        }
        public EitherU9(T9 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            field9 = value;
            index = 9;
        }
    }

    [StructLayout(LayoutKind.Auto)]
    public struct EitherU10<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
    {
        private readonly byte index;

        private readonly T1 field1;
        private readonly T2 field2;
        private readonly T3 field3;
        private readonly T4 field4;
        private readonly T5 field5;
        private readonly T6 field6;
        private readonly T7 field7;
        private readonly T8 field8;
        private readonly T9 field9;
        private readonly T10 field10;

        public TOut Switch<TCapture, TOut>(Func<T1, TCapture, TOut> case1, Func<T2, TCapture, TOut> case2, Func<T3, TCapture, TOut> case3, Func<T4, TCapture, TOut> case4, Func<T5, TCapture, TOut> case5, Func<T6, TCapture, TOut> case6, Func<T7, TCapture, TOut> case7, Func<T8, TCapture, TOut> case8, Func<T9, TCapture, TOut> case9, Func<T10, TCapture, TOut> case10, TCapture capture)
            => index switch
            {
                1 => case1(field1, capture),
                2 => case2(field2, capture),
                3 => case3(field3, capture),
                4 => case4(field4, capture),
                5 => case5(field5, capture),
                6 => case6(field6, capture),
                7 => case7(field7, capture),
                8 => case8(field8, capture),
                9 => case9(field9, capture),
                _ => case10(field10, capture)
            };

        public TOut Switch<TOut>(Func<T1, TOut> case1, Func<T2, TOut> case2, Func<T3, TOut> case3, Func<T4, TOut> case4, Func<T5, TOut> case5, Func<T6, TOut> case6, Func<T7, TOut> case7, Func<T8, TOut> case8, Func<T9, TOut> case9, Func<T10, TOut> case10)
            => index switch
            {
                1 => case1(field1),
                2 => case2(field2),
                3 => case3(field3),
                4 => case4(field4),
                5 => case5(field5),
                6 => case6(field6),
                7 => case7(field7),
                8 => case8(field8),
                9 => case9(field9),
                _ => case10(field10)
            };

        public EitherU10(T1 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            field1 = value;
            index = 1;
        }
        public EitherU10(T2 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            field2 = value;
            index = 2;
        }
        public EitherU10(T3 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            field3 = value;
            index = 3;
        }
        public EitherU10(T4 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            field4 = value;
            index = 4;
        }
        public EitherU10(T5 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            field5 = value;
            index = 5;
        }
        public EitherU10(T6 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            field6 = value;
            index = 6;
        }
        public EitherU10(T7 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            field7 = value;
            index = 7;
        }
        public EitherU10(T8 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            field8 = value;
            index = 8;
        }
        public EitherU10(T9 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            field9 = value;
            index = 9;
        }
        public EitherU10(T10 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            field10 = value;
            index = 10;
        }
    }

    [StructLayout(LayoutKind.Auto)]
    public struct EitherU11<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
    {
        private readonly byte index;

        private readonly T1 field1;
        private readonly T2 field2;
        private readonly T3 field3;
        private readonly T4 field4;
        private readonly T5 field5;
        private readonly T6 field6;
        private readonly T7 field7;
        private readonly T8 field8;
        private readonly T9 field9;
        private readonly T10 field10;
        private readonly T11 field11;

        public TOut Switch<TCapture, TOut>(Func<T1, TCapture, TOut> case1, Func<T2, TCapture, TOut> case2, Func<T3, TCapture, TOut> case3, Func<T4, TCapture, TOut> case4, Func<T5, TCapture, TOut> case5, Func<T6, TCapture, TOut> case6, Func<T7, TCapture, TOut> case7, Func<T8, TCapture, TOut> case8, Func<T9, TCapture, TOut> case9, Func<T10, TCapture, TOut> case10, Func<T11, TCapture, TOut> case11, TCapture capture)
            => index switch
            {
                1 => case1(field1, capture),
                2 => case2(field2, capture),
                3 => case3(field3, capture),
                4 => case4(field4, capture),
                5 => case5(field5, capture),
                6 => case6(field6, capture),
                7 => case7(field7, capture),
                8 => case8(field8, capture),
                9 => case9(field9, capture),
                10 => case10(field10, capture),
                _ => case11(field11, capture)
            };

        public TOut Switch<TOut>(Func<T1, TOut> case1, Func<T2, TOut> case2, Func<T3, TOut> case3, Func<T4, TOut> case4, Func<T5, TOut> case5, Func<T6, TOut> case6, Func<T7, TOut> case7, Func<T8, TOut> case8, Func<T9, TOut> case9, Func<T10, TOut> case10, Func<T11, TOut> case11)
            => index switch
            {
                1 => case1(field1),
                2 => case2(field2),
                3 => case3(field3),
                4 => case4(field4),
                5 => case5(field5),
                6 => case6(field6),
                7 => case7(field7),
                8 => case8(field8),
                9 => case9(field9),
                10 => case10(field10),
                _ => case11(field11)
            };

        public EitherU11(T1 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            field1 = value;
            index = 1;
        }
        public EitherU11(T2 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            field2 = value;
            index = 2;
        }
        public EitherU11(T3 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            field3 = value;
            index = 3;
        }
        public EitherU11(T4 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            field4 = value;
            index = 4;
        }
        public EitherU11(T5 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            field5 = value;
            index = 5;
        }
        public EitherU11(T6 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            field6 = value;
            index = 6;
        }
        public EitherU11(T7 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            field7 = value;
            index = 7;
        }
        public EitherU11(T8 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            field8 = value;
            index = 8;
        }
        public EitherU11(T9 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            field9 = value;
            index = 9;
        }
        public EitherU11(T10 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            field10 = value;
            index = 10;
        }
        public EitherU11(T11 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            field11 = value;
            index = 11;
        }
    }

    [StructLayout(LayoutKind.Auto)]
    public struct EitherU12<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
    {
        private readonly byte index;

        private readonly T1 field1;
        private readonly T2 field2;
        private readonly T3 field3;
        private readonly T4 field4;
        private readonly T5 field5;
        private readonly T6 field6;
        private readonly T7 field7;
        private readonly T8 field8;
        private readonly T9 field9;
        private readonly T10 field10;
        private readonly T11 field11;
        private readonly T12 field12;

        public TOut Switch<TCapture, TOut>(Func<T1, TCapture, TOut> case1, Func<T2, TCapture, TOut> case2, Func<T3, TCapture, TOut> case3, Func<T4, TCapture, TOut> case4, Func<T5, TCapture, TOut> case5, Func<T6, TCapture, TOut> case6, Func<T7, TCapture, TOut> case7, Func<T8, TCapture, TOut> case8, Func<T9, TCapture, TOut> case9, Func<T10, TCapture, TOut> case10, Func<T11, TCapture, TOut> case11, Func<T12, TCapture, TOut> case12, TCapture capture)
            => index switch
            {
                1 => case1(field1, capture),
                2 => case2(field2, capture),
                3 => case3(field3, capture),
                4 => case4(field4, capture),
                5 => case5(field5, capture),
                6 => case6(field6, capture),
                7 => case7(field7, capture),
                8 => case8(field8, capture),
                9 => case9(field9, capture),
                10 => case10(field10, capture),
                11 => case11(field11, capture),
                _ => case12(field12, capture)
            };

        public TOut Switch<TOut>(Func<T1, TOut> case1, Func<T2, TOut> case2, Func<T3, TOut> case3, Func<T4, TOut> case4, Func<T5, TOut> case5, Func<T6, TOut> case6, Func<T7, TOut> case7, Func<T8, TOut> case8, Func<T9, TOut> case9, Func<T10, TOut> case10, Func<T11, TOut> case11, Func<T12, TOut> case12)
            => index switch
            {
                1 => case1(field1),
                2 => case2(field2),
                3 => case3(field3),
                4 => case4(field4),
                5 => case5(field5),
                6 => case6(field6),
                7 => case7(field7),
                8 => case8(field8),
                9 => case9(field9),
                10 => case10(field10),
                11 => case11(field11),
                _ => case12(field12)
            };

        public EitherU12(T1 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            field1 = value;
            index = 1;
        }
        public EitherU12(T2 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            field2 = value;
            index = 2;
        }
        public EitherU12(T3 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            field3 = value;
            index = 3;
        }
        public EitherU12(T4 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            field4 = value;
            index = 4;
        }
        public EitherU12(T5 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            field5 = value;
            index = 5;
        }
        public EitherU12(T6 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            field6 = value;
            index = 6;
        }
        public EitherU12(T7 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            field7 = value;
            index = 7;
        }
        public EitherU12(T8 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            field8 = value;
            index = 8;
        }
        public EitherU12(T9 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            field9 = value;
            index = 9;
        }
        public EitherU12(T10 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            field10 = value;
            index = 10;
        }
        public EitherU12(T11 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            field11 = value;
            index = 11;
        }
        public EitherU12(T12 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            field12 = value;
            index = 12;
        }
    }

    [StructLayout(LayoutKind.Auto)]
    public struct EitherU13<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
    {
        private readonly byte index;

        private readonly T1 field1;
        private readonly T2 field2;
        private readonly T3 field3;
        private readonly T4 field4;
        private readonly T5 field5;
        private readonly T6 field6;
        private readonly T7 field7;
        private readonly T8 field8;
        private readonly T9 field9;
        private readonly T10 field10;
        private readonly T11 field11;
        private readonly T12 field12;
        private readonly T13 field13;

        public TOut Switch<TCapture, TOut>(Func<T1, TCapture, TOut> case1, Func<T2, TCapture, TOut> case2, Func<T3, TCapture, TOut> case3, Func<T4, TCapture, TOut> case4, Func<T5, TCapture, TOut> case5, Func<T6, TCapture, TOut> case6, Func<T7, TCapture, TOut> case7, Func<T8, TCapture, TOut> case8, Func<T9, TCapture, TOut> case9, Func<T10, TCapture, TOut> case10, Func<T11, TCapture, TOut> case11, Func<T12, TCapture, TOut> case12, Func<T13, TCapture, TOut> case13, TCapture capture)
            => index switch
            {
                1 => case1(field1, capture),
                2 => case2(field2, capture),
                3 => case3(field3, capture),
                4 => case4(field4, capture),
                5 => case5(field5, capture),
                6 => case6(field6, capture),
                7 => case7(field7, capture),
                8 => case8(field8, capture),
                9 => case9(field9, capture),
                10 => case10(field10, capture),
                11 => case11(field11, capture),
                12 => case12(field12, capture),
                _ => case13(field13, capture)
            };

        public TOut Switch<TOut>(Func<T1, TOut> case1, Func<T2, TOut> case2, Func<T3, TOut> case3, Func<T4, TOut> case4, Func<T5, TOut> case5, Func<T6, TOut> case6, Func<T7, TOut> case7, Func<T8, TOut> case8, Func<T9, TOut> case9, Func<T10, TOut> case10, Func<T11, TOut> case11, Func<T12, TOut> case12, Func<T13, TOut> case13)
            => index switch
            {
                1 => case1(field1),
                2 => case2(field2),
                3 => case3(field3),
                4 => case4(field4),
                5 => case5(field5),
                6 => case6(field6),
                7 => case7(field7),
                8 => case8(field8),
                9 => case9(field9),
                10 => case10(field10),
                11 => case11(field11),
                12 => case12(field12),
                _ => case13(field13)
            };

        public EitherU13(T1 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            field1 = value;
            index = 1;
        }
        public EitherU13(T2 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            field2 = value;
            index = 2;
        }
        public EitherU13(T3 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            field3 = value;
            index = 3;
        }
        public EitherU13(T4 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            field4 = value;
            index = 4;
        }
        public EitherU13(T5 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            field5 = value;
            index = 5;
        }
        public EitherU13(T6 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            field6 = value;
            index = 6;
        }
        public EitherU13(T7 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            field7 = value;
            index = 7;
        }
        public EitherU13(T8 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            field8 = value;
            index = 8;
        }
        public EitherU13(T9 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            field9 = value;
            index = 9;
        }
        public EitherU13(T10 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            field10 = value;
            index = 10;
        }
        public EitherU13(T11 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            field11 = value;
            index = 11;
        }
        public EitherU13(T12 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            field12 = value;
            index = 12;
        }
        public EitherU13(T13 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            field13 = value;
            index = 13;
        }
    }

    [StructLayout(LayoutKind.Auto)]
    public struct EitherU14<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
    {
        private readonly byte index;

        private readonly T1 field1;
        private readonly T2 field2;
        private readonly T3 field3;
        private readonly T4 field4;
        private readonly T5 field5;
        private readonly T6 field6;
        private readonly T7 field7;
        private readonly T8 field8;
        private readonly T9 field9;
        private readonly T10 field10;
        private readonly T11 field11;
        private readonly T12 field12;
        private readonly T13 field13;
        private readonly T14 field14;

        public TOut Switch<TCapture, TOut>(Func<T1, TCapture, TOut> case1, Func<T2, TCapture, TOut> case2, Func<T3, TCapture, TOut> case3, Func<T4, TCapture, TOut> case4, Func<T5, TCapture, TOut> case5, Func<T6, TCapture, TOut> case6, Func<T7, TCapture, TOut> case7, Func<T8, TCapture, TOut> case8, Func<T9, TCapture, TOut> case9, Func<T10, TCapture, TOut> case10, Func<T11, TCapture, TOut> case11, Func<T12, TCapture, TOut> case12, Func<T13, TCapture, TOut> case13, Func<T14, TCapture, TOut> case14, TCapture capture)
            => index switch
            {
                1 => case1(field1, capture),
                2 => case2(field2, capture),
                3 => case3(field3, capture),
                4 => case4(field4, capture),
                5 => case5(field5, capture),
                6 => case6(field6, capture),
                7 => case7(field7, capture),
                8 => case8(field8, capture),
                9 => case9(field9, capture),
                10 => case10(field10, capture),
                11 => case11(field11, capture),
                12 => case12(field12, capture),
                13 => case13(field13, capture),
                _ => case14(field14, capture)
            };

        public TOut Switch<TOut>(Func<T1, TOut> case1, Func<T2, TOut> case2, Func<T3, TOut> case3, Func<T4, TOut> case4, Func<T5, TOut> case5, Func<T6, TOut> case6, Func<T7, TOut> case7, Func<T8, TOut> case8, Func<T9, TOut> case9, Func<T10, TOut> case10, Func<T11, TOut> case11, Func<T12, TOut> case12, Func<T13, TOut> case13, Func<T14, TOut> case14)
            => index switch
            {
                1 => case1(field1),
                2 => case2(field2),
                3 => case3(field3),
                4 => case4(field4),
                5 => case5(field5),
                6 => case6(field6),
                7 => case7(field7),
                8 => case8(field8),
                9 => case9(field9),
                10 => case10(field10),
                11 => case11(field11),
                12 => case12(field12),
                13 => case13(field13),
                _ => case14(field14)
            };

        public EitherU14(T1 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            field1 = value;
            index = 1;
        }
        public EitherU14(T2 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            field2 = value;
            index = 2;
        }
        public EitherU14(T3 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            field3 = value;
            index = 3;
        }
        public EitherU14(T4 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            field4 = value;
            index = 4;
        }
        public EitherU14(T5 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            field5 = value;
            index = 5;
        }
        public EitherU14(T6 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            field6 = value;
            index = 6;
        }
        public EitherU14(T7 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            field7 = value;
            index = 7;
        }
        public EitherU14(T8 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            field8 = value;
            index = 8;
        }
        public EitherU14(T9 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            field9 = value;
            index = 9;
        }
        public EitherU14(T10 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            field10 = value;
            index = 10;
        }
        public EitherU14(T11 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            field11 = value;
            index = 11;
        }
        public EitherU14(T12 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            field12 = value;
            index = 12;
        }
        public EitherU14(T13 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            field13 = value;
            index = 13;
        }
        public EitherU14(T14 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            field14 = value;
            index = 14;
        }
    }

    [StructLayout(LayoutKind.Auto)]
    public struct EitherU15<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
    {
        private readonly byte index;

        private readonly T1 field1;
        private readonly T2 field2;
        private readonly T3 field3;
        private readonly T4 field4;
        private readonly T5 field5;
        private readonly T6 field6;
        private readonly T7 field7;
        private readonly T8 field8;
        private readonly T9 field9;
        private readonly T10 field10;
        private readonly T11 field11;
        private readonly T12 field12;
        private readonly T13 field13;
        private readonly T14 field14;
        private readonly T15 field15;

        public TOut Switch<TCapture, TOut>(Func<T1, TCapture, TOut> case1, Func<T2, TCapture, TOut> case2, Func<T3, TCapture, TOut> case3, Func<T4, TCapture, TOut> case4, Func<T5, TCapture, TOut> case5, Func<T6, TCapture, TOut> case6, Func<T7, TCapture, TOut> case7, Func<T8, TCapture, TOut> case8, Func<T9, TCapture, TOut> case9, Func<T10, TCapture, TOut> case10, Func<T11, TCapture, TOut> case11, Func<T12, TCapture, TOut> case12, Func<T13, TCapture, TOut> case13, Func<T14, TCapture, TOut> case14, Func<T15, TCapture, TOut> case15, TCapture capture)
            => index switch
            {
                1 => case1(field1, capture),
                2 => case2(field2, capture),
                3 => case3(field3, capture),
                4 => case4(field4, capture),
                5 => case5(field5, capture),
                6 => case6(field6, capture),
                7 => case7(field7, capture),
                8 => case8(field8, capture),
                9 => case9(field9, capture),
                10 => case10(field10, capture),
                11 => case11(field11, capture),
                12 => case12(field12, capture),
                13 => case13(field13, capture),
                14 => case14(field14, capture),
                _ => case15(field15, capture)
            };

        public TOut Switch<TOut>(Func<T1, TOut> case1, Func<T2, TOut> case2, Func<T3, TOut> case3, Func<T4, TOut> case4, Func<T5, TOut> case5, Func<T6, TOut> case6, Func<T7, TOut> case7, Func<T8, TOut> case8, Func<T9, TOut> case9, Func<T10, TOut> case10, Func<T11, TOut> case11, Func<T12, TOut> case12, Func<T13, TOut> case13, Func<T14, TOut> case14, Func<T15, TOut> case15)
            => index switch
            {
                1 => case1(field1),
                2 => case2(field2),
                3 => case3(field3),
                4 => case4(field4),
                5 => case5(field5),
                6 => case6(field6),
                7 => case7(field7),
                8 => case8(field8),
                9 => case9(field9),
                10 => case10(field10),
                11 => case11(field11),
                12 => case12(field12),
                13 => case13(field13),
                14 => case14(field14),
                _ => case15(field15)
            };

        public EitherU15(T1 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            Unsafe.SkipInit(out field15);
            field1 = value;
            index = 1;
        }
        public EitherU15(T2 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            Unsafe.SkipInit(out field15);
            field2 = value;
            index = 2;
        }
        public EitherU15(T3 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            Unsafe.SkipInit(out field15);
            field3 = value;
            index = 3;
        }
        public EitherU15(T4 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            Unsafe.SkipInit(out field15);
            field4 = value;
            index = 4;
        }
        public EitherU15(T5 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            Unsafe.SkipInit(out field15);
            field5 = value;
            index = 5;
        }
        public EitherU15(T6 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            Unsafe.SkipInit(out field15);
            field6 = value;
            index = 6;
        }
        public EitherU15(T7 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            Unsafe.SkipInit(out field15);
            field7 = value;
            index = 7;
        }
        public EitherU15(T8 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            Unsafe.SkipInit(out field15);
            field8 = value;
            index = 8;
        }
        public EitherU15(T9 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            Unsafe.SkipInit(out field15);
            field9 = value;
            index = 9;
        }
        public EitherU15(T10 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            Unsafe.SkipInit(out field15);
            field10 = value;
            index = 10;
        }
        public EitherU15(T11 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            Unsafe.SkipInit(out field15);
            field11 = value;
            index = 11;
        }
        public EitherU15(T12 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            Unsafe.SkipInit(out field15);
            field12 = value;
            index = 12;
        }
        public EitherU15(T13 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            Unsafe.SkipInit(out field15);
            field13 = value;
            index = 13;
        }
        public EitherU15(T14 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            Unsafe.SkipInit(out field15);
            field14 = value;
            index = 14;
        }
        public EitherU15(T15 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            Unsafe.SkipInit(out field15);
            field15 = value;
            index = 15;
        }
    }

    [StructLayout(LayoutKind.Auto)]
    public struct EitherU16<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
    {
        private readonly byte index;

        private readonly T1 field1;
        private readonly T2 field2;
        private readonly T3 field3;
        private readonly T4 field4;
        private readonly T5 field5;
        private readonly T6 field6;
        private readonly T7 field7;
        private readonly T8 field8;
        private readonly T9 field9;
        private readonly T10 field10;
        private readonly T11 field11;
        private readonly T12 field12;
        private readonly T13 field13;
        private readonly T14 field14;
        private readonly T15 field15;
        private readonly T16 field16;

        public TOut Switch<TCapture, TOut>(Func<T1, TCapture, TOut> case1, Func<T2, TCapture, TOut> case2, Func<T3, TCapture, TOut> case3, Func<T4, TCapture, TOut> case4, Func<T5, TCapture, TOut> case5, Func<T6, TCapture, TOut> case6, Func<T7, TCapture, TOut> case7, Func<T8, TCapture, TOut> case8, Func<T9, TCapture, TOut> case9, Func<T10, TCapture, TOut> case10, Func<T11, TCapture, TOut> case11, Func<T12, TCapture, TOut> case12, Func<T13, TCapture, TOut> case13, Func<T14, TCapture, TOut> case14, Func<T15, TCapture, TOut> case15, Func<T16, TCapture, TOut> case16, TCapture capture)
            => index switch
            {
                1 => case1(field1, capture),
                2 => case2(field2, capture),
                3 => case3(field3, capture),
                4 => case4(field4, capture),
                5 => case5(field5, capture),
                6 => case6(field6, capture),
                7 => case7(field7, capture),
                8 => case8(field8, capture),
                9 => case9(field9, capture),
                10 => case10(field10, capture),
                11 => case11(field11, capture),
                12 => case12(field12, capture),
                13 => case13(field13, capture),
                14 => case14(field14, capture),
                15 => case15(field15, capture),
                _ => case16(field16, capture)
            };

        public TOut Switch<TOut>(Func<T1, TOut> case1, Func<T2, TOut> case2, Func<T3, TOut> case3, Func<T4, TOut> case4, Func<T5, TOut> case5, Func<T6, TOut> case6, Func<T7, TOut> case7, Func<T8, TOut> case8, Func<T9, TOut> case9, Func<T10, TOut> case10, Func<T11, TOut> case11, Func<T12, TOut> case12, Func<T13, TOut> case13, Func<T14, TOut> case14, Func<T15, TOut> case15, Func<T16, TOut> case16)
            => index switch
            {
                1 => case1(field1),
                2 => case2(field2),
                3 => case3(field3),
                4 => case4(field4),
                5 => case5(field5),
                6 => case6(field6),
                7 => case7(field7),
                8 => case8(field8),
                9 => case9(field9),
                10 => case10(field10),
                11 => case11(field11),
                12 => case12(field12),
                13 => case13(field13),
                14 => case14(field14),
                15 => case15(field15),
                _ => case16(field16)
            };

        public EitherU16(T1 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            Unsafe.SkipInit(out field15);
            Unsafe.SkipInit(out field16);
            field1 = value;
            index = 1;
        }
        public EitherU16(T2 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            Unsafe.SkipInit(out field15);
            Unsafe.SkipInit(out field16);
            field2 = value;
            index = 2;
        }
        public EitherU16(T3 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            Unsafe.SkipInit(out field15);
            Unsafe.SkipInit(out field16);
            field3 = value;
            index = 3;
        }
        public EitherU16(T4 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            Unsafe.SkipInit(out field15);
            Unsafe.SkipInit(out field16);
            field4 = value;
            index = 4;
        }
        public EitherU16(T5 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            Unsafe.SkipInit(out field15);
            Unsafe.SkipInit(out field16);
            field5 = value;
            index = 5;
        }
        public EitherU16(T6 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            Unsafe.SkipInit(out field15);
            Unsafe.SkipInit(out field16);
            field6 = value;
            index = 6;
        }
        public EitherU16(T7 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            Unsafe.SkipInit(out field15);
            Unsafe.SkipInit(out field16);
            field7 = value;
            index = 7;
        }
        public EitherU16(T8 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            Unsafe.SkipInit(out field15);
            Unsafe.SkipInit(out field16);
            field8 = value;
            index = 8;
        }
        public EitherU16(T9 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            Unsafe.SkipInit(out field15);
            Unsafe.SkipInit(out field16);
            field9 = value;
            index = 9;
        }
        public EitherU16(T10 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            Unsafe.SkipInit(out field15);
            Unsafe.SkipInit(out field16);
            field10 = value;
            index = 10;
        }
        public EitherU16(T11 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            Unsafe.SkipInit(out field15);
            Unsafe.SkipInit(out field16);
            field11 = value;
            index = 11;
        }
        public EitherU16(T12 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            Unsafe.SkipInit(out field15);
            Unsafe.SkipInit(out field16);
            field12 = value;
            index = 12;
        }
        public EitherU16(T13 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            Unsafe.SkipInit(out field15);
            Unsafe.SkipInit(out field16);
            field13 = value;
            index = 13;
        }
        public EitherU16(T14 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            Unsafe.SkipInit(out field15);
            Unsafe.SkipInit(out field16);
            field14 = value;
            index = 14;
        }
        public EitherU16(T15 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            Unsafe.SkipInit(out field15);
            Unsafe.SkipInit(out field16);
            field15 = value;
            index = 15;
        }
        public EitherU16(T16 value)
        {
            Unsafe.SkipInit(out field1);
            Unsafe.SkipInit(out field2);
            Unsafe.SkipInit(out field3);
            Unsafe.SkipInit(out field4);
            Unsafe.SkipInit(out field5);
            Unsafe.SkipInit(out field6);
            Unsafe.SkipInit(out field7);
            Unsafe.SkipInit(out field8);
            Unsafe.SkipInit(out field9);
            Unsafe.SkipInit(out field10);
            Unsafe.SkipInit(out field11);
            Unsafe.SkipInit(out field12);
            Unsafe.SkipInit(out field13);
            Unsafe.SkipInit(out field14);
            Unsafe.SkipInit(out field15);
            Unsafe.SkipInit(out field16);
            field16 = value;
            index = 16;
        }
    }


}
