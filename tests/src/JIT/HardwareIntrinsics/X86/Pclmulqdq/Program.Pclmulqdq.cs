// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;

namespace JIT.HardwareIntrinsics.X86
{
    public static partial class Program
    {
        static Program()
        {
            TestList = new Dictionary<string, Action>() {
                ["CarryLessMultiply.UInt64.0"] = CarryLessMultiplyUInt640,
                ["CarryLessMultiply.UInt64.1"] = CarryLessMultiplyUInt641,
                ["CarryLessMultiply.UInt64.16"] = CarryLessMultiplyUInt6416,
                ["CarryLessMultiply.UInt64.17"] = CarryLessMultiplyUInt6417,
                ["CarryLessMultiply.UInt64.129"] = CarryLessMultiplyUInt64129,
                ["CarryLessMultiply.Int64.0"] = CarryLessMultiplyInt640,
                ["CarryLessMultiply.Int64.1"] = CarryLessMultiplyInt641,
                ["CarryLessMultiply.Int64.16"] = CarryLessMultiplyInt6416,
                ["CarryLessMultiply.Int64.17"] = CarryLessMultiplyInt6417,
                ["CarryLessMultiply.Int64.129"] = CarryLessMultiplyInt64129,
            };
        }
    }
}
