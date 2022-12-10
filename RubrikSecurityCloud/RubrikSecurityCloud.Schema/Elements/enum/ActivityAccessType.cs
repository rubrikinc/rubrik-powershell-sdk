// ActivityAccessType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:27.
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
    public enum ActivityAccessType
    {
        [EnumMember(Value = "CREATE_ACTIVITY")]
        CREATE_ACTIVITY,

        [EnumMember(Value = "DELETE_ACTIVITY")]
        DELETE_ACTIVITY,

        [EnumMember(Value = "READ_ACTIVITY")]
        READ_ACTIVITY,

        [EnumMember(Value = "WRITE_ACTIVITY")]
        WRITE_ACTIVITY


    } // enum ActivityAccessType

} // namespace Rubrik.SecurityCloud.Types