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
                    s += ind + "pageInfo {\n" + fspec + ind + "}\n" ;
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
                    s += ind + "privateEndpointConnection {\n" + fspec + ind + "}\n" ;
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
            this List<DetailedPrivateEndpointConnection> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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