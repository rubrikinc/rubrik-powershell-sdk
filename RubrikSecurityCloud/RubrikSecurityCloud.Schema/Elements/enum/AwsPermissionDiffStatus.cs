// AwsPermissionDiffStatus.cs
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
    public enum AwsPermissionDiffStatus
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AWS_PERMISSION_DIFF_STATUS_AVAILABLE")]
        AWS_PERMISSION_DIFF_STATUS_AVAILABLE,

        [EnumMember(Value = "AWS_PERMISSION_DIFF_STATUS_NOT_AVAILABLE")]
        AWS_PERMISSION_DIFF_STATUS_NOT_AVAILABLE,

        [EnumMember(Value = "AWS_PERMISSION_DIFF_STATUS_UNSPECIFIED")]
        AWS_PERMISSION_DIFF_STATUS_UNSPECIFIED


    } // enum AwsPermissionDiffStatus

} // namespace RubrikSecurityCloud.Types