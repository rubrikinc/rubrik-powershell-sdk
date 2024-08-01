// PingMultiClusterPcReply.cs
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
    #region PingMultiClusterPcReply
    public class PingMultiClusterPcReply: BaseType
    {
        #region members

        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        [JsonProperty("hostname")]
        public System.String? Hostname { get; set; }

        //      C# -> System.Boolean? IsDrEnabled
        // GraphQL -> isDrEnabled: Boolean (scalar)
        [JsonProperty("isDrEnabled")]
        public System.Boolean? IsDrEnabled { get; set; }

        //      C# -> List<NutanixClustersListElementWithConnectionStatus>? NutanixClusters
        // GraphQL -> nutanixClusters: [NutanixClustersListElementWithConnectionStatus!]! (type)
        [JsonProperty("nutanixClusters")]
        public List<NutanixClustersListElementWithConnectionStatus>? NutanixClusters { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PingMultiClusterPcReply";
    }

    public PingMultiClusterPcReply Set(
        System.String? Hostname = null,
        System.Boolean? IsDrEnabled = null,
        List<NutanixClustersListElementWithConnectionStatus>? NutanixClusters = null
    ) 
    {
        if ( Hostname != null ) {
            this.Hostname = Hostname;
        }
        if ( IsDrEnabled != null ) {
            this.IsDrEnabled = IsDrEnabled;
        }
        if ( NutanixClusters != null ) {
            this.NutanixClusters = NutanixClusters;
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
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (this.Hostname != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostname\n" ;
            } else {
                s += ind + "hostname\n" ;
            }
        }
        //      C# -> System.Boolean? IsDrEnabled
        // GraphQL -> isDrEnabled: Boolean (scalar)
        if (this.IsDrEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isDrEnabled\n" ;
            } else {
                s += ind + "isDrEnabled\n" ;
            }
        }
        //      C# -> List<NutanixClustersListElementWithConnectionStatus>? NutanixClusters
        // GraphQL -> nutanixClusters: [NutanixClustersListElementWithConnectionStatus!]! (type)
        if (this.NutanixClusters != null) {
            var fspec = this.NutanixClusters.AsFieldSpec(conf.Child("nutanixClusters"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "nutanixClusters" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (ec.Includes("hostname",true))
        {
            if(this.Hostname == null) {

                this.Hostname = "FETCH";

            } else {


            }
        }
        else if (this.Hostname != null && ec.Excludes("hostname",true))
        {
            this.Hostname = null;
        }
        //      C# -> System.Boolean? IsDrEnabled
        // GraphQL -> isDrEnabled: Boolean (scalar)
        if (ec.Includes("isDrEnabled",true))
        {
            if(this.IsDrEnabled == null) {

                this.IsDrEnabled = true;

            } else {


            }
        }
        else if (this.IsDrEnabled != null && ec.Excludes("isDrEnabled",true))
        {
            this.IsDrEnabled = null;
        }
        //      C# -> List<NutanixClustersListElementWithConnectionStatus>? NutanixClusters
        // GraphQL -> nutanixClusters: [NutanixClustersListElementWithConnectionStatus!]! (type)
        if (ec.Includes("nutanixClusters",false))
        {
            if(this.NutanixClusters == null) {

                this.NutanixClusters = new List<NutanixClustersListElementWithConnectionStatus>();
                this.NutanixClusters.ApplyExploratoryFieldSpec(ec.NewChild("nutanixClusters"));

            } else {

                this.NutanixClusters.ApplyExploratoryFieldSpec(ec.NewChild("nutanixClusters"));

            }
        }
        else if (this.NutanixClusters != null && ec.Excludes("nutanixClusters",false))
        {
            this.NutanixClusters = null;
        }
    }


    #endregion

    } // class PingMultiClusterPcReply
    
    #endregion

    public static class ListPingMultiClusterPcReplyExtensions
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
            this List<PingMultiClusterPcReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PingMultiClusterPcReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PingMultiClusterPcReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PingMultiClusterPcReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PingMultiClusterPcReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types