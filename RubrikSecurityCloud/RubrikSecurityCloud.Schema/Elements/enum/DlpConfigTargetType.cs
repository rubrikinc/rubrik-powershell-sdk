// DlpConfigTargetType.cs
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
    public enum DlpConfigTargetType
    {
        [EnumMember(Value = "GENERIC_NAS")]
        GENERIC_NAS,

        [EnumMember(Value = "TARGET_TYPE_UNSPECIFIED")]
        TARGET_TYPE_UNSPECIFIED,

        [EnumMember(Value = "VMWARE_VM")]
        VMWARE_VM,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum DlpConfigTargetType

} // namespace RubrikSecurityCloud.Types