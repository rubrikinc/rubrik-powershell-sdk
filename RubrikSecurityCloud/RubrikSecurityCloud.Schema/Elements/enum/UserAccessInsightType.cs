// UserAccessInsightType.cs
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
    public enum UserAccessInsightType
    {
        [EnumMember(Value = "ACL_CHANGE")]
        ACL_CHANGE,

        [EnumMember(Value = "AD_CHANGE")]
        AD_CHANGE,

        [EnumMember(Value = "CONTENT_CHANGE")]
        CONTENT_CHANGE,

        [EnumMember(Value = "UA_CONTENT_CHANGE")]
        UA_CONTENT_CHANGE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum UserAccessInsightType

} // namespace RubrikSecurityCloud.Types