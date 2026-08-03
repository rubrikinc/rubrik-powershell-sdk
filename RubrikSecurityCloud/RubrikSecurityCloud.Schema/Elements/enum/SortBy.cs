// SortBy.cs
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
    public enum SortBy
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CREATION_DATE")]
        CREATION_DATE,

        [EnumMember(Value = "IS_PRIVILEGED")]
        IS_PRIVILEGED,

        [EnumMember(Value = "UNSPECIFIED")]
        UNSPECIFIED


    } // enum SortBy

} // namespace RubrikSecurityCloud.Types