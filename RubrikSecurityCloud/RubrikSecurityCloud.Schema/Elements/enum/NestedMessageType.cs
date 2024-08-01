// NestedMessageType.cs
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
    public enum NestedMessageType
    {
        [EnumMember(Value = "ANNAPURNA_CITATION")]
        ANNAPURNA_CITATION,

        [EnumMember(Value = "CTM_SNAPSHOT_OVERVIEW")]
        CTM_SNAPSHOT_OVERVIEW,

        [EnumMember(Value = "MALWARE")]
        MALWARE,

        [EnumMember(Value = "SONAR_CHART")]
        SONAR_CHART,

        [EnumMember(Value = "TYPE_UNSPECIFIED")]
        TYPE_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum NestedMessageType

} // namespace RubrikSecurityCloud.Types