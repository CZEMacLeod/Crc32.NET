using System;
using System.Collections.Generic;
using System.Text;

namespace Force.Crc32.Settings
{
    /// <summary>
    /// Custom settings for the CRC32Algorithm
    /// </summary>
    public class Custom : Base
    {
        /// <summary>
        /// Create custom settings with appropriate values
        /// </summary>
        /// <param name="poly">Poly value to use</param>
        /// <param name="check">Check value to use</param>
        /// <param name="init">Initial value to use</param>
        public Custom(uint poly, uint check, uint init)
        {
            Poly = poly;
            Check = check;
            Initial = init;
        }
        /// <summary>
        /// Create custom settings with values copied from <paramref name="settings"/>
        /// </summary>
        /// <param name="settings">Poly, Check and Initial values are copied to this Settings object</param>
        public Custom(Base settings) : this(settings.Poly, settings.Check, settings.Initial) { }
    }
}
