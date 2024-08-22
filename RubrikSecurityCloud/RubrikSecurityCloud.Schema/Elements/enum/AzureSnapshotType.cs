// AzureSnapshotType.cs
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
    public enum AzureSnapshotType
    {
        [EnumMember(Value = "ARCHIVED")]
        ARCHIVED,

        [EnumMember(Value = "REPLICATED")]
        REPLICATED,

        [EnumMember(Value = "SOURCE")]
        SOURCE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum AzureSnapshotType

} // namespace RubrikSecurityCloud.Types