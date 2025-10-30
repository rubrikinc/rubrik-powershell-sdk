// ReportRoomType.cs
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
    public enum ReportRoomType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "DATA_THREAT_ANALYTICS")]
        DATA_THREAT_ANALYTICS,

        [EnumMember(Value = "REPORT_ROOM_DSPM")]
        REPORT_ROOM_DSPM,

        [EnumMember(Value = "REPORT_ROOM_IR")]
        REPORT_ROOM_IR,

        [EnumMember(Value = "REPORT_ROOM_NONE")]
        REPORT_ROOM_NONE,

        [EnumMember(Value = "REPORT_ROOM_SAAS")]
        REPORT_ROOM_SAAS


    } // enum ReportRoomType

} // namespace RubrikSecurityCloud.Types