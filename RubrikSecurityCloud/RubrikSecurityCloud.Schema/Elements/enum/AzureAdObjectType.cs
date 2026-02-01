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

        [EnumMember(Value = "ADMINISTRATIVE_UNIT")]
        ADMINISTRATIVE_UNIT,

        [EnumMember(Value = "APPLICATION")]
        APPLICATION,

        [EnumMember(Value = "APP_ROLE_ASSIGNMENT")]
        APP_ROLE_ASSIGNMENT,

        [EnumMember(Value = "ASSIGNMENT_FILTER")]
        ASSIGNMENT_FILTER,

        [EnumMember(Value = "AUTHENTICATION_CONTEXT")]
        AUTHENTICATION_CONTEXT,

        [EnumMember(Value = "AUTHENTICATION_STRENGTH")]
        AUTHENTICATION_STRENGTH,

        [EnumMember(Value = "AZURE_AD_OBJECT_TYPE_UNKNOWN")]
        AZURE_AD_OBJECT_TYPE_UNKNOWN,

        [EnumMember(Value = "BIT_LOCKER_KEY")]
        BIT_LOCKER_KEY,

        [EnumMember(Value = "COMPLIANCE_POLICY")]
        COMPLIANCE_POLICY,

        [EnumMember(Value = "COMPLIANCE_POLICY_ACTION")]
        COMPLIANCE_POLICY_ACTION,

        [EnumMember(Value = "COMPLIANCE_POLICY_ASSIGNMENT")]
        COMPLIANCE_POLICY_ASSIGNMENT,

        [EnumMember(Value = "COMPLIANCE_SCRIPT")]
        COMPLIANCE_SCRIPT,

        [EnumMember(Value = "CONDITIONAL_ACCESS_POLICY")]
        CONDITIONAL_ACCESS_POLICY,

        [EnumMember(Value = "DEVICE")]
        DEVICE,

        [EnumMember(Value = "GROUP")]
        GROUP,

        [EnumMember(Value = "LOCAL_ADMIN_PASSWORD")]
        LOCAL_ADMIN_PASSWORD,

        [EnumMember(Value = "NAMED_LOCATION")]
        NAMED_LOCATION,

        [EnumMember(Value = "NOTIFICATION_TEMPLATE")]
        NOTIFICATION_TEMPLATE,

        [EnumMember(Value = "ROLE")]
        ROLE,

        [EnumMember(Value = "ROLE_ASSIGNMENT")]
        ROLE_ASSIGNMENT,

        [EnumMember(Value = "SERVICE_PRINCIPAL")]
        SERVICE_PRINCIPAL,

        [EnumMember(Value = "TERMS_OF_USE")]
        TERMS_OF_USE,

        [EnumMember(Value = "USER")]
        USER


    } // enum AzureAdObjectType

} // namespace RubrikSecurityCloud.Types