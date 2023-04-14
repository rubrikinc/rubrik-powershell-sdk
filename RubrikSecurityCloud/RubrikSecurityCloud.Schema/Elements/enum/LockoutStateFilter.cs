// LockoutStateFilter.cs
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
    public enum LockoutStateFilter
    {
        [EnumMember(Value = "ALL")]
        ALL,

        [EnumMember(Value = "LOCKED")]
        LOCKED,

        [EnumMember(Value = "NOT_LOCKED")]
        NOT_LOCKED


    } // enum LockoutStateFilter

} // namespace Rubrik.SecurityCloud.Types