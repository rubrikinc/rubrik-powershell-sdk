// AppAuthStatus.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:56.
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
    public enum AppAuthStatus
    {
        [EnumMember(Value = "FULLY_AUTHENTICATED")]
        FULLY_AUTHENTICATED,

        [EnumMember(Value = "PARTIALLY_AUTHENTICATED")]
        PARTIALLY_AUTHENTICATED,

        [EnumMember(Value = "UNAUTHENTICATED")]
        UNAUTHENTICATED


    } // enum AppAuthStatus

} // namespace Rubrik.SecurityCloud.Types