// PrivateEndpointConnection.cs
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
    #region PrivateEndpointConnection
    public class PrivateEndpointConnection: BaseType
    {
        #region members

        //      C# -> PrivateEndpointConnectionStatus? PrivateEndpointConnectionStatus
        // GraphQL -> privateEndpointConnectionStatus: PrivateEndpointConnectionStatus! (enum)
        [JsonProperty("privateEndpointConnectionStatus")]
        public PrivateEndpointConnectionStatus? PrivateEndpointConnectionStatus { get; set; }

        //      C# -> System.String? PrivateEndpointId
        // GraphQL -> privateEndpointId: String! (scalar)
        [JsonProperty("privateEndpointId")]
        public System.String? PrivateEndpointId { get; set; }

        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        [JsonProperty("pageInfo")]
        public PageInfo? PageInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PrivateEndpointConnection";
    }

    public PrivateEndpointConnection Set(
        PrivateEndpointConnectionStatus? PrivateEndpointConnectionStatus = null,
        System.String? PrivateEndpointId = null,
        PageInfo? PageInfo = null
    ) 
    {
        if ( PrivateEndpointConnectionStatus != null ) {
            this.PrivateEndpointConnectionStatus = PrivateEndpointConnectionStatus;
        }
        if ( PrivateEndpointId != null ) {
            this.PrivateEndpointId = PrivateEndpointId;
        }
        if ( PageInfo != null ) {
            this.PageInfo = PageInfo;
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
        //      C# -> PrivateEndpointConnectionStatus? PrivateEndpointConnectionStatus
        // GraphQL -> privateEndpointConnectionStatus: PrivateEndpointConnectionStatus! (enum)
        if (this.PrivateEndpointConnectionStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "privateEndpointConnectionStatus\n" ;
            } else {
                s += ind + "privateEndpointConnectionStatus\n" ;
            }
        }
        //      C# -> System.String? PrivateEndpointId
        // GraphQL -> privateEndpointId: String! (scalar)
        if (this.PrivateEndpointId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "privateEndpointId\n" ;
            } else {
                s += ind + "privateEndpointId\n" ;
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> PrivateEndpointConnectionStatus? PrivateEndpointConnectionStatus
        // GraphQL -> privateEndpointConnectionStatus: PrivateEndpointConnectionStatus! (enum)
        if (ec.Includes("privateEndpointConnectionStatus",true))
        {
            if(this.PrivateEndpointConnectionStatus == null) {

                this.PrivateEndpointConnectionStatus = new PrivateEndpointConnectionStatus();

            } else {


            }
        }
        else if (this.PrivateEndpointConnectionStatus != null && ec.Excludes("privateEndpointConnectionStatus",true))
        {
            this.PrivateEndpointConnectionStatus = null;
        }
        //      C# -> System.String? PrivateEndpointId
        // GraphQL -> privateEndpointId: String! (scalar)
        if (ec.Includes("privateEndpointId",true))
        {
            if(this.PrivateEndpointId == null) {

                this.PrivateEndpointId = "FETCH";

            } else {


            }
        }
        else if (this.PrivateEndpointId != null && ec.Excludes("privateEndpointId",true))
        {
            this.PrivateEndpointId = null;
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
    }


    #endregion

    } // class PrivateEndpointConnection
    
    #endregion

    public static class ListPrivateEndpointConnectionExtensions
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
            this List<PrivateEndpointConnection> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<PrivateEndpointConnection> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PrivateEndpointConnection> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PrivateEndpointConnection());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PrivateEndpointConnection> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types