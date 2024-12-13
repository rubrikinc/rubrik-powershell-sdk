// AdVolumeExportFilterField.cs
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
    public enum AdVolumeExportFilterField
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ACTIVE_DIRECTORY_DOMAIN")]
        ACTIVE_DIRECTORY_DOMAIN,

        [EnumMember(Value = "ACTIVE_DIRECTORY_DOMAIN_CONTROLLER")]
        ACTIVE_DIRECTORY_DOMAIN_CONTROLLER,

        [EnumMember(Value = "CLUSTER_UUID")]
        CLUSTER_UUID,

        [EnumMember(Value = "FILTER_UNSPECIFIED")]
        FILTER_UNSPECIFIED,

        [EnumMember(Value = "IS_ACTIVE")]
        IS_ACTIVE,

        [EnumMember(Value = "IS_USER_VISIBLE")]
        IS_USER_VISIBLE,

        [EnumMember(Value = "SNAPSHOT")]
        SNAPSHOT


    } // enum AdVolumeExportFilterField

} // namespace RubrikSecurityCloud.Types