// NetworkInterfaceType.cs
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
    public enum NetworkInterfaceType
    {
        [EnumMember(Value = "NETWORK_INTERFACE_TYPE_DATA")]
        NETWORK_INTERFACE_TYPE_DATA,

        [EnumMember(Value = "NETWORK_INTERFACE_TYPE_MANAGEMENT")]
        NETWORK_INTERFACE_TYPE_MANAGEMENT,

        [EnumMember(Value = "NETWORK_INTERFACE_TYPE_OTHER")]
        NETWORK_INTERFACE_TYPE_OTHER,

        [EnumMember(Value = "NETWORK_INTERFACE_TYPE_SERVICE")]
        NETWORK_INTERFACE_TYPE_SERVICE


    } // enum NetworkInterfaceType

} // namespace Rubrik.SecurityCloud.Types