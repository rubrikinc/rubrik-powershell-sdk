// FlexmotionWorkloadType.cs
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
    public enum FlexmotionWorkloadType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "DB2_DATABASE")]
        DB2_DATABASE,

        [EnumMember(Value = "FILESET")]
        FILESET,

        [EnumMember(Value = "MSSQL")]
        MSSQL,

        [EnumMember(Value = "VMWARE_VIRTUAL_MACHINE")]
        VMWARE_VIRTUAL_MACHINE,

        [EnumMember(Value = "VOLUME_GROUP")]
        VOLUME_GROUP,

        [EnumMember(Value = "WORKLOAD_TYPE_UNSPECIFIED")]
        WORKLOAD_TYPE_UNSPECIFIED


    } // enum FlexmotionWorkloadType

} // namespace RubrikSecurityCloud.Types