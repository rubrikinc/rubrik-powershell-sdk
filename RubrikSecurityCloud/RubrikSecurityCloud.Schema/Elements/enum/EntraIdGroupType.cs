// EntraIdGroupType.cs
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
    public enum EntraIdGroupType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "EID_GROUP_TYPE_M365")]
        EID_GROUP_TYPE_M365,

        [EnumMember(Value = "EID_GROUP_TYPE_SECURITY")]
        EID_GROUP_TYPE_SECURITY,

        [EnumMember(Value = "EID_GROUP_TYPE_UNKNOWN")]
        EID_GROUP_TYPE_UNKNOWN


    } // enum EntraIdGroupType

} // namespace RubrikSecurityCloud.Types