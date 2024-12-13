// SnapshotSearchError.cs
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
    public enum SnapshotSearchError
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AccessDenied")]
        ACCESS_DENIED,

        [EnumMember(Value = "NoSnapshotFound")]
        NO_SNAPSHOT_FOUND


    } // enum SnapshotSearchError

} // namespace RubrikSecurityCloud.Types