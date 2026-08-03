// FileStructureSortBy.cs
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
    public enum FileStructureSortBy
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "DATA_TYPE_HITS")]
        DATA_TYPE_HITS,

        [EnumMember(Value = "NATIVE_PATH")]
        NATIVE_PATH


    } // enum FileStructureSortBy

} // namespace RubrikSecurityCloud.Types