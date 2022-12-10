// HiddenStateFilter.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:03.
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
    public enum HiddenStateFilter
    {
        [EnumMember(Value = "ALL_USERS")]
        ALL_USERS,

        [EnumMember(Value = "HIDDEN")]
        HIDDEN,

        [EnumMember(Value = "NOT_HIDDEN")]
        NOT_HIDDEN


    } // enum HiddenStateFilter

} // namespace Rubrik.SecurityCloud.Types