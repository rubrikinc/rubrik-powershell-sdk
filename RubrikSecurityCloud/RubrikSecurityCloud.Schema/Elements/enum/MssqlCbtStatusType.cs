// MssqlCbtStatusType.cs
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
    public enum MssqlCbtStatusType
    {
        [EnumMember(Value = "MSSQL_CBT_STATUS_TYPE_DEFAULT")]
        MSSQL_CBT_STATUS_TYPE_DEFAULT,

        [EnumMember(Value = "MSSQL_CBT_STATUS_TYPE_DISABLED")]
        MSSQL_CBT_STATUS_TYPE_DISABLED,

        [EnumMember(Value = "MSSQL_CBT_STATUS_TYPE_ENABLED")]
        MSSQL_CBT_STATUS_TYPE_ENABLED


    } // enum MssqlCbtStatusType

} // namespace RubrikSecurityCloud.Types