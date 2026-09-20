// ClusterManagementType.cs
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
    public enum ClusterManagementType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "MANAGEMENT_TYPE_RUBRIK_MANAGED")]
        MANAGEMENT_TYPE_RUBRIK_MANAGED,

        [EnumMember(Value = "MANAGEMENT_TYPE_SELF_MANAGED")]
        MANAGEMENT_TYPE_SELF_MANAGED,

        [EnumMember(Value = "MANAGEMENT_TYPE_UNSPECIFIED")]
        MANAGEMENT_TYPE_UNSPECIFIED


    } // enum ClusterManagementType

} // namespace RubrikSecurityCloud.Types