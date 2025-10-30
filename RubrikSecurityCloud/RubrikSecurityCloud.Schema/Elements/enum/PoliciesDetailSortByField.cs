// PoliciesDetailSortByField.cs
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
    public enum PoliciesDetailSortByField
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "NAME")]
        NAME,

        [EnumMember(Value = "TOTAL_HITS")]
        TOTAL_HITS,

        [EnumMember(Value = "TOTAL_OBJECTS")]
        TOTAL_OBJECTS


    } // enum PoliciesDetailSortByField

} // namespace RubrikSecurityCloud.Types