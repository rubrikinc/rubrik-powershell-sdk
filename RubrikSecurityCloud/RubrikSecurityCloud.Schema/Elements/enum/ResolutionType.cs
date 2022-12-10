// ResolutionType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:29.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Rubrik.SecurityCloud.Types
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
        WELL_KNOWN


    } // enum ResolutionType

} // namespace Rubrik.SecurityCloud.Types