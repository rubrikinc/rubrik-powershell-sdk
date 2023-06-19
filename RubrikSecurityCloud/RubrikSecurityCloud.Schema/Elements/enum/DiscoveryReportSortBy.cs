// DiscoveryReportSortBy.cs
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
    public enum DiscoveryReportSortBy
    {
        [EnumMember(Value = "NUM_HIGH_RISK_LOCATIONS")]
        NUM_HIGH_RISK_LOCATIONS,

        [EnumMember(Value = "NUM_OBJECTS")]
        NUM_OBJECTS,

        [EnumMember(Value = "NUM_VIOLATED_FILES")]
        NUM_VIOLATED_FILES,

        [EnumMember(Value = "NUM_VIOLATION")]
        NUM_VIOLATION,

        [EnumMember(Value = "POLICY_NAME")]
        POLICY_NAME,

        [EnumMember(Value = "POLICY_STATUS")]
        POLICY_STATUS


    } // enum DiscoveryReportSortBy

} // namespace RubrikSecurityCloud.Types