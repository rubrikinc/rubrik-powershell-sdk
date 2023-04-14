// CcpJobStatus.cs
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

namespace Rubrik.SecurityCloud.Types
{
    public enum CcpJobStatus
    {
        [EnumMember(Value = "BOOTSTRAPPING")]
        BOOTSTRAPPING,

        [EnumMember(Value = "COMPLETED")]
        COMPLETED,

        [EnumMember(Value = "FAILED")]
        FAILED,

        [EnumMember(Value = "INITIALIZING")]
        INITIALIZING,

        [EnumMember(Value = "INVALID")]
        INVALID,

        [EnumMember(Value = "NODE_CONNECTION_VERIFICATION")]
        NODE_CONNECTION_VERIFICATION,

        [EnumMember(Value = "NODE_CREATE")]
        NODE_CREATE,

        [EnumMember(Value = "NODE_INFO_EXTRACTION")]
        NODE_INFO_EXTRACTION,

        [EnumMember(Value = "ROTATE_TOKEN")]
        ROTATE_TOKEN


    } // enum CcpJobStatus

} // namespace Rubrik.SecurityCloud.Types