// IssueEventType.cs
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
    public enum IssueEventType
    {
        [EnumMember(Value = "ADD_WHITELIST_EVENT")]
        ADD_WHITELIST_EVENT,

        [EnumMember(Value = "CREATE_EVENT")]
        CREATE_EVENT,

        [EnumMember(Value = "DELETE_POLICY_EVENT")]
        DELETE_POLICY_EVENT,

        [EnumMember(Value = "NO_ISSUES_SNAPSHOT_EVENT")]
        NO_ISSUES_SNAPSHOT_EVENT,

        [EnumMember(Value = "REMOVE_POLICY_OBJ_EVENT")]
        REMOVE_POLICY_OBJ_EVENT,

        [EnumMember(Value = "REMOVE_WHITELIST_EVENT")]
        REMOVE_WHITELIST_EVENT,

        [EnumMember(Value = "SNAPSHOT_EVENT")]
        SNAPSHOT_EVENT


    } // enum IssueEventType

} // namespace RubrikSecurityCloud.Types