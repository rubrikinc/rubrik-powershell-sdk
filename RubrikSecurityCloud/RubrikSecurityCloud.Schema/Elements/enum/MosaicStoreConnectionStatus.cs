// MosaicStoreConnectionStatus.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:24.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Rubrik.SecurityCloud.Types
{
    public enum MosaicStoreConnectionStatus
    {
        [EnumMember(Value = "STATUS_UNAVAILABLE")]
        STATUS_UNAVAILABLE,

        [EnumMember(Value = "STORE_CONNECTED")]
        STORE_CONNECTED,

        [EnumMember(Value = "STORE_DISCONNECTED")]
        STORE_DISCONNECTED


    } // enum MosaicStoreConnectionStatus

} // namespace Rubrik.SecurityCloud.Types