// FeatureName.cs
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
    public enum FeatureName
    {
        [EnumMember(Value = "FilesetManagement")]
        FILESET_MANAGEMENT,

        [EnumMember(Value = "MSSQL_MANAGEMENT")]
        MSSQL_MANAGEMENT,

        [EnumMember(Value = "NAS_MANAGEMENT")]
        NAS_MANAGEMENT,

        [EnumMember(Value = "NotSpecified")]
        NOT_SPECIFIED,

        [EnumMember(Value = "ORACLE_MANAGEMENT")]
        ORACLE_MANAGEMENT,

        [EnumMember(Value = "SNAPMIRROR_MANAGEMENT")]
        SNAPMIRROR_MANAGEMENT,

        [EnumMember(Value = "VmwareManagement")]
        VMWARE_MANAGEMENT


    } // enum FeatureName

} // namespace RubrikSecurityCloud.Types