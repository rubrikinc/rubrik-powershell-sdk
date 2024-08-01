// JiraProjectTypeKey.cs
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
    public enum JiraProjectTypeKey
    {
        [EnumMember(Value = "BUSINESS")]
        BUSINESS,

        [EnumMember(Value = "PRODUCT_DISCOVERY")]
        PRODUCT_DISCOVERY,

        [EnumMember(Value = "SERVICE_DESK")]
        SERVICE_DESK,

        [EnumMember(Value = "SOFTWARE")]
        SOFTWARE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum JiraProjectTypeKey

} // namespace RubrikSecurityCloud.Types