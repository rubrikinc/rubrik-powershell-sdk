// WorkloadAnomalyCategory.cs
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
    public enum WorkloadAnomalyCategory
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ANOMALY_CATEGORY_UNSPECIFIED")]
        ANOMALY_CATEGORY_UNSPECIFIED,

        [EnumMember(Value = "INFRASTRUCTURE_DELETION")]
        INFRASTRUCTURE_DELETION,

        [EnumMember(Value = "MASS_FILE_DELETION")]
        MASS_FILE_DELETION,

        [EnumMember(Value = "NON_FILESYSTEM")]
        NON_FILESYSTEM,

        [EnumMember(Value = "RANSOMWARE_ENCRYPTION")]
        RANSOMWARE_ENCRYPTION,

        [EnumMember(Value = "UNRECOGNIZED")]
        UNRECOGNIZED


    } // enum WorkloadAnomalyCategory

} // namespace RubrikSecurityCloud.Types