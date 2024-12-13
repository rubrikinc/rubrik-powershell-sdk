// UpgradeStatus.cs
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
    public enum UpgradeStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "IN_PROGRESS")]
        IN_PROGRESS,

        [EnumMember(Value = "READY_TO_UPGRADE")]
        READY_TO_UPGRADE,

        [EnumMember(Value = "UPGRADE_FAILED")]
        UPGRADE_FAILED,

        [EnumMember(Value = "UPGRADE_SUCCESS")]
        UPGRADE_SUCCESS,

        [EnumMember(Value = "UPGRADE_UNSUPPORTED")]
        UPGRADE_UNSUPPORTED


    } // enum UpgradeStatus

} // namespace RubrikSecurityCloud.Types