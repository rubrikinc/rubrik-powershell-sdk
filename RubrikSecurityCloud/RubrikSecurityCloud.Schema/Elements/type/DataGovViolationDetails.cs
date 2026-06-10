// DataGovViolationDetails.cs
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
    #region DataGovViolationDetails
 
    public class DataGovViolationDetails: BaseType, ViolationDetailsUnion
    {
        #region members

        //      C# -> DateTime? ReferenceTime
        // GraphQL -> referenceTime: DateTime (scalar)
        [JsonProperty("referenceTime")]
        public DateTime? ReferenceTime { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.Int64? ViolatedHighRiskSensitiveHits
        // GraphQL -> violatedHighRiskSensitiveHits: Long! (scalar)
        [JsonProperty("violatedHighRiskSensitiveHits")]
        public System.Int64? ViolatedHighRiskSensitiveHits { get; set; }

        //      C# -> System.Int64? ViolatedLowRiskSensitiveHits
        // GraphQL -> violatedLowRiskSensitiveHits: Long! (scalar)
        [JsonProperty("violatedLowRiskSensitiveHits")]
        public System.Int64? ViolatedLowRiskSensitiveHits { get; set; }

        //      C# -> System.Int64? ViolatedMediumRiskSensitiveHits
        // GraphQL -> violatedMediumRiskSensitiveHits: Long! (scalar)
        [JsonProperty("violatedMediumRiskSensitiveHits")]
        public System.Int64? ViolatedMediumRiskSensitiveHits { get; set; }

        //      C# -> System.Int64? ViolatedNoRiskSensitiveHits
        // GraphQL -> violatedNoRiskSensitiveHits: Long! (scalar)
        [JsonProperty("violatedNoRiskSensitiveHits")]
        public System.Int64? ViolatedNoRiskSensitiveHits { get; set; }

        //      C# -> System.Int64? ViolatedSensitiveFiles
        // GraphQL -> violatedSensitiveFiles: Long! (scalar)
        [JsonProperty("violatedSensitiveFiles")]
        public System.Int64? ViolatedSensitiveFiles { get; set; }

        //      C# -> System.Int64? ViolatedSensitiveHits
        // GraphQL -> violatedSensitiveHits: Long! (scalar)
        [JsonProperty("violatedSensitiveHits")]
        public System.Int64? ViolatedSensitiveHits { get; set; }

        //      C# -> List<DataCategoryStats>? DataCategories
        // GraphQL -> dataCategories: [DataCategoryStats!]! (type)
        [JsonProperty("dataCategories")]
        public List<DataCategoryStats>? DataCategories { get; set; }

        //      C# -> List<DataTypeStats>? DataTypes
        // GraphQL -> dataTypes: [DataTypeStats!]! (type)
        [JsonProperty("dataTypes")]
        public List<DataTypeStats>? DataTypes { get; set; }

        //      C# -> List<DocumentTypeStats>? DocumentTypes
        // GraphQL -> documentTypes: [DocumentTypeStats!]! (type)
        [JsonProperty("documentTypes")]
        public List<DocumentTypeStats>? DocumentTypes { get; set; }

        //      C# -> IdentityViolationDetails? IdentityViolationDetails
        // GraphQL -> identityViolationDetails: IdentityViolationDetails (type)
        [JsonProperty("identityViolationDetails")]
        public IdentityViolationDetails? IdentityViolationDetails { get; set; }

        //      C# -> List<MipLabelStats>? MipLabels
        // GraphQL -> mipLabels: [MipLabelStats!]! (type)
        [JsonProperty("mipLabels")]
        public List<MipLabelStats>? MipLabels { get; set; }

        //      C# -> Permissions? Permissions
        // GraphQL -> permissions: Permissions (type)
        [JsonProperty("permissions")]
        public Permissions? Permissions { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DataGovViolationDetails";
    }

    public DataGovViolationDetails Set(
        DateTime? ReferenceTime = null,
        System.String? SnapshotId = null,
        System.Int64? ViolatedHighRiskSensitiveHits = null,
        System.Int64? ViolatedLowRiskSensitiveHits = null,
        System.Int64? ViolatedMediumRiskSensitiveHits = null,
        System.Int64? ViolatedNoRiskSensitiveHits = null,
        System.Int64? ViolatedSensitiveFiles = null,
        System.Int64? ViolatedSensitiveHits = null,
        List<DataCategoryStats>? DataCategories = null,
        List<DataTypeStats>? DataTypes = null,
        List<DocumentTypeStats>? DocumentTypes = null,
        IdentityViolationDetails? IdentityViolationDetails = null,
        List<MipLabelStats>? MipLabels = null,
        Permissions? Permissions = null
    ) 
    {
        if ( ReferenceTime != null ) {
            this.ReferenceTime = ReferenceTime;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( ViolatedHighRiskSensitiveHits != null ) {
            this.ViolatedHighRiskSensitiveHits = ViolatedHighRiskSensitiveHits;
        }
        if ( ViolatedLowRiskSensitiveHits != null ) {
            this.ViolatedLowRiskSensitiveHits = ViolatedLowRiskSensitiveHits;
        }
        if ( ViolatedMediumRiskSensitiveHits != null ) {
            this.ViolatedMediumRiskSensitiveHits = ViolatedMediumRiskSensitiveHits;
        }
        if ( ViolatedNoRiskSensitiveHits != null ) {
            this.ViolatedNoRiskSensitiveHits = ViolatedNoRiskSensitiveHits;
        }
        if ( ViolatedSensitiveFiles != null ) {
            this.ViolatedSensitiveFiles = ViolatedSensitiveFiles;
        }
        if ( ViolatedSensitiveHits != null ) {
            this.ViolatedSensitiveHits = ViolatedSensitiveHits;
        }
        if ( DataCategories != null ) {
            this.DataCategories = DataCategories;
        }
        if ( DataTypes != null ) {
            this.DataTypes = DataTypes;
        }
        if ( DocumentTypes != null ) {
            this.DocumentTypes = DocumentTypes;
        }
        if ( IdentityViolationDetails != null ) {
            this.IdentityViolationDetails = IdentityViolationDetails;
        }
        if ( MipLabels != null ) {
            this.MipLabels = MipLabels;
        }
        if ( Permissions != null ) {
            this.Permissions = Permissions;
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
        //      C# -> DateTime? ReferenceTime
        // GraphQL -> referenceTime: DateTime (scalar)
        if (this.ReferenceTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "referenceTime\n" ;
            } else {
                s += ind + "referenceTime\n" ;
            }
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID (scalar)
        if (this.SnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotId\n" ;
            } else {
                s += ind + "snapshotId\n" ;
            }
        }
        //      C# -> System.Int64? ViolatedHighRiskSensitiveHits
        // GraphQL -> violatedHighRiskSensitiveHits: Long! (scalar)
        if (this.ViolatedHighRiskSensitiveHits != null) {
            if (conf.Flat) {
                s += conf.Prefix + "violatedHighRiskSensitiveHits\n" ;
            } else {
                s += ind + "violatedHighRiskSensitiveHits\n" ;
            }
        }
        //      C# -> System.Int64? ViolatedLowRiskSensitiveHits
        // GraphQL -> violatedLowRiskSensitiveHits: Long! (scalar)
        if (this.ViolatedLowRiskSensitiveHits != null) {
            if (conf.Flat) {
                s += conf.Prefix + "violatedLowRiskSensitiveHits\n" ;
            } else {
                s += ind + "violatedLowRiskSensitiveHits\n" ;
            }
        }
        //      C# -> System.Int64? ViolatedMediumRiskSensitiveHits
        // GraphQL -> violatedMediumRiskSensitiveHits: Long! (scalar)
        if (this.ViolatedMediumRiskSensitiveHits != null) {
            if (conf.Flat) {
                s += conf.Prefix + "violatedMediumRiskSensitiveHits\n" ;
            } else {
                s += ind + "violatedMediumRiskSensitiveHits\n" ;
            }
        }
        //      C# -> System.Int64? ViolatedNoRiskSensitiveHits
        // GraphQL -> violatedNoRiskSensitiveHits: Long! (scalar)
        if (this.ViolatedNoRiskSensitiveHits != null) {
            if (conf.Flat) {
                s += conf.Prefix + "violatedNoRiskSensitiveHits\n" ;
            } else {
                s += ind + "violatedNoRiskSensitiveHits\n" ;
            }
        }
        //      C# -> System.Int64? ViolatedSensitiveFiles
        // GraphQL -> violatedSensitiveFiles: Long! (scalar)
        if (this.ViolatedSensitiveFiles != null) {
            if (conf.Flat) {
                s += conf.Prefix + "violatedSensitiveFiles\n" ;
            } else {
                s += ind + "violatedSensitiveFiles\n" ;
            }
        }
        //      C# -> System.Int64? ViolatedSensitiveHits
        // GraphQL -> violatedSensitiveHits: Long! (scalar)
        if (this.ViolatedSensitiveHits != null) {
            if (conf.Flat) {
                s += conf.Prefix + "violatedSensitiveHits\n" ;
            } else {
                s += ind + "violatedSensitiveHits\n" ;
            }
        }
        //      C# -> List<DataCategoryStats>? DataCategories
        // GraphQL -> dataCategories: [DataCategoryStats!]! (type)
        if (this.DataCategories != null) {
            var fspec = this.DataCategories.AsFieldSpec(conf.Child("dataCategories"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "dataCategories" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<DataTypeStats>? DataTypes
        // GraphQL -> dataTypes: [DataTypeStats!]! (type)
        if (this.DataTypes != null) {
            var fspec = this.DataTypes.AsFieldSpec(conf.Child("dataTypes"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "dataTypes" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<DocumentTypeStats>? DocumentTypes
        // GraphQL -> documentTypes: [DocumentTypeStats!]! (type)
        if (this.DocumentTypes != null) {
            var fspec = this.DocumentTypes.AsFieldSpec(conf.Child("documentTypes"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "documentTypes" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> IdentityViolationDetails? IdentityViolationDetails
        // GraphQL -> identityViolationDetails: IdentityViolationDetails (type)
        if (this.IdentityViolationDetails != null) {
            var fspec = this.IdentityViolationDetails.AsFieldSpec(conf.Child("identityViolationDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "identityViolationDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<MipLabelStats>? MipLabels
        // GraphQL -> mipLabels: [MipLabelStats!]! (type)
        if (this.MipLabels != null) {
            var fspec = this.MipLabels.AsFieldSpec(conf.Child("mipLabels"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "mipLabels" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Permissions? Permissions
        // GraphQL -> permissions: Permissions (type)
        if (this.Permissions != null) {
            var fspec = this.Permissions.AsFieldSpec(conf.Child("permissions"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "permissions" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> DateTime? ReferenceTime
        // GraphQL -> referenceTime: DateTime (scalar)
        if (ec.Includes("referenceTime",true))
        {
            if(this.ReferenceTime == null) {

                this.ReferenceTime = new DateTime();

            } else {


            }
        }
        else if (this.ReferenceTime != null && ec.Excludes("referenceTime",true))
        {
            this.ReferenceTime = null;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID (scalar)
        if (ec.Includes("snapshotId",true))
        {
            if(this.SnapshotId == null) {

                this.SnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotId != null && ec.Excludes("snapshotId",true))
        {
            this.SnapshotId = null;
        }
        //      C# -> System.Int64? ViolatedHighRiskSensitiveHits
        // GraphQL -> violatedHighRiskSensitiveHits: Long! (scalar)
        if (ec.Includes("violatedHighRiskSensitiveHits",true))
        {
            if(this.ViolatedHighRiskSensitiveHits == null) {

                this.ViolatedHighRiskSensitiveHits = new System.Int64();

            } else {


            }
        }
        else if (this.ViolatedHighRiskSensitiveHits != null && ec.Excludes("violatedHighRiskSensitiveHits",true))
        {
            this.ViolatedHighRiskSensitiveHits = null;
        }
        //      C# -> System.Int64? ViolatedLowRiskSensitiveHits
        // GraphQL -> violatedLowRiskSensitiveHits: Long! (scalar)
        if (ec.Includes("violatedLowRiskSensitiveHits",true))
        {
            if(this.ViolatedLowRiskSensitiveHits == null) {

                this.ViolatedLowRiskSensitiveHits = new System.Int64();

            } else {


            }
        }
        else if (this.ViolatedLowRiskSensitiveHits != null && ec.Excludes("violatedLowRiskSensitiveHits",true))
        {
            this.ViolatedLowRiskSensitiveHits = null;
        }
        //      C# -> System.Int64? ViolatedMediumRiskSensitiveHits
        // GraphQL -> violatedMediumRiskSensitiveHits: Long! (scalar)
        if (ec.Includes("violatedMediumRiskSensitiveHits",true))
        {
            if(this.ViolatedMediumRiskSensitiveHits == null) {

                this.ViolatedMediumRiskSensitiveHits = new System.Int64();

            } else {


            }
        }
        else if (this.ViolatedMediumRiskSensitiveHits != null && ec.Excludes("violatedMediumRiskSensitiveHits",true))
        {
            this.ViolatedMediumRiskSensitiveHits = null;
        }
        //      C# -> System.Int64? ViolatedNoRiskSensitiveHits
        // GraphQL -> violatedNoRiskSensitiveHits: Long! (scalar)
        if (ec.Includes("violatedNoRiskSensitiveHits",true))
        {
            if(this.ViolatedNoRiskSensitiveHits == null) {

                this.ViolatedNoRiskSensitiveHits = new System.Int64();

            } else {


            }
        }
        else if (this.ViolatedNoRiskSensitiveHits != null && ec.Excludes("violatedNoRiskSensitiveHits",true))
        {
            this.ViolatedNoRiskSensitiveHits = null;
        }
        //      C# -> System.Int64? ViolatedSensitiveFiles
        // GraphQL -> violatedSensitiveFiles: Long! (scalar)
        if (ec.Includes("violatedSensitiveFiles",true))
        {
            if(this.ViolatedSensitiveFiles == null) {

                this.ViolatedSensitiveFiles = new System.Int64();

            } else {


            }
        }
        else if (this.ViolatedSensitiveFiles != null && ec.Excludes("violatedSensitiveFiles",true))
        {
            this.ViolatedSensitiveFiles = null;
        }
        //      C# -> System.Int64? ViolatedSensitiveHits
        // GraphQL -> violatedSensitiveHits: Long! (scalar)
        if (ec.Includes("violatedSensitiveHits",true))
        {
            if(this.ViolatedSensitiveHits == null) {

                this.ViolatedSensitiveHits = new System.Int64();

            } else {


            }
        }
        else if (this.ViolatedSensitiveHits != null && ec.Excludes("violatedSensitiveHits",true))
        {
            this.ViolatedSensitiveHits = null;
        }
        //      C# -> List<DataCategoryStats>? DataCategories
        // GraphQL -> dataCategories: [DataCategoryStats!]! (type)
        if (ec.Includes("dataCategories",false))
        {
            if(this.DataCategories == null) {

                this.DataCategories = new List<DataCategoryStats>();
                this.DataCategories.ApplyExploratoryFieldSpec(ec.NewChild("dataCategories"));

            } else {

                this.DataCategories.ApplyExploratoryFieldSpec(ec.NewChild("dataCategories"));

            }
        }
        else if (this.DataCategories != null && ec.Excludes("dataCategories",false))
        {
            this.DataCategories = null;
        }
        //      C# -> List<DataTypeStats>? DataTypes
        // GraphQL -> dataTypes: [DataTypeStats!]! (type)
        if (ec.Includes("dataTypes",false))
        {
            if(this.DataTypes == null) {

                this.DataTypes = new List<DataTypeStats>();
                this.DataTypes.ApplyExploratoryFieldSpec(ec.NewChild("dataTypes"));

            } else {

                this.DataTypes.ApplyExploratoryFieldSpec(ec.NewChild("dataTypes"));

            }
        }
        else if (this.DataTypes != null && ec.Excludes("dataTypes",false))
        {
            this.DataTypes = null;
        }
        //      C# -> List<DocumentTypeStats>? DocumentTypes
        // GraphQL -> documentTypes: [DocumentTypeStats!]! (type)
        if (ec.Includes("documentTypes",false))
        {
            if(this.DocumentTypes == null) {

                this.DocumentTypes = new List<DocumentTypeStats>();
                this.DocumentTypes.ApplyExploratoryFieldSpec(ec.NewChild("documentTypes"));

            } else {

                this.DocumentTypes.ApplyExploratoryFieldSpec(ec.NewChild("documentTypes"));

            }
        }
        else if (this.DocumentTypes != null && ec.Excludes("documentTypes",false))
        {
            this.DocumentTypes = null;
        }
        //      C# -> IdentityViolationDetails? IdentityViolationDetails
        // GraphQL -> identityViolationDetails: IdentityViolationDetails (type)
        if (ec.Includes("identityViolationDetails",false))
        {
            if(this.IdentityViolationDetails == null) {

                this.IdentityViolationDetails = new IdentityViolationDetails();
                this.IdentityViolationDetails.ApplyExploratoryFieldSpec(ec.NewChild("identityViolationDetails"));

            } else {

                this.IdentityViolationDetails.ApplyExploratoryFieldSpec(ec.NewChild("identityViolationDetails"));

            }
        }
        else if (this.IdentityViolationDetails != null && ec.Excludes("identityViolationDetails",false))
        {
            this.IdentityViolationDetails = null;
        }
        //      C# -> List<MipLabelStats>? MipLabels
        // GraphQL -> mipLabels: [MipLabelStats!]! (type)
        if (ec.Includes("mipLabels",false))
        {
            if(this.MipLabels == null) {

                this.MipLabels = new List<MipLabelStats>();
                this.MipLabels.ApplyExploratoryFieldSpec(ec.NewChild("mipLabels"));

            } else {

                this.MipLabels.ApplyExploratoryFieldSpec(ec.NewChild("mipLabels"));

            }
        }
        else if (this.MipLabels != null && ec.Excludes("mipLabels",false))
        {
            this.MipLabels = null;
        }
        //      C# -> Permissions? Permissions
        // GraphQL -> permissions: Permissions (type)
        if (ec.Includes("permissions",false))
        {
            if(this.Permissions == null) {

                this.Permissions = new Permissions();
                this.Permissions.ApplyExploratoryFieldSpec(ec.NewChild("permissions"));

            } else {

                this.Permissions.ApplyExploratoryFieldSpec(ec.NewChild("permissions"));

            }
        }
        else if (this.Permissions != null && ec.Excludes("permissions",false))
        {
            this.Permissions = null;
        }
    }


    #endregion

    } // class DataGovViolationDetails
    
    #endregion

    public static class ListDataGovViolationDetailsExtensions
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
            this List<DataGovViolationDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DataGovViolationDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DataGovViolationDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DataGovViolationDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DataGovViolationDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types