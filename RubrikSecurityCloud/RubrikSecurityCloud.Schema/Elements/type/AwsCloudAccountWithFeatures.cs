// AwsCloudAccountWithFeatures.cs
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
    #region AwsCloudAccountWithFeatures
    public class AwsCloudAccountWithFeatures: BaseType
    {
        #region members

        //      C# -> AwsCloudAccount? AwsCloudAccount
        // GraphQL -> awsCloudAccount: AwsCloudAccount (type)
        [JsonProperty("awsCloudAccount")]
        public AwsCloudAccount? AwsCloudAccount { get; set; }

        //      C# -> List<FeatureDetail>? FeatureDetails
        // GraphQL -> featureDetails: [FeatureDetail!]! (type)
        [JsonProperty("featureDetails")]
        public List<FeatureDetail>? FeatureDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsCloudAccountWithFeatures";
    }

    public AwsCloudAccountWithFeatures Set(
        AwsCloudAccount? AwsCloudAccount = null,
        List<FeatureDetail>? FeatureDetails = null
    ) 
    {
        if ( AwsCloudAccount != null ) {
            this.AwsCloudAccount = AwsCloudAccount;
        }
        if ( FeatureDetails != null ) {
            this.FeatureDetails = FeatureDetails;
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
        //      C# -> AwsCloudAccount? AwsCloudAccount
        // GraphQL -> awsCloudAccount: AwsCloudAccount (type)
        if (this.AwsCloudAccount != null) {
            var fspec = this.AwsCloudAccount.AsFieldSpec(conf.Child("awsCloudAccount"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsCloudAccount {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<FeatureDetail>? FeatureDetails
        // GraphQL -> featureDetails: [FeatureDetail!]! (type)
        if (this.FeatureDetails != null) {
            var fspec = this.FeatureDetails.AsFieldSpec(conf.Child("featureDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "featureDetails {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AwsCloudAccount? AwsCloudAccount
        // GraphQL -> awsCloudAccount: AwsCloudAccount (type)
        if (ec.Includes("awsCloudAccount",false))
        {
            if(this.AwsCloudAccount == null) {

                this.AwsCloudAccount = new AwsCloudAccount();
                this.AwsCloudAccount.ApplyExploratoryFieldSpec(ec.NewChild("awsCloudAccount"));

            } else {

                this.AwsCloudAccount.ApplyExploratoryFieldSpec(ec.NewChild("awsCloudAccount"));

            }
        }
        else if (this.AwsCloudAccount != null && ec.Excludes("awsCloudAccount",false))
        {
            this.AwsCloudAccount = null;
        }
        //      C# -> List<FeatureDetail>? FeatureDetails
        // GraphQL -> featureDetails: [FeatureDetail!]! (type)
        if (ec.Includes("featureDetails",false))
        {
            if(this.FeatureDetails == null) {

                this.FeatureDetails = new List<FeatureDetail>();
                this.FeatureDetails.ApplyExploratoryFieldSpec(ec.NewChild("featureDetails"));

            } else {

                this.FeatureDetails.ApplyExploratoryFieldSpec(ec.NewChild("featureDetails"));

            }
        }
        else if (this.FeatureDetails != null && ec.Excludes("featureDetails",false))
        {
            this.FeatureDetails = null;
        }
    }


    #endregion

    } // class AwsCloudAccountWithFeatures
    
    #endregion

    public static class ListAwsCloudAccountWithFeaturesExtensions
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
            this List<AwsCloudAccountWithFeatures> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsCloudAccountWithFeatures> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsCloudAccountWithFeatures> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsCloudAccountWithFeatures());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsCloudAccountWithFeatures> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types