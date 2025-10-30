// AzureRubrikAppUseCase.cs
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
    public enum AzureRubrikAppUseCase
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "AZURE_DEVOPS")]
        AZURE_DEVOPS,

        [EnumMember(Value = "AZURE_RUBRIK_APP_USE_CASE_UNSPECIFIED")]
        AZURE_RUBRIK_APP_USE_CASE_UNSPECIFIED,

        [EnumMember(Value = "DEFAULT")]
        DEFAULT


    } // enum AzureRubrikAppUseCase

} // namespace RubrikSecurityCloud.Types