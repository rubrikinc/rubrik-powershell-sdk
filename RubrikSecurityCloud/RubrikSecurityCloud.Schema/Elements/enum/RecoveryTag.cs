// RecoveryTag.cs
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
    public enum RecoveryTag
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AZURE_LOCAL")]
        AZURE_LOCAL,

        [EnumMember(Value = "HYPERV")]
        HYPERV,

        [EnumMember(Value = "SQL_HOST_PROVISIONED")]
        SQL_HOST_PROVISIONED


    } // enum RecoveryTag

} // namespace RubrikSecurityCloud.Types