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
    public class Crc32CustomAlgorithm : Crc32AlgorithmBase<Settings.Custom>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Crc32CustomAlgorithm"/> class with the <paramref name="settings"/> provided. 
        /// </summary>
        /// <param name="settings">Settings are copied from this value</param>
        public Crc32CustomAlgorithm(Settings.Base settings)
        {
            Settings = new Settings.Custom(settings);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Crc32CustomAlgorithm"/> class with the settings provided. 
        /// </summary>
        /// <param name="isBigEndian">Should return bytes result as big endian or little endian</param>
        /// <param name="poly">Poly value to use</param>
        /// <param name="check">Check value to use</param>
        /// <param name="init">Initial value to use</param>
        public Crc32CustomAlgorithm(uint poly, uint check, uint init, bool isBigEndian = true) : base(isBigEndian)
        {
            Settings = new Settings.Custom(poly, check, init);
        }
    }
}
