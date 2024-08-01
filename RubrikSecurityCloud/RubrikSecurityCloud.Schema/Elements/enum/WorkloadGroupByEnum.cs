// WorkloadGroupByEnum.cs
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
    public enum WorkloadGroupByEnum
    {
        [EnumMember(Value = "GROUP_BY_UNSPECIFIED")]
        GROUP_BY_UNSPECIFIED,

        [EnumMember(Value = "OBJECT_TYPE")]
        OBJECT_TYPE,

        [EnumMember(Value = "PROTECTION_STATUS")]
        PROTECTION_STATUS,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum WorkloadGroupByEnum

} // namespace RubrikSecurityCloud.Types