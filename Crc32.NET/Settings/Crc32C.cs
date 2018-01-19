using System;
using System.Collections.Generic;
using System.Text;

namespace Force.Crc32.Settings
{
    /// <summary>
    /// Provides the settings for the CRC-32C (Castagnoli) algorithm 
    /// </summary>
    public class Crc32C : Base
    {
        /// <summary>
        /// Poly value to use for CRC32
        /// </summary>
        /// <value>0x82F63B78u</value>
        public override uint Poly { get => 0x82F63B78u; }
        /// <summary>
        /// Initial value for CRC32
        /// </summary>
        /// <value>0</value>
        public override uint Initial { get => 0; }
        /// <summary>
        /// Check value to use for CRC32
        /// </summary>
        /// <value>0x48674BC7</value>
        public override uint Check { get => 0x48674BC7; }
    }
}
