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

namespace Rubrik.SecurityCloud.Types
{
    public enum SnapshotSearchError
    {
        [EnumMember(Value = "AccessDenied")]
        ACCESS_DENIED,

        [EnumMember(Value = "NoSnapshotFound")]
        NO_SNAPSHOT_FOUND


    } // enum SnapshotSearchError

} // namespace Rubrik.SecurityCloud.Types