// UnmappingValidationType.cs
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
    public enum UnmappingValidationType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AST")]
        AST,

        [EnumMember(Value = "EMPTY_STORAGE_ACCOUNT")]
        EMPTY_STORAGE_ACCOUNT


    } // enum UnmappingValidationType

} // namespace RubrikSecurityCloud.Types