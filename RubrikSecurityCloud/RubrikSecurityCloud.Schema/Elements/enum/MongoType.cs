// MongoType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:29.
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
    public enum MongoType
    {
        [EnumMember(Value = "MONGO_TYPE_REPLICA_SET")]
        MONGO_TYPE_REPLICA_SET,

        [EnumMember(Value = "MONGO_TYPE_SHARDED_CLUSTER")]
        MONGO_TYPE_SHARDED_CLUSTER


    } // enum MongoType

} // namespace Rubrik.SecurityCloud.Types