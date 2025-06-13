// UpgradePackageUploadErrorCode.cs
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
    public enum UpgradePackageUploadErrorCode
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "INTERNAL_FAILURE")]
        INTERNAL_FAILURE,

        [EnumMember(Value = "MD5_MISMATCH")]
        MD5_MISMATCH,

        [EnumMember(Value = "NETWORK_FAILURE")]
        NETWORK_FAILURE,

        [EnumMember(Value = "STORAGE_FULL")]
        STORAGE_FULL


    } // enum UpgradePackageUploadErrorCode

} // namespace RubrikSecurityCloud.Types