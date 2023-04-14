// UserAuditTableColumnEnum.cs
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

namespace Rubrik.SecurityCloud.Types
{
    public enum UserAuditTableColumnEnum
    {
        [EnumMember(Value = "ClusterName")]
        CLUSTER_NAME,

        [EnumMember(Value = "ClusterType")]
        CLUSTER_TYPE,

        [EnumMember(Value = "UserAuditStatus")]
        USER_AUDIT_STATUS,

        [EnumMember(Value = "UserAuditType")]
        USER_AUDIT_TYPE


    } // enum UserAuditTableColumnEnum

} // namespace Rubrik.SecurityCloud.Types