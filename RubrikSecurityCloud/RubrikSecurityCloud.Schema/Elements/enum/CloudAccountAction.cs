// CloudAccountAction.cs
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
    public enum CloudAccountAction
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

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

} // namespace RubrikSecurityCloud.Types