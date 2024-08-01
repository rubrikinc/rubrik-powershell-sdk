// OrgNetwork.cs
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
    #region OrgNetwork
    public class OrgNetwork: BaseType
    {
        #region members

        //      C# -> List<System.String>? LiveMountIps
        // GraphQL -> liveMountIps: [String!]! (scalar)
        [JsonProperty("liveMountIps")]
        public List<System.String>? LiveMountIps { get; set; }

        //      C# -> System.String? OrgNetworkId
        // GraphQL -> orgNetworkId: UUID! (scalar)
        [JsonProperty("orgNetworkId")]
        public System.String? OrgNetworkId { get; set; }

        //      C# -> System.String? OrgNetworkName
        // GraphQL -> orgNetworkName: String! (scalar)
        [JsonProperty("orgNetworkName")]
        public System.String? OrgNetworkName { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> List<EnvoyInfo>? EnvoyInfoList
        // GraphQL -> envoyInfoList: [EnvoyInfo!]! (type)
        [JsonProperty("envoyInfoList")]
        public List<EnvoyInfo>? EnvoyInfoList { get; set; }

        //      C# -> Org? Org
        // GraphQL -> org: Org! (type)
        [JsonProperty("org")]
        public Org? Org { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "OrgNetwork";
    }

    public OrgNetwork Set(
        List<System.String>? LiveMountIps = null,
        System.String? OrgNetworkId = null,
        System.String? OrgNetworkName = null,
        Cluster? Cluster = null,
        List<EnvoyInfo>? EnvoyInfoList = null,
        Org? Org = null
    ) 
    {
        if ( LiveMountIps != null ) {
            this.LiveMountIps = LiveMountIps;
        }
        if ( OrgNetworkId != null ) {
            this.OrgNetworkId = OrgNetworkId;
        }
        if ( OrgNetworkName != null ) {
            this.OrgNetworkName = OrgNetworkName;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( EnvoyInfoList != null ) {
            this.EnvoyInfoList = EnvoyInfoList;
        }
        if ( Org != null ) {
            this.Org = Org;
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
        //      C# -> List<System.String>? LiveMountIps
        // GraphQL -> liveMountIps: [String!]! (scalar)
        if (this.LiveMountIps != null) {
            if (conf.Flat) {
                s += conf.Prefix + "liveMountIps\n" ;
            } else {
                s += ind + "liveMountIps\n" ;
            }
        }
        //      C# -> System.String? OrgNetworkId
        // GraphQL -> orgNetworkId: UUID! (scalar)
        if (this.OrgNetworkId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "orgNetworkId\n" ;
            } else {
                s += ind + "orgNetworkId\n" ;
            }
        }
        //      C# -> System.String? OrgNetworkName
        // GraphQL -> orgNetworkName: String! (scalar)
        if (this.OrgNetworkName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "orgNetworkName\n" ;
            } else {
                s += ind + "orgNetworkName\n" ;
            }
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(conf.Child("cluster"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cluster" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<EnvoyInfo>? EnvoyInfoList
        // GraphQL -> envoyInfoList: [EnvoyInfo!]! (type)
        if (this.EnvoyInfoList != null) {
            var fspec = this.EnvoyInfoList.AsFieldSpec(conf.Child("envoyInfoList"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "envoyInfoList" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> Org? Org
        // GraphQL -> org: Org! (type)
        if (this.Org != null) {
            var fspec = this.Org.AsFieldSpec(conf.Child("org"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "org" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? LiveMountIps
        // GraphQL -> liveMountIps: [String!]! (scalar)
        if (ec.Includes("liveMountIps",true))
        {
            if(this.LiveMountIps == null) {

                this.LiveMountIps = new List<System.String>();

            } else {


            }
        }
        else if (this.LiveMountIps != null && ec.Excludes("liveMountIps",true))
        {
            this.LiveMountIps = null;
        }
        //      C# -> System.String? OrgNetworkId
        // GraphQL -> orgNetworkId: UUID! (scalar)
        if (ec.Includes("orgNetworkId",true))
        {
            if(this.OrgNetworkId == null) {

                this.OrgNetworkId = "FETCH";

            } else {


            }
        }
        else if (this.OrgNetworkId != null && ec.Excludes("orgNetworkId",true))
        {
            this.OrgNetworkId = null;
        }
        //      C# -> System.String? OrgNetworkName
        // GraphQL -> orgNetworkName: String! (scalar)
        if (ec.Includes("orgNetworkName",true))
        {
            if(this.OrgNetworkName == null) {

                this.OrgNetworkName = "FETCH";

            } else {


            }
        }
        else if (this.OrgNetworkName != null && ec.Excludes("orgNetworkName",true))
        {
            this.OrgNetworkName = null;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (ec.Includes("cluster",false))
        {
            if(this.Cluster == null) {

                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            } else {

                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            }
        }
        else if (this.Cluster != null && ec.Excludes("cluster",false))
        {
            this.Cluster = null;
        }
        //      C# -> List<EnvoyInfo>? EnvoyInfoList
        // GraphQL -> envoyInfoList: [EnvoyInfo!]! (type)
        if (ec.Includes("envoyInfoList",false))
        {
            if(this.EnvoyInfoList == null) {

                this.EnvoyInfoList = new List<EnvoyInfo>();
                this.EnvoyInfoList.ApplyExploratoryFieldSpec(ec.NewChild("envoyInfoList"));

            } else {

                this.EnvoyInfoList.ApplyExploratoryFieldSpec(ec.NewChild("envoyInfoList"));

            }
        }
        else if (this.EnvoyInfoList != null && ec.Excludes("envoyInfoList",false))
        {
            this.EnvoyInfoList = null;
        }
        //      C# -> Org? Org
        // GraphQL -> org: Org! (type)
        if (ec.Includes("org",false))
        {
            if(this.Org == null) {

                this.Org = new Org();
                this.Org.ApplyExploratoryFieldSpec(ec.NewChild("org"));

            } else {

                this.Org.ApplyExploratoryFieldSpec(ec.NewChild("org"));

            }
        }
        else if (this.Org != null && ec.Excludes("org",false))
        {
            this.Org = null;
        }
    }


    #endregion

    } // class OrgNetwork
    
    #endregion

    public static class ListOrgNetworkExtensions
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
            this List<OrgNetwork> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<OrgNetwork> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<OrgNetwork> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OrgNetwork());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<OrgNetwork> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types