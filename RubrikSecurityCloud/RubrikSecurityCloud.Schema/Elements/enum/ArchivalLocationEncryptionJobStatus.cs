// ArchivalLocationEncryptionJobStatus.cs
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
    public enum ArchivalLocationEncryptionJobStatus
    {
        [EnumMember(Value = "COMPLETED_ARCHIVAL_LOCATION_ENCRYPTION_JOB_STATUS")]
        COMPLETED_ARCHIVAL_LOCATION_ENCRYPTION_JOB_STATUS,

        [EnumMember(Value = "IN_PROGRESS_ARCHIVAL_LOCATION_ENCRYPTION_JOB_STATUS")]
        IN_PROGRESS_ARCHIVAL_LOCATION_ENCRYPTION_JOB_STATUS,

        [EnumMember(Value = "QUEUED_ARCHIVAL_LOCATION_ENCRYPTION_JOB_STATUS")]
        QUEUED_ARCHIVAL_LOCATION_ENCRYPTION_JOB_STATUS,

        [EnumMember(Value = "UNKNOWN_ARCHIVAL_LOCATION_ENCRYPTION_JOB_STATUS")]
        UNKNOWN_ARCHIVAL_LOCATION_ENCRYPTION_JOB_STATUS,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ArchivalLocationEncryptionJobStatus

} // namespace RubrikSecurityCloud.Types