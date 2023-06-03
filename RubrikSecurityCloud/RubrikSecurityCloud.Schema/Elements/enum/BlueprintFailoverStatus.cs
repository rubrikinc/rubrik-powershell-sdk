// BlueprintFailoverStatus.cs
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
    public enum BlueprintFailoverStatus
    {
        [EnumMember(Value = "FAILED")]
        FAILED,

        [EnumMember(Value = "NOT_EXIST")]
        NOT_EXIST,

        [EnumMember(Value = "SUCCEEDED")]
        SUCCEEDED


    } // enum BlueprintFailoverStatus

} // namespace Rubrik.SecurityCloud.Types