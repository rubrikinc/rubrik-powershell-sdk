// DocumentTypeStatusFilter.cs
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
    public enum DocumentTypeStatusFilter
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "ACTIVE_DOCUMENT_TYPE")]
        ACTIVE_DOCUMENT_TYPE,

        [EnumMember(Value = "ALL_DOCUMENT_TYPE")]
        ALL_DOCUMENT_TYPE,

        [EnumMember(Value = "INACTIVE_DOCUMENT_TYPE")]
        INACTIVE_DOCUMENT_TYPE


    } // enum DocumentTypeStatusFilter

} // namespace RubrikSecurityCloud.Types