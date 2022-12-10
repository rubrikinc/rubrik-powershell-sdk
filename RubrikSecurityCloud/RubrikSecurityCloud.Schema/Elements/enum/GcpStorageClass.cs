// GcpStorageClass.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:19.
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
    public enum GcpStorageClass
    {
        [EnumMember(Value = "COLDLINE_GCP")]
        COLDLINE_GCP,

        [EnumMember(Value = "DURABLE_REDUCED_AVAILABILITY_GCP")]
        DURABLE_REDUCED_AVAILABILITY_GCP,

        [EnumMember(Value = "NEARLINE_GCP")]
        NEARLINE_GCP,

        [EnumMember(Value = "STANDARD_GCP")]
        STANDARD_GCP,

        [EnumMember(Value = "UNKNOWN_STORAGE_CLASS_GCP")]
        UNKNOWN_STORAGE_CLASS_GCP


    } // enum GcpStorageClass

} // namespace Rubrik.SecurityCloud.Types