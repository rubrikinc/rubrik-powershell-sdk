// SensitiveDataDiscoveryScope.cs
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
    public enum SensitiveDataDiscoveryScope
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "SENSITIVE_DATA_DISCOVERY_SCOPE_AFFECTED_FILES_ONLY")]
        SENSITIVE_DATA_DISCOVERY_SCOPE_AFFECTED_FILES_ONLY,

        [EnumMember(Value = "SENSITIVE_DATA_DISCOVERY_SCOPE_ALL_FILES")]
        SENSITIVE_DATA_DISCOVERY_SCOPE_ALL_FILES


    } // enum SensitiveDataDiscoveryScope

} // namespace RubrikSecurityCloud.Types