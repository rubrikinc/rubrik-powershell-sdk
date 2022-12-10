// V1GetCompatibleMssqlInstancesV1RequestRecoveryType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:46.
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
    public enum V1GetCompatibleMssqlInstancesV1RequestRecoveryType
    {
        [EnumMember(Value = "V1_GET_COMPATIBLE_MSSQL_INSTANCES_V1_REQUEST_RECOVERY_TYPE_EXPORT")]
        V1_GET_COMPATIBLE_MSSQL_INSTANCES_V1_REQUEST_RECOVERY_TYPE_EXPORT,

        [EnumMember(Value = "V1_GET_COMPATIBLE_MSSQL_INSTANCES_V1_REQUEST_RECOVERY_TYPE_MOUNT")]
        V1_GET_COMPATIBLE_MSSQL_INSTANCES_V1_REQUEST_RECOVERY_TYPE_MOUNT,

        [EnumMember(Value = "V1_GET_COMPATIBLE_MSSQL_INSTANCES_V1_REQUEST_RECOVERY_TYPE_RESTORE")]
        V1_GET_COMPATIBLE_MSSQL_INSTANCES_V1_REQUEST_RECOVERY_TYPE_RESTORE


    } // enum V1GetCompatibleMssqlInstancesV1RequestRecoveryType

} // namespace Rubrik.SecurityCloud.Types