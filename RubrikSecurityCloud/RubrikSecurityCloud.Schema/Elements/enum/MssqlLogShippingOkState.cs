// MssqlLogShippingOkState.cs
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
    public enum MssqlLogShippingOkState
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "MSSQL_LOG_SHIPPING_OK_STATE_RESTORING")]
        MSSQL_LOG_SHIPPING_OK_STATE_RESTORING,

        [EnumMember(Value = "MSSQL_LOG_SHIPPING_OK_STATE_STANDBY")]
        MSSQL_LOG_SHIPPING_OK_STATE_STANDBY


    } // enum MssqlLogShippingOkState

} // namespace RubrikSecurityCloud.Types