// ReportAttachmentType.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:59.
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
    public enum ReportAttachmentType
    {
        [EnumMember(Value = "REPORT_ATTACHMENT_TYPE_CSV")]
        REPORT_ATTACHMENT_TYPE_CSV,

        [EnumMember(Value = "REPORT_ATTACHMENT_TYPE_PDF")]
        REPORT_ATTACHMENT_TYPE_PDF,

        [EnumMember(Value = "REPORT_ATTACHMENT_TYPE_UNSPECIFIED")]
        REPORT_ATTACHMENT_TYPE_UNSPECIFIED


    } // enum ReportAttachmentType

} // namespace Rubrik.SecurityCloud.Types