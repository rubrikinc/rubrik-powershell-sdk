// GcpBigQueryTableType.cs
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
    public enum GcpBigQueryTableType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "BIGQUERY_TABLE_TYPE_EXTERNAL")]
        BIGQUERY_TABLE_TYPE_EXTERNAL,

        [EnumMember(Value = "BIGQUERY_TABLE_TYPE_MATERIALIZED_VIEW")]
        BIGQUERY_TABLE_TYPE_MATERIALIZED_VIEW,

        [EnumMember(Value = "BIGQUERY_TABLE_TYPE_NATIVE")]
        BIGQUERY_TABLE_TYPE_NATIVE,

        [EnumMember(Value = "BIGQUERY_TABLE_TYPE_VIEW")]
        BIGQUERY_TABLE_TYPE_VIEW


    } // enum GcpBigQueryTableType

} // namespace RubrikSecurityCloud.Types