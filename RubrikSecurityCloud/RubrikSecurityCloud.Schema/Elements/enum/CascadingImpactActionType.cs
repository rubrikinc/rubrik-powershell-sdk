// CascadingImpactActionType.cs
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
    public enum CascadingImpactActionType
    {
        [EnumMember(Value = "ACTION_TYPE_UNKNOWN")]
        ACTION_TYPE_UNKNOWN,

        [EnumMember(Value = "RECREATE")]
        RECREATE,

        [EnumMember(Value = "RELINK")]
        RELINK,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum CascadingImpactActionType

} // namespace RubrikSecurityCloud.Types