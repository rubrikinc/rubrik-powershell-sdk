// RemediationTicketAttachmentType.cs
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
    public enum RemediationTicketAttachmentType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "DOCUMENT_LIST")]
        DOCUMENT_LIST,

        [EnumMember(Value = "REMEDIATION_TICKET_ATTACHMENT_TYPE_UNSPECIFIED")]
        REMEDIATION_TICKET_ATTACHMENT_TYPE_UNSPECIFIED


    } // enum RemediationTicketAttachmentType

} // namespace RubrikSecurityCloud.Types