// CloudAccountInfo.cs
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
    #region CloudAccountInfo
    public class CloudAccountInfo: BaseType
    {
        #region members

        //      C# -> Platform? CloudPlatform
        // GraphQL -> cloudPlatform: Platform! (enum)
        [JsonProperty("cloudPlatform")]
        public Platform? CloudPlatform { get; set; }

        //      C# -> System.String? AccountId
        // GraphQL -> accountId: String! (scalar)
        [JsonProperty("accountId")]
        public System.String? AccountId { get; set; }

        //      C# -> System.String? AccountName
        // GraphQL -> accountName: String! (scalar)
        [JsonProperty("accountName")]
        public System.String? AccountName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudAccountInfo";
    }

    public CloudAccountInfo Set(
        Platform? CloudPlatform = null,
        System.String? AccountId = null,
        System.String? AccountName = null
    ) 
    {
        if ( CloudPlatform != null ) {
            this.CloudPlatform = CloudPlatform;
        }
        if ( AccountId != null ) {
            this.AccountId = AccountId;
        }
        if ( AccountName != null ) {
            this.AccountName = AccountName;
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
        //      C# -> Platform? CloudPlatform
        // GraphQL -> cloudPlatform: Platform! (enum)
        if (this.CloudPlatform != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudPlatform\n" ;
            } else {
                s += ind + "cloudPlatform\n" ;
            }
        }
        //      C# -> System.String? AccountId
        // GraphQL -> accountId: String! (scalar)
        if (this.AccountId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accountId\n" ;
            } else {
                s += ind + "accountId\n" ;
            }
        }
        //      C# -> System.String? AccountName
        // GraphQL -> accountName: String! (scalar)
        if (this.AccountName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accountName\n" ;
            } else {
                s += ind + "accountName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> Platform? CloudPlatform
        // GraphQL -> cloudPlatform: Platform! (enum)
        if (ec.Includes("cloudPlatform",true))
        {
            if(this.CloudPlatform == null) {

                this.CloudPlatform = new Platform();

            } else {


            }
        }
        else if (this.CloudPlatform != null && ec.Excludes("cloudPlatform",true))
        {
            this.CloudPlatform = null;
        }
        //      C# -> System.String? AccountId
        // GraphQL -> accountId: String! (scalar)
        if (ec.Includes("accountId",true))
        {
            if(this.AccountId == null) {

                this.AccountId = "FETCH";

            } else {


            }
        }
        else if (this.AccountId != null && ec.Excludes("accountId",true))
        {
            this.AccountId = null;
        }
        //      C# -> System.String? AccountName
        // GraphQL -> accountName: String! (scalar)
        if (ec.Includes("accountName",true))
        {
            if(this.AccountName == null) {

                this.AccountName = "FETCH";

            } else {


            }
        }
        else if (this.AccountName != null && ec.Excludes("accountName",true))
        {
            this.AccountName = null;
        }
    }


    #endregion

    } // class CloudAccountInfo
    
    #endregion

    public static class ListCloudAccountInfoExtensions
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
            this List<CloudAccountInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudAccountInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudAccountInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudAccountInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudAccountInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types