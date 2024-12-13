// AwsNativeEc2InstanceType.cs
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
    public enum AwsNativeEc2InstanceType
    {
        [EnumMember(Value = "A1_2XLARGE")]
        A1_2XLARGE,

        [EnumMember(Value = "A1_4XLARGE")]
        A1_4XLARGE,

        [EnumMember(Value = "A1_LARGE")]
        A1_LARGE,

        [EnumMember(Value = "A1_MEDIUM")]
        A1_MEDIUM,

        [EnumMember(Value = "A1_METAL")]
        A1_METAL,

        [EnumMember(Value = "A1_XLARGE")]
        A1_XLARGE,

        [EnumMember(Value = "C1_MEDIUM")]
        C1_MEDIUM,

        [EnumMember(Value = "C1_XLARGE")]
        C1_XLARGE,

        [EnumMember(Value = "C3_2XLARGE")]
        C3_2XLARGE,

        [EnumMember(Value = "C3_4XLARGE")]
        C3_4XLARGE,

        [EnumMember(Value = "C3_8XLARGE")]
        C3_8XLARGE,

        [EnumMember(Value = "C3_LARGE")]
        C3_LARGE,

        [EnumMember(Value = "C3_XLARGE")]
        C3_XLARGE,

        [EnumMember(Value = "C4_2XLARGE")]
        C4_2XLARGE,

        [EnumMember(Value = "C4_4XLARGE")]
        C4_4XLARGE,

        [EnumMember(Value = "C4_8XLARGE")]
        C4_8XLARGE,

        [EnumMember(Value = "C4_LARGE")]
        C4_LARGE,

        [EnumMember(Value = "C4_XLARGE")]
        C4_XLARGE,

        [EnumMember(Value = "C5AD_12XLARGE")]
        C5AD_12XLARGE,

        [EnumMember(Value = "C5AD_16XLARGE")]
        C5AD_16XLARGE,

        [EnumMember(Value = "C5AD_24XLARGE")]
        C5AD_24XLARGE,

        [EnumMember(Value = "C5AD_2XLARGE")]
        C5AD_2XLARGE,

        [EnumMember(Value = "C5AD_4XLARGE")]
        C5AD_4XLARGE,

        [EnumMember(Value = "C5AD_8XLARGE")]
        C5AD_8XLARGE,

        [EnumMember(Value = "C5AD_LARGE")]
        C5AD_LARGE,

        [EnumMember(Value = "C5AD_XLARGE")]
        C5AD_XLARGE,

        [EnumMember(Value = "C5A_12XLARGE")]
        C5A_12XLARGE,

        [EnumMember(Value = "C5A_16XLARGE")]
        C5A_16XLARGE,

        [EnumMember(Value = "C5A_24XLARGE")]
        C5A_24XLARGE,

        [EnumMember(Value = "C5A_2XLARGE")]
        C5A_2XLARGE,

        [EnumMember(Value = "C5A_4XLARGE")]
        C5A_4XLARGE,

        [EnumMember(Value = "C5A_8XLARGE")]
        C5A_8XLARGE,

        [EnumMember(Value = "C5A_LARGE")]
        C5A_LARGE,

        [EnumMember(Value = "C5A_XLARGE")]
        C5A_XLARGE,

        [EnumMember(Value = "C5D_12XLARGE")]
        C5D_12XLARGE,

        [EnumMember(Value = "C5D_18XLARGE")]
        C5D_18XLARGE,

        [EnumMember(Value = "C5D_24XLARGE")]
        C5D_24XLARGE,

        [EnumMember(Value = "C5D_2XLARGE")]
        C5D_2XLARGE,

        [EnumMember(Value = "C5D_4XLARGE")]
        C5D_4XLARGE,

        [EnumMember(Value = "C5D_9XLARGE")]
        C5D_9XLARGE,

        [EnumMember(Value = "C5D_LARGE")]
        C5D_LARGE,

        [EnumMember(Value = "C5D_METAL")]
        C5D_METAL,

        [EnumMember(Value = "C5D_XLARGE")]
        C5D_XLARGE,

        [EnumMember(Value = "C5N_18XLARGE")]
        C5N_18XLARGE,

        [EnumMember(Value = "C5N_2XLARGE")]
        C5N_2XLARGE,

        [EnumMember(Value = "C5N_4XLARGE")]
        C5N_4XLARGE,

        [EnumMember(Value = "C5N_9XLARGE")]
        C5N_9XLARGE,

        [EnumMember(Value = "C5N_LARGE")]
        C5N_LARGE,

        [EnumMember(Value = "C5N_METAL")]
        C5N_METAL,

        [EnumMember(Value = "C5N_XLARGE")]
        C5N_XLARGE,

        [EnumMember(Value = "C5_12XLARGE")]
        C5_12XLARGE,

        [EnumMember(Value = "C5_18XLARGE")]
        C5_18XLARGE,

        [EnumMember(Value = "C5_24XLARGE")]
        C5_24XLARGE,

        [EnumMember(Value = "C5_2XLARGE")]
        C5_2XLARGE,

        [EnumMember(Value = "C5_4XLARGE")]
        C5_4XLARGE,

        [EnumMember(Value = "C5_9XLARGE")]
        C5_9XLARGE,

        [EnumMember(Value = "C5_LARGE")]
        C5_LARGE,

        [EnumMember(Value = "C5_METAL")]
        C5_METAL,

        [EnumMember(Value = "C5_XLARGE")]
        C5_XLARGE,

        [EnumMember(Value = "C6A_12XLARGE")]
        C6A_12XLARGE,

        [EnumMember(Value = "C6A_16XLARGE")]
        C6A_16XLARGE,

        [EnumMember(Value = "C6A_24XLARGE")]
        C6A_24XLARGE,

        [EnumMember(Value = "C6A_2XLARGE")]
        C6A_2XLARGE,

        [EnumMember(Value = "C6A_32XLARGE")]
        C6A_32XLARGE,

        [EnumMember(Value = "C6A_48XLARGE")]
        C6A_48XLARGE,

        [EnumMember(Value = "C6A_4XLARGE")]
        C6A_4XLARGE,

        [EnumMember(Value = "C6A_8XLARGE")]
        C6A_8XLARGE,

        [EnumMember(Value = "C6A_LARGE")]
        C6A_LARGE,

        [EnumMember(Value = "C6A_METAL")]
        C6A_METAL,

        [EnumMember(Value = "C6A_XLARGE")]
        C6A_XLARGE,

        [EnumMember(Value = "C6GD_12XLARGE")]
        C6GD_12XLARGE,

        [EnumMember(Value = "C6GD_16XLARGE")]
        C6GD_16XLARGE,

        [EnumMember(Value = "C6GD_2XLARGE")]
        C6GD_2XLARGE,

        [EnumMember(Value = "C6GD_4XLARGE")]
        C6GD_4XLARGE,

        [EnumMember(Value = "C6GD_8XLARGE")]
        C6GD_8XLARGE,

        [EnumMember(Value = "C6GD_LARGE")]
        C6GD_LARGE,

        [EnumMember(Value = "C6GD_MEDIUM")]
        C6GD_MEDIUM,

        [EnumMember(Value = "C6GD_METAL")]
        C6GD_METAL,

        [EnumMember(Value = "C6GD_XLARGE")]
        C6GD_XLARGE,

        [EnumMember(Value = "C6GN_12XLARGE")]
        C6GN_12XLARGE,

        [EnumMember(Value = "C6GN_16XLARGE")]
        C6GN_16XLARGE,

        [EnumMember(Value = "C6GN_2XLARGE")]
        C6GN_2XLARGE,

        [EnumMember(Value = "C6GN_4XLARGE")]
        C6GN_4XLARGE,

        [EnumMember(Value = "C6GN_8XLARGE")]
        C6GN_8XLARGE,

        [EnumMember(Value = "C6GN_LARGE")]
        C6GN_LARGE,

        [EnumMember(Value = "C6GN_MEDIUM")]
        C6GN_MEDIUM,

        [EnumMember(Value = "C6GN_XLARGE")]
        C6GN_XLARGE,

        [EnumMember(Value = "C6G_12XLARGE")]
        C6G_12XLARGE,

        [EnumMember(Value = "C6G_16XLARGE")]
        C6G_16XLARGE,

        [EnumMember(Value = "C6G_2XLARGE")]
        C6G_2XLARGE,

        [EnumMember(Value = "C6G_4XLARGE")]
        C6G_4XLARGE,

        [EnumMember(Value = "C6G_8XLARGE")]
        C6G_8XLARGE,

        [EnumMember(Value = "C6G_LARGE")]
        C6G_LARGE,

        [EnumMember(Value = "C6G_MEDIUM")]
        C6G_MEDIUM,

        [EnumMember(Value = "C6G_METAL")]
        C6G_METAL,

        [EnumMember(Value = "C6G_XLARGE")]
        C6G_XLARGE,

        [EnumMember(Value = "C6ID_12XLARGE")]
        C6ID_12XLARGE,

        [EnumMember(Value = "C6ID_16XLARGE")]
        C6ID_16XLARGE,

        [EnumMember(Value = "C6ID_24XLARGE")]
        C6ID_24XLARGE,

        [EnumMember(Value = "C6ID_2XLARGE")]
        C6ID_2XLARGE,

        [EnumMember(Value = "C6ID_32XLARGE")]
        C6ID_32XLARGE,

        [EnumMember(Value = "C6ID_4XLARGE")]
        C6ID_4XLARGE,

        [EnumMember(Value = "C6ID_8XLARGE")]
        C6ID_8XLARGE,

        [EnumMember(Value = "C6ID_LARGE")]
        C6ID_LARGE,

        [EnumMember(Value = "C6ID_METAL")]
        C6ID_METAL,

        [EnumMember(Value = "C6ID_XLARGE")]
        C6ID_XLARGE,

        [EnumMember(Value = "C6IN_12XLARGE")]
        C6IN_12XLARGE,

        [EnumMember(Value = "C6IN_16XLARGE")]
        C6IN_16XLARGE,

        [EnumMember(Value = "C6IN_24XLARGE")]
        C6IN_24XLARGE,

        [EnumMember(Value = "C6IN_2XLARGE")]
        C6IN_2XLARGE,

        [EnumMember(Value = "C6IN_32XLARGE")]
        C6IN_32XLARGE,

        [EnumMember(Value = "C6IN_4XLARGE")]
        C6IN_4XLARGE,

        [EnumMember(Value = "C6IN_8XLARGE")]
        C6IN_8XLARGE,

        [EnumMember(Value = "C6IN_LARGE")]
        C6IN_LARGE,

        [EnumMember(Value = "C6IN_METAL")]
        C6IN_METAL,

        [EnumMember(Value = "C6IN_XLARGE")]
        C6IN_XLARGE,

        [EnumMember(Value = "C6I_12XLARGE")]
        C6I_12XLARGE,

        [EnumMember(Value = "C6I_16XLARGE")]
        C6I_16XLARGE,

        [EnumMember(Value = "C6I_24XLARGE")]
        C6I_24XLARGE,

        [EnumMember(Value = "C6I_2XLARGE")]
        C6I_2XLARGE,

        [EnumMember(Value = "C6I_32XLARGE")]
        C6I_32XLARGE,

        [EnumMember(Value = "C6I_4XLARGE")]
        C6I_4XLARGE,

        [EnumMember(Value = "C6I_8XLARGE")]
        C6I_8XLARGE,

        [EnumMember(Value = "C6I_LARGE")]
        C6I_LARGE,

        [EnumMember(Value = "C6I_METAL")]
        C6I_METAL,

        [EnumMember(Value = "C6I_XLARGE")]
        C6I_XLARGE,

        [EnumMember(Value = "C7GD_12XLARGE")]
        C7GD_12XLARGE,

        [EnumMember(Value = "C7GD_16XLARGE")]
        C7GD_16XLARGE,

        [EnumMember(Value = "C7GD_2XLARGE")]
        C7GD_2XLARGE,

        [EnumMember(Value = "C7GD_4XLARGE")]
        C7GD_4XLARGE,

        [EnumMember(Value = "C7GD_8XLARGE")]
        C7GD_8XLARGE,

        [EnumMember(Value = "C7GD_LARGE")]
        C7GD_LARGE,

        [EnumMember(Value = "C7GD_MEDIUM")]
        C7GD_MEDIUM,

        [EnumMember(Value = "C7GD_XLARGE")]
        C7GD_XLARGE,

        [EnumMember(Value = "C7GN_12XLARGE")]
        C7GN_12XLARGE,

        [EnumMember(Value = "C7GN_16XLARGE")]
        C7GN_16XLARGE,

        [EnumMember(Value = "C7GN_2XLARGE")]
        C7GN_2XLARGE,

        [EnumMember(Value = "C7GN_4XLARGE")]
        C7GN_4XLARGE,

        [EnumMember(Value = "C7GN_8XLARGE")]
        C7GN_8XLARGE,

        [EnumMember(Value = "C7GN_LARGE")]
        C7GN_LARGE,

        [EnumMember(Value = "C7GN_MEDIUM")]
        C7GN_MEDIUM,

        [EnumMember(Value = "C7GN_XLARGE")]
        C7GN_XLARGE,

        [EnumMember(Value = "C7G_12XLARGE")]
        C7G_12XLARGE,

        [EnumMember(Value = "C7G_16XLARGE")]
        C7G_16XLARGE,

        [EnumMember(Value = "C7G_2XLARGE")]
        C7G_2XLARGE,

        [EnumMember(Value = "C7G_4XLARGE")]
        C7G_4XLARGE,

        [EnumMember(Value = "C7G_8XLARGE")]
        C7G_8XLARGE,

        [EnumMember(Value = "C7G_LARGE")]
        C7G_LARGE,

        [EnumMember(Value = "C7G_MEDIUM")]
        C7G_MEDIUM,

        [EnumMember(Value = "C7G_METAL")]
        C7G_METAL,

        [EnumMember(Value = "C7G_XLARGE")]
        C7G_XLARGE,

        [EnumMember(Value = "C7I_12XLARGE")]
        C7I_12XLARGE,

        [EnumMember(Value = "C7I_16XLARGE")]
        C7I_16XLARGE,

        [EnumMember(Value = "C7I_24XLARGE")]
        C7I_24XLARGE,

        [EnumMember(Value = "C7I_2XLARGE")]
        C7I_2XLARGE,

        [EnumMember(Value = "C7I_48XLARGE")]
        C7I_48XLARGE,

        [EnumMember(Value = "C7I_4XLARGE")]
        C7I_4XLARGE,

        [EnumMember(Value = "C7I_8XLARGE")]
        C7I_8XLARGE,

        [EnumMember(Value = "C7I_LARGE")]
        C7I_LARGE,

        [EnumMember(Value = "C7I_XLARGE")]
        C7I_XLARGE,

        [EnumMember(Value = "CC1_4XLARGE")]
        CC1_4XLARGE,

        [EnumMember(Value = "CC2_8XLARGE")]
        CC2_8XLARGE,

        [EnumMember(Value = "CG1_4XLARGE")]
        CG1_4XLARGE,

        [EnumMember(Value = "CR1_8XLARGE")]
        CR1_8XLARGE,

        [EnumMember(Value = "D2_2XLARGE")]
        D2_2XLARGE,

        [EnumMember(Value = "D2_4XLARGE")]
        D2_4XLARGE,

        [EnumMember(Value = "D2_8XLARGE")]
        D2_8XLARGE,

        [EnumMember(Value = "D2_XLARGE")]
        D2_XLARGE,

        [EnumMember(Value = "D3EN_12XLARGE")]
        D3EN_12XLARGE,

        [EnumMember(Value = "D3EN_2XLARGE")]
        D3EN_2XLARGE,

        [EnumMember(Value = "D3EN_4XLARGE")]
        D3EN_4XLARGE,

        [EnumMember(Value = "D3EN_6XLARGE")]
        D3EN_6XLARGE,

        [EnumMember(Value = "D3EN_8XLARGE")]
        D3EN_8XLARGE,

        [EnumMember(Value = "D3EN_XLARGE")]
        D3EN_XLARGE,

        [EnumMember(Value = "D3_2XLARGE")]
        D3_2XLARGE,

        [EnumMember(Value = "D3_4XLARGE")]
        D3_4XLARGE,

        [EnumMember(Value = "D3_8XLARGE")]
        D3_8XLARGE,

        [EnumMember(Value = "D3_XLARGE")]
        D3_XLARGE,

        [EnumMember(Value = "DL1_24XLARGE")]
        DL1_24XLARGE,

        [EnumMember(Value = "F1_16XLARGE")]
        F1_16XLARGE,

        [EnumMember(Value = "F1_2XLARGE")]
        F1_2XLARGE,

        [EnumMember(Value = "F1_4XLARGE")]
        F1_4XLARGE,

        [EnumMember(Value = "G2_2XLARGE")]
        G2_2XLARGE,

        [EnumMember(Value = "G2_8XLARGE")]
        G2_8XLARGE,

        [EnumMember(Value = "G3S_XLARGE")]
        G3S_XLARGE,

        [EnumMember(Value = "G3_16XLARGE")]
        G3_16XLARGE,

        [EnumMember(Value = "G3_4XLARGE")]
        G3_4XLARGE,

        [EnumMember(Value = "G3_8XLARGE")]
        G3_8XLARGE,

        [EnumMember(Value = "G4AD_16XLARGE")]
        G4AD_16XLARGE,

        [EnumMember(Value = "G4AD_2XLARGE")]
        G4AD_2XLARGE,

        [EnumMember(Value = "G4AD_4XLARGE")]
        G4AD_4XLARGE,

        [EnumMember(Value = "G4AD_8XLARGE")]
        G4AD_8XLARGE,

        [EnumMember(Value = "G4AD_XLARGE")]
        G4AD_XLARGE,

        [EnumMember(Value = "G4DN_12XLARGE")]
        G4DN_12XLARGE,

        [EnumMember(Value = "G4DN_16XLARGE")]
        G4DN_16XLARGE,

        [EnumMember(Value = "G4DN_2XLARGE")]
        G4DN_2XLARGE,

        [EnumMember(Value = "G4DN_4XLARGE")]
        G4DN_4XLARGE,

        [EnumMember(Value = "G4DN_8XLARGE")]
        G4DN_8XLARGE,

        [EnumMember(Value = "G4DN_METAL")]
        G4DN_METAL,

        [EnumMember(Value = "G4DN_XLARGE")]
        G4DN_XLARGE,

        [EnumMember(Value = "G5G_16XLARGE")]
        G5G_16XLARGE,

        [EnumMember(Value = "G5G_2XLARGE")]
        G5G_2XLARGE,

        [EnumMember(Value = "G5G_4XLARGE")]
        G5G_4XLARGE,

        [EnumMember(Value = "G5G_8XLARGE")]
        G5G_8XLARGE,

        [EnumMember(Value = "G5G_METAL")]
        G5G_METAL,

        [EnumMember(Value = "G5G_XLARGE")]
        G5G_XLARGE,

        [EnumMember(Value = "G5_12XLARGE")]
        G5_12XLARGE,

        [EnumMember(Value = "G5_16XLARGE")]
        G5_16XLARGE,

        [EnumMember(Value = "G5_24XLARGE")]
        G5_24XLARGE,

        [EnumMember(Value = "G5_2XLARGE")]
        G5_2XLARGE,

        [EnumMember(Value = "G5_48XLARGE")]
        G5_48XLARGE,

        [EnumMember(Value = "G5_4XLARGE")]
        G5_4XLARGE,

        [EnumMember(Value = "G5_8XLARGE")]
        G5_8XLARGE,

        [EnumMember(Value = "G5_XLARGE")]
        G5_XLARGE,

        [EnumMember(Value = "H1_16XLARGE")]
        H1_16XLARGE,

        [EnumMember(Value = "H1_2XLARGE")]
        H1_2XLARGE,

        [EnumMember(Value = "H1_4XLARGE")]
        H1_4XLARGE,

        [EnumMember(Value = "H1_8XLARGE")]
        H1_8XLARGE,

        [EnumMember(Value = "HI1_4XLARGE")]
        HI1_4XLARGE,

        [EnumMember(Value = "HPC7G_16XLARGE")]
        HPC7G_16XLARGE,

        [EnumMember(Value = "HPC7G_4XLARGE")]
        HPC7G_4XLARGE,

        [EnumMember(Value = "HPC7G_8XLARGE")]
        HPC7G_8XLARGE,

        [EnumMember(Value = "HS1_8XLARGE")]
        HS1_8XLARGE,

        [EnumMember(Value = "I2_2XLARGE")]
        I2_2XLARGE,

        [EnumMember(Value = "I2_4XLARGE")]
        I2_4XLARGE,

        [EnumMember(Value = "I2_8XLARGE")]
        I2_8XLARGE,

        [EnumMember(Value = "I2_XLARGE")]
        I2_XLARGE,

        [EnumMember(Value = "I3EN_12XLARGE")]
        I3EN_12XLARGE,

        [EnumMember(Value = "I3EN_24XLARGE")]
        I3EN_24XLARGE,

        [EnumMember(Value = "I3EN_2XLARGE")]
        I3EN_2XLARGE,

        [EnumMember(Value = "I3EN_3XLARGE")]
        I3EN_3XLARGE,

        [EnumMember(Value = "I3EN_6XLARGE")]
        I3EN_6XLARGE,

        [EnumMember(Value = "I3EN_LARGE")]
        I3EN_LARGE,

        [EnumMember(Value = "I3EN_METAL")]
        I3EN_METAL,

        [EnumMember(Value = "I3EN_XLARGE")]
        I3EN_XLARGE,

        [EnumMember(Value = "I3_16XLARGE")]
        I3_16XLARGE,

        [EnumMember(Value = "I3_2XLARGE")]
        I3_2XLARGE,

        [EnumMember(Value = "I3_4XLARGE")]
        I3_4XLARGE,

        [EnumMember(Value = "I3_8XLARGE")]
        I3_8XLARGE,

        [EnumMember(Value = "I3_LARGE")]
        I3_LARGE,

        [EnumMember(Value = "I3_METAL")]
        I3_METAL,

        [EnumMember(Value = "I3_XLARGE")]
        I3_XLARGE,

        [EnumMember(Value = "I4G_16XLARGE")]
        I4G_16XLARGE,

        [EnumMember(Value = "I4G_2XLARGE")]
        I4G_2XLARGE,

        [EnumMember(Value = "I4G_4XLARGE")]
        I4G_4XLARGE,

        [EnumMember(Value = "I4G_8XLARGE")]
        I4G_8XLARGE,

        [EnumMember(Value = "I4G_LARGE")]
        I4G_LARGE,

        [EnumMember(Value = "I4G_XLARGE")]
        I4G_XLARGE,

        [EnumMember(Value = "I4I_16XLARGE")]
        I4I_16XLARGE,

        [EnumMember(Value = "I4I_2XLARGE")]
        I4I_2XLARGE,

        [EnumMember(Value = "I4I_32XLARGE")]
        I4I_32XLARGE,

        [EnumMember(Value = "I4I_4XLARGE")]
        I4I_4XLARGE,

        [EnumMember(Value = "I4I_8XLARGE")]
        I4I_8XLARGE,

        [EnumMember(Value = "I4I_LARGE")]
        I4I_LARGE,

        [EnumMember(Value = "I4I_METAL")]
        I4I_METAL,

        [EnumMember(Value = "I4I_XLARGE")]
        I4I_XLARGE,

        [EnumMember(Value = "IM4GN_16XLARGE")]
        IM4GN_16XLARGE,

        [EnumMember(Value = "IM4GN_2XLARGE")]
        IM4GN_2XLARGE,

        [EnumMember(Value = "IM4GN_4XLARGE")]
        IM4GN_4XLARGE,

        [EnumMember(Value = "IM4GN_8XLARGE")]
        IM4GN_8XLARGE,

        [EnumMember(Value = "IM4GN_LARGE")]
        IM4GN_LARGE,

        [EnumMember(Value = "IM4GN_XLARGE")]
        IM4GN_XLARGE,

        [EnumMember(Value = "INF1_24XLARGE")]
        INF1_24XLARGE,

        [EnumMember(Value = "INF1_2XLARGE")]
        INF1_2XLARGE,

        [EnumMember(Value = "INF1_6XLARGE")]
        INF1_6XLARGE,

        [EnumMember(Value = "INF1_XLARGE")]
        INF1_XLARGE,

        [EnumMember(Value = "INF2_24XLARGE")]
        INF2_24XLARGE,

        [EnumMember(Value = "INF2_48XLARGE")]
        INF2_48XLARGE,

        [EnumMember(Value = "INF2_8XLARGE")]
        INF2_8XLARGE,

        [EnumMember(Value = "INF2_XLARGE")]
        INF2_XLARGE,

        [EnumMember(Value = "IS4GEN_2XLARGE")]
        IS4GEN_2XLARGE,

        [EnumMember(Value = "IS4GEN_4XLARGE")]
        IS4GEN_4XLARGE,

        [EnumMember(Value = "IS4GEN_8XLARGE")]
        IS4GEN_8XLARGE,

        [EnumMember(Value = "IS4GEN_LARGE")]
        IS4GEN_LARGE,

        [EnumMember(Value = "IS4GEN_MEDIUM")]
        IS4GEN_MEDIUM,

        [EnumMember(Value = "IS4GEN_XLARGE")]
        IS4GEN_XLARGE,

        [EnumMember(Value = "M1_LARGE")]
        M1_LARGE,

        [EnumMember(Value = "M1_MEDIUM")]
        M1_MEDIUM,

        [EnumMember(Value = "M1_SMALL")]
        M1_SMALL,

        [EnumMember(Value = "M1_XLARGE")]
        M1_XLARGE,

        [EnumMember(Value = "M2_2XLARGE")]
        M2_2XLARGE,

        [EnumMember(Value = "M2_4XLARGE")]
        M2_4XLARGE,

        [EnumMember(Value = "M2_XLARGE")]
        M2_XLARGE,

        [EnumMember(Value = "M3_2XLARGE")]
        M3_2XLARGE,

        [EnumMember(Value = "M3_LARGE")]
        M3_LARGE,

        [EnumMember(Value = "M3_MEDIUM")]
        M3_MEDIUM,

        [EnumMember(Value = "M3_XLARGE")]
        M3_XLARGE,

        [EnumMember(Value = "M4_10XLARGE")]
        M4_10XLARGE,

        [EnumMember(Value = "M4_16XLARGE")]
        M4_16XLARGE,

        [EnumMember(Value = "M4_2XLARGE")]
        M4_2XLARGE,

        [EnumMember(Value = "M4_4XLARGE")]
        M4_4XLARGE,

        [EnumMember(Value = "M4_LARGE")]
        M4_LARGE,

        [EnumMember(Value = "M4_XLARGE")]
        M4_XLARGE,

        [EnumMember(Value = "M5AD_12XLARGE")]
        M5AD_12XLARGE,

        [EnumMember(Value = "M5AD_16XLARGE")]
        M5AD_16XLARGE,

        [EnumMember(Value = "M5AD_24XLARGE")]
        M5AD_24XLARGE,

        [EnumMember(Value = "M5AD_2XLARGE")]
        M5AD_2XLARGE,

        [EnumMember(Value = "M5AD_4XLARGE")]
        M5AD_4XLARGE,

        [EnumMember(Value = "M5AD_8XLARGE")]
        M5AD_8XLARGE,

        [EnumMember(Value = "M5AD_LARGE")]
        M5AD_LARGE,

        [EnumMember(Value = "M5AD_XLARGE")]
        M5AD_XLARGE,

        [EnumMember(Value = "M5A_12XLARGE")]
        M5A_12XLARGE,

        [EnumMember(Value = "M5A_16XLARGE")]
        M5A_16XLARGE,

        [EnumMember(Value = "M5A_24XLARGE")]
        M5A_24XLARGE,

        [EnumMember(Value = "M5A_2XLARGE")]
        M5A_2XLARGE,

        [EnumMember(Value = "M5A_4XLARGE")]
        M5A_4XLARGE,

        [EnumMember(Value = "M5A_8XLARGE")]
        M5A_8XLARGE,

        [EnumMember(Value = "M5A_LARGE")]
        M5A_LARGE,

        [EnumMember(Value = "M5A_XLARGE")]
        M5A_XLARGE,

        [EnumMember(Value = "M5DN_12XLARGE")]
        M5DN_12XLARGE,

        [EnumMember(Value = "M5DN_16XLARGE")]
        M5DN_16XLARGE,

        [EnumMember(Value = "M5DN_24XLARGE")]
        M5DN_24XLARGE,

        [EnumMember(Value = "M5DN_2XLARGE")]
        M5DN_2XLARGE,

        [EnumMember(Value = "M5DN_4XLARGE")]
        M5DN_4XLARGE,

        [EnumMember(Value = "M5DN_8XLARGE")]
        M5DN_8XLARGE,

        [EnumMember(Value = "M5DN_LARGE")]
        M5DN_LARGE,

        [EnumMember(Value = "M5DN_METAL")]
        M5DN_METAL,

        [EnumMember(Value = "M5DN_XLARGE")]
        M5DN_XLARGE,

        [EnumMember(Value = "M5D_12XLARGE")]
        M5D_12XLARGE,

        [EnumMember(Value = "M5D_16XLARGE")]
        M5D_16XLARGE,

        [EnumMember(Value = "M5D_24XLARGE")]
        M5D_24XLARGE,

        [EnumMember(Value = "M5D_2XLARGE")]
        M5D_2XLARGE,

        [EnumMember(Value = "M5D_4XLARGE")]
        M5D_4XLARGE,

        [EnumMember(Value = "M5D_8XLARGE")]
        M5D_8XLARGE,

        [EnumMember(Value = "M5D_LARGE")]
        M5D_LARGE,

        [EnumMember(Value = "M5D_METAL")]
        M5D_METAL,

        [EnumMember(Value = "M5D_XLARGE")]
        M5D_XLARGE,

        [EnumMember(Value = "M5N_12XLARGE")]
        M5N_12XLARGE,

        [EnumMember(Value = "M5N_16XLARGE")]
        M5N_16XLARGE,

        [EnumMember(Value = "M5N_24XLARGE")]
        M5N_24XLARGE,

        [EnumMember(Value = "M5N_2XLARGE")]
        M5N_2XLARGE,

        [EnumMember(Value = "M5N_4XLARGE")]
        M5N_4XLARGE,

        [EnumMember(Value = "M5N_8XLARGE")]
        M5N_8XLARGE,

        [EnumMember(Value = "M5N_LARGE")]
        M5N_LARGE,

        [EnumMember(Value = "M5N_METAL")]
        M5N_METAL,

        [EnumMember(Value = "M5N_XLARGE")]
        M5N_XLARGE,

        [EnumMember(Value = "M5ZN_12XLARGE")]
        M5ZN_12XLARGE,

        [EnumMember(Value = "M5ZN_2XLARGE")]
        M5ZN_2XLARGE,

        [EnumMember(Value = "M5ZN_3XLARGE")]
        M5ZN_3XLARGE,

        [EnumMember(Value = "M5ZN_6XLARGE")]
        M5ZN_6XLARGE,

        [EnumMember(Value = "M5ZN_LARGE")]
        M5ZN_LARGE,

        [EnumMember(Value = "M5ZN_METAL")]
        M5ZN_METAL,

        [EnumMember(Value = "M5ZN_XLARGE")]
        M5ZN_XLARGE,

        [EnumMember(Value = "M5_12XLARGE")]
        M5_12XLARGE,

        [EnumMember(Value = "M5_16XLARGE")]
        M5_16XLARGE,

        [EnumMember(Value = "M5_24XLARGE")]
        M5_24XLARGE,

        [EnumMember(Value = "M5_2XLARGE")]
        M5_2XLARGE,

        [EnumMember(Value = "M5_4XLARGE")]
        M5_4XLARGE,

        [EnumMember(Value = "M5_8XLARGE")]
        M5_8XLARGE,

        [EnumMember(Value = "M5_LARGE")]
        M5_LARGE,

        [EnumMember(Value = "M5_METAL")]
        M5_METAL,

        [EnumMember(Value = "M5_XLARGE")]
        M5_XLARGE,

        [EnumMember(Value = "M6A_12XLARGE")]
        M6A_12XLARGE,

        [EnumMember(Value = "M6A_16XLARGE")]
        M6A_16XLARGE,

        [EnumMember(Value = "M6A_24XLARGE")]
        M6A_24XLARGE,

        [EnumMember(Value = "M6A_2XLARGE")]
        M6A_2XLARGE,

        [EnumMember(Value = "M6A_32XLARGE")]
        M6A_32XLARGE,

        [EnumMember(Value = "M6A_48XLARGE")]
        M6A_48XLARGE,

        [EnumMember(Value = "M6A_4XLARGE")]
        M6A_4XLARGE,

        [EnumMember(Value = "M6A_8XLARGE")]
        M6A_8XLARGE,

        [EnumMember(Value = "M6A_LARGE")]
        M6A_LARGE,

        [EnumMember(Value = "M6A_METAL")]
        M6A_METAL,

        [EnumMember(Value = "M6A_XLARGE")]
        M6A_XLARGE,

        [EnumMember(Value = "M6GD_12XLARGE")]
        M6GD_12XLARGE,

        [EnumMember(Value = "M6GD_16XLARGE")]
        M6GD_16XLARGE,

        [EnumMember(Value = "M6GD_2XLARGE")]
        M6GD_2XLARGE,

        [EnumMember(Value = "M6GD_4XLARGE")]
        M6GD_4XLARGE,

        [EnumMember(Value = "M6GD_8XLARGE")]
        M6GD_8XLARGE,

        [EnumMember(Value = "M6GD_LARGE")]
        M6GD_LARGE,

        [EnumMember(Value = "M6GD_MEDIUM")]
        M6GD_MEDIUM,

        [EnumMember(Value = "M6GD_METAL")]
        M6GD_METAL,

        [EnumMember(Value = "M6GD_XLARGE")]
        M6GD_XLARGE,

        [EnumMember(Value = "M6G_12XLARGE")]
        M6G_12XLARGE,

        [EnumMember(Value = "M6G_16XLARGE")]
        M6G_16XLARGE,

        [EnumMember(Value = "M6G_2XLARGE")]
        M6G_2XLARGE,

        [EnumMember(Value = "M6G_4XLARGE")]
        M6G_4XLARGE,

        [EnumMember(Value = "M6G_8XLARGE")]
        M6G_8XLARGE,

        [EnumMember(Value = "M6G_LARGE")]
        M6G_LARGE,

        [EnumMember(Value = "M6G_MEDIUM")]
        M6G_MEDIUM,

        [EnumMember(Value = "M6G_METAL")]
        M6G_METAL,

        [EnumMember(Value = "M6G_XLARGE")]
        M6G_XLARGE,

        [EnumMember(Value = "M6IDN_12XLARGE")]
        M6IDN_12XLARGE,

        [EnumMember(Value = "M6IDN_16XLARGE")]
        M6IDN_16XLARGE,

        [EnumMember(Value = "M6IDN_24XLARGE")]
        M6IDN_24XLARGE,

        [EnumMember(Value = "M6IDN_2XLARGE")]
        M6IDN_2XLARGE,

        [EnumMember(Value = "M6IDN_32XLARGE")]
        M6IDN_32XLARGE,

        [EnumMember(Value = "M6IDN_4XLARGE")]
        M6IDN_4XLARGE,

        [EnumMember(Value = "M6IDN_8XLARGE")]
        M6IDN_8XLARGE,

        [EnumMember(Value = "M6IDN_LARGE")]
        M6IDN_LARGE,

        [EnumMember(Value = "M6IDN_METAL")]
        M6IDN_METAL,

        [EnumMember(Value = "M6IDN_XLARGE")]
        M6IDN_XLARGE,

        [EnumMember(Value = "M6ID_12XLARGE")]
        M6ID_12XLARGE,

        [EnumMember(Value = "M6ID_16XLARGE")]
        M6ID_16XLARGE,

        [EnumMember(Value = "M6ID_24XLARGE")]
        M6ID_24XLARGE,

        [EnumMember(Value = "M6ID_2XLARGE")]
        M6ID_2XLARGE,

        [EnumMember(Value = "M6ID_32XLARGE")]
        M6ID_32XLARGE,

        [EnumMember(Value = "M6ID_4XLARGE")]
        M6ID_4XLARGE,

        [EnumMember(Value = "M6ID_8XLARGE")]
        M6ID_8XLARGE,

        [EnumMember(Value = "M6ID_LARGE")]
        M6ID_LARGE,

        [EnumMember(Value = "M6ID_METAL")]
        M6ID_METAL,

        [EnumMember(Value = "M6ID_XLARGE")]
        M6ID_XLARGE,

        [EnumMember(Value = "M6IN_12XLARGE")]
        M6IN_12XLARGE,

        [EnumMember(Value = "M6IN_16XLARGE")]
        M6IN_16XLARGE,

        [EnumMember(Value = "M6IN_24XLARGE")]
        M6IN_24XLARGE,

        [EnumMember(Value = "M6IN_2XLARGE")]
        M6IN_2XLARGE,

        [EnumMember(Value = "M6IN_32XLARGE")]
        M6IN_32XLARGE,

        [EnumMember(Value = "M6IN_4XLARGE")]
        M6IN_4XLARGE,

        [EnumMember(Value = "M6IN_8XLARGE")]
        M6IN_8XLARGE,

        [EnumMember(Value = "M6IN_LARGE")]
        M6IN_LARGE,

        [EnumMember(Value = "M6IN_METAL")]
        M6IN_METAL,

        [EnumMember(Value = "M6IN_XLARGE")]
        M6IN_XLARGE,

        [EnumMember(Value = "M6I_12XLARGE")]
        M6I_12XLARGE,

        [EnumMember(Value = "M6I_16XLARGE")]
        M6I_16XLARGE,

        [EnumMember(Value = "M6I_24XLARGE")]
        M6I_24XLARGE,

        [EnumMember(Value = "M6I_2XLARGE")]
        M6I_2XLARGE,

        [EnumMember(Value = "M6I_32XLARGE")]
        M6I_32XLARGE,

        [EnumMember(Value = "M6I_4XLARGE")]
        M6I_4XLARGE,

        [EnumMember(Value = "M6I_8XLARGE")]
        M6I_8XLARGE,

        [EnumMember(Value = "M6I_LARGE")]
        M6I_LARGE,

        [EnumMember(Value = "M6I_METAL")]
        M6I_METAL,

        [EnumMember(Value = "M6I_XLARGE")]
        M6I_XLARGE,

        [EnumMember(Value = "M7A_12XLARGE")]
        M7A_12XLARGE,

        [EnumMember(Value = "M7A_16XLARGE")]
        M7A_16XLARGE,

        [EnumMember(Value = "M7A_24XLARGE")]
        M7A_24XLARGE,

        [EnumMember(Value = "M7A_2XLARGE")]
        M7A_2XLARGE,

        [EnumMember(Value = "M7A_32XLARGE")]
        M7A_32XLARGE,

        [EnumMember(Value = "M7A_48XLARGE")]
        M7A_48XLARGE,

        [EnumMember(Value = "M7A_4XLARGE")]
        M7A_4XLARGE,

        [EnumMember(Value = "M7A_8XLARGE")]
        M7A_8XLARGE,

        [EnumMember(Value = "M7A_LARGE")]
        M7A_LARGE,

        [EnumMember(Value = "M7A_MEDIUM")]
        M7A_MEDIUM,

        [EnumMember(Value = "M7A_METAL_48XL")]
        M7A_METAL_48XL,

        [EnumMember(Value = "M7A_XLARGE")]
        M7A_XLARGE,

        [EnumMember(Value = "M7GD_12XLARGE")]
        M7GD_12XLARGE,

        [EnumMember(Value = "M7GD_16XLARGE")]
        M7GD_16XLARGE,

        [EnumMember(Value = "M7GD_2XLARGE")]
        M7GD_2XLARGE,

        [EnumMember(Value = "M7GD_4XLARGE")]
        M7GD_4XLARGE,

        [EnumMember(Value = "M7GD_8XLARGE")]
        M7GD_8XLARGE,

        [EnumMember(Value = "M7GD_LARGE")]
        M7GD_LARGE,

        [EnumMember(Value = "M7GD_MEDIUM")]
        M7GD_MEDIUM,

        [EnumMember(Value = "M7GD_XLARGE")]
        M7GD_XLARGE,

        [EnumMember(Value = "M7G_12XLARGE")]
        M7G_12XLARGE,

        [EnumMember(Value = "M7G_16XLARGE")]
        M7G_16XLARGE,

        [EnumMember(Value = "M7G_2XLARGE")]
        M7G_2XLARGE,

        [EnumMember(Value = "M7G_4XLARGE")]
        M7G_4XLARGE,

        [EnumMember(Value = "M7G_8XLARGE")]
        M7G_8XLARGE,

        [EnumMember(Value = "M7G_LARGE")]
        M7G_LARGE,

        [EnumMember(Value = "M7G_MEDIUM")]
        M7G_MEDIUM,

        [EnumMember(Value = "M7G_METAL")]
        M7G_METAL,

        [EnumMember(Value = "M7G_XLARGE")]
        M7G_XLARGE,

        [EnumMember(Value = "M7I_12XLARGE")]
        M7I_12XLARGE,

        [EnumMember(Value = "M7I_16XLARGE")]
        M7I_16XLARGE,

        [EnumMember(Value = "M7I_24XLARGE")]
        M7I_24XLARGE,

        [EnumMember(Value = "M7I_2XLARGE")]
        M7I_2XLARGE,

        [EnumMember(Value = "M7I_48XLARGE")]
        M7I_48XLARGE,

        [EnumMember(Value = "M7I_4XLARGE")]
        M7I_4XLARGE,

        [EnumMember(Value = "M7I_8XLARGE")]
        M7I_8XLARGE,

        [EnumMember(Value = "M7I_FLEX_2XLARGE")]
        M7I_FLEX_2XLARGE,

        [EnumMember(Value = "M7I_FLEX_4XLARGE")]
        M7I_FLEX_4XLARGE,

        [EnumMember(Value = "M7I_FLEX_8XLARGE")]
        M7I_FLEX_8XLARGE,

        [EnumMember(Value = "M7I_FLEX_LARGE")]
        M7I_FLEX_LARGE,

        [EnumMember(Value = "M7I_FLEX_XLARGE")]
        M7I_FLEX_XLARGE,

        [EnumMember(Value = "M7I_LARGE")]
        M7I_LARGE,

        [EnumMember(Value = "M7I_XLARGE")]
        M7I_XLARGE,

        [EnumMember(Value = "MAC1_METAL")]
        MAC1_METAL,

        [EnumMember(Value = "MAC2_METAL")]
        MAC2_METAL,

        [EnumMember(Value = "NOT_SPECIFIED")]
        NOT_SPECIFIED,

        [EnumMember(Value = "P2_16XLARGE")]
        P2_16XLARGE,

        [EnumMember(Value = "P2_8XLARGE")]
        P2_8XLARGE,

        [EnumMember(Value = "P2_XLARGE")]
        P2_XLARGE,

        [EnumMember(Value = "P3DN_24XLARGE")]
        P3DN_24XLARGE,

        [EnumMember(Value = "P3_16XLARGE")]
        P3_16XLARGE,

        [EnumMember(Value = "P3_2XLARGE")]
        P3_2XLARGE,

        [EnumMember(Value = "P3_8XLARGE")]
        P3_8XLARGE,

        [EnumMember(Value = "P4D_24XLARGE")]
        P4D_24XLARGE,

        [EnumMember(Value = "P5_48XLARGE")]
        P5_48XLARGE,

        [EnumMember(Value = "R3_2XLARGE")]
        R3_2XLARGE,

        [EnumMember(Value = "R3_4XLARGE")]
        R3_4XLARGE,

        [EnumMember(Value = "R3_8XLARGE")]
        R3_8XLARGE,

        [EnumMember(Value = "R3_LARGE")]
        R3_LARGE,

        [EnumMember(Value = "R3_XLARGE")]
        R3_XLARGE,

        [EnumMember(Value = "R4_16XLARGE")]
        R4_16XLARGE,

        [EnumMember(Value = "R4_2XLARGE")]
        R4_2XLARGE,

        [EnumMember(Value = "R4_4XLARGE")]
        R4_4XLARGE,

        [EnumMember(Value = "R4_8XLARGE")]
        R4_8XLARGE,

        [EnumMember(Value = "R4_LARGE")]
        R4_LARGE,

        [EnumMember(Value = "R4_XLARGE")]
        R4_XLARGE,

        [EnumMember(Value = "R5AD_12XLARGE")]
        R5AD_12XLARGE,

        [EnumMember(Value = "R5AD_16XLARGE")]
        R5AD_16XLARGE,

        [EnumMember(Value = "R5AD_24XLARGE")]
        R5AD_24XLARGE,

        [EnumMember(Value = "R5AD_2XLARGE")]
        R5AD_2XLARGE,

        [EnumMember(Value = "R5AD_4XLARGE")]
        R5AD_4XLARGE,

        [EnumMember(Value = "R5AD_8XLARGE")]
        R5AD_8XLARGE,

        [EnumMember(Value = "R5AD_LARGE")]
        R5AD_LARGE,

        [EnumMember(Value = "R5AD_XLARGE")]
        R5AD_XLARGE,

        [EnumMember(Value = "R5A_12XLARGE")]
        R5A_12XLARGE,

        [EnumMember(Value = "R5A_16XLARGE")]
        R5A_16XLARGE,

        [EnumMember(Value = "R5A_24XLARGE")]
        R5A_24XLARGE,

        [EnumMember(Value = "R5A_2XLARGE")]
        R5A_2XLARGE,

        [EnumMember(Value = "R5A_4XLARGE")]
        R5A_4XLARGE,

        [EnumMember(Value = "R5A_8XLARGE")]
        R5A_8XLARGE,

        [EnumMember(Value = "R5A_LARGE")]
        R5A_LARGE,

        [EnumMember(Value = "R5A_XLARGE")]
        R5A_XLARGE,

        [EnumMember(Value = "R5B_12XLARGE")]
        R5B_12XLARGE,

        [EnumMember(Value = "R5B_16XLARGE")]
        R5B_16XLARGE,

        [EnumMember(Value = "R5B_24XLARGE")]
        R5B_24XLARGE,

        [EnumMember(Value = "R5B_2XLARGE")]
        R5B_2XLARGE,

        [EnumMember(Value = "R5B_4XLARGE")]
        R5B_4XLARGE,

        [EnumMember(Value = "R5B_8XLARGE")]
        R5B_8XLARGE,

        [EnumMember(Value = "R5B_LARGE")]
        R5B_LARGE,

        [EnumMember(Value = "R5B_METAL")]
        R5B_METAL,

        [EnumMember(Value = "R5B_XLARGE")]
        R5B_XLARGE,

        [EnumMember(Value = "R5DN_12XLARGE")]
        R5DN_12XLARGE,

        [EnumMember(Value = "R5DN_16XLARGE")]
        R5DN_16XLARGE,

        [EnumMember(Value = "R5DN_24XLARGE")]
        R5DN_24XLARGE,

        [EnumMember(Value = "R5DN_2XLARGE")]
        R5DN_2XLARGE,

        [EnumMember(Value = "R5DN_4XLARGE")]
        R5DN_4XLARGE,

        [EnumMember(Value = "R5DN_8XLARGE")]
        R5DN_8XLARGE,

        [EnumMember(Value = "R5DN_LARGE")]
        R5DN_LARGE,

        [EnumMember(Value = "R5DN_METAL")]
        R5DN_METAL,

        [EnumMember(Value = "R5DN_XLARGE")]
        R5DN_XLARGE,

        [EnumMember(Value = "R5D_12XLARGE")]
        R5D_12XLARGE,

        [EnumMember(Value = "R5D_16XLARGE")]
        R5D_16XLARGE,

        [EnumMember(Value = "R5D_24XLARGE")]
        R5D_24XLARGE,

        [EnumMember(Value = "R5D_2XLARGE")]
        R5D_2XLARGE,

        [EnumMember(Value = "R5D_4XLARGE")]
        R5D_4XLARGE,

        [EnumMember(Value = "R5D_8XLARGE")]
        R5D_8XLARGE,

        [EnumMember(Value = "R5D_LARGE")]
        R5D_LARGE,

        [EnumMember(Value = "R5D_METAL")]
        R5D_METAL,

        [EnumMember(Value = "R5D_XLARGE")]
        R5D_XLARGE,

        [EnumMember(Value = "R5N_12XLARGE")]
        R5N_12XLARGE,

        [EnumMember(Value = "R5N_16XLARGE")]
        R5N_16XLARGE,

        [EnumMember(Value = "R5N_24XLARGE")]
        R5N_24XLARGE,

        [EnumMember(Value = "R5N_2XLARGE")]
        R5N_2XLARGE,

        [EnumMember(Value = "R5N_4XLARGE")]
        R5N_4XLARGE,

        [EnumMember(Value = "R5N_8XLARGE")]
        R5N_8XLARGE,

        [EnumMember(Value = "R5N_LARGE")]
        R5N_LARGE,

        [EnumMember(Value = "R5N_METAL")]
        R5N_METAL,

        [EnumMember(Value = "R5N_XLARGE")]
        R5N_XLARGE,

        [EnumMember(Value = "R5_12XLARGE")]
        R5_12XLARGE,

        [EnumMember(Value = "R5_16XLARGE")]
        R5_16XLARGE,

        [EnumMember(Value = "R5_24XLARGE")]
        R5_24XLARGE,

        [EnumMember(Value = "R5_2XLARGE")]
        R5_2XLARGE,

        [EnumMember(Value = "R5_4XLARGE")]
        R5_4XLARGE,

        [EnumMember(Value = "R5_8XLARGE")]
        R5_8XLARGE,

        [EnumMember(Value = "R5_LARGE")]
        R5_LARGE,

        [EnumMember(Value = "R5_METAL")]
        R5_METAL,

        [EnumMember(Value = "R5_XLARGE")]
        R5_XLARGE,

        [EnumMember(Value = "R6A_12XLARGE")]
        R6A_12XLARGE,

        [EnumMember(Value = "R6A_16XLARGE")]
        R6A_16XLARGE,

        [EnumMember(Value = "R6A_24XLARGE")]
        R6A_24XLARGE,

        [EnumMember(Value = "R6A_2XLARGE")]
        R6A_2XLARGE,

        [EnumMember(Value = "R6A_32XLARGE")]
        R6A_32XLARGE,

        [EnumMember(Value = "R6A_48XLARGE")]
        R6A_48XLARGE,

        [EnumMember(Value = "R6A_4XLARGE")]
        R6A_4XLARGE,

        [EnumMember(Value = "R6A_8XLARGE")]
        R6A_8XLARGE,

        [EnumMember(Value = "R6A_LARGE")]
        R6A_LARGE,

        [EnumMember(Value = "R6A_METAL")]
        R6A_METAL,

        [EnumMember(Value = "R6A_XLARGE")]
        R6A_XLARGE,

        [EnumMember(Value = "R6GD_12XLARGE")]
        R6GD_12XLARGE,

        [EnumMember(Value = "R6GD_16XLARGE")]
        R6GD_16XLARGE,

        [EnumMember(Value = "R6GD_2XLARGE")]
        R6GD_2XLARGE,

        [EnumMember(Value = "R6GD_4XLARGE")]
        R6GD_4XLARGE,

        [EnumMember(Value = "R6GD_8XLARGE")]
        R6GD_8XLARGE,

        [EnumMember(Value = "R6GD_LARGE")]
        R6GD_LARGE,

        [EnumMember(Value = "R6GD_MEDIUM")]
        R6GD_MEDIUM,

        [EnumMember(Value = "R6GD_METAL")]
        R6GD_METAL,

        [EnumMember(Value = "R6GD_XLARGE")]
        R6GD_XLARGE,

        [EnumMember(Value = "R6G_12XLARGE")]
        R6G_12XLARGE,

        [EnumMember(Value = "R6G_16XLARGE")]
        R6G_16XLARGE,

        [EnumMember(Value = "R6G_2XLARGE")]
        R6G_2XLARGE,

        [EnumMember(Value = "R6G_4XLARGE")]
        R6G_4XLARGE,

        [EnumMember(Value = "R6G_8XLARGE")]
        R6G_8XLARGE,

        [EnumMember(Value = "R6G_LARGE")]
        R6G_LARGE,

        [EnumMember(Value = "R6G_MEDIUM")]
        R6G_MEDIUM,

        [EnumMember(Value = "R6G_METAL")]
        R6G_METAL,

        [EnumMember(Value = "R6G_XLARGE")]
        R6G_XLARGE,

        [EnumMember(Value = "R6IDN_12XLARGE")]
        R6IDN_12XLARGE,

        [EnumMember(Value = "R6IDN_16XLARGE")]
        R6IDN_16XLARGE,

        [EnumMember(Value = "R6IDN_24XLARGE")]
        R6IDN_24XLARGE,

        [EnumMember(Value = "R6IDN_2XLARGE")]
        R6IDN_2XLARGE,

        [EnumMember(Value = "R6IDN_32XLARGE")]
        R6IDN_32XLARGE,

        [EnumMember(Value = "R6IDN_4XLARGE")]
        R6IDN_4XLARGE,

        [EnumMember(Value = "R6IDN_8XLARGE")]
        R6IDN_8XLARGE,

        [EnumMember(Value = "R6IDN_LARGE")]
        R6IDN_LARGE,

        [EnumMember(Value = "R6IDN_METAL")]
        R6IDN_METAL,

        [EnumMember(Value = "R6IDN_XLARGE")]
        R6IDN_XLARGE,

        [EnumMember(Value = "R6ID_12XLARGE")]
        R6ID_12XLARGE,

        [EnumMember(Value = "R6ID_16XLARGE")]
        R6ID_16XLARGE,

        [EnumMember(Value = "R6ID_24XLARGE")]
        R6ID_24XLARGE,

        [EnumMember(Value = "R6ID_2XLARGE")]
        R6ID_2XLARGE,

        [EnumMember(Value = "R6ID_32XLARGE")]
        R6ID_32XLARGE,

        [EnumMember(Value = "R6ID_4XLARGE")]
        R6ID_4XLARGE,

        [EnumMember(Value = "R6ID_8XLARGE")]
        R6ID_8XLARGE,

        [EnumMember(Value = "R6ID_LARGE")]
        R6ID_LARGE,

        [EnumMember(Value = "R6ID_METAL")]
        R6ID_METAL,

        [EnumMember(Value = "R6ID_XLARGE")]
        R6ID_XLARGE,

        [EnumMember(Value = "R6IN_12XLARGE")]
        R6IN_12XLARGE,

        [EnumMember(Value = "R6IN_16XLARGE")]
        R6IN_16XLARGE,

        [EnumMember(Value = "R6IN_24XLARGE")]
        R6IN_24XLARGE,

        [EnumMember(Value = "R6IN_2XLARGE")]
        R6IN_2XLARGE,

        [EnumMember(Value = "R6IN_32XLARGE")]
        R6IN_32XLARGE,

        [EnumMember(Value = "R6IN_4XLARGE")]
        R6IN_4XLARGE,

        [EnumMember(Value = "R6IN_8XLARGE")]
        R6IN_8XLARGE,

        [EnumMember(Value = "R6IN_LARGE")]
        R6IN_LARGE,

        [EnumMember(Value = "R6IN_METAL")]
        R6IN_METAL,

        [EnumMember(Value = "R6IN_XLARGE")]
        R6IN_XLARGE,

        [EnumMember(Value = "R6I_12XLARGE")]
        R6I_12XLARGE,

        [EnumMember(Value = "R6I_16XLARGE")]
        R6I_16XLARGE,

        [EnumMember(Value = "R6I_24XLARGE")]
        R6I_24XLARGE,

        [EnumMember(Value = "R6I_2XLARGE")]
        R6I_2XLARGE,

        [EnumMember(Value = "R6I_32XLARGE")]
        R6I_32XLARGE,

        [EnumMember(Value = "R6I_4XLARGE")]
        R6I_4XLARGE,

        [EnumMember(Value = "R6I_8XLARGE")]
        R6I_8XLARGE,

        [EnumMember(Value = "R6I_LARGE")]
        R6I_LARGE,

        [EnumMember(Value = "R6I_METAL")]
        R6I_METAL,

        [EnumMember(Value = "R6I_XLARGE")]
        R6I_XLARGE,

        [EnumMember(Value = "R7A_12XLARGE")]
        R7A_12XLARGE,

        [EnumMember(Value = "R7A_16XLARGE")]
        R7A_16XLARGE,

        [EnumMember(Value = "R7A_24XLARGE")]
        R7A_24XLARGE,

        [EnumMember(Value = "R7A_2XLARGE")]
        R7A_2XLARGE,

        [EnumMember(Value = "R7A_32XLARGE")]
        R7A_32XLARGE,

        [EnumMember(Value = "R7A_48XLARGE")]
        R7A_48XLARGE,

        [EnumMember(Value = "R7A_4XLARGE")]
        R7A_4XLARGE,

        [EnumMember(Value = "R7A_8XLARGE")]
        R7A_8XLARGE,

        [EnumMember(Value = "R7A_LARGE")]
        R7A_LARGE,

        [EnumMember(Value = "R7A_MEDIUM")]
        R7A_MEDIUM,

        [EnumMember(Value = "R7A_XLARGE")]
        R7A_XLARGE,

        [EnumMember(Value = "R7GD_12XLARGE")]
        R7GD_12XLARGE,

        [EnumMember(Value = "R7GD_16XLARGE")]
        R7GD_16XLARGE,

        [EnumMember(Value = "R7GD_2XLARGE")]
        R7GD_2XLARGE,

        [EnumMember(Value = "R7GD_4XLARGE")]
        R7GD_4XLARGE,

        [EnumMember(Value = "R7GD_8XLARGE")]
        R7GD_8XLARGE,

        [EnumMember(Value = "R7GD_LARGE")]
        R7GD_LARGE,

        [EnumMember(Value = "R7GD_MEDIUM")]
        R7GD_MEDIUM,

        [EnumMember(Value = "R7GD_XLARGE")]
        R7GD_XLARGE,

        [EnumMember(Value = "R7G_12XLARGE")]
        R7G_12XLARGE,

        [EnumMember(Value = "R7G_16XLARGE")]
        R7G_16XLARGE,

        [EnumMember(Value = "R7G_2XLARGE")]
        R7G_2XLARGE,

        [EnumMember(Value = "R7G_4XLARGE")]
        R7G_4XLARGE,

        [EnumMember(Value = "R7G_8XLARGE")]
        R7G_8XLARGE,

        [EnumMember(Value = "R7G_LARGE")]
        R7G_LARGE,

        [EnumMember(Value = "R7G_MEDIUM")]
        R7G_MEDIUM,

        [EnumMember(Value = "R7G_METAL")]
        R7G_METAL,

        [EnumMember(Value = "R7G_XLARGE")]
        R7G_XLARGE,

        [EnumMember(Value = "R7IZ_12XLARGE")]
        R7IZ_12XLARGE,

        [EnumMember(Value = "R7IZ_16XLARGE")]
        R7IZ_16XLARGE,

        [EnumMember(Value = "R7IZ_2XLARGE")]
        R7IZ_2XLARGE,

        [EnumMember(Value = "R7IZ_32XLARGE")]
        R7IZ_32XLARGE,

        [EnumMember(Value = "R7IZ_4XLARGE")]
        R7IZ_4XLARGE,

        [EnumMember(Value = "R7IZ_8XLARGE")]
        R7IZ_8XLARGE,

        [EnumMember(Value = "R7IZ_LARGE")]
        R7IZ_LARGE,

        [EnumMember(Value = "R7IZ_XLARGE")]
        R7IZ_XLARGE,

        [EnumMember(Value = "R7I_12XLARGE")]
        R7I_12XLARGE,

        [EnumMember(Value = "R7I_16XLARGE")]
        R7I_16XLARGE,

        [EnumMember(Value = "R7I_24XLARGE")]
        R7I_24XLARGE,

        [EnumMember(Value = "R7I_2XLARGE")]
        R7I_2XLARGE,

        [EnumMember(Value = "R7I_48XLARGE")]
        R7I_48XLARGE,

        [EnumMember(Value = "R7I_4XLARGE")]
        R7I_4XLARGE,

        [EnumMember(Value = "R7I_8XLARGE")]
        R7I_8XLARGE,

        [EnumMember(Value = "R7I_LARGE")]
        R7I_LARGE,

        [EnumMember(Value = "R7I_METAL_24XL")]
        R7I_METAL_24XL,

        [EnumMember(Value = "R7I_METAL_48XL")]
        R7I_METAL_48XL,

        [EnumMember(Value = "R7I_XLARGE")]
        R7I_XLARGE,

        [EnumMember(Value = "T1_MICRO")]
        T1_MICRO,

        [EnumMember(Value = "T2_2XLARGE")]
        T2_2XLARGE,

        [EnumMember(Value = "T2_LARGE")]
        T2_LARGE,

        [EnumMember(Value = "T2_MEDIUM")]
        T2_MEDIUM,

        [EnumMember(Value = "T2_MICRO")]
        T2_MICRO,

        [EnumMember(Value = "T2_NANO")]
        T2_NANO,

        [EnumMember(Value = "T2_SMALL")]
        T2_SMALL,

        [EnumMember(Value = "T2_XLARGE")]
        T2_XLARGE,

        [EnumMember(Value = "T3A_2XLARGE")]
        T3A_2XLARGE,

        [EnumMember(Value = "T3A_LARGE")]
        T3A_LARGE,

        [EnumMember(Value = "T3A_MEDIUM")]
        T3A_MEDIUM,

        [EnumMember(Value = "T3A_MICRO")]
        T3A_MICRO,

        [EnumMember(Value = "T3A_NANO")]
        T3A_NANO,

        [EnumMember(Value = "T3A_SMALL")]
        T3A_SMALL,

        [EnumMember(Value = "T3A_XLARGE")]
        T3A_XLARGE,

        [EnumMember(Value = "T3_2XLARGE")]
        T3_2XLARGE,

        [EnumMember(Value = "T3_LARGE")]
        T3_LARGE,

        [EnumMember(Value = "T3_MEDIUM")]
        T3_MEDIUM,

        [EnumMember(Value = "T3_MICRO")]
        T3_MICRO,

        [EnumMember(Value = "T3_NANO")]
        T3_NANO,

        [EnumMember(Value = "T3_SMALL")]
        T3_SMALL,

        [EnumMember(Value = "T3_XLARGE")]
        T3_XLARGE,

        [EnumMember(Value = "T4G_2XLARGE")]
        T4G_2XLARGE,

        [EnumMember(Value = "T4G_LARGE")]
        T4G_LARGE,

        [EnumMember(Value = "T4G_MEDIUM")]
        T4G_MEDIUM,

        [EnumMember(Value = "T4G_MICRO")]
        T4G_MICRO,

        [EnumMember(Value = "T4G_NANO")]
        T4G_NANO,

        [EnumMember(Value = "T4G_SMALL")]
        T4G_SMALL,

        [EnumMember(Value = "T4G_XLARGE")]
        T4G_XLARGE,

        [EnumMember(Value = "TRN1N_32XLARGE")]
        TRN1N_32XLARGE,

        [EnumMember(Value = "TRN1_2XLARGE")]
        TRN1_2XLARGE,

        [EnumMember(Value = "TRN1_32XLARGE")]
        TRN1_32XLARGE,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "U_12TB1_112XLARGE")]
        U_12TB1_112XLARGE,

        [EnumMember(Value = "U_12TB1_METAL")]
        U_12TB1_METAL,

        [EnumMember(Value = "U_18TB1_112XLARGE")]
        U_18TB1_112XLARGE,

        [EnumMember(Value = "U_18TB1_METAL")]
        U_18TB1_METAL,

        [EnumMember(Value = "U_24TB1_112XLARGE")]
        U_24TB1_112XLARGE,

        [EnumMember(Value = "U_24TB1_METAL")]
        U_24TB1_METAL,

        [EnumMember(Value = "U_3TB1_56XLARGE")]
        U_3TB1_56XLARGE,

        [EnumMember(Value = "U_6TB1_112XLARGE")]
        U_6TB1_112XLARGE,

        [EnumMember(Value = "U_6TB1_56XLARGE")]
        U_6TB1_56XLARGE,

        [EnumMember(Value = "U_6TB1_METAL")]
        U_6TB1_METAL,

        [EnumMember(Value = "U_9TB1_112XLARGE")]
        U_9TB1_112XLARGE,

        [EnumMember(Value = "U_9TB1_METAL")]
        U_9TB1_METAL,

        [EnumMember(Value = "VT1_24XLARGE")]
        VT1_24XLARGE,

        [EnumMember(Value = "VT1_3XLARGE")]
        VT1_3XLARGE,

        [EnumMember(Value = "VT1_6XLARGE")]
        VT1_6XLARGE,

        [EnumMember(Value = "X1E_16XLARGE")]
        X1E_16XLARGE,

        [EnumMember(Value = "X1E_2XLARGE")]
        X1E_2XLARGE,

        [EnumMember(Value = "X1E_32XLARGE")]
        X1E_32XLARGE,

        [EnumMember(Value = "X1E_4XLARGE")]
        X1E_4XLARGE,

        [EnumMember(Value = "X1E_8XLARGE")]
        X1E_8XLARGE,

        [EnumMember(Value = "X1E_XLARGE")]
        X1E_XLARGE,

        [EnumMember(Value = "X1_16XLARGE")]
        X1_16XLARGE,

        [EnumMember(Value = "X1_32XLARGE")]
        X1_32XLARGE,

        [EnumMember(Value = "X2GD_12XLARGE")]
        X2GD_12XLARGE,

        [EnumMember(Value = "X2GD_16XLARGE")]
        X2GD_16XLARGE,

        [EnumMember(Value = "X2GD_2XLARGE")]
        X2GD_2XLARGE,

        [EnumMember(Value = "X2GD_4XLARGE")]
        X2GD_4XLARGE,

        [EnumMember(Value = "X2GD_8XLARGE")]
        X2GD_8XLARGE,

        [EnumMember(Value = "X2GD_LARGE")]
        X2GD_LARGE,

        [EnumMember(Value = "X2GD_MEDIUM")]
        X2GD_MEDIUM,

        [EnumMember(Value = "X2GD_METAL")]
        X2GD_METAL,

        [EnumMember(Value = "X2GD_XLARGE")]
        X2GD_XLARGE,

        [EnumMember(Value = "X2IDN_16XLARGE")]
        X2IDN_16XLARGE,

        [EnumMember(Value = "X2IDN_24XLARGE")]
        X2IDN_24XLARGE,

        [EnumMember(Value = "X2IDN_32XLARGE")]
        X2IDN_32XLARGE,

        [EnumMember(Value = "X2IDN_METAL")]
        X2IDN_METAL,

        [EnumMember(Value = "X2IEDN_16XLARGE")]
        X2IEDN_16XLARGE,

        [EnumMember(Value = "X2IEDN_24XLARGE")]
        X2IEDN_24XLARGE,

        [EnumMember(Value = "X2IEDN_2XLARGE")]
        X2IEDN_2XLARGE,

        [EnumMember(Value = "X2IEDN_32XLARGE")]
        X2IEDN_32XLARGE,

        [EnumMember(Value = "X2IEDN_4XLARGE")]
        X2IEDN_4XLARGE,

        [EnumMember(Value = "X2IEDN_8XLARGE")]
        X2IEDN_8XLARGE,

        [EnumMember(Value = "X2IEDN_METAL")]
        X2IEDN_METAL,

        [EnumMember(Value = "X2IEDN_XLARGE")]
        X2IEDN_XLARGE,

        [EnumMember(Value = "X2IEZN_12XLARGE")]
        X2IEZN_12XLARGE,

        [EnumMember(Value = "X2IEZN_2XLARGE")]
        X2IEZN_2XLARGE,

        [EnumMember(Value = "X2IEZN_4XLARGE")]
        X2IEZN_4XLARGE,

        [EnumMember(Value = "X2IEZN_6XLARGE")]
        X2IEZN_6XLARGE,

        [EnumMember(Value = "X2IEZN_8XLARGE")]
        X2IEZN_8XLARGE,

        [EnumMember(Value = "X2IEZN_METAL")]
        X2IEZN_METAL,

        [EnumMember(Value = "Z1D_12XLARGE")]
        Z1D_12XLARGE,

        [EnumMember(Value = "Z1D_2XLARGE")]
        Z1D_2XLARGE,

        [EnumMember(Value = "Z1D_3XLARGE")]
        Z1D_3XLARGE,

        [EnumMember(Value = "Z1D_6XLARGE")]
        Z1D_6XLARGE,

        [EnumMember(Value = "Z1D_LARGE")]
        Z1D_LARGE,

        [EnumMember(Value = "Z1D_METAL")]
        Z1D_METAL,

        [EnumMember(Value = "Z1D_XLARGE")]
        Z1D_XLARGE


    } // enum AwsNativeEc2InstanceType

} // namespace RubrikSecurityCloud.Types