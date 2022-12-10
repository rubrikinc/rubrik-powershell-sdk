// DeltaType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:02.
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
    public enum DeltaType
    {
        [EnumMember(Value = "BYTES_CREATED")]
        BYTES_CREATED,

        [EnumMember(Value = "BYTES_DELETED")]
        BYTES_DELETED,

        [EnumMember(Value = "BYTES_MODIFIED")]
        BYTES_MODIFIED,

        [EnumMember(Value = "NODES_CREATED")]
        NODES_CREATED,

        [EnumMember(Value = "NODES_DELETED")]
        NODES_DELETED,

        [EnumMember(Value = "NODES_MODIFIED")]
        NODES_MODIFIED,

        [EnumMember(Value = "NODES_RANSOMWARE_STRAIN_AFFECTED")]
        NODES_RANSOMWARE_STRAIN_AFFECTED,

        [EnumMember(Value = "NODES_RANSOMWARE_STRAIN_NOTE")]
        NODES_RANSOMWARE_STRAIN_NOTE,

        [EnumMember(Value = "NODES_SUSPICIOUS")]
        NODES_SUSPICIOUS


    } // enum DeltaType

} // namespace Rubrik.SecurityCloud.Types