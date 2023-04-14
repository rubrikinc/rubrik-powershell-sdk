// MosaicStoreConnectionStatus.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
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