// TemplateMessageType.cs
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
    public enum TemplateMessageType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AUDIT")]
        AUDIT,

        [EnumMember(Value = "EVENT")]
        EVENT,

        [EnumMember(Value = "TEMPLATE_MESSAGE_TYPE_UNSPECIFIED")]
        TEMPLATE_MESSAGE_TYPE_UNSPECIFIED


    } // enum TemplateMessageType

} // namespace RubrikSecurityCloud.Types