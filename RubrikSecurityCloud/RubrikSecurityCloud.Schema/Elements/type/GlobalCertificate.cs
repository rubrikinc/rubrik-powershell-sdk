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

        //      C# -> IssuerType? IssuerType
        // GraphQL -> issuerType: IssuerType! (enum)
        [JsonProperty("issuerType")]
        public IssuerType? IssuerType { get; set; }

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

        //      C# -> System.Boolean? IsCa
        // GraphQL -> isCa: Boolean! (scalar)
        [JsonProperty("isCa")]
        public System.Boolean? IsCa { get; set; }

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

        //      C# -> System.Boolean? UserHasPrivilegeToScheduleRotation
        // GraphQL -> userHasPrivilegeToScheduleRotation: Boolean! (scalar)
        [JsonProperty("userHasPrivilegeToScheduleRotation")]
        public System.Boolean? UserHasPrivilegeToScheduleRotation { get; set; }

        //      C# -> List<CdmCertificateUsageInfo>? CdmUsages
        // GraphQL -> cdmUsages: [CdmCertificateUsageInfo!]! (type)
        [JsonProperty("cdmUsages")]
        public List<CdmCertificateUsageInfo>? CdmUsages { get; set; }

        //      C# -> CertificateRotation? CertificateRotation
        // GraphQL -> certificateRotation: CertificateRotation (type)
        [JsonProperty("certificateRotation")]
        public CertificateRotation? CertificateRotation { get; set; }

        //      C# -> List<CertificateClusterInfo>? Clusters
        // GraphQL -> clusters: [CertificateClusterInfo!] (type)
        [JsonProperty("clusters")]
        public List<CertificateClusterInfo>? Clusters { get; set; }

        //      C# -> Org? Org
        // GraphQL -> org: Org (type)
        [JsonProperty("org")]
        public Org? Org { get; set; }

        //      C# -> RbsHostUsage? RbsHostUsage
        // GraphQL -> rbsHostUsage: RbsHostUsage (type)
        [JsonProperty("rbsHostUsage")]
        public RbsHostUsage? RbsHostUsage { get; set; }

        //      C# -> List<CertificateUsageInfo>? Usages
        // GraphQL -> usages: [CertificateUsageInfo!]! (type)
        [JsonProperty("usages")]
        public List<CertificateUsageInfo>? Usages { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GlobalCertificate";
    }

    public GlobalCertificate Set(
        IssuerType? IssuerType = null,
        GlobalCertificateStatus? Status = null,
        System.String? Certificate = null,
        System.String? CertificateFid = null,
        System.String? CertificateId = null,
        System.String? Description = null,
        DateTime? ExpiringAt = null,
        System.Boolean? HasKey = null,
        System.Boolean? IsCa = null,
        System.Boolean? IsCaSigned = null,
        System.Boolean? IsCdmBorn = null,
        System.String? IssuedBy = null,
        DateTime? IssuedOn = null,
        System.String? IssuedTo = null,
        System.String? Name = null,
        System.String? SerialNumber = null,
        System.String? Sha1Fingerprint = null,
        System.String? Sha256Fingerprint = null,
        System.Boolean? UserHasPrivilegeToScheduleRotation = null,
        List<CdmCertificateUsageInfo>? CdmUsages = null,
        CertificateRotation? CertificateRotation = null,
        List<CertificateClusterInfo>? Clusters = null,
        Org? Org = null,
        RbsHostUsage? RbsHostUsage = null,
        List<CertificateUsageInfo>? Usages = null
    ) 
    {
        if ( IssuerType != null ) {
            this.IssuerType = IssuerType;
        }
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
        if ( IsCa != null ) {
            this.IsCa = IsCa;
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
        if ( UserHasPrivilegeToScheduleRotation != null ) {
            this.UserHasPrivilegeToScheduleRotation = UserHasPrivilegeToScheduleRotation;
        }
        if ( CdmUsages != null ) {
            this.CdmUsages = CdmUsages;
        }
        if ( CertificateRotation != null ) {
            this.CertificateRotation = CertificateRotation;
        }
        if ( Clusters != null ) {
            this.Clusters = Clusters;
        }
        if ( Org != null ) {
            this.Org = Org;
        }
        if ( RbsHostUsage != null ) {
            this.RbsHostUsage = RbsHostUsage;
        }
        if ( Usages != null ) {
            this.Usages = Usages;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> IssuerType? IssuerType
        // GraphQL -> issuerType: IssuerType! (enum)
        if (this.IssuerType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "issuerType\n" ;
            } else {
                s += ind + "issuerType\n" ;
            }
        }
        //      C# -> GlobalCertificateStatus? Status
        // GraphQL -> status: GlobalCertificateStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? Certificate
        // GraphQL -> certificate: String! (scalar)
        if (this.Certificate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "certificate\n" ;
            } else {
                s += ind + "certificate\n" ;
            }
        }
        //      C# -> System.String? CertificateFid
        // GraphQL -> certificateFid: UUID! (scalar)
        if (this.CertificateFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "certificateFid\n" ;
            } else {
                s += ind + "certificateFid\n" ;
            }
        }
        //      C# -> System.String? CertificateId
        // GraphQL -> certificateId: String! (scalar)
        if (this.CertificateId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "certificateId\n" ;
            } else {
                s += ind + "certificateId\n" ;
            }
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            if (conf.Flat) {
                s += conf.Prefix + "description\n" ;
            } else {
                s += ind + "description\n" ;
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
        //      C# -> System.Boolean? HasKey
        // GraphQL -> hasKey: Boolean! (scalar)
        if (this.HasKey != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasKey\n" ;
            } else {
                s += ind + "hasKey\n" ;
            }
        }
        //      C# -> System.Boolean? IsCa
        // GraphQL -> isCa: Boolean! (scalar)
        if (this.IsCa != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isCa\n" ;
            } else {
                s += ind + "isCa\n" ;
            }
        }
        //      C# -> System.Boolean? IsCaSigned
        // GraphQL -> isCaSigned: Boolean! (scalar)
        if (this.IsCaSigned != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isCaSigned\n" ;
            } else {
                s += ind + "isCaSigned\n" ;
            }
        }
        //      C# -> System.Boolean? IsCdmBorn
        // GraphQL -> isCdmBorn: Boolean! (scalar)
        if (this.IsCdmBorn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isCdmBorn\n" ;
            } else {
                s += ind + "isCdmBorn\n" ;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
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
        //      C# -> System.Boolean? UserHasPrivilegeToScheduleRotation
        // GraphQL -> userHasPrivilegeToScheduleRotation: Boolean! (scalar)
        if (this.UserHasPrivilegeToScheduleRotation != null) {
            if (conf.Flat) {
                s += conf.Prefix + "userHasPrivilegeToScheduleRotation\n" ;
            } else {
                s += ind + "userHasPrivilegeToScheduleRotation\n" ;
            }
        }
        //      C# -> List<CdmCertificateUsageInfo>? CdmUsages
        // GraphQL -> cdmUsages: [CdmCertificateUsageInfo!]! (type)
        if (this.CdmUsages != null) {
            var fspec = this.CdmUsages.AsFieldSpec(conf.Child("cdmUsages"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cdmUsages" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> CertificateRotation? CertificateRotation
        // GraphQL -> certificateRotation: CertificateRotation (type)
        if (this.CertificateRotation != null) {
            var fspec = this.CertificateRotation.AsFieldSpec(conf.Child("certificateRotation"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "certificateRotation" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<CertificateClusterInfo>? Clusters
        // GraphQL -> clusters: [CertificateClusterInfo!] (type)
        if (this.Clusters != null) {
            var fspec = this.Clusters.AsFieldSpec(conf.Child("clusters"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "clusters" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Org? Org
        // GraphQL -> org: Org (type)
        if (this.Org != null) {
            var fspec = this.Org.AsFieldSpec(conf.Child("org"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "org" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RbsHostUsage? RbsHostUsage
        // GraphQL -> rbsHostUsage: RbsHostUsage (type)
        if (this.RbsHostUsage != null) {
            var fspec = this.RbsHostUsage.AsFieldSpec(conf.Child("rbsHostUsage"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "rbsHostUsage" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<CertificateUsageInfo>? Usages
        // GraphQL -> usages: [CertificateUsageInfo!]! (type)
        if (this.Usages != null) {
            var fspec = this.Usages.AsFieldSpec(conf.Child("usages"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "usages" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> IssuerType? IssuerType
        // GraphQL -> issuerType: IssuerType! (enum)
        if (ec.Includes("issuerType",true))
        {
            if(this.IssuerType == null) {

                this.IssuerType = new IssuerType();

            } else {


            }
        }
        else if (this.IssuerType != null && ec.Excludes("issuerType",true))
        {
            this.IssuerType = null;
        }
        //      C# -> GlobalCertificateStatus? Status
        // GraphQL -> status: GlobalCertificateStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new GlobalCertificateStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
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
        //      C# -> System.String? CertificateFid
        // GraphQL -> certificateFid: UUID! (scalar)
        if (ec.Includes("certificateFid",true))
        {
            if(this.CertificateFid == null) {

                this.CertificateFid = "FETCH";

            } else {


            }
        }
        else if (this.CertificateFid != null && ec.Excludes("certificateFid",true))
        {
            this.CertificateFid = null;
        }
        //      C# -> System.String? CertificateId
        // GraphQL -> certificateId: String! (scalar)
        if (ec.Includes("certificateId",true))
        {
            if(this.CertificateId == null) {

                this.CertificateId = "FETCH";

            } else {


            }
        }
        else if (this.CertificateId != null && ec.Excludes("certificateId",true))
        {
            this.CertificateId = null;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (ec.Includes("description",true))
        {
            if(this.Description == null) {

                this.Description = "FETCH";

            } else {


            }
        }
        else if (this.Description != null && ec.Excludes("description",true))
        {
            this.Description = null;
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
        //      C# -> System.Boolean? HasKey
        // GraphQL -> hasKey: Boolean! (scalar)
        if (ec.Includes("hasKey",true))
        {
            if(this.HasKey == null) {

                this.HasKey = true;

            } else {


            }
        }
        else if (this.HasKey != null && ec.Excludes("hasKey",true))
        {
            this.HasKey = null;
        }
        //      C# -> System.Boolean? IsCa
        // GraphQL -> isCa: Boolean! (scalar)
        if (ec.Includes("isCa",true))
        {
            if(this.IsCa == null) {

                this.IsCa = true;

            } else {


            }
        }
        else if (this.IsCa != null && ec.Excludes("isCa",true))
        {
            this.IsCa = null;
        }
        //      C# -> System.Boolean? IsCaSigned
        // GraphQL -> isCaSigned: Boolean! (scalar)
        if (ec.Includes("isCaSigned",true))
        {
            if(this.IsCaSigned == null) {

                this.IsCaSigned = true;

            } else {


            }
        }
        else if (this.IsCaSigned != null && ec.Excludes("isCaSigned",true))
        {
            this.IsCaSigned = null;
        }
        //      C# -> System.Boolean? IsCdmBorn
        // GraphQL -> isCdmBorn: Boolean! (scalar)
        if (ec.Includes("isCdmBorn",true))
        {
            if(this.IsCdmBorn == null) {

                this.IsCdmBorn = true;

            } else {


            }
        }
        else if (this.IsCdmBorn != null && ec.Excludes("isCdmBorn",true))
        {
            this.IsCdmBorn = null;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
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
        //      C# -> System.Boolean? UserHasPrivilegeToScheduleRotation
        // GraphQL -> userHasPrivilegeToScheduleRotation: Boolean! (scalar)
        if (ec.Includes("userHasPrivilegeToScheduleRotation",true))
        {
            if(this.UserHasPrivilegeToScheduleRotation == null) {

                this.UserHasPrivilegeToScheduleRotation = true;

            } else {


            }
        }
        else if (this.UserHasPrivilegeToScheduleRotation != null && ec.Excludes("userHasPrivilegeToScheduleRotation",true))
        {
            this.UserHasPrivilegeToScheduleRotation = null;
        }
        //      C# -> List<CdmCertificateUsageInfo>? CdmUsages
        // GraphQL -> cdmUsages: [CdmCertificateUsageInfo!]! (type)
        if (ec.Includes("cdmUsages",false))
        {
            if(this.CdmUsages == null) {

                this.CdmUsages = new List<CdmCertificateUsageInfo>();
                this.CdmUsages.ApplyExploratoryFieldSpec(ec.NewChild("cdmUsages"));

            } else {

                this.CdmUsages.ApplyExploratoryFieldSpec(ec.NewChild("cdmUsages"));

            }
        }
        else if (this.CdmUsages != null && ec.Excludes("cdmUsages",false))
        {
            this.CdmUsages = null;
        }
        //      C# -> CertificateRotation? CertificateRotation
        // GraphQL -> certificateRotation: CertificateRotation (type)
        if (ec.Includes("certificateRotation",false))
        {
            if(this.CertificateRotation == null) {

                this.CertificateRotation = new CertificateRotation();
                this.CertificateRotation.ApplyExploratoryFieldSpec(ec.NewChild("certificateRotation"));

            } else {

                this.CertificateRotation.ApplyExploratoryFieldSpec(ec.NewChild("certificateRotation"));

            }
        }
        else if (this.CertificateRotation != null && ec.Excludes("certificateRotation",false))
        {
            this.CertificateRotation = null;
        }
        //      C# -> List<CertificateClusterInfo>? Clusters
        // GraphQL -> clusters: [CertificateClusterInfo!] (type)
        if (ec.Includes("clusters",false))
        {
            if(this.Clusters == null) {

                this.Clusters = new List<CertificateClusterInfo>();
                this.Clusters.ApplyExploratoryFieldSpec(ec.NewChild("clusters"));

            } else {

                this.Clusters.ApplyExploratoryFieldSpec(ec.NewChild("clusters"));

            }
        }
        else if (this.Clusters != null && ec.Excludes("clusters",false))
        {
            this.Clusters = null;
        }
        //      C# -> Org? Org
        // GraphQL -> org: Org (type)
        if (ec.Includes("org",false))
        {
            if(this.Org == null) {

                this.Org = new Org();
                this.Org.ApplyExploratoryFieldSpec(ec.NewChild("org"));

            } else {

                this.Org.ApplyExploratoryFieldSpec(ec.NewChild("org"));

            }
        }
        else if (this.Org != null && ec.Excludes("org",false))
        {
            this.Org = null;
        }
        //      C# -> RbsHostUsage? RbsHostUsage
        // GraphQL -> rbsHostUsage: RbsHostUsage (type)
        if (ec.Includes("rbsHostUsage",false))
        {
            if(this.RbsHostUsage == null) {

                this.RbsHostUsage = new RbsHostUsage();
                this.RbsHostUsage.ApplyExploratoryFieldSpec(ec.NewChild("rbsHostUsage"));

            } else {

                this.RbsHostUsage.ApplyExploratoryFieldSpec(ec.NewChild("rbsHostUsage"));

            }
        }
        else if (this.RbsHostUsage != null && ec.Excludes("rbsHostUsage",false))
        {
            this.RbsHostUsage = null;
        }
        //      C# -> List<CertificateUsageInfo>? Usages
        // GraphQL -> usages: [CertificateUsageInfo!]! (type)
        if (ec.Includes("usages",false))
        {
            if(this.Usages == null) {

                this.Usages = new List<CertificateUsageInfo>();
                this.Usages.ApplyExploratoryFieldSpec(ec.NewChild("usages"));

            } else {

                this.Usages.ApplyExploratoryFieldSpec(ec.NewChild("usages"));

            }
        }
        else if (this.Usages != null && ec.Excludes("usages",false))
        {
            this.Usages = null;
        }
    }


    #endregion

    } // class GlobalCertificate
    
    #endregion

    public static class ListGlobalCertificateExtensions
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
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<GlobalCertificate> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GlobalCertificate> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GlobalCertificate> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GlobalCertificate());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GlobalCertificate> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types