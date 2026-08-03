// LinkedEntityLinkType.cs
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
    public enum LinkedEntityLinkType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "LINK_TYPE_DIRECT")]
        LINK_TYPE_DIRECT,

        [EnumMember(Value = "LINK_TYPE_NESTED")]
        LINK_TYPE_NESTED,

        [EnumMember(Value = "LINK_TYPE_UNSPECIFIED")]
        LINK_TYPE_UNSPECIFIED


    } // enum LinkedEntityLinkType

} // namespace RubrikSecurityCloud.Types