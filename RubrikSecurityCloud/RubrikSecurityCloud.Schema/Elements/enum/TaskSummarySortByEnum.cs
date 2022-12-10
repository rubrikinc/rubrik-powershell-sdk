// TaskSummarySortByEnum.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:38.
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
    public enum TaskSummarySortByEnum
    {
        [EnumMember(Value = "Date")]
        DATE,

        [EnumMember(Value = "NumCanceled")]
        NUM_CANCELED,

        [EnumMember(Value = "NumExpected")]
        NUM_EXPECTED,

        [EnumMember(Value = "NumFailed")]
        NUM_FAILED,

        [EnumMember(Value = "NumSucceeded")]
        NUM_SUCCEEDED,

        [EnumMember(Value = "ObjectName")]
        OBJECT_NAME,

        [EnumMember(Value = "ObjectType")]
        OBJECT_TYPE,

        [EnumMember(Value = "SlaDomainName")]
        SLA_DOMAIN_NAME


    } // enum TaskSummarySortByEnum

} // namespace Rubrik.SecurityCloud.Types