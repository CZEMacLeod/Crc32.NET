using System;
using System.Collections.Generic;
using System.Text;

namespace Force.Crc32.Settings
{

    /// <summary>
    /// Stores the Settings used by the generic Crc32Algorithm
    /// </summary>
    public abstract class Base
    {
        /// <summary>
        /// Poly value to use for CRC32
        /// </summary>
        public virtual uint Poly { get; internal set; }
        /// <summary>
        /// Check value to use for CRC32
        /// </summary>
        public virtual uint Check { get; internal set; }
        /// <summary>
        /// Initial value for CRC32
        /// </summary>
        public virtual uint Initial { get; internal set; }

    }
}
