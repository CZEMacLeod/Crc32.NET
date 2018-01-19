using System;
using System.Security.Cryptography;

namespace Force.Crc32
{
    /// <summary>
    /// Implementation of CRC-32C (Castagnoli).
    /// This class supports several convenient static methods returning the CRC as UInt32.
    /// </summary>
    /// <remarks>
    /// Uses Settings.CRC32C to get Castagnoli poly and check values
    /// </remarks>
    public class Crc32CAlgorithm : Crc32Algorithm<Settings.Crc32C>
    {
        // Used for static methods for backwards compatibility
        private static readonly Crc32Algorithm<Settings.Default> _instance;
        static Crc32CAlgorithm()
        {
            _instance = new Crc32Algorithm<Settings.Default>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Crc32CAlgorithm"/> class. 
        /// </summary>
        public Crc32CAlgorithm() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Crc32CAlgorithm"/> class. 
        /// </summary>
        /// <param name="isBigEndian">Should return bytes result as big endian or little endian</param>
        /// <remarks>Crc32 by dariogriffo uses big endian, so, we need to be compatible and return big endian as default</remarks>
        public Crc32CAlgorithm(bool isBigEndian = true) : base(isBigEndian) { }

        /// <inheritdoc />
        new public static uint Append(uint initial, byte[] input, int offset, int length) => _instance.Append(initial, input, offset, length);
        /// <inheritdoc />
        new public static uint Append(uint initial, byte[] input) => _instance.Append(initial, input);
        /// <inheritdoc />
        new public static uint Compute(byte[] input, int offset, int length) => _instance.Compute(input, offset, length);
        /// <inheritdoc />
        new public static uint Compute(byte[] input) => _instance.Compute(input);
        /// <inheritdoc />
        new public static uint ComputeAndWriteToEnd(byte[] input, int offset, int length) => _instance.ComputeAndWriteToEnd(input, offset, length);
        /// <inheritdoc />
        new public static uint ComputeAndWriteToEnd(byte[] input) => _instance.ComputeAndWriteToEnd(input);
        /// <inheritdoc />
        new public static bool IsValidWithCrcAtEnd(byte[] input, int offset, int lengthWithCrc) => _instance.IsValidWithCrcAtEnd(input, offset, lengthWithCrc);
        /// <inheritdoc />
        new public static bool IsValidWithCrcAtEnd(byte[] input) => _instance.IsValidWithCrcAtEnd(input);
    }
}
