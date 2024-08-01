// ResolutionType.cs
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
    public enum ResolutionType
    {
        [EnumMember(Value = "RESOLVED_AD")]
        RESOLVED_AD,

        [EnumMember(Value = "RESOLVED_ON_HOST")]
        RESOLVED_ON_HOST,

        [EnumMember(Value = "UNRESOLVED")]
        UNRESOLVED,

        [EnumMember(Value = "WELL_KNOWN")]
        WELL_KNOWN,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ResolutionType

} // namespace RubrikSecurityCloud.Types