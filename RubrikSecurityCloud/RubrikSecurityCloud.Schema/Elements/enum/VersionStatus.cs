// VersionStatus.cs
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

namespace Rubrik.SecurityCloud.Types
{
    public enum VersionStatus
    {
        [EnumMember(Value = "STABLE")]
        STABLE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "UPGRADE_RECOMMENDED")]
        UPGRADE_RECOMMENDED


    } // enum VersionStatus

} // namespace Rubrik.SecurityCloud.Types