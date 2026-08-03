// EntraIdipRangeType.cs
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
    public enum EntraIdipRangeType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "EID_IP_RANGE_TYPE_IPV4_CIDR")]
        EID_IP_RANGE_TYPE_IPV4_CIDR,

        [EnumMember(Value = "EID_IP_RANGE_TYPE_IPV6_CIDR")]
        EID_IP_RANGE_TYPE_IPV6_CIDR,

        [EnumMember(Value = "EID_IP_RANGE_TYPE_UNSPECIFIED")]
        EID_IP_RANGE_TYPE_UNSPECIFIED


    } // enum EntraIdipRangeType

} // namespace RubrikSecurityCloud.Types