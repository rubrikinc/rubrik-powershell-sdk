// AzureSnapshotType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:15.
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
    public enum AzureSnapshotType
    {
        [EnumMember(Value = "ARCHIVED")]
        ARCHIVED,

        [EnumMember(Value = "REPLICATED")]
        REPLICATED,

        [EnumMember(Value = "SOURCE")]
        SOURCE


    } // enum AzureSnapshotType

} // namespace Rubrik.SecurityCloud.Types