// MongoSourceStatus.cs
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
    public enum MongoSourceStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ADD_SOURCE_FAILED")]
        ADD_SOURCE_FAILED,

        [EnumMember(Value = "ADD_SOURCE_IN_PROGRESS")]
        ADD_SOURCE_IN_PROGRESS,

        [EnumMember(Value = "ADD_SOURCE_SUCCESSFUL")]
        ADD_SOURCE_SUCCESSFUL,

        [EnumMember(Value = "DISCOVERY_FAILED")]
        DISCOVERY_FAILED,

        [EnumMember(Value = "_UNSUPPORTED")]
        UNSUPPORTED


    } // enum MongoSourceStatus

} // namespace RubrikSecurityCloud.Types