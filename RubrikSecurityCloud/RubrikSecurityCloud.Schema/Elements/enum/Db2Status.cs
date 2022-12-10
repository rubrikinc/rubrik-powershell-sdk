// Db2Status.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:12.
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
    public enum Db2Status
    {
        [EnumMember(Value = "ERROR")]
        ERROR,

        [EnumMember(Value = "OK")]
        OK,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "WARNING")]
        WARNING


    } // enum Db2Status

} // namespace Rubrik.SecurityCloud.Types