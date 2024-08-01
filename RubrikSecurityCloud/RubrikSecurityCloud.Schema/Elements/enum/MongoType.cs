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

namespace RubrikSecurityCloud.Types
{
    public enum MongoType
    {
        [EnumMember(Value = "MONGO_TYPE_REPLICA_SET")]
        MONGO_TYPE_REPLICA_SET,

        [EnumMember(Value = "MONGO_TYPE_SHARDED_CLUSTER")]
        MONGO_TYPE_SHARDED_CLUSTER,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum MongoType

} // namespace RubrikSecurityCloud.Types