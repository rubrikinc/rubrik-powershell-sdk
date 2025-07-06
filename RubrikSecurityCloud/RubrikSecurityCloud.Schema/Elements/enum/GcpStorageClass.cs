// GcpStorageClass.cs
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
    public enum GcpStorageClass
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ARCHIVE_GCP")]
        ARCHIVE_GCP,

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

} // namespace RubrikSecurityCloud.Types