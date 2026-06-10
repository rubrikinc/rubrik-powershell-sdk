// RecoverySortType.cs
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
    public enum RecoverySortType
    {
        [EnumMember(Value = "RECOVERY_NAME")]
        RECOVERY_NAME,

        [EnumMember(Value = "START_TIME")]
        START_TIME,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum RecoverySortType

} // namespace RubrikSecurityCloud.Types