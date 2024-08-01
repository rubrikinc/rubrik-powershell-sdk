// ActiveDirectoryUserPasswordRecoveryOption.cs
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
    public enum ActiveDirectoryUserPasswordRecoveryOption
    {
        [EnumMember(Value = "ACTIVE_DIRECTORY_USER_PASSWORD_RECOVERY_OPTION_DONT_RESTORE_PASSWORD")]
        ACTIVE_DIRECTORY_USER_PASSWORD_RECOVERY_OPTION_DONT_RESTORE_PASSWORD,

        [EnumMember(Value = "ACTIVE_DIRECTORY_USER_PASSWORD_RECOVERY_OPTION_RESTORE_PASSWORD_FROM_BACKUP_COPY")]
        ACTIVE_DIRECTORY_USER_PASSWORD_RECOVERY_OPTION_RESTORE_PASSWORD_FROM_BACKUP_COPY,

        [EnumMember(Value = "ACTIVE_DIRECTORY_USER_PASSWORD_RECOVERY_OPTION_RETAIN_RECYCLE_BIN_PASSWORD")]
        ACTIVE_DIRECTORY_USER_PASSWORD_RECOVERY_OPTION_RETAIN_RECYCLE_BIN_PASSWORD,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ActiveDirectoryUserPasswordRecoveryOption

} // namespace RubrikSecurityCloud.Types