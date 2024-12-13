// AzureAdObjectType.cs
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
    public enum AzureAdObjectType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "APPLICATION")]
        APPLICATION,

        [EnumMember(Value = "APP_ROLE_ASSIGNMENT")]
        APP_ROLE_ASSIGNMENT,

        [EnumMember(Value = "AZURE_AD_OBJECT_TYPE_UNKNOWN")]
        AZURE_AD_OBJECT_TYPE_UNKNOWN,

        [EnumMember(Value = "GROUP")]
        GROUP,

        [EnumMember(Value = "ROLE")]
        ROLE,

        [EnumMember(Value = "SERVICE_PRINCIPAL")]
        SERVICE_PRINCIPAL,

        [EnumMember(Value = "USER")]
        USER


    } // enum AzureAdObjectType

} // namespace RubrikSecurityCloud.Types