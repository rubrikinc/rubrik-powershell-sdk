// AzureStorageAccountKind.cs
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
    public enum AzureStorageAccountKind
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "BLOB_STORAGE")]
        BLOB_STORAGE,

        [EnumMember(Value = "BLOCK_BLOB_STORAGE")]
        BLOCK_BLOB_STORAGE,

        [EnumMember(Value = "FILE_STORAGE")]
        FILE_STORAGE,

        [EnumMember(Value = "STORAGE")]
        STORAGE,

        [EnumMember(Value = "STORAGE_KIND_UNKNOWN")]
        STORAGE_KIND_UNKNOWN,

        [EnumMember(Value = "STORAGE_V2")]
        STORAGE_V2


    } // enum AzureStorageAccountKind

} // namespace RubrikSecurityCloud.Types