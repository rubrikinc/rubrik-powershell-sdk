// DetailedPrivateEndpointConnection.cs
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
    #region DetailedPrivateEndpointConnection
    public class DetailedPrivateEndpointConnection: BaseType
    {
        #region members

        //      C# -> System.String? StorageAccountId
        // GraphQL -> storageAccountId: String! (scalar)
        [JsonProperty("storageAccountId")]
        public System.String? StorageAccountId { get; set; }

        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        [JsonProperty("pageInfo")]
        public PageInfo? PageInfo { get; set; }

        //      C# -> PrivateEndpointConnection? PrivateEndpointConnection
        // GraphQL -> privateEndpointConnection: PrivateEndpointConnection (type)
        [JsonProperty("privateEndpointConnection")]
        public PrivateEndpointConnection? PrivateEndpointConnection { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DetailedPrivateEndpointConnection";
    }

    public DetailedPrivateEndpointConnection Set(
        System.String? StorageAccountId = null,
        PageInfo? PageInfo = null,
        PrivateEndpointConnection? PrivateEndpointConnection = null
    ) 
    {
        if ( StorageAccountId != null ) {
            this.StorageAccountId = StorageAccountId;
        }
        if ( PageInfo != null ) {
            this.PageInfo = PageInfo;
        }
        if ( PrivateEndpointConnection != null ) {
            this.PrivateEndpointConnection = PrivateEndpointConnection;
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
        //      C# -> System.String? StorageAccountId
        // GraphQL -> storageAccountId: String! (scalar)
        if (this.StorageAccountId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storageAccountId\n" ;
            } else {
                s += ind + "storageAccountId\n" ;
            }
        }
        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        if (this.PageInfo != null) {
            var fspec = this.PageInfo.AsFieldSpec(conf.Child("pageInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "pageInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> PrivateEndpointConnection? PrivateEndpointConnection
        // GraphQL -> privateEndpointConnection: PrivateEndpointConnection (type)
        if (this.PrivateEndpointConnection != null) {
            var fspec = this.PrivateEndpointConnection.AsFieldSpec(conf.Child("privateEndpointConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "privateEndpointConnection" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? StorageAccountId
        // GraphQL -> storageAccountId: String! (scalar)
        if (ec.Includes("storageAccountId",true))
        {
            if(this.StorageAccountId == null) {

                this.StorageAccountId = "FETCH";

            } else {


            }
        }
        else if (this.StorageAccountId != null && ec.Excludes("storageAccountId",true))
        {
            this.StorageAccountId = null;
        }
        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        if (ec.Includes("pageInfo",false))
        {
            if(this.PageInfo == null) {

                this.PageInfo = new PageInfo();
                this.PageInfo.ApplyExploratoryFieldSpec(ec.NewChild("pageInfo"));

            } else {

                this.PageInfo.ApplyExploratoryFieldSpec(ec.NewChild("pageInfo"));

            }
        }
        else if (this.PageInfo != null && ec.Excludes("pageInfo",false))
        {
            this.PageInfo = null;
        }
        //      C# -> PrivateEndpointConnection? PrivateEndpointConnection
        // GraphQL -> privateEndpointConnection: PrivateEndpointConnection (type)
        if (ec.Includes("privateEndpointConnection",false))
        {
            if(this.PrivateEndpointConnection == null) {

                this.PrivateEndpointConnection = new PrivateEndpointConnection();
                this.PrivateEndpointConnection.ApplyExploratoryFieldSpec(ec.NewChild("privateEndpointConnection"));

            } else {

                this.PrivateEndpointConnection.ApplyExploratoryFieldSpec(ec.NewChild("privateEndpointConnection"));

            }
        }
        else if (this.PrivateEndpointConnection != null && ec.Excludes("privateEndpointConnection",false))
        {
            this.PrivateEndpointConnection = null;
        }
    }


    #endregion

    } // class DetailedPrivateEndpointConnection
    
    #endregion

    public static class ListDetailedPrivateEndpointConnectionExtensions
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
            this List<DetailedPrivateEndpointConnection> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DetailedPrivateEndpointConnection> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DetailedPrivateEndpointConnection> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DetailedPrivateEndpointConnection());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DetailedPrivateEndpointConnection> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types