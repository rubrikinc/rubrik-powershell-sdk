// AttributedFeatureFlagName.cs
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
    public enum AttributedFeatureFlagName
    {
        [EnumMember(Value = "AZURE_BLOB_LEVEL_IMMUTABILITY_ENABLED")]
        AZURE_BLOB_LEVEL_IMMUTABILITY_ENABLED,

        [EnumMember(Value = "RESTORE_TO_TARGET_VM_ENABLED")]
        RESTORE_TO_TARGET_VM_ENABLED,

        [EnumMember(Value = "ROLLING_UPGRADE")]
        ROLLING_UPGRADE,

        [EnumMember(Value = "SAMPLE_FLAG_WITH_ATTRIBUTES")]
        SAMPLE_FLAG_WITH_ATTRIBUTES,

        [EnumMember(Value = "SONAR_PHASED_ANALYSIS")]
        SONAR_PHASED_ANALYSIS


    } // enum AttributedFeatureFlagName

} // namespace RubrikSecurityCloud.Types