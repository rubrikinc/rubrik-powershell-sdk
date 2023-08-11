// AnalyzerTypeEnum.cs
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
    public enum AnalyzerTypeEnum
    {
        [EnumMember(Value = "ABA_ROUTING_NUMBER")]
        ABA_ROUTING_NUMBER,

        [EnumMember(Value = "AUSTRALIA_ABN")]
        AUSTRALIA_ABN,

        [EnumMember(Value = "AUSTRALIA_ACN")]
        AUSTRALIA_ACN,

        [EnumMember(Value = "AUSTRALIA_BANK_ACCOUNT_NUMBER")]
        AUSTRALIA_BANK_ACCOUNT_NUMBER,

        [EnumMember(Value = "AUSTRALIA_BSB")]
        AUSTRALIA_BSB,

        [EnumMember(Value = "AUSTRALIA_DL")]
        AUSTRALIA_DL,

        [EnumMember(Value = "AUSTRALIA_MEDICAL_ACCOUNT")]
        AUSTRALIA_MEDICAL_ACCOUNT,

        [EnumMember(Value = "AUSTRALIA_PASSPORT")]
        AUSTRALIA_PASSPORT,

        [EnumMember(Value = "AUSTRALIA_TFN")]
        AUSTRALIA_TFN,

        [EnumMember(Value = "AWS_CONNECTION_STRING")]
        AWS_CONNECTION_STRING,

        [EnumMember(Value = "AZURE_CONNECTION_STRING")]
        AZURE_CONNECTION_STRING,

        [EnumMember(Value = "BELGIUM_BNN")]
        BELGIUM_BNN,

        [EnumMember(Value = "BELGIUM_DL")]
        BELGIUM_DL,

        [EnumMember(Value = "BELGIUM_PASSPORT")]
        BELGIUM_PASSPORT,

        [EnumMember(Value = "CANADA_BANK_ACCT")]
        CANADA_BANK_ACCT,

        [EnumMember(Value = "CANADA_HEALTH_SERVICE")]
        CANADA_HEALTH_SERVICE,

        [EnumMember(Value = "CANADA_PASSPORT")]
        CANADA_PASSPORT,

        [EnumMember(Value = "CANADA_PHIN")]
        CANADA_PHIN,

        [EnumMember(Value = "CANADA_SOCIAL_INSURANCE_NUMBER")]
        CANADA_SOCIAL_INSURANCE_NUMBER,

        [EnumMember(Value = "CREDIT_CARD")]
        CREDIT_CARD,

        [EnumMember(Value = "CUSIP_NUMBER")]
        CUSIP_NUMBER,

        [EnumMember(Value = "DEA_NUMBER")]
        DEA_NUMBER,

        [EnumMember(Value = "DIGITAL_CERTIFICATE")]
        DIGITAL_CERTIFICATE,

        [EnumMember(Value = "EIN")]
        EIN,

        [EnumMember(Value = "EMAIL_ADDRESS")]
        EMAIL_ADDRESS,

        [EnumMember(Value = "FRANCE_SSN")]
        FRANCE_SSN,

        [EnumMember(Value = "GCP_OAUTH_REFRESH_TOKEN")]
        GCP_OAUTH_REFRESH_TOKEN,

        [EnumMember(Value = "GERMANY_DL")]
        GERMANY_DL,

        [EnumMember(Value = "GERMANY_ID")]
        GERMANY_ID,

        [EnumMember(Value = "GERMANY_PASSPORT")]
        GERMANY_PASSPORT,

        [EnumMember(Value = "GITHUB_OAUTH_REFRESH_TOKEN")]
        GITHUB_OAUTH_REFRESH_TOKEN,

        [EnumMember(Value = "GOOGLE_API_KEY")]
        GOOGLE_API_KEY,

        [EnumMember(Value = "IBAN")]
        IBAN,

        [EnumMember(Value = "IPV4_ADDRESS")]
        IPV4_ADDRESS,

        [EnumMember(Value = "IRELAND_DL")]
        IRELAND_DL,

        [EnumMember(Value = "IRELAND_PASSPORT_NUMBER")]
        IRELAND_PASSPORT_NUMBER,

        [EnumMember(Value = "IRELAND_PPS")]
        IRELAND_PPS,

        [EnumMember(Value = "KEYWORD")]
        KEYWORD,

        [EnumMember(Value = "MAC_ADDRESS")]
        MAC_ADDRESS,

        [EnumMember(Value = "NETHERLANDS_BSN")]
        NETHERLANDS_BSN,

        [EnumMember(Value = "NETHERLANDS_DL")]
        NETHERLANDS_DL,

        [EnumMember(Value = "NETHERLANDS_PASSPORT")]
        NETHERLANDS_PASSPORT,

        [EnumMember(Value = "NETHERLANDS_TIN")]
        NETHERLANDS_TIN,

        [EnumMember(Value = "NETHERLANDS_VAT")]
        NETHERLANDS_VAT,

        [EnumMember(Value = "PASSPORT")]
        PASSPORT,

        [EnumMember(Value = "PHONE_NUMBER")]
        PHONE_NUMBER,

        [EnumMember(Value = "PRIVATE_KEY")]
        PRIVATE_KEY,

        [EnumMember(Value = "REGEX")]
        REGEX,

        [EnumMember(Value = "SIMHASH")]
        SIMHASH,

        [EnumMember(Value = "SWEDEN_DL")]
        SWEDEN_DL,

        [EnumMember(Value = "SWEDEN_NIN")]
        SWEDEN_NIN,

        [EnumMember(Value = "SWEDEN_PASSPORT")]
        SWEDEN_PASSPORT,

        [EnumMember(Value = "SWEDEN_TIN")]
        SWEDEN_TIN,

        [EnumMember(Value = "SWIFT_CODE")]
        SWIFT_CODE,

        [EnumMember(Value = "UK_DL")]
        UK_DL,

        [EnumMember(Value = "UK_ELECTORAL")]
        UK_ELECTORAL,

        [EnumMember(Value = "UK_NHS")]
        UK_NHS,

        [EnumMember(Value = "UK_NINO")]
        UK_NINO,

        [EnumMember(Value = "UK_UTR")]
        UK_UTR,

        [EnumMember(Value = "UNDEFINED")]
        UNDEFINED,

        [EnumMember(Value = "US_BANK_ACCT")]
        US_BANK_ACCT,

        [EnumMember(Value = "US_CA_DL")]
        US_CA_DL,

        [EnumMember(Value = "US_DL")]
        US_DL,

        [EnumMember(Value = "US_HEALTHCARE_NPI")]
        US_HEALTHCARE_NPI,

        [EnumMember(Value = "US_ITIN")]
        US_ITIN,

        [EnumMember(Value = "US_MBI")]
        US_MBI,

        [EnumMember(Value = "US_SSN")]
        US_SSN,

        [EnumMember(Value = "US_VIN")]
        US_VIN,

        [EnumMember(Value = "WORD_FREQUENCY")]
        WORD_FREQUENCY


    } // enum AnalyzerTypeEnum

} // namespace RubrikSecurityCloud.Types