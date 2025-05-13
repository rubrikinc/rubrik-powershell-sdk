// FeedEntryStatus.cs
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
    public enum FeedEntryStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ACTIVE")]
        ACTIVE,

        [EnumMember(Value = "DELETED")]
        DELETED,

        [EnumMember(Value = "DISABLED_BY_RUBRIK")]
        DISABLED_BY_RUBRIK,

        [EnumMember(Value = "DISABLED_BY_USER")]
        DISABLED_BY_USER


    } // enum FeedEntryStatus

} // namespace RubrikSecurityCloud.Types