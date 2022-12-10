// MssqlCbtEffectiveStatusType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:36.
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
    public enum MssqlCbtEffectiveStatusType
    {
        [EnumMember(Value = "MSSQL_CBT_EFFECTIVE_STATUS_TYPE_OFF")]
        MSSQL_CBT_EFFECTIVE_STATUS_TYPE_OFF,

        [EnumMember(Value = "MSSQL_CBT_EFFECTIVE_STATUS_TYPE_OFF_DEFAULT")]
        MSSQL_CBT_EFFECTIVE_STATUS_TYPE_OFF_DEFAULT,

        [EnumMember(Value = "MSSQL_CBT_EFFECTIVE_STATUS_TYPE_ON")]
        MSSQL_CBT_EFFECTIVE_STATUS_TYPE_ON,

        [EnumMember(Value = "MSSQL_CBT_EFFECTIVE_STATUS_TYPE_ON_DEFAULT")]
        MSSQL_CBT_EFFECTIVE_STATUS_TYPE_ON_DEFAULT


    } // enum MssqlCbtEffectiveStatusType

} // namespace Rubrik.SecurityCloud.Types