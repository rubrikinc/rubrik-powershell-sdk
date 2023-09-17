// AwsNativeRdsDbInstanceClass.cs
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
    public enum AwsNativeRdsDbInstanceClass
    {
        [EnumMember(Value = "DB_M1_LARGE")]
        DB_M1_LARGE,

        [EnumMember(Value = "DB_M1_MEDIUM")]
        DB_M1_MEDIUM,

        [EnumMember(Value = "DB_M1_SMALL")]
        DB_M1_SMALL,

        [EnumMember(Value = "DB_M1_XLARGE")]
        DB_M1_XLARGE,

        [EnumMember(Value = "DB_M2_2XLARGE")]
        DB_M2_2XLARGE,

        [EnumMember(Value = "DB_M2_4XLARGE")]
        DB_M2_4XLARGE,

        [EnumMember(Value = "DB_M2_XLARGE")]
        DB_M2_XLARGE,

        [EnumMember(Value = "DB_M3_2XLARGE")]
        DB_M3_2XLARGE,

        [EnumMember(Value = "DB_M3_LARGE")]
        DB_M3_LARGE,

        [EnumMember(Value = "DB_M3_MEDIUM")]
        DB_M3_MEDIUM,

        [EnumMember(Value = "DB_M3_XLARGE")]
        DB_M3_XLARGE,

        [EnumMember(Value = "DB_M4_10XLARGE")]
        DB_M4_10XLARGE,

        [EnumMember(Value = "DB_M4_16XLARGE")]
        DB_M4_16XLARGE,

        [EnumMember(Value = "DB_M4_2XLARGE")]
        DB_M4_2XLARGE,

        [EnumMember(Value = "DB_M4_4XLARGE")]
        DB_M4_4XLARGE,

        [EnumMember(Value = "DB_M4_LARGE")]
        DB_M4_LARGE,

        [EnumMember(Value = "DB_M4_XLARGE")]
        DB_M4_XLARGE,

        [EnumMember(Value = "DB_M5D_12XLARGE")]
        DB_M5D_12XLARGE,

        [EnumMember(Value = "DB_M5D_16XLARGE")]
        DB_M5D_16XLARGE,

        [EnumMember(Value = "DB_M5D_24XLARGE")]
        DB_M5D_24XLARGE,

        [EnumMember(Value = "DB_M5D_2XLARGE")]
        DB_M5D_2XLARGE,

        [EnumMember(Value = "DB_M5D_4XLARGE")]
        DB_M5D_4XLARGE,

        [EnumMember(Value = "DB_M5D_8XLARGE")]
        DB_M5D_8XLARGE,

        [EnumMember(Value = "DB_M5D_LARGE")]
        DB_M5D_LARGE,

        [EnumMember(Value = "DB_M5D_XLARGE")]
        DB_M5D_XLARGE,

        [EnumMember(Value = "DB_M5_12XLARGE")]
        DB_M5_12XLARGE,

        [EnumMember(Value = "DB_M5_16XLARGE")]
        DB_M5_16XLARGE,

        [EnumMember(Value = "DB_M5_24XLARGE")]
        DB_M5_24XLARGE,

        [EnumMember(Value = "DB_M5_2XLARGE")]
        DB_M5_2XLARGE,

        [EnumMember(Value = "DB_M5_4XLARGE")]
        DB_M5_4XLARGE,

        [EnumMember(Value = "DB_M5_8XLARGE")]
        DB_M5_8XLARGE,

        [EnumMember(Value = "DB_M5_LARGE")]
        DB_M5_LARGE,

        [EnumMember(Value = "DB_M5_XLARGE")]
        DB_M5_XLARGE,

        [EnumMember(Value = "DB_M6GD_12XLARGE")]
        DB_M6GD_12XLARGE,

        [EnumMember(Value = "DB_M6GD_16XLARGE")]
        DB_M6GD_16XLARGE,

        [EnumMember(Value = "DB_M6GD_2XLARGE")]
        DB_M6GD_2XLARGE,

        [EnumMember(Value = "DB_M6GD_4XLARGE")]
        DB_M6GD_4XLARGE,

        [EnumMember(Value = "DB_M6GD_8XLARGE")]
        DB_M6GD_8XLARGE,

        [EnumMember(Value = "DB_M6GD_LARGE")]
        DB_M6GD_LARGE,

        [EnumMember(Value = "DB_M6GD_XLARGE")]
        DB_M6GD_XLARGE,

        [EnumMember(Value = "DB_M6G_12XLARGE")]
        DB_M6G_12XLARGE,

        [EnumMember(Value = "DB_M6G_16XLARGE")]
        DB_M6G_16XLARGE,

        [EnumMember(Value = "DB_M6G_2XLARGE")]
        DB_M6G_2XLARGE,

        [EnumMember(Value = "DB_M6G_4XLARGE")]
        DB_M6G_4XLARGE,

        [EnumMember(Value = "DB_M6G_8XLARGE")]
        DB_M6G_8XLARGE,

        [EnumMember(Value = "DB_M6G_LARGE")]
        DB_M6G_LARGE,

        [EnumMember(Value = "DB_M6G_XLARGE")]
        DB_M6G_XLARGE,

        [EnumMember(Value = "DB_M6I_12XLARGE")]
        DB_M6I_12XLARGE,

        [EnumMember(Value = "DB_M6I_16XLARGE")]
        DB_M6I_16XLARGE,

        [EnumMember(Value = "DB_M6I_24XLARGE")]
        DB_M6I_24XLARGE,

        [EnumMember(Value = "DB_M6I_2XLARGE")]
        DB_M6I_2XLARGE,

        [EnumMember(Value = "DB_M6I_32XLARGE")]
        DB_M6I_32XLARGE,

        [EnumMember(Value = "DB_M6I_4XLARGE")]
        DB_M6I_4XLARGE,

        [EnumMember(Value = "DB_M6I_8XLARGE")]
        DB_M6I_8XLARGE,

        [EnumMember(Value = "DB_M6I_LARGE")]
        DB_M6I_LARGE,

        [EnumMember(Value = "DB_M6I_XLARGE")]
        DB_M6I_XLARGE,

        [EnumMember(Value = "DB_R3_2XLARGE")]
        DB_R3_2XLARGE,

        [EnumMember(Value = "DB_R3_4XLARGE")]
        DB_R3_4XLARGE,

        [EnumMember(Value = "DB_R3_8XLARGE")]
        DB_R3_8XLARGE,

        [EnumMember(Value = "DB_R3_LARGE")]
        DB_R3_LARGE,

        [EnumMember(Value = "DB_R3_XLARGE")]
        DB_R3_XLARGE,

        [EnumMember(Value = "DB_R4_12XLARGE")]
        DB_R4_12XLARGE,

        [EnumMember(Value = "DB_R4_16XLARGE")]
        DB_R4_16XLARGE,

        [EnumMember(Value = "DB_R4_2XLARGE")]
        DB_R4_2XLARGE,

        [EnumMember(Value = "DB_R4_4XLARGE")]
        DB_R4_4XLARGE,

        [EnumMember(Value = "DB_R4_8XLARGE")]
        DB_R4_8XLARGE,

        [EnumMember(Value = "DB_R4_LARGE")]
        DB_R4_LARGE,

        [EnumMember(Value = "DB_R4_XLARGE")]
        DB_R4_XLARGE,

        [EnumMember(Value = "DB_R5B_12XLARGE")]
        DB_R5B_12XLARGE,

        [EnumMember(Value = "DB_R5B_16XLARGE")]
        DB_R5B_16XLARGE,

        [EnumMember(Value = "DB_R5B_24XLARGE")]
        DB_R5B_24XLARGE,

        [EnumMember(Value = "DB_R5B_2XLARGE")]
        DB_R5B_2XLARGE,

        [EnumMember(Value = "DB_R5B_4XLARGE")]
        DB_R5B_4XLARGE,

        [EnumMember(Value = "DB_R5B_8XLARGE")]
        DB_R5B_8XLARGE,

        [EnumMember(Value = "DB_R5B_LARGE")]
        DB_R5B_LARGE,

        [EnumMember(Value = "DB_R5B_XLARGE")]
        DB_R5B_XLARGE,

        [EnumMember(Value = "DB_R5D_12XLARGE")]
        DB_R5D_12XLARGE,

        [EnumMember(Value = "DB_R5D_16XLARGE")]
        DB_R5D_16XLARGE,

        [EnumMember(Value = "DB_R5D_24XLARGE")]
        DB_R5D_24XLARGE,

        [EnumMember(Value = "DB_R5D_2XLARGE")]
        DB_R5D_2XLARGE,

        [EnumMember(Value = "DB_R5D_4XLARGE")]
        DB_R5D_4XLARGE,

        [EnumMember(Value = "DB_R5D_8XLARGE")]
        DB_R5D_8XLARGE,

        [EnumMember(Value = "DB_R5D_LARGE")]
        DB_R5D_LARGE,

        [EnumMember(Value = "DB_R5D_XLARGE")]
        DB_R5D_XLARGE,

        [EnumMember(Value = "DB_R5_12XLARGE")]
        DB_R5_12XLARGE,

        [EnumMember(Value = "DB_R5_16XLARGE")]
        DB_R5_16XLARGE,

        [EnumMember(Value = "DB_R5_24XLARGE")]
        DB_R5_24XLARGE,

        [EnumMember(Value = "DB_R5_2XLARGE")]
        DB_R5_2XLARGE,

        [EnumMember(Value = "DB_R5_4XLARGE")]
        DB_R5_4XLARGE,

        [EnumMember(Value = "DB_R5_8XLARGE")]
        DB_R5_8XLARGE,

        [EnumMember(Value = "DB_R5_LARGE")]
        DB_R5_LARGE,

        [EnumMember(Value = "DB_R5_XLARGE")]
        DB_R5_XLARGE,

        [EnumMember(Value = "DB_R6GD_12XLARGE")]
        DB_R6GD_12XLARGE,

        [EnumMember(Value = "DB_R6GD_16XLARGE")]
        DB_R6GD_16XLARGE,

        [EnumMember(Value = "DB_R6GD_2XLARGE")]
        DB_R6GD_2XLARGE,

        [EnumMember(Value = "DB_R6GD_4XLARGE")]
        DB_R6GD_4XLARGE,

        [EnumMember(Value = "DB_R6GD_8XLARGE")]
        DB_R6GD_8XLARGE,

        [EnumMember(Value = "DB_R6GD_LARGE")]
        DB_R6GD_LARGE,

        [EnumMember(Value = "DB_R6GD_XLARGE")]
        DB_R6GD_XLARGE,

        [EnumMember(Value = "DB_R6G_12XLARGE")]
        DB_R6G_12XLARGE,

        [EnumMember(Value = "DB_R6G_16XLARGE")]
        DB_R6G_16XLARGE,

        [EnumMember(Value = "DB_R6G_2XLARGE")]
        DB_R6G_2XLARGE,

        [EnumMember(Value = "DB_R6G_4XLARGE")]
        DB_R6G_4XLARGE,

        [EnumMember(Value = "DB_R6G_8XLARGE")]
        DB_R6G_8XLARGE,

        [EnumMember(Value = "DB_R6G_LARGE")]
        DB_R6G_LARGE,

        [EnumMember(Value = "DB_R6G_XLARGE")]
        DB_R6G_XLARGE,

        [EnumMember(Value = "DB_R6I_12XLARGE")]
        DB_R6I_12XLARGE,

        [EnumMember(Value = "DB_R6I_16XLARGE")]
        DB_R6I_16XLARGE,

        [EnumMember(Value = "DB_R6I_24XLARGE")]
        DB_R6I_24XLARGE,

        [EnumMember(Value = "DB_R6I_2XLARGE")]
        DB_R6I_2XLARGE,

        [EnumMember(Value = "DB_R6I_32XLARGE")]
        DB_R6I_32XLARGE,

        [EnumMember(Value = "DB_R6I_4XLARGE")]
        DB_R6I_4XLARGE,

        [EnumMember(Value = "DB_R6I_8XLARGE")]
        DB_R6I_8XLARGE,

        [EnumMember(Value = "DB_R6I_LARGE")]
        DB_R6I_LARGE,

        [EnumMember(Value = "DB_R6I_XLARGE")]
        DB_R6I_XLARGE,

        [EnumMember(Value = "DB_T2_2XLARGE")]
        DB_T2_2XLARGE,

        [EnumMember(Value = "DB_T2_LARGE")]
        DB_T2_LARGE,

        [EnumMember(Value = "DB_T2_MEDIUM")]
        DB_T2_MEDIUM,

        [EnumMember(Value = "DB_T2_MICRO")]
        DB_T2_MICRO,

        [EnumMember(Value = "DB_T2_SMALL")]
        DB_T2_SMALL,

        [EnumMember(Value = "DB_T2_XLARGE")]
        DB_T2_XLARGE,

        [EnumMember(Value = "DB_T3_2XLARGE")]
        DB_T3_2XLARGE,

        [EnumMember(Value = "DB_T3_LARGE")]
        DB_T3_LARGE,

        [EnumMember(Value = "DB_T3_MEDIUM")]
        DB_T3_MEDIUM,

        [EnumMember(Value = "DB_T3_MICRO")]
        DB_T3_MICRO,

        [EnumMember(Value = "DB_T3_SMALL")]
        DB_T3_SMALL,

        [EnumMember(Value = "DB_T3_XLARGE")]
        DB_T3_XLARGE,

        [EnumMember(Value = "DB_T4G_2XLARGE")]
        DB_T4G_2XLARGE,

        [EnumMember(Value = "DB_T4G_LARGE")]
        DB_T4G_LARGE,

        [EnumMember(Value = "DB_T4G_MEDIUM")]
        DB_T4G_MEDIUM,

        [EnumMember(Value = "DB_T4G_MICRO")]
        DB_T4G_MICRO,

        [EnumMember(Value = "DB_T4G_SMALL")]
        DB_T4G_SMALL,

        [EnumMember(Value = "DB_T4G_XLARGE")]
        DB_T4G_XLARGE,

        [EnumMember(Value = "DB_X1E_16XLARGE")]
        DB_X1E_16XLARGE,

        [EnumMember(Value = "DB_X1E_2XLARGE")]
        DB_X1E_2XLARGE,

        [EnumMember(Value = "DB_X1E_32XLARGE")]
        DB_X1E_32XLARGE,

        [EnumMember(Value = "DB_X1E_4XLARGE")]
        DB_X1E_4XLARGE,

        [EnumMember(Value = "DB_X1E_8XLARGE")]
        DB_X1E_8XLARGE,

        [EnumMember(Value = "DB_X1E_XLARGE")]
        DB_X1E_XLARGE,

        [EnumMember(Value = "DB_X1_16XLARGE")]
        DB_X1_16XLARGE,

        [EnumMember(Value = "DB_X1_32XLARGE")]
        DB_X1_32XLARGE,

        [EnumMember(Value = "DB_X2G_12XLARGE")]
        DB_X2G_12XLARGE,

        [EnumMember(Value = "DB_X2G_16XLARGE")]
        DB_X2G_16XLARGE,

        [EnumMember(Value = "DB_X2G_2XLARGE")]
        DB_X2G_2XLARGE,

        [EnumMember(Value = "DB_X2G_4XLARGE")]
        DB_X2G_4XLARGE,

        [EnumMember(Value = "DB_X2G_8XLARGE")]
        DB_X2G_8XLARGE,

        [EnumMember(Value = "DB_X2G_LARGE")]
        DB_X2G_LARGE,

        [EnumMember(Value = "DB_X2G_MEDIUM")]
        DB_X2G_MEDIUM,

        [EnumMember(Value = "DB_X2G_XLARGE")]
        DB_X2G_XLARGE,

        [EnumMember(Value = "DB_Z1D_12XLARGE")]
        DB_Z1D_12XLARGE,

        [EnumMember(Value = "DB_Z1D_2XLARGE")]
        DB_Z1D_2XLARGE,

        [EnumMember(Value = "DB_Z1D_4XLARGE")]
        DB_Z1D_4XLARGE,

        [EnumMember(Value = "DB_Z1D_6XLARGE")]
        DB_Z1D_6XLARGE,

        [EnumMember(Value = "DB_Z1D_LARGE")]
        DB_Z1D_LARGE,

        [EnumMember(Value = "DB_Z1D_XLARGE")]
        DB_Z1D_XLARGE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum AwsNativeRdsDbInstanceClass

} // namespace RubrikSecurityCloud.Types