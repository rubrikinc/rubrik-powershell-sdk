// SourceWorkloadActionAfterFailover.cs
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
    public enum SourceWorkloadActionAfterFailover
    {
        [EnumMember(Value = "DELETE")]
        DELETE,

        [EnumMember(Value = "MARK_AS_DEPRECATED")]
        MARK_AS_DEPRECATED,

        [EnumMember(Value = "UNKNOWN_ACTION")]
        UNKNOWN_ACTION,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum SourceWorkloadActionAfterFailover

} // namespace RubrikSecurityCloud.Types