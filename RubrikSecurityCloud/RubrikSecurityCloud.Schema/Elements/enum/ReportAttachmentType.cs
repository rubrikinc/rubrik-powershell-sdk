// ReportAttachmentType.cs
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
    public enum ReportAttachmentType
    {
        [EnumMember(Value = "REPORT_ATTACHMENT_TYPE_CSV")]
        REPORT_ATTACHMENT_TYPE_CSV,

        [EnumMember(Value = "REPORT_ATTACHMENT_TYPE_PDF")]
        REPORT_ATTACHMENT_TYPE_PDF,

        [EnumMember(Value = "REPORT_ATTACHMENT_TYPE_UNSPECIFIED")]
        REPORT_ATTACHMENT_TYPE_UNSPECIFIED,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum ReportAttachmentType

} // namespace RubrikSecurityCloud.Types