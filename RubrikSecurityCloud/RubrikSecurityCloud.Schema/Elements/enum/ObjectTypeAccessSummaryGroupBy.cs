// ObjectTypeAccessSummaryGroupBy.cs
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
    public enum ObjectTypeAccessSummaryGroupBy
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ACCOUNT")]
        ACCOUNT,

        [EnumMember(Value = "GROUP_BY_UNSPECIFIED")]
        GROUP_BY_UNSPECIFIED,

        [EnumMember(Value = "OBJECT_TYPE")]
        OBJECT_TYPE


    } // enum ObjectTypeAccessSummaryGroupBy

} // namespace RubrikSecurityCloud.Types