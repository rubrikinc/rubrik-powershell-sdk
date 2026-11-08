// AwsElasticacheConfigurationType.cs
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
    public enum AwsElasticacheConfigurationType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AWS_ELASTICACHE_CONFIGURATION_TYPE_CACHE_CLUSTER")]
        AWS_ELASTICACHE_CONFIGURATION_TYPE_CACHE_CLUSTER,

        [EnumMember(Value = "AWS_ELASTICACHE_CONFIGURATION_TYPE_REPLICATION_GROUP")]
        AWS_ELASTICACHE_CONFIGURATION_TYPE_REPLICATION_GROUP,

        [EnumMember(Value = "AWS_ELASTICACHE_CONFIGURATION_TYPE_SERVERLESS")]
        AWS_ELASTICACHE_CONFIGURATION_TYPE_SERVERLESS


    } // enum AwsElasticacheConfigurationType

} // namespace RubrikSecurityCloud.Types