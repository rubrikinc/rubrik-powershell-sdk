// CdmOracleRacNode.cs
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
    #region CdmOracleRacNode
    public class CdmOracleRacNode: BaseType
    {
        #region members

        //      C# -> HostConnectivityStatusEnum? Status
        // GraphQL -> status: HostConnectivityStatusEnum! (enum)
        [JsonProperty("status")]
        public HostConnectivityStatusEnum? Status { get; set; }

        //      C# -> System.String? HostFid
        // GraphQL -> hostFid: String (scalar)
        [JsonProperty("hostFid")]
        public System.String? HostFid { get; set; }

        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String! (scalar)
        [JsonProperty("nodeName")]
        public System.String? NodeName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CdmOracleRacNode";
    }

    public CdmOracleRacNode Set(
        HostConnectivityStatusEnum? Status = null,
        System.String? HostFid = null,
        System.String? NodeName = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( HostFid != null ) {
            this.HostFid = HostFid;
        }
        if ( NodeName != null ) {
            this.NodeName = NodeName;
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
        //      C# -> HostConnectivityStatusEnum? Status
        // GraphQL -> status: HostConnectivityStatusEnum! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? HostFid
        // GraphQL -> hostFid: String (scalar)
        if (this.HostFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostFid\n" ;
            } else {
                s += ind + "hostFid\n" ;
            }
        }
        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String! (scalar)
        if (this.NodeName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nodeName\n" ;
            } else {
                s += ind + "nodeName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> HostConnectivityStatusEnum? Status
        // GraphQL -> status: HostConnectivityStatusEnum! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new HostConnectivityStatusEnum();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? HostFid
        // GraphQL -> hostFid: String (scalar)
        if (ec.Includes("hostFid",true))
        {
            if(this.HostFid == null) {

                this.HostFid = "FETCH";

            } else {


            }
        }
        else if (this.HostFid != null && ec.Excludes("hostFid",true))
        {
            this.HostFid = null;
        }
        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String! (scalar)
        if (ec.Includes("nodeName",true))
        {
            if(this.NodeName == null) {

                this.NodeName = "FETCH";

            } else {


            }
        }
        else if (this.NodeName != null && ec.Excludes("nodeName",true))
        {
            this.NodeName = null;
        }
    }


    #endregion

    } // class CdmOracleRacNode
    
    #endregion

    public static class ListCdmOracleRacNodeExtensions
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
            this List<CdmOracleRacNode> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<CdmOracleRacNode> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CdmOracleRacNode> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmOracleRacNode());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CdmOracleRacNode> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types