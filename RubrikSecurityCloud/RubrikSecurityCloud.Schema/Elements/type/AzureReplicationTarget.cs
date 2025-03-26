// AzureReplicationTarget.cs
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
    #region AzureReplicationTarget
    public class AzureReplicationTarget: BaseType
    {
        #region members

        //      C# -> AzureNativeRegionForReplication? Region
        // GraphQL -> region: AzureNativeRegionForReplication! (enum)
        [JsonProperty("region")]
        public AzureNativeRegionForReplication? Region { get; set; }

        //      C# -> System.String? SubscriptionId
        // GraphQL -> subscriptionId: String! (scalar)
        [JsonProperty("subscriptionId")]
        public System.String? SubscriptionId { get; set; }

        //      C# -> System.String? SubscriptionName
        // GraphQL -> subscriptionName: String! (scalar)
        [JsonProperty("subscriptionName")]
        public System.String? SubscriptionName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureReplicationTarget";
    }

    public AzureReplicationTarget Set(
        AzureNativeRegionForReplication? Region = null,
        System.String? SubscriptionId = null,
        System.String? SubscriptionName = null
    ) 
    {
        if ( Region != null ) {
            this.Region = Region;
        }
        if ( SubscriptionId != null ) {
            this.SubscriptionId = SubscriptionId;
        }
        if ( SubscriptionName != null ) {
            this.SubscriptionName = SubscriptionName;
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
        //      C# -> AzureNativeRegionForReplication? Region
        // GraphQL -> region: AzureNativeRegionForReplication! (enum)
        if (this.Region != null) {
            if (conf.Flat) {
                s += conf.Prefix + "region\n" ;
            } else {
                s += ind + "region\n" ;
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
        //      C# -> System.String? SubscriptionName
        // GraphQL -> subscriptionName: String! (scalar)
        if (this.SubscriptionName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "subscriptionName\n" ;
            } else {
                s += ind + "subscriptionName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AzureNativeRegionForReplication? Region
        // GraphQL -> region: AzureNativeRegionForReplication! (enum)
        if (ec.Includes("region",true))
        {
            if(this.Region == null) {

                this.Region = new AzureNativeRegionForReplication();

            } else {


            }
        }
        else if (this.Region != null && ec.Excludes("region",true))
        {
            this.Region = null;
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
        //      C# -> System.String? SubscriptionName
        // GraphQL -> subscriptionName: String! (scalar)
        if (ec.Includes("subscriptionName",true))
        {
            if(this.SubscriptionName == null) {

                this.SubscriptionName = "FETCH";

            } else {


            }
        }
        else if (this.SubscriptionName != null && ec.Excludes("subscriptionName",true))
        {
            this.SubscriptionName = null;
        }
    }


    #endregion

    } // class AzureReplicationTarget
    
    #endregion

    public static class ListAzureReplicationTargetExtensions
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
            this List<AzureReplicationTarget> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureReplicationTarget> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureReplicationTarget> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureReplicationTarget());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureReplicationTarget> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types