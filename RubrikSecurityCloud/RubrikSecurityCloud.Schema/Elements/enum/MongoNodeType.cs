// MongoNodeType.cs
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
    public enum MongoNodeType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CONFIG_SERVER")]
        CONFIG_SERVER,

        [EnumMember(Value = "MONGOS")]
        MONGOS,

        [EnumMember(Value = "NODE_TYPE_UNSPECIFIED")]
        NODE_TYPE_UNSPECIFIED,

        [EnumMember(Value = "REPLICA_SET")]
        REPLICA_SET


    } // enum MongoNodeType

} // namespace RubrikSecurityCloud.Types