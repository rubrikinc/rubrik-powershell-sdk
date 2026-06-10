// RemediationLocation.cs
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
    public enum RemediationLocation
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "REMEDIATION_LOCATION_ACTIVITY_LOG")]
        REMEDIATION_LOCATION_ACTIVITY_LOG,

        [EnumMember(Value = "REMEDIATION_LOCATION_OBJECT_INVENTORY")]
        REMEDIATION_LOCATION_OBJECT_INVENTORY,

        [EnumMember(Value = "REMEDIATION_LOCATION_UNSPECIFIED")]
        REMEDIATION_LOCATION_UNSPECIFIED,

        [EnumMember(Value = "REMEDIATION_LOCATION_VIOLATION")]
        REMEDIATION_LOCATION_VIOLATION


    } // enum RemediationLocation

} // namespace RubrikSecurityCloud.Types