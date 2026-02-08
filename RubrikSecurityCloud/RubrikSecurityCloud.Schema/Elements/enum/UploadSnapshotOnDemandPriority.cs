// UploadSnapshotOnDemandPriority.cs
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
    public enum UploadSnapshotOnDemandPriority
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "UPLOAD_AFTER_ALL")]
        UPLOAD_AFTER_ALL,

        [EnumMember(Value = "UPLOAD_AFTER_CUSTOM_RETENTION")]
        UPLOAD_AFTER_CUSTOM_RETENTION,

        [EnumMember(Value = "UPLOAD_BEFORE_ALL")]
        UPLOAD_BEFORE_ALL,

        [EnumMember(Value = "UPLOAD_SNAPSHOT_ON_DEMAND_PRIORITY_UNSPECIFIED")]
        UPLOAD_SNAPSHOT_ON_DEMAND_PRIORITY_UNSPECIFIED


    } // enum UploadSnapshotOnDemandPriority

} // namespace RubrikSecurityCloud.Types