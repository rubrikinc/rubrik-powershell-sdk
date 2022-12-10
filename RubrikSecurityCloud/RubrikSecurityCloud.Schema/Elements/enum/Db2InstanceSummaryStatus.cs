// Db2InstanceSummaryStatus.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:24.
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
    public enum Db2InstanceSummaryStatus
    {
        [EnumMember(Value = "DB2_INSTANCE_SUMMARY_STATUS_ERROR")]
        DB2_INSTANCE_SUMMARY_STATUS_ERROR,

        [EnumMember(Value = "DB2_INSTANCE_SUMMARY_STATUS_OK")]
        DB2_INSTANCE_SUMMARY_STATUS_OK,

        [EnumMember(Value = "DB2_INSTANCE_SUMMARY_STATUS_UNKNOWN")]
        DB2_INSTANCE_SUMMARY_STATUS_UNKNOWN,

        [EnumMember(Value = "DB2_INSTANCE_SUMMARY_STATUS_WARNING")]
        DB2_INSTANCE_SUMMARY_STATUS_WARNING


    } // enum Db2InstanceSummaryStatus

} // namespace Rubrik.SecurityCloud.Types