// AwsElasticacheEngineType.cs
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
    public enum AwsElasticacheEngineType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AWS_ELASTICACHE_ENGINE_TYPE_MEMCACHED")]
        AWS_ELASTICACHE_ENGINE_TYPE_MEMCACHED,

        [EnumMember(Value = "AWS_ELASTICACHE_ENGINE_TYPE_REDIS")]
        AWS_ELASTICACHE_ENGINE_TYPE_REDIS,

        [EnumMember(Value = "AWS_ELASTICACHE_ENGINE_TYPE_VALKEY")]
        AWS_ELASTICACHE_ENGINE_TYPE_VALKEY


    } // enum AwsElasticacheEngineType

} // namespace RubrikSecurityCloud.Types