// AzureSnappableLocation.cs
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
    #region AzureSnappableLocation
 
    public class AzureSnappableLocation: BaseType, SnappableLocationType
    {
        #region members

        //      C# -> System.String? AzureRegion
        // GraphQL -> azureRegion: String! (scalar)
        [JsonProperty("azureRegion")]
        public System.String? AzureRegion { get; set; }

        //      C# -> System.String? SubscriptionRubrikId
        // GraphQL -> subscriptionRubrikId: String (scalar)
        [JsonProperty("subscriptionRubrikId")]
        public System.String? SubscriptionRubrikId { get; set; }

        //      C# -> System.String? SubscriptionRubrikName
        // GraphQL -> subscriptionRubrikName: String (scalar)
        [JsonProperty("subscriptionRubrikName")]
        public System.String? SubscriptionRubrikName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureSnappableLocation";
    }

    public AzureSnappableLocation Set(
        System.String? AzureRegion = null,
        System.String? SubscriptionRubrikId = null,
        System.String? SubscriptionRubrikName = null
    ) 
    {
        if ( AzureRegion != null ) {
            this.AzureRegion = AzureRegion;
        }
        if ( SubscriptionRubrikId != null ) {
            this.SubscriptionRubrikId = SubscriptionRubrikId;
        }
        if ( SubscriptionRubrikName != null ) {
            this.SubscriptionRubrikName = SubscriptionRubrikName;
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
        //      C# -> System.String? AzureRegion
        // GraphQL -> azureRegion: String! (scalar)
        if (this.AzureRegion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "azureRegion\n" ;
            } else {
                s += ind + "azureRegion\n" ;
            }
        }
        //      C# -> System.String? SubscriptionRubrikId
        // GraphQL -> subscriptionRubrikId: String (scalar)
        if (this.SubscriptionRubrikId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "subscriptionRubrikId\n" ;
            } else {
                s += ind + "subscriptionRubrikId\n" ;
            }
        }
        //      C# -> System.String? SubscriptionRubrikName
        // GraphQL -> subscriptionRubrikName: String (scalar)
        if (this.SubscriptionRubrikName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "subscriptionRubrikName\n" ;
            } else {
                s += ind + "subscriptionRubrikName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
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
        //      C# -> System.String? SubscriptionRubrikId
        // GraphQL -> subscriptionRubrikId: String (scalar)
        if (ec.Includes("subscriptionRubrikId",true))
        {
            if(this.SubscriptionRubrikId == null) {

                this.SubscriptionRubrikId = "FETCH";

            } else {


            }
        }
        else if (this.SubscriptionRubrikId != null && ec.Excludes("subscriptionRubrikId",true))
        {
            this.SubscriptionRubrikId = null;
        }
        //      C# -> System.String? SubscriptionRubrikName
        // GraphQL -> subscriptionRubrikName: String (scalar)
        if (ec.Includes("subscriptionRubrikName",true))
        {
            if(this.SubscriptionRubrikName == null) {

                this.SubscriptionRubrikName = "FETCH";

            } else {


            }
        }
        else if (this.SubscriptionRubrikName != null && ec.Excludes("subscriptionRubrikName",true))
        {
            this.SubscriptionRubrikName = null;
        }
    }


    #endregion

    } // class AzureSnappableLocation
    
    #endregion

    public static class ListAzureSnappableLocationExtensions
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
            this List<AzureSnappableLocation> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<AzureSnappableLocation> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureSnappableLocation> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureSnappableLocation());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureSnappableLocation> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types