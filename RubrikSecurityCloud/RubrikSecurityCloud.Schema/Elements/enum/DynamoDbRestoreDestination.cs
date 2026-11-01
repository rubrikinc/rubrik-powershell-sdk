// DynamoDbRestoreDestination.cs
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
    public enum DynamoDbRestoreDestination
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "DYNAMODB_RESTORE_DESTINATION_EXPORT_JSON")]
        DYNAMODB_RESTORE_DESTINATION_EXPORT_JSON,

        [EnumMember(Value = "DYNAMODB_RESTORE_DESTINATION_IN_PLACE")]
        DYNAMODB_RESTORE_DESTINATION_IN_PLACE,

        [EnumMember(Value = "DYNAMODB_RESTORE_DESTINATION_NEW_TABLE")]
        DYNAMODB_RESTORE_DESTINATION_NEW_TABLE,

        [EnumMember(Value = "DYNAMODB_RESTORE_DESTINATION_UNSPECIFIED")]
        DYNAMODB_RESTORE_DESTINATION_UNSPECIFIED


    } // enum DynamoDbRestoreDestination

} // namespace RubrikSecurityCloud.Types