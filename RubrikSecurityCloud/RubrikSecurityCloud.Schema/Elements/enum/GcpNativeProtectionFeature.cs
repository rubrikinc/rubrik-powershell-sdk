// GcpNativeProtectionFeature.cs
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
    public enum GcpNativeProtectionFeature
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CLOUD_SQL")]
        CLOUD_SQL,

        [EnumMember(Value = "GCE")]
        GCE,

        [EnumMember(Value = "GCP_NATIVE_PROTECTION_FEATURE_NAME_UNSPECIFIED")]
        GCP_NATIVE_PROTECTION_FEATURE_NAME_UNSPECIFIED


    } // enum GcpNativeProtectionFeature

} // namespace RubrikSecurityCloud.Types