// DynamoDbTtlHandling.cs
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
    public enum DynamoDbTtlHandling
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "DYNAMODB_TTL_HANDLING_CUSTOM")]
        DYNAMODB_TTL_HANDLING_CUSTOM,

        [EnumMember(Value = "DYNAMODB_TTL_HANDLING_DO_NOT_APPLY")]
        DYNAMODB_TTL_HANDLING_DO_NOT_APPLY,

        [EnumMember(Value = "DYNAMODB_TTL_HANDLING_ORIGINAL")]
        DYNAMODB_TTL_HANDLING_ORIGINAL,

        [EnumMember(Value = "DYNAMODB_TTL_HANDLING_UNSPECIFIED")]
        DYNAMODB_TTL_HANDLING_UNSPECIFIED


    } // enum DynamoDbTtlHandling

} // namespace RubrikSecurityCloud.Types