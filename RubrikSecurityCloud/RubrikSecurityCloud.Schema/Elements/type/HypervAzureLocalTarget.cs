// HypervAzureLocalTarget.cs
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
    #region HypervAzureLocalTarget
    public class HypervAzureLocalTarget: BaseType
    {
        #region members

        //      C# -> System.String? AzureRegion
        // GraphQL -> azureRegion: String! (scalar)
        [JsonProperty("azureRegion")]
        public System.String? AzureRegion { get; set; }

        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        [JsonProperty("clusterName")]
        public System.String? ClusterName { get; set; }

        //      C# -> System.String? CustomLocationId
        // GraphQL -> customLocationId: String! (scalar)
        [JsonProperty("customLocationId")]
        public System.String? CustomLocationId { get; set; }

        //      C# -> System.String? HypervClusterId
        // GraphQL -> hypervClusterId: UUID! (scalar)
        [JsonProperty("hypervClusterId")]
        public System.String? HypervClusterId { get; set; }

        //      C# -> System.String? ResourceGroup
        // GraphQL -> resourceGroup: String! (scalar)
        [JsonProperty("resourceGroup")]
        public System.String? ResourceGroup { get; set; }

        //      C# -> System.String? SubscriptionId
        // GraphQL -> subscriptionId: String! (scalar)
        [JsonProperty("subscriptionId")]
        public System.String? SubscriptionId { get; set; }

        //      C# -> List<HypervAzureLocalNicSpec>? Nics
        // GraphQL -> nics: [HypervAzureLocalNicSpec!]! (type)
        [JsonProperty("nics")]
        public List<HypervAzureLocalNicSpec>? Nics { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HypervAzureLocalTarget";
    }

    public HypervAzureLocalTarget Set(
        System.String? AzureRegion = null,
        System.String? ClusterName = null,
        System.String? CustomLocationId = null,
        System.String? HypervClusterId = null,
        System.String? ResourceGroup = null,
        System.String? SubscriptionId = null,
        List<HypervAzureLocalNicSpec>? Nics = null
    ) 
    {
        if ( AzureRegion != null ) {
            this.AzureRegion = AzureRegion;
        }
        if ( ClusterName != null ) {
            this.ClusterName = ClusterName;
        }
        if ( CustomLocationId != null ) {
            this.CustomLocationId = CustomLocationId;
        }
        if ( HypervClusterId != null ) {
            this.HypervClusterId = HypervClusterId;
        }
        if ( ResourceGroup != null ) {
            this.ResourceGroup = ResourceGroup;
        }
        if ( SubscriptionId != null ) {
            this.SubscriptionId = SubscriptionId;
        }
        if ( Nics != null ) {
            this.Nics = Nics;
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
        //      C# -> System.String? AzureRegion
        // GraphQL -> azureRegion: String! (scalar)
        if (this.AzureRegion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "azureRegion\n" ;
            } else {
                s += ind + "azureRegion\n" ;
            }
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (this.ClusterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterName\n" ;
            } else {
                s += ind + "clusterName\n" ;
            }
        }
        //      C# -> System.String? CustomLocationId
        // GraphQL -> customLocationId: String! (scalar)
        if (this.CustomLocationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "customLocationId\n" ;
            } else {
                s += ind + "customLocationId\n" ;
            }
        }
        //      C# -> System.String? HypervClusterId
        // GraphQL -> hypervClusterId: UUID! (scalar)
        if (this.HypervClusterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hypervClusterId\n" ;
            } else {
                s += ind + "hypervClusterId\n" ;
            }
        }
        //      C# -> System.String? ResourceGroup
        // GraphQL -> resourceGroup: String! (scalar)
        if (this.ResourceGroup != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceGroup\n" ;
            } else {
                s += ind + "resourceGroup\n" ;
            }
        }
        //      C# -> System.String? SubscriptionId
        // GraphQL -> subscriptionId: String! (scalar)
        if (this.SubscriptionId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "subscriptionId\n" ;
            } else {
                s += ind + "subscriptionId\n" ;
            }
        }
        //      C# -> List<HypervAzureLocalNicSpec>? Nics
        // GraphQL -> nics: [HypervAzureLocalNicSpec!]! (type)
        if (this.Nics != null) {
            var fspec = this.Nics.AsFieldSpec(conf.Child("nics"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "nics" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? AzureRegion
        // GraphQL -> azureRegion: String! (scalar)
        if (ec.Includes("azureRegion",true))
        {
            if(this.AzureRegion == null) {

                this.AzureRegion = "FETCH";

            } else {


            }
        }
        else if (this.AzureRegion != null && ec.Excludes("azureRegion",true))
        {
            this.AzureRegion = null;
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (ec.Includes("clusterName",true))
        {
            if(this.ClusterName == null) {

                this.ClusterName = "FETCH";

            } else {


            }
        }
        else if (this.ClusterName != null && ec.Excludes("clusterName",true))
        {
            this.ClusterName = null;
        }
        //      C# -> System.String? CustomLocationId
        // GraphQL -> customLocationId: String! (scalar)
        if (ec.Includes("customLocationId",true))
        {
            if(this.CustomLocationId == null) {

                this.CustomLocationId = "FETCH";

            } else {


            }
        }
        else if (this.CustomLocationId != null && ec.Excludes("customLocationId",true))
        {
            this.CustomLocationId = null;
        }
        //      C# -> System.String? HypervClusterId
        // GraphQL -> hypervClusterId: UUID! (scalar)
        if (ec.Includes("hypervClusterId",true))
        {
            if(this.HypervClusterId == null) {

                this.HypervClusterId = "FETCH";

            } else {


            }
        }
        else if (this.HypervClusterId != null && ec.Excludes("hypervClusterId",true))
        {
            this.HypervClusterId = null;
        }
        //      C# -> System.String? ResourceGroup
        // GraphQL -> resourceGroup: String! (scalar)
        if (ec.Includes("resourceGroup",true))
        {
            if(this.ResourceGroup == null) {

                this.ResourceGroup = "FETCH";

            } else {


            }
        }
        else if (this.ResourceGroup != null && ec.Excludes("resourceGroup",true))
        {
            this.ResourceGroup = null;
        }
        //      C# -> System.String? SubscriptionId
        // GraphQL -> subscriptionId: String! (scalar)
        if (ec.Includes("subscriptionId",true))
        {
            if(this.SubscriptionId == null) {

                this.SubscriptionId = "FETCH";

            } else {


            }
        }
        else if (this.SubscriptionId != null && ec.Excludes("subscriptionId",true))
        {
            this.SubscriptionId = null;
        }
        //      C# -> List<HypervAzureLocalNicSpec>? Nics
        // GraphQL -> nics: [HypervAzureLocalNicSpec!]! (type)
        if (ec.Includes("nics",false))
        {
            if(this.Nics == null) {

                this.Nics = new List<HypervAzureLocalNicSpec>();
                this.Nics.ApplyExploratoryFieldSpec(ec.NewChild("nics"));

            } else {

                this.Nics.ApplyExploratoryFieldSpec(ec.NewChild("nics"));

            }
        }
        else if (this.Nics != null && ec.Excludes("nics",false))
        {
            this.Nics = null;
        }
    }


    #endregion

    } // class HypervAzureLocalTarget
    
    #endregion

    public static class ListHypervAzureLocalTargetExtensions
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
            this List<HypervAzureLocalTarget> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HypervAzureLocalTarget> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HypervAzureLocalTarget> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HypervAzureLocalTarget());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HypervAzureLocalTarget> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types