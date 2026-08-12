// IcebergSnapshotSelectionStrategy.cs
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
    public enum IcebergSnapshotSelectionStrategy
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ICEBERG_SNAPSHOT_LATEST")]
        ICEBERG_SNAPSHOT_LATEST,

        [EnumMember(Value = "ICEBERG_SNAPSHOT_LATEST_COMPACTED")]
        ICEBERG_SNAPSHOT_LATEST_COMPACTED,

        [EnumMember(Value = "ICEBERG_SNAPSHOT_LATEST_TAGGED")]
        ICEBERG_SNAPSHOT_LATEST_TAGGED


    } // enum IcebergSnapshotSelectionStrategy

} // namespace RubrikSecurityCloud.Types