// SlaQuerySortByField.cs
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
    public enum SlaQuerySortByField
    {
        [EnumMember(Value = "NAME")]
        NAME,

        [EnumMember(Value = "PAUSED_CLUSTER_COUNT")]
        PAUSED_CLUSTER_COUNT,

        [EnumMember(Value = "PROTECTED_OBJECT_COUNT")]
        PROTECTED_OBJECT_COUNT,

        [EnumMember(Value = "RETENTION")]
        RETENTION,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum SlaQuerySortByField

} // namespace RubrikSecurityCloud.Types