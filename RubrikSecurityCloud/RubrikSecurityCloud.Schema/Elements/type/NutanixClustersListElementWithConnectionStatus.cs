// NutanixClustersListElementWithConnectionStatus.cs
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
    #region NutanixClustersListElementWithConnectionStatus
    public class NutanixClustersListElementWithConnectionStatus: BaseType
    {
        #region members

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> NutanixClusterConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: NutanixClusterConnectionStatus (type)
        [JsonProperty("connectionStatus")]
        public NutanixClusterConnectionStatus? ConnectionStatus { get; set; }

        //      C# -> NutanixClustersListElement? NutanixClustersListElement
        // GraphQL -> nutanixClustersListElement: NutanixClustersListElement (type)
        [JsonProperty("nutanixClustersListElement")]
        public NutanixClustersListElement? NutanixClustersListElement { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NutanixClustersListElementWithConnectionStatus";
    }

    public NutanixClustersListElementWithConnectionStatus Set(
        System.String? ClusterUuid = null,
        System.String? Name = null,
        NutanixClusterConnectionStatus? ConnectionStatus = null,
        NutanixClustersListElement? NutanixClustersListElement = null
    ) 
    {
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( ConnectionStatus != null ) {
            this.ConnectionStatus = ConnectionStatus;
        }
        if ( NutanixClustersListElement != null ) {
            this.NutanixClustersListElement = NutanixClustersListElement;
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
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String (scalar)
        if (this.ClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterUuid\n" ;
            } else {
                s += ind + "clusterUuid\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> NutanixClusterConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: NutanixClusterConnectionStatus (type)
        if (this.ConnectionStatus != null) {
            var fspec = this.ConnectionStatus.AsFieldSpec(conf.Child("connectionStatus"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "connectionStatus" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> NutanixClustersListElement? NutanixClustersListElement
        // GraphQL -> nutanixClustersListElement: NutanixClustersListElement (type)
        if (this.NutanixClustersListElement != null) {
            var fspec = this.NutanixClustersListElement.AsFieldSpec(conf.Child("nutanixClustersListElement"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "nutanixClustersListElement" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String (scalar)
        if (ec.Includes("clusterUuid",true))
        {
            if(this.ClusterUuid == null) {

                this.ClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.ClusterUuid != null && ec.Excludes("clusterUuid",true))
        {
            this.ClusterUuid = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> NutanixClusterConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: NutanixClusterConnectionStatus (type)
        if (ec.Includes("connectionStatus",false))
        {
            if(this.ConnectionStatus == null) {

                this.ConnectionStatus = new NutanixClusterConnectionStatus();
                this.ConnectionStatus.ApplyExploratoryFieldSpec(ec.NewChild("connectionStatus"));

            } else {

                this.ConnectionStatus.ApplyExploratoryFieldSpec(ec.NewChild("connectionStatus"));

            }
        }
        else if (this.ConnectionStatus != null && ec.Excludes("connectionStatus",false))
        {
            this.ConnectionStatus = null;
        }
        //      C# -> NutanixClustersListElement? NutanixClustersListElement
        // GraphQL -> nutanixClustersListElement: NutanixClustersListElement (type)
        if (ec.Includes("nutanixClustersListElement",false))
        {
            if(this.NutanixClustersListElement == null) {

                this.NutanixClustersListElement = new NutanixClustersListElement();
                this.NutanixClustersListElement.ApplyExploratoryFieldSpec(ec.NewChild("nutanixClustersListElement"));

            } else {

                this.NutanixClustersListElement.ApplyExploratoryFieldSpec(ec.NewChild("nutanixClustersListElement"));

            }
        }
        else if (this.NutanixClustersListElement != null && ec.Excludes("nutanixClustersListElement",false))
        {
            this.NutanixClustersListElement = null;
        }
    }


    #endregion

    } // class NutanixClustersListElementWithConnectionStatus
    
    #endregion

    public static class ListNutanixClustersListElementWithConnectionStatusExtensions
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
            this List<NutanixClustersListElementWithConnectionStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NutanixClustersListElementWithConnectionStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NutanixClustersListElementWithConnectionStatus> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NutanixClustersListElementWithConnectionStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NutanixClustersListElementWithConnectionStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types