// MssqlLogShippingOkState.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:31.
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
    public enum MssqlLogShippingOkState
    {
        [EnumMember(Value = "MSSQL_LOG_SHIPPING_OK_STATE_RESTORING")]
        MSSQL_LOG_SHIPPING_OK_STATE_RESTORING,

        [EnumMember(Value = "MSSQL_LOG_SHIPPING_OK_STATE_STANDBY")]
        MSSQL_LOG_SHIPPING_OK_STATE_STANDBY


    } // enum MssqlLogShippingOkState

} // namespace Rubrik.SecurityCloud.Types