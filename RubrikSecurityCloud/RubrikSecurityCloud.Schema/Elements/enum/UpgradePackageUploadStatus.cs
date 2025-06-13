// UpgradePackageUploadStatus.cs
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
    public enum UpgradePackageUploadStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "COMPLETED")]
        COMPLETED,

        [EnumMember(Value = "FAILED")]
        FAILED,

        [EnumMember(Value = "INITIALIZING")]
        INITIALIZING,

        [EnumMember(Value = "UPLOADING")]
        UPLOADING,

        [EnumMember(Value = "VALIDATING")]
        VALIDATING


    } // enum UpgradePackageUploadStatus

} // namespace RubrikSecurityCloud.Types