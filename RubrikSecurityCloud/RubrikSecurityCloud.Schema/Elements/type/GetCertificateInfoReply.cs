// GetCertificateInfoReply.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region GetCertificateInfoReply
    public class GetCertificateInfoReply: BaseType
    {
        #region members

        //      C# -> System.String? Certificate
        // GraphQL -> certificate: String! (scalar)
        [JsonProperty("certificate")]
        public System.String? Certificate { get; set; }

        //      C# -> DateTime? ExpiringAt
        // GraphQL -> expiringAt: DateTime (scalar)
        [JsonProperty("expiringAt")]
        public DateTime? ExpiringAt { get; set; }

        //      C# -> System.String? IssuedBy
        // GraphQL -> issuedBy: String! (scalar)
        [JsonProperty("issuedBy")]
        public System.String? IssuedBy { get; set; }

        //      C# -> DateTime? IssuedOn
        // GraphQL -> issuedOn: DateTime (scalar)
        [JsonProperty("issuedOn")]
        public DateTime? IssuedOn { get; set; }

        //      C# -> System.String? IssuedTo
        // GraphQL -> issuedTo: String! (scalar)
        [JsonProperty("issuedTo")]
        public System.String? IssuedTo { get; set; }

        //      C# -> System.String? SerialNumber
        // GraphQL -> serialNumber: String! (scalar)
        [JsonProperty("serialNumber")]
        public System.String? SerialNumber { get; set; }

        //      C# -> System.String? Sha1Fingerprint
        // GraphQL -> sha1Fingerprint: String! (scalar)
        [JsonProperty("sha1Fingerprint")]
        public System.String? Sha1Fingerprint { get; set; }

        //      C# -> System.String? Sha256Fingerprint
        // GraphQL -> sha256Fingerprint: String! (scalar)
        [JsonProperty("sha256Fingerprint")]
        public System.String? Sha256Fingerprint { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetCertificateInfoReply";
    }

    public GetCertificateInfoReply Set(
        System.String? Certificate = null,
        DateTime? ExpiringAt = null,
        System.String? IssuedBy = null,
        DateTime? IssuedOn = null,
        System.String? IssuedTo = null,
        System.String? SerialNumber = null,
        System.String? Sha1Fingerprint = null,
        System.String? Sha256Fingerprint = null
    ) 
    {
        if ( Certificate != null ) {
            this.Certificate = Certificate;
        }
        if ( ExpiringAt != null ) {
            this.ExpiringAt = ExpiringAt;
        }
        if ( IssuedBy != null ) {
            this.IssuedBy = IssuedBy;
        }
        if ( IssuedOn != null ) {
            this.IssuedOn = IssuedOn;
        }
        if ( IssuedTo != null ) {
            this.IssuedTo = IssuedTo;
        }
        if ( SerialNumber != null ) {
            this.SerialNumber = SerialNumber;
        }
        if ( Sha1Fingerprint != null ) {
            this.Sha1Fingerprint = Sha1Fingerprint;
        }
        if ( Sha256Fingerprint != null ) {
            this.Sha256Fingerprint = Sha256Fingerprint;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? Certificate
        // GraphQL -> certificate: String! (scalar)
        if (this.Certificate != null) {
            s += ind + "certificate\n" ;
        }
        //      C# -> DateTime? ExpiringAt
        // GraphQL -> expiringAt: DateTime (scalar)
        if (this.ExpiringAt != null) {
            s += ind + "expiringAt\n" ;
        }
        //      C# -> System.String? IssuedBy
        // GraphQL -> issuedBy: String! (scalar)
        if (this.IssuedBy != null) {
            s += ind + "issuedBy\n" ;
        }
        //      C# -> DateTime? IssuedOn
        // GraphQL -> issuedOn: DateTime (scalar)
        if (this.IssuedOn != null) {
            s += ind + "issuedOn\n" ;
        }
        //      C# -> System.String? IssuedTo
        // GraphQL -> issuedTo: String! (scalar)
        if (this.IssuedTo != null) {
            s += ind + "issuedTo\n" ;
        }
        //      C# -> System.String? SerialNumber
        // GraphQL -> serialNumber: String! (scalar)
        if (this.SerialNumber != null) {
            s += ind + "serialNumber\n" ;
        }
        //      C# -> System.String? Sha1Fingerprint
        // GraphQL -> sha1Fingerprint: String! (scalar)
        if (this.Sha1Fingerprint != null) {
            s += ind + "sha1Fingerprint\n" ;
        }
        //      C# -> System.String? Sha256Fingerprint
        // GraphQL -> sha256Fingerprint: String! (scalar)
        if (this.Sha256Fingerprint != null) {
            s += ind + "sha256Fingerprint\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Certificate
        // GraphQL -> certificate: String! (scalar)
        if (this.Certificate == null && ec.Includes("certificate",true))
        {
            this.Certificate = "FETCH";
        }
        //      C# -> DateTime? ExpiringAt
        // GraphQL -> expiringAt: DateTime (scalar)
        if (this.ExpiringAt == null && ec.Includes("expiringAt",true))
        {
            this.ExpiringAt = new DateTime();
        }
        //      C# -> System.String? IssuedBy
        // GraphQL -> issuedBy: String! (scalar)
        if (this.IssuedBy == null && ec.Includes("issuedBy",true))
        {
            this.IssuedBy = "FETCH";
        }
        //      C# -> DateTime? IssuedOn
        // GraphQL -> issuedOn: DateTime (scalar)
        if (this.IssuedOn == null && ec.Includes("issuedOn",true))
        {
            this.IssuedOn = new DateTime();
        }
        //      C# -> System.String? IssuedTo
        // GraphQL -> issuedTo: String! (scalar)
        if (this.IssuedTo == null && ec.Includes("issuedTo",true))
        {
            this.IssuedTo = "FETCH";
        }
        //      C# -> System.String? SerialNumber
        // GraphQL -> serialNumber: String! (scalar)
        if (this.SerialNumber == null && ec.Includes("serialNumber",true))
        {
            this.SerialNumber = "FETCH";
        }
        //      C# -> System.String? Sha1Fingerprint
        // GraphQL -> sha1Fingerprint: String! (scalar)
        if (this.Sha1Fingerprint == null && ec.Includes("sha1Fingerprint",true))
        {
            this.Sha1Fingerprint = "FETCH";
        }
        //      C# -> System.String? Sha256Fingerprint
        // GraphQL -> sha256Fingerprint: String! (scalar)
        if (this.Sha256Fingerprint == null && ec.Includes("sha256Fingerprint",true))
        {
            this.Sha256Fingerprint = "FETCH";
        }
    }


    #endregion

    } // class GetCertificateInfoReply
    
    #endregion

    public static class ListGetCertificateInfoReplyExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<GetCertificateInfoReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GetCertificateInfoReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetCertificateInfoReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<GetCertificateInfoReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types