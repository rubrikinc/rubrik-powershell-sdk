// ClusterRaidType.cs
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
    public enum ClusterRaidType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "RAID0")]
        RAI_D0,

        [EnumMember(Value = "RAID1")]
        RAI_D1


    } // enum ClusterRaidType

} // namespace RubrikSecurityCloud.Types