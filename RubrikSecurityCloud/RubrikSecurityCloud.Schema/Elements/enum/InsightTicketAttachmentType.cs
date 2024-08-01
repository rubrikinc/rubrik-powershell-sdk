// InsightTicketAttachmentType.cs
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
    public enum InsightTicketAttachmentType
    {
        [EnumMember(Value = "FILE_LIST")]
        FILE_LIST,

        [EnumMember(Value = "USER_LIST")]
        USER_LIST,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum InsightTicketAttachmentType

} // namespace RubrikSecurityCloud.Types