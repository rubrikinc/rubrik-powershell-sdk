// AddAzureCloudAccountStatus.cs
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
    #region AddAzureCloudAccountStatus
    public class AddAzureCloudAccountStatus: BaseType
    {
        #region members

        //      C# -> System.String? AzureSubscriptionNativeId
        // GraphQL -> azureSubscriptionNativeId: String! (scalar)
        [JsonProperty("azureSubscriptionNativeId")]
        public System.String? AzureSubscriptionNativeId { get; set; }

        //      C# -> System.String? AzureSubscriptionRubrikId
        // GraphQL -> azureSubscriptionRubrikId: String! (scalar)
        [JsonProperty("azureSubscriptionRubrikId")]
        public System.String? AzureSubscriptionRubrikId { get; set; }

        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        [JsonProperty("error")]
        public System.String? Error { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AddAzureCloudAccountStatus";
    }

    public AddAzureCloudAccountStatus Set(
        System.String? AzureSubscriptionNativeId = null,
        System.String? AzureSubscriptionRubrikId = null,
        System.String? Error = null
    ) 
    {
        if ( AzureSubscriptionNativeId != null ) {
            this.AzureSubscriptionNativeId = AzureSubscriptionNativeId;
        }
        if ( AzureSubscriptionRubrikId != null ) {
            this.AzureSubscriptionRubrikId = AzureSubscriptionRubrikId;
        }
        if ( Error != null ) {
            this.Error = Error;
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
        //      C# -> System.String? AzureSubscriptionNativeId
        // GraphQL -> azureSubscriptionNativeId: String! (scalar)
        if (this.AzureSubscriptionNativeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "azureSubscriptionNativeId\n" ;
            } else {
                s += ind + "azureSubscriptionNativeId\n" ;
            }
        }
        //      C# -> System.String? AzureSubscriptionRubrikId
        // GraphQL -> azureSubscriptionRubrikId: String! (scalar)
        if (this.AzureSubscriptionRubrikId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "azureSubscriptionRubrikId\n" ;
            } else {
                s += ind + "azureSubscriptionRubrikId\n" ;
            }
        }
        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        if (this.Error != null) {
            if (conf.Flat) {
                s += conf.Prefix + "error\n" ;
            } else {
                s += ind + "error\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? AzureSubscriptionNativeId
        // GraphQL -> azureSubscriptionNativeId: String! (scalar)
        if (ec.Includes("azureSubscriptionNativeId",true))
        {
            if(this.AzureSubscriptionNativeId == null) {

                this.AzureSubscriptionNativeId = "FETCH";

            } else {


            }
        }
        else if (this.AzureSubscriptionNativeId != null && ec.Excludes("azureSubscriptionNativeId",true))
        {
            this.AzureSubscriptionNativeId = null;
        }
        //      C# -> System.String? AzureSubscriptionRubrikId
        // GraphQL -> azureSubscriptionRubrikId: String! (scalar)
        if (ec.Includes("azureSubscriptionRubrikId",true))
        {
            if(this.AzureSubscriptionRubrikId == null) {

                this.AzureSubscriptionRubrikId = "FETCH";

            } else {


            }
        }
        else if (this.AzureSubscriptionRubrikId != null && ec.Excludes("azureSubscriptionRubrikId",true))
        {
            this.AzureSubscriptionRubrikId = null;
        }
        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        if (ec.Includes("error",true))
        {
            if(this.Error == null) {

                this.Error = "FETCH";

            } else {


            }
        }
        else if (this.Error != null && ec.Excludes("error",true))
        {
            this.Error = null;
        }
    }


    #endregion

    } // class AddAzureCloudAccountStatus
    
    #endregion

    public static class ListAddAzureCloudAccountStatusExtensions
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
            this List<AddAzureCloudAccountStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AddAzureCloudAccountStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AddAzureCloudAccountStatus> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AddAzureCloudAccountStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AddAzureCloudAccountStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types