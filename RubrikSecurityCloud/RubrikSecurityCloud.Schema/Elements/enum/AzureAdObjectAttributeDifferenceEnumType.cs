// AzureAdObjectAttributeDifferenceEnumType.cs
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
    public enum AzureAdObjectAttributeDifferenceEnumType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ADDED")]
        ADDED,

        [EnumMember(Value = "DELETED")]
        DELETED,

        [EnumMember(Value = "MODIFIED")]
        MODIFIED,

        [EnumMember(Value = "UNKNOWN_ATTRIBUTE_DIFFERENCE_TYPE")]
        UNKNOWN_ATTRIBUTE_DIFFERENCE_TYPE,

        [EnumMember(Value = "UNMODIFIED")]
        UNMODIFIED


    } // enum AzureAdObjectAttributeDifferenceEnumType

} // namespace RubrikSecurityCloud.Types