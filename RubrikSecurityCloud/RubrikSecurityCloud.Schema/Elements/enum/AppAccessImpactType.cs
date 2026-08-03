// AppAccessImpactType.cs
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
    public enum AppAccessImpactType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "APP_ACCESS_IMPACT_TYPE_ACCESS_GRANTED")]
        APP_ACCESS_IMPACT_TYPE_ACCESS_GRANTED,

        [EnumMember(Value = "APP_ACCESS_IMPACT_TYPE_ACCESS_REVOKED")]
        APP_ACCESS_IMPACT_TYPE_ACCESS_REVOKED,

        [EnumMember(Value = "APP_ACCESS_IMPACT_TYPE_PATH_ADDED")]
        APP_ACCESS_IMPACT_TYPE_PATH_ADDED,

        [EnumMember(Value = "APP_ACCESS_IMPACT_TYPE_PATH_REMOVED")]
        APP_ACCESS_IMPACT_TYPE_PATH_REMOVED


    } // enum AppAccessImpactType

} // namespace RubrikSecurityCloud.Types