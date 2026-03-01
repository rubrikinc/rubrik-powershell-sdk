// MysqldbDatabaseProtectionStateEnum.cs
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
    public enum MysqldbDatabaseProtectionStateEnum
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "FULLY_PROTECTED")]
        FULLY_PROTECTED,

        [EnumMember(Value = "FULLY_UNPROTECTED")]
        FULLY_UNPROTECTED,

        [EnumMember(Value = "PARTIALLY_PROTECTED")]
        PARTIALLY_PROTECTED


    } // enum MysqldbDatabaseProtectionStateEnum

} // namespace RubrikSecurityCloud.Types