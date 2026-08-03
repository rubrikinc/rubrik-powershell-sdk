// Db2InstanceSummaryInstanceType.cs
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
    public enum Db2InstanceSummaryInstanceType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "DB2_INSTANCE_SUMMARY_INSTANCE_TYPE_PARTITIONED")]
        DB2_INSTANCE_SUMMARY_INSTANCE_TYPE_PARTITIONED,

        [EnumMember(Value = "DB2_INSTANCE_SUMMARY_INSTANCE_TYPE_PURESCALE")]
        DB2_INSTANCE_SUMMARY_INSTANCE_TYPE_PURESCALE,

        [EnumMember(Value = "DB2_INSTANCE_SUMMARY_INSTANCE_TYPE_STANDALONE")]
        DB2_INSTANCE_SUMMARY_INSTANCE_TYPE_STANDALONE,

        [EnumMember(Value = "DB2_INSTANCE_SUMMARY_INSTANCE_TYPE_UNKNOWN")]
        DB2_INSTANCE_SUMMARY_INSTANCE_TYPE_UNKNOWN


    } // enum Db2InstanceSummaryInstanceType

} // namespace RubrikSecurityCloud.Types