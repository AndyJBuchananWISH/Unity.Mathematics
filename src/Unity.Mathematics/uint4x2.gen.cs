// GENERATED CODE
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [System.Serializable]
    public partial struct uint4x2 : System.IEquatable<uint4x2>, IFormattable
    {
        public uint4 c0;
        public uint4 c1;

        /// <summary>uint4x2 zero value.</summary>
        public static readonly uint4x2 zero = new uint4x2(0u, 0u,   0u, 0u,   0u, 0u,   0u, 0u);


        /// <summary>Constructs a uint4x2 matrix from 2 uint4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint4x2(uint4 c0, uint4 c1)
        { 
            this.c0 = c0;
            this.c1 = c1;
        }

        /// <summary>Constructs a uint4x2 matrix from 8 uint values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint4x2(uint m00, uint m01,
                       uint m10, uint m11,
                       uint m20, uint m21,
                       uint m30, uint m31)
        { 
            this.c0 = new uint4(m00, m10, m20, m30);
            this.c1 = new uint4(m01, m11, m21, m31);
        }

        /// <summary>Constructs a uint4x2 matrix constructed from a single uint value by assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint4x2(uint v)
        {
            this.c0 = v;
            this.c1 = v;
        }

        /// <summary>Constructs a uint4x2 matrix from a single bool value by converting it to uint and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint4x2(bool v)
        {
            this.c0 = math.select(new uint4(0u), new uint4(1u), v);
            this.c1 = math.select(new uint4(0u), new uint4(1u), v);
        }

        /// <summary>Constructs a uint4x2 matrix from a bool4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint4x2(bool4x2 v)
        {
            this.c0 = math.select(new uint4(0u), new uint4(1u), v.c0);
            this.c1 = math.select(new uint4(0u), new uint4(1u), v.c1);
        }

        /// <summary>Constructs a uint4x2 matrix from a single int value by converting it to uint and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint4x2(int v)
        {
            this.c0 = (uint4)v;
            this.c1 = (uint4)v;
        }

        /// <summary>Constructs a uint4x2 matrix from a int4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint4x2(int4x2 v)
        {
            this.c0 = (uint4)v.c0;
            this.c1 = (uint4)v.c1;
        }

        /// <summary>Constructs a uint4x2 matrix from a single float value by converting it to uint and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint4x2(float v)
        {
            this.c0 = (uint4)v;
            this.c1 = (uint4)v;
        }

        /// <summary>Constructs a uint4x2 matrix from a float4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint4x2(float4x2 v)
        {
            this.c0 = (uint4)v.c0;
            this.c1 = (uint4)v.c1;
        }

        /// <summary>Constructs a uint4x2 matrix from a single double value by converting it to uint and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint4x2(double v)
        {
            this.c0 = (uint4)v;
            this.c1 = (uint4)v;
        }

        /// <summary>Constructs a uint4x2 matrix from a double4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint4x2(double4x2 v)
        {
            this.c0 = (uint4)v.c0;
            this.c1 = (uint4)v.c1;
        }


        /// <summary>Implicitly converts a single uint value to a uint4x2 matrix by assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint4x2(uint v) { return new uint4x2(v); }

        /// <summary>Explicitly converts a single bool value to a uint4x2 matrix by converting it to uint and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint4x2(bool v) { return new uint4x2(v); }

        /// <summary>Explicitly converts a bool4x2 matrix to a uint4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint4x2(bool4x2 v) { return new uint4x2(v); }

        /// <summary>Explicitly converts a single int value to a uint4x2 matrix by converting it to uint and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint4x2(int v) { return new uint4x2(v); }

        /// <summary>Explicitly converts a int4x2 matrix to a uint4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint4x2(int4x2 v) { return new uint4x2(v); }

        /// <summary>Explicitly converts a single float value to a uint4x2 matrix by converting it to uint and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint4x2(float v) { return new uint4x2(v); }

        /// <summary>Explicitly converts a float4x2 matrix to a uint4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint4x2(float4x2 v) { return new uint4x2(v); }

        /// <summary>Explicitly converts a single double value to a uint4x2 matrix by converting it to uint and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint4x2(double v) { return new uint4x2(v); }

        /// <summary>Explicitly converts a double4x2 matrix to a uint4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint4x2(double4x2 v) { return new uint4x2(v); }



        // mul
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 operator * (uint4x2 lhs, uint4x2 rhs) { return new uint4x2 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 operator * (uint4x2 lhs, uint rhs) { return new uint4x2 (lhs.c0 * rhs, lhs.c1 * rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 operator * (uint lhs, uint4x2 rhs) { return new uint4x2 (lhs * rhs.c0, lhs * rhs.c1); }

        // add
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 operator + (uint4x2 lhs, uint4x2 rhs) { return new uint4x2 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 operator + (uint4x2 lhs, uint rhs) { return new uint4x2 (lhs.c0 + rhs, lhs.c1 + rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 operator + (uint lhs, uint4x2 rhs) { return new uint4x2 (lhs + rhs.c0, lhs + rhs.c1); }

        // sub
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 operator - (uint4x2 lhs, uint4x2 rhs) { return new uint4x2 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 operator - (uint4x2 lhs, uint rhs) { return new uint4x2 (lhs.c0 - rhs, lhs.c1 - rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 operator - (uint lhs, uint4x2 rhs) { return new uint4x2 (lhs - rhs.c0, lhs - rhs.c1); }

        // div
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 operator / (uint4x2 lhs, uint4x2 rhs) { return new uint4x2 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 operator / (uint4x2 lhs, uint rhs) { return new uint4x2 (lhs.c0 / rhs, lhs.c1 / rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 operator / (uint lhs, uint4x2 rhs) { return new uint4x2 (lhs / rhs.c0, lhs / rhs.c1); }

        // mod
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 operator % (uint4x2 lhs, uint4x2 rhs) { return new uint4x2 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 operator % (uint4x2 lhs, uint rhs) { return new uint4x2 (lhs.c0 % rhs, lhs.c1 % rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 operator % (uint lhs, uint4x2 rhs) { return new uint4x2 (lhs % rhs.c0, lhs % rhs.c1); }

        // increment
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 operator ++ (uint4x2 val) { return new uint4x2 (++val.c0, ++val.c1); }


        // decrement
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 operator -- (uint4x2 val) { return new uint4x2 (--val.c0, --val.c1); }


        // smaller 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator < (uint4x2 lhs, uint4x2 rhs) { return new bool4x2 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator < (uint4x2 lhs, uint rhs) { return new bool4x2 (lhs.c0 < rhs, lhs.c1 < rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator < (uint lhs, uint4x2 rhs) { return new bool4x2 (lhs < rhs.c0, lhs < rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator <= (uint4x2 lhs, uint4x2 rhs) { return new bool4x2 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator <= (uint4x2 lhs, uint rhs) { return new bool4x2 (lhs.c0 <= rhs, lhs.c1 <= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator <= (uint lhs, uint4x2 rhs) { return new bool4x2 (lhs <= rhs.c0, lhs <= rhs.c1); }

        // greater 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator > (uint4x2 lhs, uint4x2 rhs) { return new bool4x2 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator > (uint4x2 lhs, uint rhs) { return new bool4x2 (lhs.c0 > rhs, lhs.c1 > rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator > (uint lhs, uint4x2 rhs) { return new bool4x2 (lhs > rhs.c0, lhs > rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator >= (uint4x2 lhs, uint4x2 rhs) { return new bool4x2 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator >= (uint4x2 lhs, uint rhs) { return new bool4x2 (lhs.c0 >= rhs, lhs.c1 >= rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator >= (uint lhs, uint4x2 rhs) { return new bool4x2 (lhs >= rhs.c0, lhs >= rhs.c1); }

        // neg 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 operator - (uint4x2 val) { return new uint4x2 (-val.c0, -val.c1); }


        // plus 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 operator + (uint4x2 val) { return new uint4x2 (+val.c0, +val.c1); }


        // left shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 operator << (uint4x2 lhs, int rhs) { return new uint4x2 (lhs.c0 << rhs, lhs.c1 << rhs); }

        // right shift
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 operator >> (uint4x2 lhs, int rhs) { return new uint4x2 (lhs.c0 >> rhs, lhs.c1 >> rhs); }

        // equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator == (uint4x2 lhs, uint4x2 rhs) { return new bool4x2 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator == (uint4x2 lhs, uint rhs) { return new bool4x2 (lhs.c0 == rhs, lhs.c1 == rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator == (uint lhs, uint4x2 rhs) { return new bool4x2 (lhs == rhs.c0, lhs == rhs.c1); }

        // not equal 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator != (uint4x2 lhs, uint4x2 rhs) { return new bool4x2 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator != (uint4x2 lhs, uint rhs) { return new bool4x2 (lhs.c0 != rhs, lhs.c1 != rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4x2 operator != (uint lhs, uint4x2 rhs) { return new bool4x2 (lhs != rhs.c0, lhs != rhs.c1); }

        // operator ~ 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 operator ~ (uint4x2 val) { return new uint4x2 (~val.c0, ~val.c1); }


        // operator &
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 operator & (uint4x2 lhs, uint4x2 rhs) { return new uint4x2 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 operator & (uint4x2 lhs, uint rhs) { return new uint4x2 (lhs.c0 & rhs, lhs.c1 & rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 operator & (uint lhs, uint4x2 rhs) { return new uint4x2 (lhs & rhs.c0, lhs & rhs.c1); }

        // operator |
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 operator | (uint4x2 lhs, uint4x2 rhs) { return new uint4x2 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 operator | (uint4x2 lhs, uint rhs) { return new uint4x2 (lhs.c0 | rhs, lhs.c1 | rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 operator | (uint lhs, uint4x2 rhs) { return new uint4x2 (lhs | rhs.c0, lhs | rhs.c1); }

        // operator ^
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 operator ^ (uint4x2 lhs, uint4x2 rhs) { return new uint4x2 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 operator ^ (uint4x2 lhs, uint rhs) { return new uint4x2 (lhs.c0 ^ rhs, lhs.c1 ^ rhs); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 operator ^ (uint lhs, uint4x2 rhs) { return new uint4x2 (lhs ^ rhs.c0, lhs ^ rhs.c1); }

        // [int index] 
        unsafe public uint4 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (uint4x2* array = &this) { return ((uint4*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (uint4* array = &c0) { array[index] = value; }
            }
        }

        // Equals 
        public bool Equals(uint4x2 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object o) { return Equals((uint4x2)o); }


        // GetHashCode 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        // ToString 
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("uint4x2({0}, {1},  {2}, {3},  {4}, {5},  {6}, {7})", c0.x, c1.x, c0.y, c1.y, c0.z, c1.z, c0.w, c1.w);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("uint4x2({0}, {1},  {2}, {3},  {4}, {5},  {6}, {7})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider), c0.w.ToString(format, formatProvider), c1.w.ToString(format, formatProvider));
        }

    }

    public static partial class math
    {
        /// <summary>Returns a uint4x2 matrix constructed from 2 uint4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 uint4x2(uint4 c0, uint4 c1) { return new uint4x2(c0, c1); }

        /// <summary>Returns a uint4x2 matrix constructed from from 8 uint values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 uint4x2(uint m00, uint m01,
                                      uint m10, uint m11,
                                      uint m20, uint m21,
                                      uint m30, uint m31)
        {
            return new uint4x2(m00, m01,
                               m10, m11,
                               m20, m21,
                               m30, m31);
        }

        /// <summary>Returns a uint4x2 matrix constructed from a single uint value by assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 uint4x2(uint v) { return new uint4x2(v); }

        /// <summary>Returns a uint4x2 matrix constructed from a single bool value by converting it to uint and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 uint4x2(bool v) { return new uint4x2(v); }

        /// <summary>Return a uint4x2 matrix constructed from a bool4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 uint4x2(bool4x2 v) { return new uint4x2(v); }

        /// <summary>Returns a uint4x2 matrix constructed from a single int value by converting it to uint and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 uint4x2(int v) { return new uint4x2(v); }

        /// <summary>Return a uint4x2 matrix constructed from a int4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 uint4x2(int4x2 v) { return new uint4x2(v); }

        /// <summary>Returns a uint4x2 matrix constructed from a single float value by converting it to uint and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 uint4x2(float v) { return new uint4x2(v); }

        /// <summary>Return a uint4x2 matrix constructed from a float4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 uint4x2(float4x2 v) { return new uint4x2(v); }

        /// <summary>Returns a uint4x2 matrix constructed from a single double value by converting it to uint and assigning it to every entry.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 uint4x2(double v) { return new uint4x2(v); }

        /// <summary>Return a uint4x2 matrix constructed from a double4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4x2 uint4x2(double4x2 v) { return new uint4x2(v); }

        /// <summary>Return the uint2x4 transpose of a uint4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2x4 transpose(uint4x2 v)
        {
            return uint2x4(
                v.c0.x, v.c0.y, v.c0.z, v.c0.w,
                v.c1.x, v.c1.y, v.c1.z, v.c1.w);
        }

        /// <summary>Returns a uint hash code of a uint4x2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(uint4x2 v)
        {
            return csum(v.c0 * uint4(0xA1E92D39u, 0x4583C801u, 0x9536A0F5u, 0xAF816615u) + 
                        v.c1 * uint4(0x9AF8D62Du, 0xE3600729u, 0x5F17300Du, 0x670D6809u)) + 0x7AF32C49u;
        }

        /// <summary>
        /// Returns a uint4 vector hash code of a uint4x2 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 hashwide(uint4x2 v)
        {
            return (v.c0 * uint4(0xAE131389u, 0x5D1B165Bu, 0x87096CD7u, 0x4C7F6DD1u) + 
                    v.c1 * uint4(0x4822A3E9u, 0xAAC3C25Du, 0xD21D0945u, 0x88FCAB2Du)) + 0x614DA60Du;
        }

    }
}
