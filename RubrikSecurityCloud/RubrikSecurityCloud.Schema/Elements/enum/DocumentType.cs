// DocumentType.cs
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
    public enum DocumentType
    {
        [EnumMember(Value = "DOC_TYPE_UNSPECIFIED")]
        DOC_TYPE_UNSPECIFIED,

        [EnumMember(Value = "KB_ARTICLE")]
        KB_ARTICLE,

        [EnumMember(Value = "PRODUCT_DOC")]
        PRODUCT_DOC,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum DocumentType

} // namespace RubrikSecurityCloud.Types