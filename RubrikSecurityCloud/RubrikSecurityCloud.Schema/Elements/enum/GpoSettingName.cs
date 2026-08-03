// GpoSettingName.cs
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
    public enum GpoSettingName
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "GPO_SETTING_NAME_CLEAR_TEXT_PASSWORD")]
        GPO_SETTING_NAME_CLEAR_TEXT_PASSWORD,

        [EnumMember(Value = "GPO_SETTING_NAME_LOCKOUT_BAD_COUNT")]
        GPO_SETTING_NAME_LOCKOUT_BAD_COUNT,

        [EnumMember(Value = "GPO_SETTING_NAME_LOCKOUT_DURATION")]
        GPO_SETTING_NAME_LOCKOUT_DURATION,

        [EnumMember(Value = "GPO_SETTING_NAME_MAXIMUM_PASSWORD_AGE")]
        GPO_SETTING_NAME_MAXIMUM_PASSWORD_AGE,

        [EnumMember(Value = "GPO_SETTING_NAME_MAX_CLOCK_SKEW")]
        GPO_SETTING_NAME_MAX_CLOCK_SKEW,

        [EnumMember(Value = "GPO_SETTING_NAME_MAX_RENEW_AGE")]
        GPO_SETTING_NAME_MAX_RENEW_AGE,

        [EnumMember(Value = "GPO_SETTING_NAME_MAX_SERVICE_AGE")]
        GPO_SETTING_NAME_MAX_SERVICE_AGE,

        [EnumMember(Value = "GPO_SETTING_NAME_MAX_TICKET_AGE")]
        GPO_SETTING_NAME_MAX_TICKET_AGE,

        [EnumMember(Value = "GPO_SETTING_NAME_MINIMUM_PASSWORD_AGE")]
        GPO_SETTING_NAME_MINIMUM_PASSWORD_AGE,

        [EnumMember(Value = "GPO_SETTING_NAME_MINIMUM_PASSWORD_LENGTH")]
        GPO_SETTING_NAME_MINIMUM_PASSWORD_LENGTH,

        [EnumMember(Value = "GPO_SETTING_NAME_NO_LM_HASH")]
        GPO_SETTING_NAME_NO_LM_HASH,

        [EnumMember(Value = "GPO_SETTING_NAME_PASSWORD_COMPLEXITY")]
        GPO_SETTING_NAME_PASSWORD_COMPLEXITY,

        [EnumMember(Value = "GPO_SETTING_NAME_PASSWORD_HISTORY_SIZE")]
        GPO_SETTING_NAME_PASSWORD_HISTORY_SIZE,

        [EnumMember(Value = "GPO_SETTING_NAME_RESET_LOCKOUT_COUNT")]
        GPO_SETTING_NAME_RESET_LOCKOUT_COUNT,

        [EnumMember(Value = "GPO_SETTING_NAME_TICKET_VALIDATE_CLIENT")]
        GPO_SETTING_NAME_TICKET_VALIDATE_CLIENT


    } // enum GpoSettingName

} // namespace RubrikSecurityCloud.Types