// AppAuthStatus.cs
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
    public enum AppAuthStatus
    {
        [EnumMember(Value = "FULLY_AUTHENTICATED")]
        FULLY_AUTHENTICATED,

        [EnumMember(Value = "PARTIALLY_AUTHENTICATED")]
        PARTIALLY_AUTHENTICATED,

        [EnumMember(Value = "UNAUTHENTICATED")]
        UNAUTHENTICATED


    } // enum AppAuthStatus

} // namespace RubrikSecurityCloud.Types