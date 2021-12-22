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
    /// Recipient bits of the
    /// libusb_control_setup::bmRequestType "bmRequestType" field in control transfers. Values 4 through 31 are reserved.
    /// </summary>
    [Flags]
    public enum RequestRecipient : byte
    {
        /// <summary>
        /// Device
        /// </summary>
        Device = 0,

        /// <summary>
        /// Interface
        /// </summary>
        Interface = 0x1,

        /// <summary>
        /// Endpoint
        /// </summary>
        Endpoint = 0x2,

        /// <summary>
        /// Other
        /// </summary>
        Other = 0x3,

    }
}
