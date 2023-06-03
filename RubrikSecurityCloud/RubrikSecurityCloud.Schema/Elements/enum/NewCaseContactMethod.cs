// NewCaseContactMethod.cs
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
    public enum NewCaseContactMethod
    {
        [EnumMember(Value = "CASE_CONTACT_METHOD_UNSPECIFIED")]
        CASE_CONTACT_METHOD_UNSPECIFIED,

        [EnumMember(Value = "EMAIL")]
        EMAIL,

        [EnumMember(Value = "PHONE")]
        PHONE


    } // enum NewCaseContactMethod

} // namespace Rubrik.SecurityCloud.Types