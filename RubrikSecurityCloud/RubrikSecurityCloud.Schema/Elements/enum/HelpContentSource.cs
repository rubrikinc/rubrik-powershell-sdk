// HelpContentSource.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:01.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace Rubrik.SecurityCloud.Types
{
    public enum HelpContentSource
    {
        [EnumMember(Value = "KB_ARTICLES")]
        KB_ARTICLES,

        [EnumMember(Value = "PRODUCT_DOCS")]
        PRODUCT_DOCS,

        [EnumMember(Value = "SOURCE_UNSPECIFIED")]
        SOURCE_UNSPECIFIED


    } // enum HelpContentSource

} // namespace Rubrik.SecurityCloud.Types