// HelpContentSource.cs
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
    public enum HelpContentSource
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "KB_ARTICLES")]
        KB_ARTICLES,

        [EnumMember(Value = "PRODUCT_DOCS")]
        PRODUCT_DOCS,

        [EnumMember(Value = "SOURCE_UNSPECIFIED")]
        SOURCE_UNSPECIFIED


    } // enum HelpContentSource

} // namespace RubrikSecurityCloud.Types