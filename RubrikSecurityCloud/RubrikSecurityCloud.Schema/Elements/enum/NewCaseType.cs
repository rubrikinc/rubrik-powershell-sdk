// NewCaseType.cs
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
    public enum NewCaseType
    {
        [EnumMember(Value = "CASE_TYPE_UNSPECIFIED")]
        CASE_TYPE_UNSPECIFIED,

        [EnumMember(Value = "DOCUMENTATION")]
        DOCUMENTATION,

        [EnumMember(Value = "HARDWARE")]
        HARDWARE,

        [EnumMember(Value = "OTHER")]
        OTHER,

        [EnumMember(Value = "PRODUCT_ENHANCEMENT")]
        PRODUCT_ENHANCEMENT,

        [EnumMember(Value = "PRODUCT_QUESTION")]
        PRODUCT_QUESTION,

        [EnumMember(Value = "SOFTWARE")]
        SOFTWARE


    } // enum NewCaseType

} // namespace RubrikSecurityCloud.Types