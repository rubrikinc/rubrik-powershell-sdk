// AmiType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:11.
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
    public enum AmiType
    {
        [EnumMember(Value = "CREATED_AT_RUNTIME")]
        CREATED_AT_RUNTIME,

        [EnumMember(Value = "EXISTING")]
        EXISTING,

        [EnumMember(Value = "USER_SPECIFIED")]
        USER_SPECIFIED


    } // enum AmiType

} // namespace Rubrik.SecurityCloud.Types