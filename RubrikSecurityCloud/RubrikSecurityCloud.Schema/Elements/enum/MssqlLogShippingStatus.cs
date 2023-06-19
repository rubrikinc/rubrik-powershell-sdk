// MssqlLogShippingStatus.cs
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
    public enum MssqlLogShippingStatus
    {
        [EnumMember(Value = "MSSQL_LOG_SHIPPING_STATUS_BROKEN")]
        MSSQL_LOG_SHIPPING_STATUS_BROKEN,

        [EnumMember(Value = "MSSQL_LOG_SHIPPING_STATUS_INITIALIZING")]
        MSSQL_LOG_SHIPPING_STATUS_INITIALIZING,

        [EnumMember(Value = "MSSQL_LOG_SHIPPING_STATUS_OK")]
        MSSQL_LOG_SHIPPING_STATUS_OK,

        [EnumMember(Value = "MSSQL_LOG_SHIPPING_STATUS_STALE")]
        MSSQL_LOG_SHIPPING_STATUS_STALE


    } // enum MssqlLogShippingStatus

} // namespace RubrikSecurityCloud.Types