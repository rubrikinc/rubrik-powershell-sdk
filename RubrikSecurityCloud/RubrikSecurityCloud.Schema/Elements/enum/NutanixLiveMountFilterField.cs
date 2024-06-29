// NutanixLiveMountFilterField.cs
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
    public enum NutanixLiveMountFilterField
    {
        [EnumMember(Value = "CLUSTER_UUID")]
        CLUSTER_UUID,

        [EnumMember(Value = "FIELD_UNSPECIFIED")]
        FIELD_UNSPECIFIED,

        [EnumMember(Value = "MOUNT_NAME")]
        MOUNT_NAME,

        [EnumMember(Value = "ORG_ID")]
        ORG_ID,

        [EnumMember(Value = "SOURCE_OR_ACTIVE_VM_CDMID")]
        SOURCE_OR_ACTIVE_VM_CDMID,

        [EnumMember(Value = "SOURCE_VM_CDMID")]
        SOURCE_VM_CDMID


    } // enum NutanixLiveMountFilterField

} // namespace RubrikSecurityCloud.Types