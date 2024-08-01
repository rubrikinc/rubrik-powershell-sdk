// PolicyDetailsSortBy.cs
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
    public enum PolicyDetailsSortBy
    {
        [EnumMember(Value = "SORT_UNSPECIFIED")]
        SORT_UNSPECIFIED,

        [EnumMember(Value = "WORKLOAD_NAME")]
        WORKLOAD_NAME,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum PolicyDetailsSortBy

} // namespace RubrikSecurityCloud.Types