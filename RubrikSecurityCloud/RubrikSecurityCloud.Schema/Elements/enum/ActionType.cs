// ActionType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:42.
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
    public enum ActionType
    {
        [EnumMember(Value = "RESUME")]
        RESUME,

        [EnumMember(Value = "ROLLBACK")]
        ROLLBACK,

        [EnumMember(Value = "START")]
        START


    } // enum ActionType

} // namespace Rubrik.SecurityCloud.Types