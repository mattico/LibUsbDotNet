//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright © 2006-2010 Travis Robinson. All rights reserved.
// Copyright © 2011-2018 LibUsbDotNet contributors. All rights reserved.
// 
// website: http://github.com/libusbdotnet/libusbdotnet
// 
// This program is free software; you can redistribute it and/or modify it
// under the terms of the GNU General Public License as published by the
// Free Software Foundation; either version 2 of the License, or 
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful, but 
// WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
// or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License
// for more details.
// 
// You should have received a copy of the GNU General Public License along
// with this program; if not, write to the Free Software Foundation, Inc.,
// 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA. or 
// visit www.gnu.org.
// 
//

using System;

namespace LibUsbDotNet
{
    /// <summary>
    /// Log message levels.
    /// </summary>
    [Flags]
    public enum LogLevel : byte
    {
        /// <summary>
        /// (0) : No messages ever emitted by the library (default)
        /// </summary>
        None = 0,

        /// <summary>
        /// (1) : Error messages are emitted
        /// </summary>
        Error = 0x1,

        /// <summary>
        /// (2) : Warning and error messages are emitted
        /// </summary>
        Warning = 0x2,

        /// <summary>
        /// (3) : Informational, warning and error messages are emitted
        /// </summary>
        Info = 0x3,

        /// <summary>
        /// (4) : All messages are emitted
        /// </summary>
        Debug = 0x4,

    }
}
