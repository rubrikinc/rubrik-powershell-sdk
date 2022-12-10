// MongoSourceType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:42.
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
    public enum MongoSourceType
    {
        [EnumMember(Value = "REPLICA_SET")]
        REPLICA_SET,

        [EnumMember(Value = "SHARDED")]
        SHARDED


    } // enum MongoSourceType

} // namespace Rubrik.SecurityCloud.Types