// V1QueryLogReportRequestSortBy.cs
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
    public enum V1QueryLogReportRequestSortBy
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "V1_QUERY_LOG_REPORT_REQUEST_SORT_BY_DATABASE_TYPE")]
        V1_QUERY_LOG_REPORT_REQUEST_SORT_BY_DATABASE_TYPE,

        [EnumMember(Value = "V1_QUERY_LOG_REPORT_REQUEST_SORT_BY_EFFECTIVE_SLA_DOMAIN_NAME")]
        V1_QUERY_LOG_REPORT_REQUEST_SORT_BY_EFFECTIVE_SLA_DOMAIN_NAME,

        [EnumMember(Value = "V1_QUERY_LOG_REPORT_REQUEST_SORT_BY_LAST_SNAPSHOT_TIME")]
        V1_QUERY_LOG_REPORT_REQUEST_SORT_BY_LAST_SNAPSHOT_TIME,

        [EnumMember(Value = "V1_QUERY_LOG_REPORT_REQUEST_SORT_BY_LATEST_RECOVERY_TIME")]
        V1_QUERY_LOG_REPORT_REQUEST_SORT_BY_LATEST_RECOVERY_TIME,

        [EnumMember(Value = "V1_QUERY_LOG_REPORT_REQUEST_SORT_BY_LOCATION")]
        V1_QUERY_LOG_REPORT_REQUEST_SORT_BY_LOCATION,

        [EnumMember(Value = "V1_QUERY_LOG_REPORT_REQUEST_SORT_BY_LOG_BACKUP_DELAY")]
        V1_QUERY_LOG_REPORT_REQUEST_SORT_BY_LOG_BACKUP_DELAY,

        [EnumMember(Value = "V1_QUERY_LOG_REPORT_REQUEST_SORT_BY_LOG_BACKUP_FREQUENCY")]
        V1_QUERY_LOG_REPORT_REQUEST_SORT_BY_LOG_BACKUP_FREQUENCY,

        [EnumMember(Value = "V1_QUERY_LOG_REPORT_REQUEST_SORT_BY_NAME")]
        V1_QUERY_LOG_REPORT_REQUEST_SORT_BY_NAME


    } // enum V1QueryLogReportRequestSortBy

} // namespace RubrikSecurityCloud.Types