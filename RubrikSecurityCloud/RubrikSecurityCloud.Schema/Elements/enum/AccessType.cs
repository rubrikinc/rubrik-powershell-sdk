// AccessType.cs
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
    public enum AccessType
    {
        [EnumMember(Value = "CREATE_ACCESS")]
        CREATE_ACCESS,

        [EnumMember(Value = "DELETE_ACCESS")]
        DELETE_ACCESS,

        [EnumMember(Value = "FULL_CONTROL")]
        FULL_CONTROL,

        [EnumMember(Value = "READ_ACCESS")]
        READ_ACCESS,

        [EnumMember(Value = "WRITE_ACCESS")]
        WRITE_ACCESS


    } // enum AccessType

} // namespace RubrikSecurityCloud.Types