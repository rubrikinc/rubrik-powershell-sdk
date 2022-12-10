// TaskReportTableColumnEnum.cs
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
    public enum TaskReportTableColumnEnum
    {
        [EnumMember(Value = "EndDate")]
        END_DATE,

        [EnumMember(Value = "Location")]
        LOCATION,

        [EnumMember(Value = "NumOfCanceled")]
        NUM_OF_CANCELED,

        [EnumMember(Value = "NumOfExpected")]
        NUM_OF_EXPECTED,

        [EnumMember(Value = "NumOfFailed")]
        NUM_OF_FAILED,

        [EnumMember(Value = "NumOfSucceeded")]
        NUM_OF_SUCCEEDED,

        [EnumMember(Value = "ObjectName")]
        OBJECT_NAME,

        [EnumMember(Value = "ObjectType")]
        OBJECT_TYPE,

        [EnumMember(Value = "SlaDomainName")]
        SLA_DOMAIN_NAME,

        [EnumMember(Value = "StartDate")]
        START_DATE


    } // enum TaskReportTableColumnEnum

} // namespace Rubrik.SecurityCloud.Types