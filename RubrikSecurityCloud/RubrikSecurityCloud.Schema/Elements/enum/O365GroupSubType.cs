// O365GroupSubType.cs
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
    public enum O365GroupSubType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AD_GROUP")]
        AD_GROUP,

        [EnumMember(Value = "SHAREPOINT_CONFIGURED_GROUP")]
        SHAREPOINT_CONFIGURED_GROUP,

        [EnumMember(Value = "SHAREPOINT_TEAMS_CONFIGURED_GROUP")]
        SHAREPOINT_TEAMS_CONFIGURED_GROUP,

        [EnumMember(Value = "TEAMS_CONFIGURED_GROUP")]
        TEAMS_CONFIGURED_GROUP,

        [EnumMember(Value = "UNTYPED_GROUP")]
        UNTYPED_GROUP


    } // enum O365GroupSubType

} // namespace RubrikSecurityCloud.Types