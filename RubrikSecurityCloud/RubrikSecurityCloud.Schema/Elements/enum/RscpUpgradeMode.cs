// RscpUpgradeMode.cs
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
    public enum RscpUpgradeMode
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "RSCP_UPGRADE_MODE_NORMAL")]
        RSCP_UPGRADE_MODE_NORMAL,

        [EnumMember(Value = "RSCP_UPGRADE_MODE_STAGE")]
        RSCP_UPGRADE_MODE_STAGE,

        [EnumMember(Value = "RSCP_UPGRADE_MODE_UNSPECIFIED")]
        RSCP_UPGRADE_MODE_UNSPECIFIED


    } // enum RscpUpgradeMode

} // namespace RubrikSecurityCloud.Types