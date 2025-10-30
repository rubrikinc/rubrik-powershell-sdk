// RbsUpgradeStatus.cs
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
    public enum RbsUpgradeStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "UPGRADED")]
        UPGRADED,

        [EnumMember(Value = "UPGRADE_PENDING")]
        UPGRADE_PENDING,

        [EnumMember(Value = "UPGRADE_STATUS_UNKNOWN")]
        UPGRADE_STATUS_UNKNOWN


    } // enum RbsUpgradeStatus

} // namespace RubrikSecurityCloud.Types