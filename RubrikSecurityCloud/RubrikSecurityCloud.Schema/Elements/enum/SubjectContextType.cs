// SubjectContextType.cs
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
    public enum SubjectContextType
    {
        [EnumMember(Value = "USER")]
        USER,

        [EnumMember(Value = "USER_GROUP")]
        USER_GROUP,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum SubjectContextType

} // namespace RubrikSecurityCloud.Types