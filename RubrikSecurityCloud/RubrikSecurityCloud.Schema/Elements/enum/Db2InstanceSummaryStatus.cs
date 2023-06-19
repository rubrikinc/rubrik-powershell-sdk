// Db2InstanceSummaryStatus.cs
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

} // namespace RubrikSecurityCloud.Types