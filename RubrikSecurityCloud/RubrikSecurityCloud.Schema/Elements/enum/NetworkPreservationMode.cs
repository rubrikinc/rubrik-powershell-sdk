// NetworkPreservationMode.cs
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

namespace RubrikSecurityCloud.Types
{
    public enum NetworkPreservationMode
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "KEEP_MAC_NO_OS_CONFIG")]
        KEEP_MAC_NO_OS_CONFIG,

        [EnumMember(Value = "KEEP_MAC_OS_CONFIG")]
        KEEP_MAC_OS_CONFIG,

        [EnumMember(Value = "NEW_MAC_NO_OS_CONFIG")]
        NEW_MAC_NO_OS_CONFIG,

        [EnumMember(Value = "NEW_MAC_OS_CONFIG")]
        NEW_MAC_OS_CONFIG,

        [EnumMember(Value = "REMOVE_ALL")]
        REMOVE_ALL


    } // enum NetworkPreservationMode

} // namespace RubrikSecurityCloud.Types