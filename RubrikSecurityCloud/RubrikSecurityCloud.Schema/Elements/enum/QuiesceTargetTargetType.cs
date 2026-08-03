// QuiesceTargetTargetType.cs
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
    public enum QuiesceTargetTargetType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "QUIESCE_TARGET_TARGET_TYPE_RBA_HOST")]
        QUIESCE_TARGET_TARGET_TYPE_RBA_HOST,

        [EnumMember(Value = "QUIESCE_TARGET_TARGET_TYPE_VMWARE_VM")]
        QUIESCE_TARGET_TARGET_TYPE_VMWARE_VM


    } // enum QuiesceTargetTargetType

} // namespace RubrikSecurityCloud.Types