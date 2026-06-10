// GitHubAppStatus.cs
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
    public enum GitHubAppStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "INSTALLED")]
        INSTALLED,

        [EnumMember(Value = "MISSING_LATEST_PERMISSIONS")]
        MISSING_LATEST_PERMISSIONS,

        [EnumMember(Value = "NOT_REGISTERED")]
        NOT_REGISTERED,

        [EnumMember(Value = "REGISTERED")]
        REGISTERED


    } // enum GitHubAppStatus

} // namespace RubrikSecurityCloud.Types