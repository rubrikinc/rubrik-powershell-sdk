// CcpJobType.cs
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
    public enum CcpJobType
    {
        [EnumMember(Value = "ADD_NODE")]
        ADD_NODE,

        [EnumMember(Value = "CLUSTER_CREATE")]
        CLUSTER_CREATE,

        [EnumMember(Value = "CLUSTER_DELETE")]
        CLUSTER_DELETE,

        [EnumMember(Value = "CLUSTER_RECOVER")]
        CLUSTER_RECOVER,

        [EnumMember(Value = "REMOVE_NODE")]
        REMOVE_NODE,

        [EnumMember(Value = "REPLACE_NODE")]
        REPLACE_NODE


    } // enum CcpJobType

} // namespace RubrikSecurityCloud.Types