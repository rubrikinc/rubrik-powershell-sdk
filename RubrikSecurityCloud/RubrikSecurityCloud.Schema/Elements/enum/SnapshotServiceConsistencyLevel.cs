// SnapshotServiceConsistencyLevel.cs
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
    public enum SnapshotServiceConsistencyLevel
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AMI_BASED")]
        AMI_BASED,

        [EnumMember(Value = "CRASH_CONSISTENT")]
        CRASH_CONSISTENT


    } // enum SnapshotServiceConsistencyLevel

} // namespace RubrikSecurityCloud.Types