// CloudStorageRehydrationSpeed.cs
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
    public enum CloudStorageRehydrationSpeed
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CLOUD_STORAGE_REHYDRATION_SPEED_AWS_BULK")]
        CLOUD_STORAGE_REHYDRATION_SPEED_AWS_BULK,

        [EnumMember(Value = "CLOUD_STORAGE_REHYDRATION_SPEED_AWS_EXPEDITED")]
        CLOUD_STORAGE_REHYDRATION_SPEED_AWS_EXPEDITED,

        [EnumMember(Value = "CLOUD_STORAGE_REHYDRATION_SPEED_AWS_STANDARD")]
        CLOUD_STORAGE_REHYDRATION_SPEED_AWS_STANDARD,

        [EnumMember(Value = "CLOUD_STORAGE_REHYDRATION_SPEED_AZURE_HIGH_PRIORITY")]
        CLOUD_STORAGE_REHYDRATION_SPEED_AZURE_HIGH_PRIORITY,

        [EnumMember(Value = "CLOUD_STORAGE_REHYDRATION_SPEED_AZURE_STANDARD")]
        CLOUD_STORAGE_REHYDRATION_SPEED_AZURE_STANDARD


    } // enum CloudStorageRehydrationSpeed

} // namespace RubrikSecurityCloud.Types