// VersionSourceType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:18.
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
    public enum VersionSourceType
    {
        [EnumMember(Value = "VERSION_SOURCE_TYPE_CASSANDRA")]
        VERSION_SOURCE_TYPE_CASSANDRA,

        [EnumMember(Value = "VERSION_SOURCE_TYPE_MONGO")]
        VERSION_SOURCE_TYPE_MONGO


    } // enum VersionSourceType

} // namespace Rubrik.SecurityCloud.Types