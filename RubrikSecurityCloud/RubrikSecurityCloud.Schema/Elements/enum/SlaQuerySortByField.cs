// SlaQuerySortByField.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:34.
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
    public enum SlaQuerySortByField
    {
        [EnumMember(Value = "NAME")]
        NAME,

        [EnumMember(Value = "PAUSED_CLUSTER_COUNT")]
        PAUSED_CLUSTER_COUNT,

        [EnumMember(Value = "PROTECTED_OBJECT_COUNT")]
        PROTECTED_OBJECT_COUNT,

        [EnumMember(Value = "RETENTION")]
        RETENTION


    } // enum SlaQuerySortByField

} // namespace Rubrik.SecurityCloud.Types