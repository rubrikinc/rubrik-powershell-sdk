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

        [EnumMember(Value = "G4DN_XLARGE")]
        G4DN_XLARGE,

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

        [EnumMember(Value = "INF1_24XLARGE")]
        INF1_24XLARGE,

        [EnumMember(Value = "INF1_2XLARGE")]
        INF1_2XLARGE,

        [EnumMember(Value = "INF1_6XLARGE")]
        INF1_6XLARGE,

        [EnumMember(Value = "INF1_XLARGE")]
        INF1_XLARGE,

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

        [EnumMember(Value = "M5N_XLARGE")]
        M5N_XLARGE,

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

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        [EnumMember(Value = "U_12TB1_METAL")]
        U_12TB1_METAL,

        [EnumMember(Value = "U_18TB1_METAL")]
        U_18TB1_METAL,

        [EnumMember(Value = "U_24TB1_METAL")]
        U_24TB1_METAL,

        [EnumMember(Value = "U_6TB1_METAL")]
        U_6TB1_METAL,

        [EnumMember(Value = "U_9TB1_METAL")]
        U_9TB1_METAL,

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