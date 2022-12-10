// DownloadIdentifierEnum.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:03.
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
    public enum DownloadIdentifierEnum
    {
        [EnumMember(Value = "ORION_THREAT_HUNT_DOWNLOAD")]
        ORION_THREAT_HUNT_DOWNLOAD,

        [EnumMember(Value = "REPORT")]
        REPORT,

        [EnumMember(Value = "SEND_NOW_EMAIL")]
        SEND_NOW_EMAIL,

        [EnumMember(Value = "SLA_WITH_REPLICATION")]
        SLA_WITH_REPLICATION,

        [EnumMember(Value = "SNAPSHOT_FILES_DOWNLOAD")]
        SNAPSHOT_FILES_DOWNLOAD,

        [EnumMember(Value = "SONAR_DOWNLOAD")]
        SONAR_DOWNLOAD


    } // enum DownloadIdentifierEnum

} // namespace Rubrik.SecurityCloud.Types