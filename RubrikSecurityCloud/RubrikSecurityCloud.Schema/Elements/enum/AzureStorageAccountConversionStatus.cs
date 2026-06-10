// AzureStorageAccountConversionStatus.cs
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
    public enum AzureStorageAccountConversionStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AZURE_STORAGE_ACCOUNT_CONVERSION_STATUS_FAILED")]
        AZURE_STORAGE_ACCOUNT_CONVERSION_STATUS_FAILED,

        [EnumMember(Value = "AZURE_STORAGE_ACCOUNT_CONVERSION_STATUS_IN_PROGRESS")]
        AZURE_STORAGE_ACCOUNT_CONVERSION_STATUS_IN_PROGRESS,

        [EnumMember(Value = "AZURE_STORAGE_ACCOUNT_CONVERSION_STATUS_NONE")]
        AZURE_STORAGE_ACCOUNT_CONVERSION_STATUS_NONE,

        [EnumMember(Value = "AZURE_STORAGE_ACCOUNT_CONVERSION_STATUS_SUBMITTED")]
        AZURE_STORAGE_ACCOUNT_CONVERSION_STATUS_SUBMITTED,

        [EnumMember(Value = "AZURE_STORAGE_ACCOUNT_CONVERSION_STATUS_SUCCEEDED")]
        AZURE_STORAGE_ACCOUNT_CONVERSION_STATUS_SUCCEEDED


    } // enum AzureStorageAccountConversionStatus

} // namespace RubrikSecurityCloud.Types