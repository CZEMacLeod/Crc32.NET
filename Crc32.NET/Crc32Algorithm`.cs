using System;
using System.Security.Cryptography;

namespace Force.Crc32
{
    /// <summary>
    /// Implementation of CRC-32.
    /// This class supports several convenient static methods returning the CRC as UInt32.
    /// </summary>
    /// <typeparam name="TSetting">Settings to use for CRC-32 calculation</typeparam>
    public class Crc32Algorithm<TSetting> : Crc32AlgorithmBase
        where TSetting : Force.Crc32.Settings.Base, new()
    {
        /// <inheritdoc />
        public Crc32Algorithm() {
            Settings = new TSetting();
        }

        /// <inheritdoc />
        public Crc32Algorithm(bool isBigEndian = true) : base(isBigEndian) {
            Settings = new TSetting();
        }
    }
}
