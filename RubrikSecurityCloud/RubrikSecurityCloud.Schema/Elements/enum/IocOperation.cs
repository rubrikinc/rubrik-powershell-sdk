// IocOperation.cs
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
    public enum IocOperation
    {
        [EnumMember(Value = "DISABLE")]
        DISABLE,

        [EnumMember(Value = "ENABLE")]
        ENABLE,

        [EnumMember(Value = "OPERATION_UNSPECIFIED")]
        OPERATION_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum IocOperation

} // namespace RubrikSecurityCloud.Types