// SnapshotLocationType.cs
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
    public enum SnapshotLocationType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AUTOMATIC")]
        AUTOMATIC,

        [EnumMember(Value = "EXTERNAL_ARCHIVE")]
        EXTERNAL_ARCHIVE,

        [EnumMember(Value = "LOCAL")]
        LOCAL,

        [EnumMember(Value = "RCV_PREMIUM")]
        RCV_PREMIUM,

        [EnumMember(Value = "REPLICATED")]
        REPLICATED


    } // enum SnapshotLocationType

} // namespace RubrikSecurityCloud.Types