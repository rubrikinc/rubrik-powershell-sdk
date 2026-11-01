// CopyScheduleCloudProvider.cs
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
    public enum CopyScheduleCloudProvider
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "COPY_SCHEDULE_CLOUD_PROVIDER_AZ")]
        COPY_SCHEDULE_CLOUD_PROVIDER_AZ,

        [EnumMember(Value = "COPY_SCHEDULE_CLOUD_PROVIDER_GCP")]
        COPY_SCHEDULE_CLOUD_PROVIDER_GCP,

        [EnumMember(Value = "COPY_SCHEDULE_CLOUD_PROVIDER_NFSBLOB")]
        COPY_SCHEDULE_CLOUD_PROVIDER_NFSBLOB,

        [EnumMember(Value = "COPY_SCHEDULE_CLOUD_PROVIDER_S3")]
        COPY_SCHEDULE_CLOUD_PROVIDER_S3,

        [EnumMember(Value = "COPY_SCHEDULE_CLOUD_PROVIDER_UNSPECIFIED")]
        COPY_SCHEDULE_CLOUD_PROVIDER_UNSPECIFIED


    } // enum CopyScheduleCloudProvider

} // namespace RubrikSecurityCloud.Types