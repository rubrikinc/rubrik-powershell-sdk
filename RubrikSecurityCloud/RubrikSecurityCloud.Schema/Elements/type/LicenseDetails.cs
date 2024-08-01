// LicenseDetails.cs
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
    #region LicenseDetails
    public class LicenseDetails: BaseType
    {
        #region members

        //      C# -> EntitlementStatus? EntitlementStatus
        // GraphQL -> entitlementStatus: EntitlementStatus! (enum)
        [JsonProperty("entitlementStatus")]
        public EntitlementStatus? EntitlementStatus { get; set; }

        //      C# -> LicenseInsightsSeverity? ExpirySeverity
        // GraphQL -> expirySeverity: LicenseInsightsSeverity! (enum)
        [JsonProperty("expirySeverity")]
        public LicenseInsightsSeverity? ExpirySeverity { get; set; }

        //      C# -> LicenseProduct? Product
        // GraphQL -> product: LicenseProduct! (enum)
        [JsonProperty("product")]
        public LicenseProduct? Product { get; set; }

        //      C# -> List<LicenseProduct>? SharedProducts
        // GraphQL -> sharedProducts: [LicenseProduct!]! (enum)
        [JsonProperty("sharedProducts")]
        public List<LicenseProduct>? SharedProducts { get; set; }

        //      C# -> System.String? Category
        // GraphQL -> category: String! (scalar)
        [JsonProperty("category")]
        public System.String? Category { get; set; }

        //      C# -> System.String? EntitlementEdition
        // GraphQL -> entitlementEdition: String! (scalar)
        [JsonProperty("entitlementEdition")]
        public System.String? EntitlementEdition { get; set; }

        //      C# -> System.String? EntitlementId
        // GraphQL -> entitlementId: String! (scalar)
        [JsonProperty("entitlementId")]
        public System.String? EntitlementId { get; set; }

        //      C# -> System.String? LicenseName
        // GraphQL -> licenseName: String! (scalar)
        [JsonProperty("licenseName")]
        public System.String? LicenseName { get; set; }

        //      C# -> System.String? RenewedEntitlementId
        // GraphQL -> renewedEntitlementId: String! (scalar)
        [JsonProperty("renewedEntitlementId")]
        public System.String? RenewedEntitlementId { get; set; }

        //      C# -> DateTime? TermEndDate
        // GraphQL -> termEndDate: DateTime (scalar)
        [JsonProperty("termEndDate")]
        public DateTime? TermEndDate { get; set; }

        //      C# -> DateTime? TermStartDate
        // GraphQL -> termStartDate: DateTime (scalar)
        [JsonProperty("termStartDate")]
        public DateTime? TermStartDate { get; set; }

        //      C# -> List<LicenseParams>? LicenseParams
        // GraphQL -> licenseParams: [LicenseParams!]! (type)
        [JsonProperty("licenseParams")]
        public List<LicenseParams>? LicenseParams { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "LicenseDetails";
    }

    public LicenseDetails Set(
        EntitlementStatus? EntitlementStatus = null,
        LicenseInsightsSeverity? ExpirySeverity = null,
        LicenseProduct? Product = null,
        List<LicenseProduct>? SharedProducts = null,
        System.String? Category = null,
        System.String? EntitlementEdition = null,
        System.String? EntitlementId = null,
        System.String? LicenseName = null,
        System.String? RenewedEntitlementId = null,
        DateTime? TermEndDate = null,
        DateTime? TermStartDate = null,
        List<LicenseParams>? LicenseParams = null
    ) 
    {
        if ( EntitlementStatus != null ) {
            this.EntitlementStatus = EntitlementStatus;
        }
        if ( ExpirySeverity != null ) {
            this.ExpirySeverity = ExpirySeverity;
        }
        if ( Product != null ) {
            this.Product = Product;
        }
        if ( SharedProducts != null ) {
            this.SharedProducts = SharedProducts;
        }
        if ( Category != null ) {
            this.Category = Category;
        }
        if ( EntitlementEdition != null ) {
            this.EntitlementEdition = EntitlementEdition;
        }
        if ( EntitlementId != null ) {
            this.EntitlementId = EntitlementId;
        }
        if ( LicenseName != null ) {
            this.LicenseName = LicenseName;
        }
        if ( RenewedEntitlementId != null ) {
            this.RenewedEntitlementId = RenewedEntitlementId;
        }
        if ( TermEndDate != null ) {
            this.TermEndDate = TermEndDate;
        }
        if ( TermStartDate != null ) {
            this.TermStartDate = TermStartDate;
        }
        if ( LicenseParams != null ) {
            this.LicenseParams = LicenseParams;
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
        //      C# -> EntitlementStatus? EntitlementStatus
        // GraphQL -> entitlementStatus: EntitlementStatus! (enum)
        if (this.EntitlementStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "entitlementStatus\n" ;
            } else {
                s += ind + "entitlementStatus\n" ;
            }
        }
        //      C# -> LicenseInsightsSeverity? ExpirySeverity
        // GraphQL -> expirySeverity: LicenseInsightsSeverity! (enum)
        if (this.ExpirySeverity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "expirySeverity\n" ;
            } else {
                s += ind + "expirySeverity\n" ;
            }
        }
        //      C# -> LicenseProduct? Product
        // GraphQL -> product: LicenseProduct! (enum)
        if (this.Product != null) {
            if (conf.Flat) {
                s += conf.Prefix + "product\n" ;
            } else {
                s += ind + "product\n" ;
            }
        }
        //      C# -> List<LicenseProduct>? SharedProducts
        // GraphQL -> sharedProducts: [LicenseProduct!]! (enum)
        if (this.SharedProducts != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sharedProducts\n" ;
            } else {
                s += ind + "sharedProducts\n" ;
            }
        }
        //      C# -> System.String? Category
        // GraphQL -> category: String! (scalar)
        if (this.Category != null) {
            if (conf.Flat) {
                s += conf.Prefix + "category\n" ;
            } else {
                s += ind + "category\n" ;
            }
        }
        //      C# -> System.String? EntitlementEdition
        // GraphQL -> entitlementEdition: String! (scalar)
        if (this.EntitlementEdition != null) {
            if (conf.Flat) {
                s += conf.Prefix + "entitlementEdition\n" ;
            } else {
                s += ind + "entitlementEdition\n" ;
            }
        }
        //      C# -> System.String? EntitlementId
        // GraphQL -> entitlementId: String! (scalar)
        if (this.EntitlementId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "entitlementId\n" ;
            } else {
                s += ind + "entitlementId\n" ;
            }
        }
        //      C# -> System.String? LicenseName
        // GraphQL -> licenseName: String! (scalar)
        if (this.LicenseName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "licenseName\n" ;
            } else {
                s += ind + "licenseName\n" ;
            }
        }
        //      C# -> System.String? RenewedEntitlementId
        // GraphQL -> renewedEntitlementId: String! (scalar)
        if (this.RenewedEntitlementId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "renewedEntitlementId\n" ;
            } else {
                s += ind + "renewedEntitlementId\n" ;
            }
        }
        //      C# -> DateTime? TermEndDate
        // GraphQL -> termEndDate: DateTime (scalar)
        if (this.TermEndDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "termEndDate\n" ;
            } else {
                s += ind + "termEndDate\n" ;
            }
        }
        //      C# -> DateTime? TermStartDate
        // GraphQL -> termStartDate: DateTime (scalar)
        if (this.TermStartDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "termStartDate\n" ;
            } else {
                s += ind + "termStartDate\n" ;
            }
        }
        //      C# -> List<LicenseParams>? LicenseParams
        // GraphQL -> licenseParams: [LicenseParams!]! (type)
        if (this.LicenseParams != null) {
            var fspec = this.LicenseParams.AsFieldSpec(conf.Child("licenseParams"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "licenseParams" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> EntitlementStatus? EntitlementStatus
        // GraphQL -> entitlementStatus: EntitlementStatus! (enum)
        if (ec.Includes("entitlementStatus",true))
        {
            if(this.EntitlementStatus == null) {

                this.EntitlementStatus = new EntitlementStatus();

            } else {


            }
        }
        else if (this.EntitlementStatus != null && ec.Excludes("entitlementStatus",true))
        {
            this.EntitlementStatus = null;
        }
        //      C# -> LicenseInsightsSeverity? ExpirySeverity
        // GraphQL -> expirySeverity: LicenseInsightsSeverity! (enum)
        if (ec.Includes("expirySeverity",true))
        {
            if(this.ExpirySeverity == null) {

                this.ExpirySeverity = new LicenseInsightsSeverity();

            } else {


            }
        }
        else if (this.ExpirySeverity != null && ec.Excludes("expirySeverity",true))
        {
            this.ExpirySeverity = null;
        }
        //      C# -> LicenseProduct? Product
        // GraphQL -> product: LicenseProduct! (enum)
        if (ec.Includes("product",true))
        {
            if(this.Product == null) {

                this.Product = new LicenseProduct();

            } else {


            }
        }
        else if (this.Product != null && ec.Excludes("product",true))
        {
            this.Product = null;
        }
        //      C# -> List<LicenseProduct>? SharedProducts
        // GraphQL -> sharedProducts: [LicenseProduct!]! (enum)
        if (ec.Includes("sharedProducts",true))
        {
            if(this.SharedProducts == null) {

                this.SharedProducts = new List<LicenseProduct>();

            } else {


            }
        }
        else if (this.SharedProducts != null && ec.Excludes("sharedProducts",true))
        {
            this.SharedProducts = null;
        }
        //      C# -> System.String? Category
        // GraphQL -> category: String! (scalar)
        if (ec.Includes("category",true))
        {
            if(this.Category == null) {

                this.Category = "FETCH";

            } else {


            }
        }
        else if (this.Category != null && ec.Excludes("category",true))
        {
            this.Category = null;
        }
        //      C# -> System.String? EntitlementEdition
        // GraphQL -> entitlementEdition: String! (scalar)
        if (ec.Includes("entitlementEdition",true))
        {
            if(this.EntitlementEdition == null) {

                this.EntitlementEdition = "FETCH";

            } else {


            }
        }
        else if (this.EntitlementEdition != null && ec.Excludes("entitlementEdition",true))
        {
            this.EntitlementEdition = null;
        }
        //      C# -> System.String? EntitlementId
        // GraphQL -> entitlementId: String! (scalar)
        if (ec.Includes("entitlementId",true))
        {
            if(this.EntitlementId == null) {

                this.EntitlementId = "FETCH";

            } else {


            }
        }
        else if (this.EntitlementId != null && ec.Excludes("entitlementId",true))
        {
            this.EntitlementId = null;
        }
        //      C# -> System.String? LicenseName
        // GraphQL -> licenseName: String! (scalar)
        if (ec.Includes("licenseName",true))
        {
            if(this.LicenseName == null) {

                this.LicenseName = "FETCH";

            } else {


            }
        }
        else if (this.LicenseName != null && ec.Excludes("licenseName",true))
        {
            this.LicenseName = null;
        }
        //      C# -> System.String? RenewedEntitlementId
        // GraphQL -> renewedEntitlementId: String! (scalar)
        if (ec.Includes("renewedEntitlementId",true))
        {
            if(this.RenewedEntitlementId == null) {

                this.RenewedEntitlementId = "FETCH";

            } else {


            }
        }
        else if (this.RenewedEntitlementId != null && ec.Excludes("renewedEntitlementId",true))
        {
            this.RenewedEntitlementId = null;
        }
        //      C# -> DateTime? TermEndDate
        // GraphQL -> termEndDate: DateTime (scalar)
        if (ec.Includes("termEndDate",true))
        {
            if(this.TermEndDate == null) {

                this.TermEndDate = new DateTime();

            } else {


            }
        }
        else if (this.TermEndDate != null && ec.Excludes("termEndDate",true))
        {
            this.TermEndDate = null;
        }
        //      C# -> DateTime? TermStartDate
        // GraphQL -> termStartDate: DateTime (scalar)
        if (ec.Includes("termStartDate",true))
        {
            if(this.TermStartDate == null) {

                this.TermStartDate = new DateTime();

            } else {


            }
        }
        else if (this.TermStartDate != null && ec.Excludes("termStartDate",true))
        {
            this.TermStartDate = null;
        }
        //      C# -> List<LicenseParams>? LicenseParams
        // GraphQL -> licenseParams: [LicenseParams!]! (type)
        if (ec.Includes("licenseParams",false))
        {
            if(this.LicenseParams == null) {

                this.LicenseParams = new List<LicenseParams>();
                this.LicenseParams.ApplyExploratoryFieldSpec(ec.NewChild("licenseParams"));

            } else {

                this.LicenseParams.ApplyExploratoryFieldSpec(ec.NewChild("licenseParams"));

            }
        }
        else if (this.LicenseParams != null && ec.Excludes("licenseParams",false))
        {
            this.LicenseParams = null;
        }
    }


    #endregion

    } // class LicenseDetails
    
    #endregion

    public static class ListLicenseDetailsExtensions
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
            this List<LicenseDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<LicenseDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<LicenseDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new LicenseDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<LicenseDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types