// DynamoDbOverwriteMode.cs
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
    public enum DynamoDbOverwriteMode
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "DYNAMODB_OVERWRITE_MODE_CONDITIONAL")]
        DYNAMODB_OVERWRITE_MODE_CONDITIONAL,

        [EnumMember(Value = "DYNAMODB_OVERWRITE_MODE_LAST_WRITE_WINS")]
        DYNAMODB_OVERWRITE_MODE_LAST_WRITE_WINS,

        [EnumMember(Value = "DYNAMODB_OVERWRITE_MODE_SKIP_EXISTING")]
        DYNAMODB_OVERWRITE_MODE_SKIP_EXISTING,

        [EnumMember(Value = "DYNAMODB_OVERWRITE_MODE_UNSPECIFIED")]
        DYNAMODB_OVERWRITE_MODE_UNSPECIFIED


    } // enum DynamoDbOverwriteMode

} // namespace RubrikSecurityCloud.Types