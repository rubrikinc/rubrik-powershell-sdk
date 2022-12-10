// ColdStorageClass.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:12.
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
    public enum ColdStorageClass
    {
        [EnumMember(Value = "AWS_GLACIER")]
        AWS_GLACIER,

        [EnumMember(Value = "AWS_GLACIER_DEEP_ARCHIVE")]
        AWS_GLACIER_DEEP_ARCHIVE,

        [EnumMember(Value = "AZURE_ARCHIVE")]
        AZURE_ARCHIVE,

        [EnumMember(Value = "COLD_STORAGE_CLASS_UNKNOWN")]
        COLD_STORAGE_CLASS_UNKNOWN


    } // enum ColdStorageClass

} // namespace Rubrik.SecurityCloud.Types