// AzureAdObjectSearchType.cs
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
    public enum AzureAdObjectSearchType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "APPLICATION_NAME")]
        APPLICATION_NAME,

        [EnumMember(Value = "AUTHENTICATION_CONTEXT_NAME")]
        AUTHENTICATION_CONTEXT_NAME,

        [EnumMember(Value = "AUTHENTICATION_STRENGTH_NAME")]
        AUTHENTICATION_STRENGTH_NAME,

        [EnumMember(Value = "CONDITIONAL_ACCESS_POLICY_NAME")]
        CONDITIONAL_ACCESS_POLICY_NAME,

        [EnumMember(Value = "GROUP_NAME")]
        GROUP_NAME,

        [EnumMember(Value = "GROUP_TYPE")]
        GROUP_TYPE,

        [EnumMember(Value = "NAMED_LOCATION_NAME")]
        NAMED_LOCATION_NAME,

        [EnumMember(Value = "PRINCIPAL_USER_NAME")]
        PRINCIPAL_USER_NAME,

        [EnumMember(Value = "ROLE_NAME")]
        ROLE_NAME,

        [EnumMember(Value = "SERVICE_PRINCIPAL_NAME")]
        SERVICE_PRINCIPAL_NAME,

        [EnumMember(Value = "TERMS_OF_USE_NAME")]
        TERMS_OF_USE_NAME,

        [EnumMember(Value = "USER_NAME")]
        USER_NAME,

        [EnumMember(Value = "USER_TYPE")]
        USER_TYPE


    } // enum AzureAdObjectSearchType

} // namespace RubrikSecurityCloud.Types