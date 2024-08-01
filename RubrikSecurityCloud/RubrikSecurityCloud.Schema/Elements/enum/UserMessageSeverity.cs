// UserMessageSeverity.cs
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
    public enum UserMessageSeverity
    {
        [EnumMember(Value = "ERROR")]
        ERROR,

        [EnumMember(Value = "WARNING")]
        WARNING,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum UserMessageSeverity

} // namespace RubrikSecurityCloud.Types