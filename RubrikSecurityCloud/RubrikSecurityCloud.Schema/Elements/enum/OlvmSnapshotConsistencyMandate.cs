// OlvmSnapshotConsistencyMandate.cs
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
    public enum OlvmSnapshotConsistencyMandate
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "OLVM_SNAPSHOT_CONSISTENCY_MANDATE_APP_CONSISTENT")]
        OLVM_SNAPSHOT_CONSISTENCY_MANDATE_APP_CONSISTENT,

        [EnumMember(Value = "OLVM_SNAPSHOT_CONSISTENCY_MANDATE_AUTOMATIC")]
        OLVM_SNAPSHOT_CONSISTENCY_MANDATE_AUTOMATIC,

        [EnumMember(Value = "OLVM_SNAPSHOT_CONSISTENCY_MANDATE_CRASH_CONSISTENT")]
        OLVM_SNAPSHOT_CONSISTENCY_MANDATE_CRASH_CONSISTENT


    } // enum OlvmSnapshotConsistencyMandate

} // namespace RubrikSecurityCloud.Types