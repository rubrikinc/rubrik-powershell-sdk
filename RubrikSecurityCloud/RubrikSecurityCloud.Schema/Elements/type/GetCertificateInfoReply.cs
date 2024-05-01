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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? Certificate
        // GraphQL -> certificate: String! (scalar)
        if (this.Certificate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "certificate\n" ;
            } else {
                s += ind + "certificate\n" ;
            }
        }
        //      C# -> DateTime? ExpiringAt
        // GraphQL -> expiringAt: DateTime (scalar)
        if (this.ExpiringAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "expiringAt\n" ;
            } else {
                s += ind + "expiringAt\n" ;
            }
        }
        //      C# -> System.String? IssuedBy
        // GraphQL -> issuedBy: String! (scalar)
        if (this.IssuedBy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "issuedBy\n" ;
            } else {
                s += ind + "issuedBy\n" ;
            }
        }
        //      C# -> DateTime? IssuedOn
        // GraphQL -> issuedOn: DateTime (scalar)
        if (this.IssuedOn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "issuedOn\n" ;
            } else {
                s += ind + "issuedOn\n" ;
            }
        }
        //      C# -> System.String? IssuedTo
        // GraphQL -> issuedTo: String! (scalar)
        if (this.IssuedTo != null) {
            if (conf.Flat) {
                s += conf.Prefix + "issuedTo\n" ;
            } else {
                s += ind + "issuedTo\n" ;
            }
        }
        //      C# -> System.String? SerialNumber
        // GraphQL -> serialNumber: String! (scalar)
        if (this.SerialNumber != null) {
            if (conf.Flat) {
                s += conf.Prefix + "serialNumber\n" ;
            } else {
                s += ind + "serialNumber\n" ;
            }
        }
        //      C# -> System.String? Sha1Fingerprint
        // GraphQL -> sha1Fingerprint: String! (scalar)
        if (this.Sha1Fingerprint != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sha1Fingerprint\n" ;
            } else {
                s += ind + "sha1Fingerprint\n" ;
            }
        }
        //      C# -> System.String? Sha256Fingerprint
        // GraphQL -> sha256Fingerprint: String! (scalar)
        if (this.Sha256Fingerprint != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sha256Fingerprint\n" ;
            } else {
                s += ind + "sha256Fingerprint\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Certificate
        // GraphQL -> certificate: String! (scalar)
        if (ec.Includes("certificate",true))
        {
            if(this.Certificate == null) {

                this.Certificate = "FETCH";

            } else {


            }
        }
        else if (this.Certificate != null && ec.Excludes("certificate",true))
        {
            this.Certificate = null;
        }
        //      C# -> DateTime? ExpiringAt
        // GraphQL -> expiringAt: DateTime (scalar)
        if (ec.Includes("expiringAt",true))
        {
            if(this.ExpiringAt == null) {

                this.ExpiringAt = new DateTime();

            } else {


            }
        }
        else if (this.ExpiringAt != null && ec.Excludes("expiringAt",true))
        {
            this.ExpiringAt = null;
        }
        //      C# -> System.String? IssuedBy
        // GraphQL -> issuedBy: String! (scalar)
        if (ec.Includes("issuedBy",true))
        {
            if(this.IssuedBy == null) {

                this.IssuedBy = "FETCH";

            } else {


            }
        }
        else if (this.IssuedBy != null && ec.Excludes("issuedBy",true))
        {
            this.IssuedBy = null;
        }
        //      C# -> DateTime? IssuedOn
        // GraphQL -> issuedOn: DateTime (scalar)
        if (ec.Includes("issuedOn",true))
        {
            if(this.IssuedOn == null) {

                this.IssuedOn = new DateTime();

            } else {


            }
        }
        else if (this.IssuedOn != null && ec.Excludes("issuedOn",true))
        {
            this.IssuedOn = null;
        }
        //      C# -> System.String? IssuedTo
        // GraphQL -> issuedTo: String! (scalar)
        if (ec.Includes("issuedTo",true))
        {
            if(this.IssuedTo == null) {

                this.IssuedTo = "FETCH";

            } else {


            }
        }
        else if (this.IssuedTo != null && ec.Excludes("issuedTo",true))
        {
            this.IssuedTo = null;
        }
        //      C# -> System.String? SerialNumber
        // GraphQL -> serialNumber: String! (scalar)
        if (ec.Includes("serialNumber",true))
        {
            if(this.SerialNumber == null) {

                this.SerialNumber = "FETCH";

            } else {


            }
        }
        else if (this.SerialNumber != null && ec.Excludes("serialNumber",true))
        {
            this.SerialNumber = null;
        }
        //      C# -> System.String? Sha1Fingerprint
        // GraphQL -> sha1Fingerprint: String! (scalar)
        if (ec.Includes("sha1Fingerprint",true))
        {
            if(this.Sha1Fingerprint == null) {

                this.Sha1Fingerprint = "FETCH";

            } else {


            }
        }
        else if (this.Sha1Fingerprint != null && ec.Excludes("sha1Fingerprint",true))
        {
            this.Sha1Fingerprint = null;
        }
        //      C# -> System.String? Sha256Fingerprint
        // GraphQL -> sha256Fingerprint: String! (scalar)
        if (ec.Includes("sha256Fingerprint",true))
        {
            if(this.Sha256Fingerprint == null) {

                this.Sha256Fingerprint = "FETCH";

            } else {


            }
        }
        else if (this.Sha256Fingerprint != null && ec.Excludes("sha256Fingerprint",true))
        {
            this.Sha256Fingerprint = null;
        }
    }


    #endregion

    } // class GetCertificateInfoReply
    
    #endregion

    public static class ListGetCertificateInfoReplyExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<GetCertificateInfoReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetCertificateInfoReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<GetCertificateInfoReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types