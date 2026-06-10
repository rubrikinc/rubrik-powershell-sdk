// AzureAdPimGroupAccessType.cs
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
    public enum AzureAdPimGroupAccessType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "PIM_GROUP_ACCESS_TYPE_MEMBER")]
        PIM_GROUP_ACCESS_TYPE_MEMBER,

        [EnumMember(Value = "PIM_GROUP_ACCESS_TYPE_OWNER")]
        PIM_GROUP_ACCESS_TYPE_OWNER,

        [EnumMember(Value = "PIM_GROUP_ACCESS_TYPE_UNSPECIFIED")]
        PIM_GROUP_ACCESS_TYPE_UNSPECIFIED


    } // enum AzureAdPimGroupAccessType

} // namespace RubrikSecurityCloud.Types