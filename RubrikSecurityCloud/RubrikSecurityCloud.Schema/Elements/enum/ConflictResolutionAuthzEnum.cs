// ConflictResolutionAuthzEnum.cs
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
    public enum ConflictResolutionAuthzEnum
    {
        [EnumMember(Value = "ALLOW_AUTO_CONFLICT_RESOLUTION")]
        ALLOW_AUTO_CONFLICT_RESOLUTION,

        [EnumMember(Value = "NONE")]
        NONE,

        [EnumMember(Value = "NO_CONFLICT_RESOLUTION")]
        NO_CONFLICT_RESOLUTION


    } // enum ConflictResolutionAuthzEnum

} // namespace RubrikSecurityCloud.Types