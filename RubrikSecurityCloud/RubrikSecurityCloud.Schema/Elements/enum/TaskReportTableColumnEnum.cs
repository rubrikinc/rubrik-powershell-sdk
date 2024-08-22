// TaskReportTableColumnEnum.cs
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
        START_DATE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum TaskReportTableColumnEnum

} // namespace RubrikSecurityCloud.Types