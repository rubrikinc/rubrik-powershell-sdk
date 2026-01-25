// OrgSegregatedConsumption.cs
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
    #region OrgSegregatedConsumption
    public class OrgSegregatedConsumption: BaseType
    {
        #region members

        //      C# -> System.String? OrgId
        // GraphQL -> orgId: UUID! (scalar)
        [JsonProperty("orgId")]
        public System.String? OrgId { get; set; }

        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String! (scalar)
        [JsonProperty("orgName")]
        public System.String? OrgName { get; set; }

        //      C# -> System.Int64? TotalFetbConsumed
        // GraphQL -> totalFetbConsumed: Long (scalar)
        [JsonProperty("totalFetbConsumed")]
        public System.Int64? TotalFetbConsumed { get; set; }

        //      C# -> System.Int64? TotalObjectCount
        // GraphQL -> totalObjectCount: Long (scalar)
        [JsonProperty("totalObjectCount")]
        public System.Int64? TotalObjectCount { get; set; }

        //      C# -> SegregatedFetbConsumption? ExchangeConsumption
        // GraphQL -> exchangeConsumption: SegregatedFETBConsumption (type)
        [JsonProperty("exchangeConsumption")]
        public SegregatedFetbConsumption? ExchangeConsumption { get; set; }

        //      C# -> List<ObjectTypeUsage>? ObjectTypeUsage
        // GraphQL -> objectTypeUsage: [ObjectTypeUsage!]! (type)
        [JsonProperty("objectTypeUsage")]
        public List<ObjectTypeUsage>? ObjectTypeUsage { get; set; }

        //      C# -> SegregatedFetbConsumption? OnedriveConsumption
        // GraphQL -> onedriveConsumption: SegregatedFETBConsumption (type)
        [JsonProperty("onedriveConsumption")]
        public SegregatedFetbConsumption? OnedriveConsumption { get; set; }

        //      C# -> SegregatedFetbConsumption? SharepointConsumption
        // GraphQL -> sharepointConsumption: SegregatedFETBConsumption (type)
        [JsonProperty("sharepointConsumption")]
        public SegregatedFetbConsumption? SharepointConsumption { get; set; }

        //      C# -> SegregatedFetbConsumption? TotalConsumption
        // GraphQL -> totalConsumption: SegregatedFETBConsumption (type)
        [JsonProperty("totalConsumption")]
        public SegregatedFetbConsumption? TotalConsumption { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "OrgSegregatedConsumption";
    }

    public OrgSegregatedConsumption Set(
        System.String? OrgId = null,
        System.String? OrgName = null,
        System.Int64? TotalFetbConsumed = null,
        System.Int64? TotalObjectCount = null,
        SegregatedFetbConsumption? ExchangeConsumption = null,
        List<ObjectTypeUsage>? ObjectTypeUsage = null,
        SegregatedFetbConsumption? OnedriveConsumption = null,
        SegregatedFetbConsumption? SharepointConsumption = null,
        SegregatedFetbConsumption? TotalConsumption = null
    ) 
    {
        if ( OrgId != null ) {
            this.OrgId = OrgId;
        }
        if ( OrgName != null ) {
            this.OrgName = OrgName;
        }
        if ( TotalFetbConsumed != null ) {
            this.TotalFetbConsumed = TotalFetbConsumed;
        }
        if ( TotalObjectCount != null ) {
            this.TotalObjectCount = TotalObjectCount;
        }
        if ( ExchangeConsumption != null ) {
            this.ExchangeConsumption = ExchangeConsumption;
        }
        if ( ObjectTypeUsage != null ) {
            this.ObjectTypeUsage = ObjectTypeUsage;
        }
        if ( OnedriveConsumption != null ) {
            this.OnedriveConsumption = OnedriveConsumption;
        }
        if ( SharepointConsumption != null ) {
            this.SharepointConsumption = SharepointConsumption;
        }
        if ( TotalConsumption != null ) {
            this.TotalConsumption = TotalConsumption;
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
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: UUID! (scalar)
        if (this.OrgId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "orgId\n" ;
            } else {
                s += ind + "orgId\n" ;
            }
        }
        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String! (scalar)
        if (this.OrgName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "orgName\n" ;
            } else {
                s += ind + "orgName\n" ;
            }
        }
        //      C# -> System.Int64? TotalFetbConsumed
        // GraphQL -> totalFetbConsumed: Long (scalar)
        if (this.TotalFetbConsumed != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalFetbConsumed\n" ;
            } else {
                s += ind + "totalFetbConsumed\n" ;
            }
        }
        //      C# -> System.Int64? TotalObjectCount
        // GraphQL -> totalObjectCount: Long (scalar)
        if (this.TotalObjectCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalObjectCount\n" ;
            } else {
                s += ind + "totalObjectCount\n" ;
            }
        }
        //      C# -> SegregatedFetbConsumption? ExchangeConsumption
        // GraphQL -> exchangeConsumption: SegregatedFETBConsumption (type)
        if (this.ExchangeConsumption != null) {
            var fspec = this.ExchangeConsumption.AsFieldSpec(conf.Child("exchangeConsumption"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "exchangeConsumption" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ObjectTypeUsage>? ObjectTypeUsage
        // GraphQL -> objectTypeUsage: [ObjectTypeUsage!]! (type)
        if (this.ObjectTypeUsage != null) {
            var fspec = this.ObjectTypeUsage.AsFieldSpec(conf.Child("objectTypeUsage"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "objectTypeUsage" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SegregatedFetbConsumption? OnedriveConsumption
        // GraphQL -> onedriveConsumption: SegregatedFETBConsumption (type)
        if (this.OnedriveConsumption != null) {
            var fspec = this.OnedriveConsumption.AsFieldSpec(conf.Child("onedriveConsumption"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "onedriveConsumption" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SegregatedFetbConsumption? SharepointConsumption
        // GraphQL -> sharepointConsumption: SegregatedFETBConsumption (type)
        if (this.SharepointConsumption != null) {
            var fspec = this.SharepointConsumption.AsFieldSpec(conf.Child("sharepointConsumption"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sharepointConsumption" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SegregatedFetbConsumption? TotalConsumption
        // GraphQL -> totalConsumption: SegregatedFETBConsumption (type)
        if (this.TotalConsumption != null) {
            var fspec = this.TotalConsumption.AsFieldSpec(conf.Child("totalConsumption"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "totalConsumption" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? OrgId
        // GraphQL -> orgId: UUID! (scalar)
        if (ec.Includes("orgId",true))
        {
            if(this.OrgId == null) {

                this.OrgId = "FETCH";

            } else {


            }
        }
        else if (this.OrgId != null && ec.Excludes("orgId",true))
        {
            this.OrgId = null;
        }
        //      C# -> System.String? OrgName
        // GraphQL -> orgName: String! (scalar)
        if (ec.Includes("orgName",true))
        {
            if(this.OrgName == null) {

                this.OrgName = "FETCH";

            } else {


            }
        }
        else if (this.OrgName != null && ec.Excludes("orgName",true))
        {
            this.OrgName = null;
        }
        //      C# -> System.Int64? TotalFetbConsumed
        // GraphQL -> totalFetbConsumed: Long (scalar)
        if (ec.Includes("totalFetbConsumed",true))
        {
            if(this.TotalFetbConsumed == null) {

                this.TotalFetbConsumed = new System.Int64();

            } else {


            }
        }
        else if (this.TotalFetbConsumed != null && ec.Excludes("totalFetbConsumed",true))
        {
            this.TotalFetbConsumed = null;
        }
        //      C# -> System.Int64? TotalObjectCount
        // GraphQL -> totalObjectCount: Long (scalar)
        if (ec.Includes("totalObjectCount",true))
        {
            if(this.TotalObjectCount == null) {

                this.TotalObjectCount = new System.Int64();

            } else {


            }
        }
        else if (this.TotalObjectCount != null && ec.Excludes("totalObjectCount",true))
        {
            this.TotalObjectCount = null;
        }
        //      C# -> SegregatedFetbConsumption? ExchangeConsumption
        // GraphQL -> exchangeConsumption: SegregatedFETBConsumption (type)
        if (ec.Includes("exchangeConsumption",false))
        {
            if(this.ExchangeConsumption == null) {

                this.ExchangeConsumption = new SegregatedFetbConsumption();
                this.ExchangeConsumption.ApplyExploratoryFieldSpec(ec.NewChild("exchangeConsumption"));

            } else {

                this.ExchangeConsumption.ApplyExploratoryFieldSpec(ec.NewChild("exchangeConsumption"));

            }
        }
        else if (this.ExchangeConsumption != null && ec.Excludes("exchangeConsumption",false))
        {
            this.ExchangeConsumption = null;
        }
        //      C# -> List<ObjectTypeUsage>? ObjectTypeUsage
        // GraphQL -> objectTypeUsage: [ObjectTypeUsage!]! (type)
        if (ec.Includes("objectTypeUsage",false))
        {
            if(this.ObjectTypeUsage == null) {

                this.ObjectTypeUsage = new List<ObjectTypeUsage>();
                this.ObjectTypeUsage.ApplyExploratoryFieldSpec(ec.NewChild("objectTypeUsage"));

            } else {

                this.ObjectTypeUsage.ApplyExploratoryFieldSpec(ec.NewChild("objectTypeUsage"));

            }
        }
        else if (this.ObjectTypeUsage != null && ec.Excludes("objectTypeUsage",false))
        {
            this.ObjectTypeUsage = null;
        }
        //      C# -> SegregatedFetbConsumption? OnedriveConsumption
        // GraphQL -> onedriveConsumption: SegregatedFETBConsumption (type)
        if (ec.Includes("onedriveConsumption",false))
        {
            if(this.OnedriveConsumption == null) {

                this.OnedriveConsumption = new SegregatedFetbConsumption();
                this.OnedriveConsumption.ApplyExploratoryFieldSpec(ec.NewChild("onedriveConsumption"));

            } else {

                this.OnedriveConsumption.ApplyExploratoryFieldSpec(ec.NewChild("onedriveConsumption"));

            }
        }
        else if (this.OnedriveConsumption != null && ec.Excludes("onedriveConsumption",false))
        {
            this.OnedriveConsumption = null;
        }
        //      C# -> SegregatedFetbConsumption? SharepointConsumption
        // GraphQL -> sharepointConsumption: SegregatedFETBConsumption (type)
        if (ec.Includes("sharepointConsumption",false))
        {
            if(this.SharepointConsumption == null) {

                this.SharepointConsumption = new SegregatedFetbConsumption();
                this.SharepointConsumption.ApplyExploratoryFieldSpec(ec.NewChild("sharepointConsumption"));

            } else {

                this.SharepointConsumption.ApplyExploratoryFieldSpec(ec.NewChild("sharepointConsumption"));

            }
        }
        else if (this.SharepointConsumption != null && ec.Excludes("sharepointConsumption",false))
        {
            this.SharepointConsumption = null;
        }
        //      C# -> SegregatedFetbConsumption? TotalConsumption
        // GraphQL -> totalConsumption: SegregatedFETBConsumption (type)
        if (ec.Includes("totalConsumption",false))
        {
            if(this.TotalConsumption == null) {

                this.TotalConsumption = new SegregatedFetbConsumption();
                this.TotalConsumption.ApplyExploratoryFieldSpec(ec.NewChild("totalConsumption"));

            } else {

                this.TotalConsumption.ApplyExploratoryFieldSpec(ec.NewChild("totalConsumption"));

            }
        }
        else if (this.TotalConsumption != null && ec.Excludes("totalConsumption",false))
        {
            this.TotalConsumption = null;
        }
    }


    #endregion

    } // class OrgSegregatedConsumption
    
    #endregion

    public static class ListOrgSegregatedConsumptionExtensions
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
            this List<OrgSegregatedConsumption> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<OrgSegregatedConsumption> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<OrgSegregatedConsumption> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OrgSegregatedConsumption());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<OrgSegregatedConsumption> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types