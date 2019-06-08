// -----------------------------------------------------------------------------------------------
// <copyright company="SolarPlexus IT-strategi AB" file="GuidEx.cs">
//   Copyright (C) 2012 - SolarPlexus IT-strategi AB
// </copyright>
// <summary>
//   GuidEx - Represents a globally unique identifier (GUID). Can create version 5 GUID.
// </summary>
// -----------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace System
{
    /// <summary>
    /// Represents a globally unique identifier (GUID). Can create version 5 GUID.
    /// </summary>
    /// <remarks>
    /// A GUID is a 128-bit integer (16 bytes) that can be used across all computers and networks wherever a unique identifier is required. 
    /// Such an identifier has a very low probability of being duplicated.
    /// 
    /// The version 5 creation is built uppon the RFC4122 GUID definition.
    /// </remarks>
    [StructLayout(LayoutKind.Explicit)]
    public struct GuidEx : IComparable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GuidEx" /> struct.
        /// </summary>
        /// <param name="id">The id.</param>
        public GuidEx(Guid id)
        {
            var bytes = id.ToByteArray();
            var data1 = BitConverter.ToInt32(bytes, 0);
            var data2 = BitConverter.ToInt16(bytes, sizeof(int));
            var data3 = BitConverter.ToInt16(bytes, sizeof(int) + sizeof(short));
            _data4_7 = bytes[15];
            _data4_6 = bytes[14];
            _data4_5 = bytes[13];
            _data4_4 = bytes[12];
            _data4_3 = bytes[11];
            _data4_2 = bytes[10];
            _data4_1 = bytes[9];
            _data4_0 = bytes[8];
            _data3 = data3;
            _data2 = data2;
            _data1 = data1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidEx" /> struct.
        /// </summary>
        /// <param name="bytes">The bytes.</param>
        public GuidEx(byte[] bytes)
        {
            var data1 = BitConverter.ToInt32(bytes, 0);
            var data2 = BitConverter.ToInt16(bytes, sizeof(int));
            var data3 = BitConverter.ToInt16(bytes, sizeof(int) + sizeof(short));
            _data4_7 = bytes[15];
            _data4_6 = bytes[14];
            _data4_5 = bytes[13];
            _data4_4 = bytes[12];
            _data4_3 = bytes[11];
            _data4_2 = bytes[10];
            _data4_1 = bytes[9];
            _data4_0 = bytes[8];
            _data3 = data3;
            _data2 = data2;
            _data1 = data1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidEx" /> struct.
        /// </summary>
        /// <param name="data1">The data1.</param>
        /// <param name="data2">The data2.</param>
        /// <param name="data3">The data3.</param>
        /// <param name="bytes">The bytes.</param>
        public GuidEx(int data1, short data2, short data3, byte[] bytes)
        {
            _data4_7 = bytes[7];
            _data4_6 = bytes[6];
            _data4_5 = bytes[5];
            _data4_4 = bytes[4];
            _data4_3 = bytes[3];
            _data4_2 = bytes[2];
            _data4_1 = bytes[1];
            _data4_0 = bytes[0];
            _data3 = data3;
            _data2 = data2;
            _data1 = data1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidEx" /> struct.
        /// </summary>
        /// <param name="data1">The data1.</param>
        /// <param name="data2">The data2.</param>
        /// <param name="data3">The data3.</param>
        /// <param name="bytes">The bytes.</param>
        public GuidEx(uint data1, ushort data2, ushort data3, byte[] bytes)
        {
            _data4_7 = bytes[7];
            _data4_6 = bytes[6];
            _data4_5 = bytes[5];
            _data4_4 = bytes[4];
            _data4_3 = bytes[3];
            _data4_2 = bytes[2];
            _data4_1 = bytes[1];
            _data4_0 = bytes[0];
            _data3 = (short)data3;
            _data2 = (short)data2;
            _data1 = (int)data1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidEx" /> struct.
        /// </summary>
        /// <param name="data1">The data1.</param>
        /// <param name="data2">The data2.</param>
        /// <param name="data3">The data3.</param>
        /// <param name="byte0">The byte0.</param>
        /// <param name="byte1">The byte1.</param>
        /// <param name="byte2">The byte2.</param>
        /// <param name="byte3">The byte3.</param>
        /// <param name="byte4">The byte4.</param>
        /// <param name="byte5">The byte5.</param>
        /// <param name="byte6">The byte6.</param>
        /// <param name="byte7">The byte7.</param>
        public GuidEx(int data1, short data2, short data3, byte byte0, byte byte1, byte byte2, byte byte3, byte byte4, byte byte5, byte byte6, byte byte7)
        {
            _data4_7 = byte7;
            _data4_6 = byte6;
            _data4_5 = byte5;
            _data4_4 = byte4;
            _data4_3 = byte3;
            _data4_2 = byte2;
            _data4_1 = byte1;
            _data4_0 = byte0;
            _data3 = data3;
            _data2 = data2;
            _data1 = data1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidEx" /> struct.
        /// </summary>
        /// <param name="data1">The data1.</param>
        /// <param name="data2">The data2.</param>
        /// <param name="data3">The data3.</param>
        /// <param name="byte0">The byte0.</param>
        /// <param name="byte1">The byte1.</param>
        /// <param name="byte2">The byte2.</param>
        /// <param name="byte3">The byte3.</param>
        /// <param name="byte4">The byte4.</param>
        /// <param name="byte5">The byte5.</param>
        /// <param name="byte6">The byte6.</param>
        /// <param name="byte7">The byte7.</param>
        public GuidEx(uint data1, ushort data2, ushort data3, byte byte0, byte byte1, byte byte2, byte byte3, byte byte4, byte byte5, byte byte6, byte byte7)
        {
            _data4_7 = byte7;
            _data4_6 = byte6;
            _data4_5 = byte5;
            _data4_4 = byte4;
            _data4_3 = byte3;
            _data4_2 = byte2;
            _data4_1 = byte1;
            _data4_0 = byte0;
            _data3 = (short)data3;
            _data2 = (short)data2;
            _data1 = (int)data1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidEx" /> struct.
        /// </summary>
        /// <param name="s">The s.</param>
        public GuidEx(string s)
        {
            Guid id;
            if (Guid.TryParse(s, out id))
            {
                var bytes = id.ToByteArray();
                var data1 = BitConverter.ToInt32(bytes, 0);
                var data2 = BitConverter.ToInt16(bytes, sizeof(int));
                var data3 = BitConverter.ToInt16(bytes, sizeof(int) + sizeof(short));
                _data4_7 = bytes[15];
                _data4_6 = bytes[14];
                _data4_5 = bytes[13];
                _data4_4 = bytes[12];
                _data4_3 = bytes[11];
                _data4_2 = bytes[10];
                _data4_1 = bytes[9];
                _data4_0 = bytes[8];
                _data3 = data3;
                _data2 = data2;
                _data1 = data1;
            }
            else
            {
                var nameSpaceId = Guid.Parse(NameSpaceUnknown);
                var sha1 = Security.Cryptography.SHA1.Create();
                var bytes = Encoding.Default.GetBytes(s);
                var bs = new List<byte>(nameSpaceId.ToByteArray());
                bs.AddRange(bytes);
                var hash = sha1.ComputeHash(bs.ToArray());
                var data1 = BitConverter.ToInt32(hash, 0);
                var data2 = BitConverter.ToInt16(hash, 4);
                var data3 = (short)((short)(BitConverter.ToInt16(hash, 6) & 0x0FFF) | 0x5000);
                _data4_0 = (byte)((byte)(hash[8] & 0x3F) | 0x80);
                _data4_1 = hash[9];

                _data4_7 = hash[15];
                _data4_6 = hash[14];
                _data4_5 = hash[13];
                _data4_4 = hash[12];
                _data4_3 = hash[11];
                _data4_2 = hash[10];
                _data3 = data3;
                _data2 = data2;
                _data1 = data1;                
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidEx" /> struct.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="nameSpaceId">The name space id.</param>
        public GuidEx(string s, Guid nameSpaceId)
        {
            var sha1 = Security.Cryptography.SHA1.Create();
            var bytes = Encoding.Default.GetBytes(s);
            var bs = new List<byte>(nameSpaceId.ToByteArray());
            bs.AddRange(bytes);
            var hash = sha1.ComputeHash(bs.ToArray());
            var data1 = BitConverter.ToInt32(hash, 0);
            var data2 = BitConverter.ToInt16(hash, 4);
            var data3 = (short)((short)(BitConverter.ToInt16(hash, 6) & 0x0FFF) | 0x5000);
            _data4_0 = (byte)((byte)(hash[8] & 0x3F) | 0x80);
            _data4_1 = hash[9];

            _data4_7 = hash[15];
            _data4_6 = hash[14];
            _data4_5 = hash[13];
            _data4_4 = hash[12];
            _data4_3 = hash[11];
            _data4_2 = hash[10];
            _data3 = data3;
            _data2 = data2;
            _data1 = data1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GuidEx" /> struct.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="nameSpace">The name space.</param>
        public GuidEx(string s, string nameSpace)
        {
            Guid nameSpaceId;
            if (!Guid.TryParse(nameSpace, out nameSpaceId))
            {
                nameSpaceId = new GuidEx(nameSpace, Guid.Parse(NameSpaceKeyName));
            }
            var sha1 = Security.Cryptography.SHA1.Create();
            var bytes = Encoding.Default.GetBytes(s);
            var bs = new List<byte>(nameSpaceId.ToByteArray());
            bs.AddRange(bytes);
            var hash = sha1.ComputeHash(bs.ToArray());
            var data1 = BitConverter.ToInt32(hash, 0);
            var data2 = BitConverter.ToInt16(hash, 4);
            var data3 = (short)((short)(BitConverter.ToInt16(hash, 6) & 0x0FFF) | 0x5000);
            _data4_0 = (byte)((byte)(hash[8] & 0x3F) | 0x80);
            _data4_1 = hash[9];

            _data4_7 = hash[15];
            _data4_6 = hash[14];
            _data4_5 = hash[13];
            _data4_4 = hash[12];
            _data4_3 = hash[11];
            _data4_2 = hash[10];
            _data3 = data3;
            _data2 = data2;
            _data1 = data1;
        }

        /// <summary>
        /// The KeyName name space id.
        /// </summary>
        public const string NameSpaceKeyName = "F5B7F911-BD81-2CA7-AB06-CDF20013530C";

        /// <summary>
        /// The Unknown name space id.
        /// </summary>
        public const string NameSpaceUnknown = "0ABF9483-45B3-21C8-9988-BFA879D16E0F";

        /// <summary>
        /// The fully-qualified domain name name space id as defined in RFC4122, Appendix C.
        /// </summary>
        public const string NameSpaceDns = "6BA7B810-9DAD-11D1-80B4-00C04FD430C8";

        /// <summary>
        /// The Url name space id as defined in RFC4122, Appendix C.
        /// </summary>
        public const string NameSpaceUrl = "6BA7B811-9DAD-11D1-80B4-00C04FD430C8";

        /// <summary>
        /// The ISO OID name space id as defined in RFC4122, Appendix C.
        /// </summary>
        public const string NameSpaceIsoOid = "6BA7B812-9DAD-11D1-80B4-00C04FD430C8";

        /// <summary>
        /// The X.500 DN (in DER or a text output format) name space id as defined in RFC4122, Appendix C.
        /// </summary>
        public const string NameSpaceX500 = "6ba7b814-9dad-11d1-80b4-00c04fd430c8";

        [FieldOffset(0)]
        private readonly int _data1;
        [FieldOffset(4)]
        private readonly short _data2;
        [FieldOffset(6)]
        private readonly short _data3;
        [FieldOffset(8)]
        private readonly byte _data4_0;
        [FieldOffset(9)]
        private readonly byte _data4_1;
        [FieldOffset(10)]
        private readonly byte _data4_2;
        [FieldOffset(11)]
        private readonly byte _data4_3;
        [FieldOffset(12)]
        private readonly byte _data4_4;
        [FieldOffset(13)]
        private readonly byte _data4_5;
        [FieldOffset(14)]
        private readonly byte _data4_6;
        [FieldOffset(15)]
        private readonly byte _data4_7;

        /// <summary>
        /// Gets the version.
        /// </summary>
        /// <value>The version.</value>
        public int Version
        {
            get { return _data3 >> 12; }
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            return ((Guid)this).ToString();
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public string ToString(string format)
        {
            return ((Guid)this).ToString(format);
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <param name="provider">The provider.</param>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public string ToString(string format, IFormatProvider provider)
        {
            return ((Guid)this).ToString(format, provider);
        }

        /// <summary>
        /// Creates a new GUID.
        /// </summary>
        /// <returns>GuidEx.</returns>
        public static GuidEx NewGuid()
        {
            return (GuidEx) Guid.NewGuid();
        }

        /// <summary>
        /// Creates a GUID from the given string using the unknown name space.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>GuidEx.</returns>
        public static GuidEx NewGuid(string s)
        {
            return new GuidEx(s);
        }

        /// <summary>
        /// Creates a GUID from the given string using the given name space.
        /// </summary>
        /// <remarks>
        /// The name space id is calculated from the name space string via the KeyName id.
        /// </remarks>
        /// <param name="s">The s.</param>
        /// <param name="nameSpace">The name space.</param>
        /// <returns>GuidEx.</returns>
        public static GuidEx NewGuid(string s, string nameSpace)
        {
            return new GuidEx(s, nameSpace);
        }

        /// <summary>
        /// Creates a GUID from the given string using the given name space id.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <param name="nameSpaceId">The name space id.</param>
        /// <returns>GuidEx.</returns>
        public static GuidEx NewGuid(string s, Guid nameSpaceId)
        {
            return new GuidEx(s, nameSpaceId);
        }

        /// <summary>
        /// To the byte array.
        /// </summary>
        /// <returns>System.Byte[][].</returns>
        public byte[] ToByteArray()
        {
            return ((Guid) this).ToByteArray();
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        public override int GetHashCode()
        {
            return ((Guid) this).GetHashCode();
        }

        /// <summary>
        /// Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object.
        /// </summary>
        /// <returns>
        /// A value that indicates the relative order of the objects being compared. The return value has these meanings: Value Meaning Less than zero This instance is less than <paramref name="obj"/>. Zero This instance is equal to <paramref name="obj"/>. Greater than zero This instance is greater than <paramref name="obj"/>. 
        /// </returns>
        /// <param name="obj">An object to compare with this instance. </param><exception cref="T:System.ArgumentException"><paramref name="obj"/> is not the same type as this instance. </exception><filterpriority>2</filterpriority>
        public int CompareTo(object obj)
        {
            if (obj is GuidEx || obj is Guid)
            {
                return ((Guid)this).CompareTo((GuidEx)obj);
            }
            throw new ArgumentException("The object must be of type Guid or GuidEx.");
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" /> is equal to this instance.
        /// </summary>
        /// <param name="obj">Another object to compare to.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is GuidEx))
                return ((Guid) this).Equals(obj);
            return ((Guid)this).Equals((GuidEx)obj);
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="GuidEx" /> to <see cref="Guid" />.
        /// </summary>
        /// <param name="ex">The ex.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Guid(GuidEx ex)
        {
            return new Guid(ex._data1, ex._data2, ex._data3, ex._data4_0, ex._data4_1, ex._data4_2, ex._data4_3, ex._data4_4, ex._data4_5,
                            ex._data4_6, ex._data4_7);
        }

        /// <summary>
        /// Performs an explicit conversion from <see cref="System.String" /> to <see cref="GuidEx" />.
        /// </summary>
        /// <param name="ex">The ex.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator GuidEx(string ex)
        {
            return new GuidEx(ex);
        }

        /// <summary>
        /// Performs an explicit conversion from <see cref="Guid" /> to <see cref="GuidEx" />.
        /// </summary>
        /// <param name="ex">The ex.</param>
        /// <returns>The result of the conversion.</returns>
        public static explicit operator GuidEx(Guid ex)
        {
            return new GuidEx(ex);
        }
    }
}