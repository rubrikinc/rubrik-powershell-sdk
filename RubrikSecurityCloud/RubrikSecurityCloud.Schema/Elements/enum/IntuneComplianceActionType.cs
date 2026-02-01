// IntuneComplianceActionType.cs
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
    public enum IntuneComplianceActionType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "INTUNE_COMPLIANCE_ACTION_TYPE_BLOCK")]
        INTUNE_COMPLIANCE_ACTION_TYPE_BLOCK,

        [EnumMember(Value = "INTUNE_COMPLIANCE_ACTION_TYPE_NOTIFICATION")]
        INTUNE_COMPLIANCE_ACTION_TYPE_NOTIFICATION,

        [EnumMember(Value = "INTUNE_COMPLIANCE_ACTION_TYPE_NO_ACTION")]
        INTUNE_COMPLIANCE_ACTION_TYPE_NO_ACTION,

        [EnumMember(Value = "INTUNE_COMPLIANCE_ACTION_TYPE_PUSH_NOTIFICATION")]
        INTUNE_COMPLIANCE_ACTION_TYPE_PUSH_NOTIFICATION,

        [EnumMember(Value = "INTUNE_COMPLIANCE_ACTION_TYPE_REMOTE_LOCK")]
        INTUNE_COMPLIANCE_ACTION_TYPE_REMOTE_LOCK,

        [EnumMember(Value = "INTUNE_COMPLIANCE_ACTION_TYPE_REMOVE_RESOURCE_ACCESS_PROFILES")]
        INTUNE_COMPLIANCE_ACTION_TYPE_REMOVE_RESOURCE_ACCESS_PROFILES,

        [EnumMember(Value = "INTUNE_COMPLIANCE_ACTION_TYPE_RETIRE")]
        INTUNE_COMPLIANCE_ACTION_TYPE_RETIRE,

        [EnumMember(Value = "INTUNE_COMPLIANCE_ACTION_TYPE_UNKNOWN")]
        INTUNE_COMPLIANCE_ACTION_TYPE_UNKNOWN,

        [EnumMember(Value = "INTUNE_COMPLIANCE_ACTION_TYPE_WIPE")]
        INTUNE_COMPLIANCE_ACTION_TYPE_WIPE


    } // enum IntuneComplianceActionType

} // namespace RubrikSecurityCloud.Types