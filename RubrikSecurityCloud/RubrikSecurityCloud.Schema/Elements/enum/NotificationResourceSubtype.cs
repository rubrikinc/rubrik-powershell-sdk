// NotificationResourceSubtype.cs
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
    public enum NotificationResourceSubtype
    {
        [EnumMember(Value = "CROSS_ACCOUNT_CLUSTER")]
        CROSS_ACCOUNT_CLUSTER,

        [EnumMember(Value = "CROSS_ACCOUNT_PAIR")]
        CROSS_ACCOUNT_PAIR,

        [EnumMember(Value = "MSSQL_DISCOVERY")]
        MSSQL_DISCOVERY,

        [EnumMember(Value = "RESOURCE_SUBTYPE_UNSPECIFIED")]
        RESOURCE_SUBTYPE_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum NotificationResourceSubtype

} // namespace RubrikSecurityCloud.Types