using System;
using System.Collections.Generic;
using System.Text;

namespace Force.Crc32.Settings
{
    /// <summary>
    /// Provides the settings for the CRC-32/ADCCP algorithm
    /// </summary>
    /// <remarks>This is also known as PKZIP, ETHERNET, 802.3</remarks>
    public class ADCCP : Base
    {
        /// <summary>
        /// Poly value to use for CRC32
        /// </summary>
        /// <value>0x04c11db7u</value>
        public override uint Poly { get => 0x04c11db7u; }
        /// <summary>
        /// Initial value for CRC32
        /// </summary>
        /// <value>0xffffffffu</value>
        public override uint Initial { get => 0xffffffffu; }
        /// <summary>
        /// Validation value to use for CRC32
        /// </summary>
        /// <value>0xcbf43926</value>
        public override uint Check { get => 0xcbf43926; }
    }
}
