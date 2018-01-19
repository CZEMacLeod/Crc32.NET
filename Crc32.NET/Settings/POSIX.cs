using System;
using System.Collections.Generic;
using System.Text;

namespace Force.Crc32.Settings
{
    /// <summary>
    /// Provides the settings for the CRC-32/POSIX algorithm
    /// </summary>
    /// <remarks>Similar to ADCCP algorithm, but uses a different initial value</remarks>
    /// <see cref="ADCCP"/>
    public class POSIX : Base
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
        public override uint Initial { get => 0; }
        /// <summary>
        /// Validation value to use for CRC32
        /// </summary>
        /// <value>0xcbf43926</value>
        public override uint Check { get => 0x765e7680; }
    }
}
