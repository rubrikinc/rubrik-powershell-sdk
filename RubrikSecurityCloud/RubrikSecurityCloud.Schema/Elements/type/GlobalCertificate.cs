// GlobalCertificate.cs
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
    #region GlobalCertificate
    public class GlobalCertificate: BaseType
    {
        #region members

        //      C# -> GlobalCertificateStatus? Status
        // GraphQL -> status: GlobalCertificateStatus! (enum)
        [JsonProperty("status")]
        public GlobalCertificateStatus? Status { get; set; }

        //      C# -> System.String? Certificate
        // GraphQL -> certificate: String! (scalar)
        [JsonProperty("certificate")]
        public System.String? Certificate { get; set; }

        //      C# -> System.String? CertificateFid
        // GraphQL -> certificateFid: UUID! (scalar)
        [JsonProperty("certificateFid")]
        public System.String? CertificateFid { get; set; }

        //      C# -> System.String? CertificateId
        // GraphQL -> certificateId: String! (scalar)
        [JsonProperty("certificateId")]
        public System.String? CertificateId { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> DateTime? ExpiringAt
        // GraphQL -> expiringAt: DateTime (scalar)
        [JsonProperty("expiringAt")]
        public DateTime? ExpiringAt { get; set; }

        //      C# -> System.Boolean? HasKey
        // GraphQL -> hasKey: Boolean! (scalar)
        [JsonProperty("hasKey")]
        public System.Boolean? HasKey { get; set; }

        //      C# -> System.Boolean? IsCaSigned
        // GraphQL -> isCaSigned: Boolean! (scalar)
        [JsonProperty("isCaSigned")]
        public System.Boolean? IsCaSigned { get; set; }

        //      C# -> System.Boolean? IsCdmBorn
        // GraphQL -> isCdmBorn: Boolean! (scalar)
        [JsonProperty("isCdmBorn")]
        public System.Boolean? IsCdmBorn { get; set; }

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

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

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

        //      C# -> List<CdmCertificateUsageInfo>? CdmUsages
        // GraphQL -> cdmUsages: [CdmCertificateUsageInfo!]! (type)
        [JsonProperty("cdmUsages")]
        public List<CdmCertificateUsageInfo>? CdmUsages { get; set; }

        //      C# -> List<CertificateClusterInfo>? Clusters
        // GraphQL -> clusters: [CertificateClusterInfo!] (type)
        [JsonProperty("clusters")]
        public List<CertificateClusterInfo>? Clusters { get; set; }

        //      C# -> Org? Org
        // GraphQL -> org: Org (type)
        [JsonProperty("org")]
        public Org? Org { get; set; }

        //      C# -> List<CertificateUsageInfo>? Usages
        // GraphQL -> usages: [CertificateUsageInfo!]! (type)
        [JsonProperty("usages")]
        public List<CertificateUsageInfo>? Usages { get; set; }


        #endregion

    #region methods

    public GlobalCertificate Set(
        GlobalCertificateStatus? Status = null,
        System.String? Certificate = null,
        System.String? CertificateFid = null,
        System.String? CertificateId = null,
        System.String? Description = null,
        DateTime? ExpiringAt = null,
        System.Boolean? HasKey = null,
        System.Boolean? IsCaSigned = null,
        System.Boolean? IsCdmBorn = null,
        System.String? IssuedBy = null,
        DateTime? IssuedOn = null,
        System.String? IssuedTo = null,
        System.String? Name = null,
        System.String? SerialNumber = null,
        System.String? Sha1Fingerprint = null,
        System.String? Sha256Fingerprint = null,
        List<CdmCertificateUsageInfo>? CdmUsages = null,
        List<CertificateClusterInfo>? Clusters = null,
        Org? Org = null,
        List<CertificateUsageInfo>? Usages = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( Certificate != null ) {
            this.Certificate = Certificate;
        }
        if ( CertificateFid != null ) {
            this.CertificateFid = CertificateFid;
        }
        if ( CertificateId != null ) {
            this.CertificateId = CertificateId;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( ExpiringAt != null ) {
            this.ExpiringAt = ExpiringAt;
        }
        if ( HasKey != null ) {
            this.HasKey = HasKey;
        }
        if ( IsCaSigned != null ) {
            this.IsCaSigned = IsCaSigned;
        }
        if ( IsCdmBorn != null ) {
            this.IsCdmBorn = IsCdmBorn;
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
        if ( Name != null ) {
            this.Name = Name;
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
        if ( CdmUsages != null ) {
            this.CdmUsages = CdmUsages;
        }
        if ( Clusters != null ) {
            this.Clusters = Clusters;
        }
        if ( Org != null ) {
            this.Org = Org;
        }
        if ( Usages != null ) {
            this.Usages = Usages;
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
        //      C# -> GlobalCertificateStatus? Status
        // GraphQL -> status: GlobalCertificateStatus! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> System.String? Certificate
        // GraphQL -> certificate: String! (scalar)
        if (this.Certificate != null) {
            s += ind + "certificate\n" ;
        }
        //      C# -> System.String? CertificateFid
        // GraphQL -> certificateFid: UUID! (scalar)
        if (this.CertificateFid != null) {
            s += ind + "certificateFid\n" ;
        }
        //      C# -> System.String? CertificateId
        // GraphQL -> certificateId: String! (scalar)
        if (this.CertificateId != null) {
            s += ind + "certificateId\n" ;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            s += ind + "description\n" ;
        }
        //      C# -> DateTime? ExpiringAt
        // GraphQL -> expiringAt: DateTime (scalar)
        if (this.ExpiringAt != null) {
            s += ind + "expiringAt\n" ;
        }
        //      C# -> System.Boolean? HasKey
        // GraphQL -> hasKey: Boolean! (scalar)
        if (this.HasKey != null) {
            s += ind + "hasKey\n" ;
        }
        //      C# -> System.Boolean? IsCaSigned
        // GraphQL -> isCaSigned: Boolean! (scalar)
        if (this.IsCaSigned != null) {
            s += ind + "isCaSigned\n" ;
        }
        //      C# -> System.Boolean? IsCdmBorn
        // GraphQL -> isCdmBorn: Boolean! (scalar)
        if (this.IsCdmBorn != null) {
            s += ind + "isCdmBorn\n" ;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
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
        //      C# -> List<CdmCertificateUsageInfo>? CdmUsages
        // GraphQL -> cdmUsages: [CdmCertificateUsageInfo!]! (type)
        if (this.CdmUsages != null) {
            var fspec = this.CdmUsages.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cdmUsages {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<CertificateClusterInfo>? Clusters
        // GraphQL -> clusters: [CertificateClusterInfo!] (type)
        if (this.Clusters != null) {
            var fspec = this.Clusters.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "clusters {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> Org? Org
        // GraphQL -> org: Org (type)
        if (this.Org != null) {
            var fspec = this.Org.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "org {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<CertificateUsageInfo>? Usages
        // GraphQL -> usages: [CertificateUsageInfo!]! (type)
        if (this.Usages != null) {
            var fspec = this.Usages.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "usages {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> GlobalCertificateStatus? Status
        // GraphQL -> status: GlobalCertificateStatus! (enum)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new GlobalCertificateStatus();
        }
        //      C# -> System.String? Certificate
        // GraphQL -> certificate: String! (scalar)
        if (this.Certificate == null && Exploration.Includes(parent + ".certificate", true))
        {
            this.Certificate = "FETCH";
        }
        //      C# -> System.String? CertificateFid
        // GraphQL -> certificateFid: UUID! (scalar)
        if (this.CertificateFid == null && Exploration.Includes(parent + ".certificateFid", true))
        {
            this.CertificateFid = "FETCH";
        }
        //      C# -> System.String? CertificateId
        // GraphQL -> certificateId: String! (scalar)
        if (this.CertificateId == null && Exploration.Includes(parent + ".certificateId", true))
        {
            this.CertificateId = "FETCH";
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description == null && Exploration.Includes(parent + ".description", true))
        {
            this.Description = "FETCH";
        }
        //      C# -> DateTime? ExpiringAt
        // GraphQL -> expiringAt: DateTime (scalar)
        if (this.ExpiringAt == null && Exploration.Includes(parent + ".expiringAt", true))
        {
            this.ExpiringAt = new DateTime();
        }
        //      C# -> System.Boolean? HasKey
        // GraphQL -> hasKey: Boolean! (scalar)
        if (this.HasKey == null && Exploration.Includes(parent + ".hasKey", true))
        {
            this.HasKey = true;
        }
        //      C# -> System.Boolean? IsCaSigned
        // GraphQL -> isCaSigned: Boolean! (scalar)
        if (this.IsCaSigned == null && Exploration.Includes(parent + ".isCaSigned", true))
        {
            this.IsCaSigned = true;
        }
        //      C# -> System.Boolean? IsCdmBorn
        // GraphQL -> isCdmBorn: Boolean! (scalar)
        if (this.IsCdmBorn == null && Exploration.Includes(parent + ".isCdmBorn", true))
        {
            this.IsCdmBorn = true;
        }
        //      C# -> System.String? IssuedBy
        // GraphQL -> issuedBy: String! (scalar)
        if (this.IssuedBy == null && Exploration.Includes(parent + ".issuedBy", true))
        {
            this.IssuedBy = "FETCH";
        }
        //      C# -> DateTime? IssuedOn
        // GraphQL -> issuedOn: DateTime (scalar)
        if (this.IssuedOn == null && Exploration.Includes(parent + ".issuedOn", true))
        {
            this.IssuedOn = new DateTime();
        }
        //      C# -> System.String? IssuedTo
        // GraphQL -> issuedTo: String! (scalar)
        if (this.IssuedTo == null && Exploration.Includes(parent + ".issuedTo", true))
        {
            this.IssuedTo = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? SerialNumber
        // GraphQL -> serialNumber: String! (scalar)
        if (this.SerialNumber == null && Exploration.Includes(parent + ".serialNumber", true))
        {
            this.SerialNumber = "FETCH";
        }
        //      C# -> System.String? Sha1Fingerprint
        // GraphQL -> sha1Fingerprint: String! (scalar)
        if (this.Sha1Fingerprint == null && Exploration.Includes(parent + ".sha1Fingerprint", true))
        {
            this.Sha1Fingerprint = "FETCH";
        }
        //      C# -> System.String? Sha256Fingerprint
        // GraphQL -> sha256Fingerprint: String! (scalar)
        if (this.Sha256Fingerprint == null && Exploration.Includes(parent + ".sha256Fingerprint", true))
        {
            this.Sha256Fingerprint = "FETCH";
        }
        //      C# -> List<CdmCertificateUsageInfo>? CdmUsages
        // GraphQL -> cdmUsages: [CdmCertificateUsageInfo!]! (type)
        if (this.CdmUsages == null && Exploration.Includes(parent + ".cdmUsages"))
        {
            this.CdmUsages = new List<CdmCertificateUsageInfo>();
            this.CdmUsages.ApplyExploratoryFieldSpec(parent + ".cdmUsages");
        }
        //      C# -> List<CertificateClusterInfo>? Clusters
        // GraphQL -> clusters: [CertificateClusterInfo!] (type)
        if (this.Clusters == null && Exploration.Includes(parent + ".clusters"))
        {
            this.Clusters = new List<CertificateClusterInfo>();
            this.Clusters.ApplyExploratoryFieldSpec(parent + ".clusters");
        }
        //      C# -> Org? Org
        // GraphQL -> org: Org (type)
        if (this.Org == null && Exploration.Includes(parent + ".org"))
        {
            this.Org = new Org();
            this.Org.ApplyExploratoryFieldSpec(parent + ".org");
        }
        //      C# -> List<CertificateUsageInfo>? Usages
        // GraphQL -> usages: [CertificateUsageInfo!]! (type)
        if (this.Usages == null && Exploration.Includes(parent + ".usages"))
        {
            this.Usages = new List<CertificateUsageInfo>();
            this.Usages.ApplyExploratoryFieldSpec(parent + ".usages");
        }
    }


    #endregion

    } // class GlobalCertificate
    
    #endregion

    public static class ListGlobalCertificateExtensions
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
            this List<GlobalCertificate> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GlobalCertificate> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new GlobalCertificate());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types