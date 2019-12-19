﻿using System;
namespace InstaSharper.Helpers
{
    internal static class ByteExtensions
    {
        private const int VariantIndexPosition = 8;
        private const int VariantMask = 0x3f;
        private const int VariantBits = 0x80;
        private const int VersionIndexPosition = 7;
        private const int VersionMask = 0x0f;

        /// <summary>
        /// Sets the first two bits of the 8th (0-based index) byte to binary '10'
        /// </summary>
        /// <param name="array">The array to modify in place</param>
        /// <returns>The modified <paramref name="array"/></returns>
        public static byte[] AddVariantMarker(this byte[] array)
        {
            array[VariantIndexPosition] &= VariantMask;
            array[VariantIndexPosition] |= VariantBits;
            return array;
        }

        /// <summary>
        /// Sets the 4 most significant bits of 7th (0-based index) byte to the version number
        /// </summary>
        /// <param name="array">The array to modify in place</param>
        /// <param name="version">The UUID version</param>
        /// <returns>The modified <paramref name="array"/></returns>
        public static byte[] AddVersionMarker(this byte[] array)
        {
            var versionBits = (byte)0x40;
            array[VersionIndexPosition] &= VersionMask;
            array[VersionIndexPosition] |= versionBits;
            return array;
        }

        public static byte[] TrimTo16Bytes(this byte[] array)
        {
            var result = new byte[16];
            Array.Copy(array, result, 16);
            return result;
        }
    }
}
