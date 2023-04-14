// MongoType.cs
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