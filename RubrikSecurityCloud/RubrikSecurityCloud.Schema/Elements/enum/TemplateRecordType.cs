// TemplateRecordType.cs
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
    public enum TemplateRecordType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "CUSTOM")]
        CUSTOM,

        [EnumMember(Value = "DEFAULT")]
        DEFAULT,

        [EnumMember(Value = "TEMPLATE_RECORD_TYPE_UNSPECIFIED")]
        TEMPLATE_RECORD_TYPE_UNSPECIFIED


    } // enum TemplateRecordType

} // namespace RubrikSecurityCloud.Types