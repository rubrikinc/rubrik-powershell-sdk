// ActivityCategory.cs
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
    public enum ActivityCategory
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ACTIVITY_CATEGORY_ACL_CHANGE")]
        ACTIVITY_CATEGORY_ACL_CHANGE,

        [EnumMember(Value = "ACTIVITY_CATEGORY_ADDITION")]
        ACTIVITY_CATEGORY_ADDITION,

        [EnumMember(Value = "ACTIVITY_CATEGORY_ATTRIBUTE_CHANGE")]
        ACTIVITY_CATEGORY_ATTRIBUTE_CHANGE,

        [EnumMember(Value = "ACTIVITY_CATEGORY_DELETION")]
        ACTIVITY_CATEGORY_DELETION,

        [EnumMember(Value = "ACTIVITY_CATEGORY_GPO_CHANGE")]
        ACTIVITY_CATEGORY_GPO_CHANGE,

        [EnumMember(Value = "ACTIVITY_CATEGORY_MEMBERSHIP_CHANGE")]
        ACTIVITY_CATEGORY_MEMBERSHIP_CHANGE,

        [EnumMember(Value = "ACTIVITY_CATEGORY_UNSPECIFIED")]
        ACTIVITY_CATEGORY_UNSPECIFIED


    } // enum ActivityCategory

} // namespace RubrikSecurityCloud.Types