// Db2DatabaseStatus.cs
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
    public enum Db2DatabaseStatus
    {
        [EnumMember(Value = "DBSTATUS_UNSPECIFIED")]
        DBSTATUS_UNSPECIFIED,

        [EnumMember(Value = "ERROR")]
        ERROR,

        [EnumMember(Value = "OK")]
        OK,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "WARNING")]
        WARNING


    } // enum Db2DatabaseStatus

} // namespace RubrikSecurityCloud.Types