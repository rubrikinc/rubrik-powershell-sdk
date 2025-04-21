// RscUpgradeStatusType.cs
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
    public enum RscUpgradeStatusType
    {
        [EnumMember(Value = "CDM_ONLY_OPERATION")]
        CDM_ONLY_OPERATION,

        [EnumMember(Value = "DISCONNECTED")]
        DISCONNECTED,

        [EnumMember(Value = "DOWNLOADING")]
        DOWNLOADING,

        [EnumMember(Value = "DOWNLOAD_FAILED")]
        DOWNLOAD_FAILED,

        [EnumMember(Value = "INITIALIZING")]
        INITIALIZING,

        [EnumMember(Value = "PRECHECKING")]
        PRECHECKING,

        [EnumMember(Value = "PRECHECK_FAILED")]
        PRECHECK_FAILED,

        [EnumMember(Value = "READY_FOR_DOWNLOAD")]
        READY_FOR_DOWNLOAD,

        [EnumMember(Value = "READY_FOR_UPGRADE")]
        READY_FOR_UPGRADE,

        [EnumMember(Value = "ROLLINGBACK")]
        ROLLINGBACK,

        [EnumMember(Value = "ROLLINGBACK_FAILED")]
        ROLLINGBACK_FAILED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "UPGRADE_FAILED")]
        UPGRADE_FAILED,

        [EnumMember(Value = "UPGRADING")]
        UPGRADING,

        [EnumMember(Value = "WAITING_FOR_OPERATION_TO_START")]
        WAITING_FOR_OPERATION_TO_START


    } // enum RscUpgradeStatusType

} // namespace RubrikSecurityCloud.Types