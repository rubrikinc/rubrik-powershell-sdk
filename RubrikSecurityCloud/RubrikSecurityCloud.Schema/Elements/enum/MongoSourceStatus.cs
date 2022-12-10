// MongoSourceStatus.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:42.
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
    public enum MongoSourceStatus
    {
        [EnumMember(Value = "ADD_SOURCE_FAILED")]
        ADD_SOURCE_FAILED,

        [EnumMember(Value = "ADD_SOURCE_IN_PROGRESS")]
        ADD_SOURCE_IN_PROGRESS,

        [EnumMember(Value = "ADD_SOURCE_SUCCESSFUL")]
        ADD_SOURCE_SUCCESSFUL,

        [EnumMember(Value = "_UNSUPPORTED")]
        UNSUPPORTED


    } // enum MongoSourceStatus

} // namespace Rubrik.SecurityCloud.Types