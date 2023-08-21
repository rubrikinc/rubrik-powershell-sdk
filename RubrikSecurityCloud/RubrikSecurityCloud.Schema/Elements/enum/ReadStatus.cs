// ReadStatus.cs
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
    public enum ReadStatus
    {
        [EnumMember(Value = "READ")]
        READ,

        [EnumMember(Value = "READ_STATUS_UNSPECIFIED")]
        READ_STATUS_UNSPECIFIED,

        [EnumMember(Value = "UNREAD")]
        UNREAD


    } // enum ReadStatus

} // namespace RubrikSecurityCloud.Types