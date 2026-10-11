// IrisdbAuthenticationType.cs
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
    public enum IrisdbAuthenticationType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "OS_BASED")]
        OS_BASED,

        [EnumMember(Value = "PASSWORD_BASED")]
        PASSWORD_BASED


    } // enum IrisdbAuthenticationType

} // namespace RubrikSecurityCloud.Types