// Db2ConfigureRestoreResponseStatus.cs
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
    public enum Db2ConfigureRestoreResponseStatus
    {
        [EnumMember(Value = "DB2_CONFIGURE_RESTORE_RESPONSE_STATUS_ERROR")]
        DB2_CONFIGURE_RESTORE_RESPONSE_STATUS_ERROR,

        [EnumMember(Value = "DB2_CONFIGURE_RESTORE_RESPONSE_STATUS_OK")]
        DB2_CONFIGURE_RESTORE_RESPONSE_STATUS_OK,

        [EnumMember(Value = "DB2_CONFIGURE_RESTORE_RESPONSE_STATUS_UNKNOWN")]
        DB2_CONFIGURE_RESTORE_RESPONSE_STATUS_UNKNOWN,

        [EnumMember(Value = "DB2_CONFIGURE_RESTORE_RESPONSE_STATUS_WARNING")]
        DB2_CONFIGURE_RESTORE_RESPONSE_STATUS_WARNING


    } // enum Db2ConfigureRestoreResponseStatus

} // namespace RubrikSecurityCloud.Types