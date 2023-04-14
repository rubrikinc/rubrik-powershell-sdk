// UnlockMethod.cs
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
    public enum UnlockMethod
    {
        [EnumMember(Value = "ADMINISTRATIVE_UNLOCK")]
        ADMINISTRATIVE_UNLOCK,

        [EnumMember(Value = "AUTO_UNLOCK")]
        AUTO_UNLOCK,

        [EnumMember(Value = "SELF_SERVICE")]
        SELF_SERVICE,

        [EnumMember(Value = "SUPPORT_UNLOCK")]
        SUPPORT_UNLOCK,

        [EnumMember(Value = "UNLOCK_METHOD_UNSPECIFIED")]
        UNLOCK_METHOD_UNSPECIFIED


    } // enum UnlockMethod

} // namespace Rubrik.SecurityCloud.Types