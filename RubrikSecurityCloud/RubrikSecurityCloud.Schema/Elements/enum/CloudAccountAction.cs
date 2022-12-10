// CloudAccountAction.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:26.
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
    public enum CloudAccountAction
    {
        [EnumMember(Value = "CREATE")]
        CREATE,

        [EnumMember(Value = "DELETE")]
        DELETE,

        [EnumMember(Value = "UPDATE_CHILD_ACCOUNTS")]
        UPDATE_CHILD_ACCOUNTS,

        [EnumMember(Value = "UPDATE_PERMISSIONS")]
        UPDATE_PERMISSIONS,

        [EnumMember(Value = "UPDATE_REGIONS")]
        UPDATE_REGIONS


    } // enum CloudAccountAction

} // namespace Rubrik.SecurityCloud.Types