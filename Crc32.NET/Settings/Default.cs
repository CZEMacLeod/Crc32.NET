using System;
using System.Collections.Generic;
using System.Text;

namespace Force.Crc32.Settings
{

    /// <summary>
    /// Provides the settings for the default CRC-32 algorithm
    /// </summary>
    public class Default : Base
    {
        /// <summary>
        /// Poly value to use for CRC32
        /// </summary>
        /// <value>0xedb88320u</value>
        public override uint Poly { get => 0xedb88320u; }
        /// <summary>
        /// Initial value for CRC32
        /// </summary>
        /// <value>0</value>
        public override uint Initial { get => 0;  }
        /// <summary>
        /// Check value to use for CRC32
        /// </summary>
        /// <value>0x2144DF1C</value>
        public override uint Check { get => 0x2144DF1C;  }
    }
}
