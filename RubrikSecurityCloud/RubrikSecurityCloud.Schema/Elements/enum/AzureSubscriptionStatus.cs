// AzureSubscriptionStatus.cs
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
    public enum AzureSubscriptionStatus
    {
        [EnumMember(Value = "ADDED")]
        ADDED,

        [EnumMember(Value = "DELETED")]
        DELETED,

        [EnumMember(Value = "DELETING")]
        DELETING,

        [EnumMember(Value = "DELETION_FAILED")]
        DELETION_FAILED,

        [EnumMember(Value = "REFRESHED")]
        REFRESHED,

        [EnumMember(Value = "REFRESHING")]
        REFRESHING,

        [EnumMember(Value = "REFRESH_FAILED")]
        REFRESH_FAILED


    } // enum AzureSubscriptionStatus

} // namespace RubrikSecurityCloud.Types