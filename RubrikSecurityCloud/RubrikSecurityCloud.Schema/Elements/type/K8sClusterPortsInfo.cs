// K8sClusterPortsInfo.cs
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
    #region K8sClusterPortsInfo
    public class K8sClusterPortsInfo: BaseType
    {
        #region members

        //      C# -> KuprClusterPortsType? PortRangeType
        // GraphQL -> portRangeType: KuprClusterPortsType! (enum)
        [JsonProperty("portRangeType")]
        public KuprClusterPortsType? PortRangeType { get; set; }

        //      C# -> System.String? KuprClusterUuid
        // GraphQL -> kuprClusterUuid: UUID! (scalar)
        [JsonProperty("kuprClusterUuid")]
        public System.String? KuprClusterUuid { get; set; }

        //      C# -> System.Int32? MaxPort
        // GraphQL -> maxPort: Int! (scalar)
        [JsonProperty("maxPort")]
        public System.Int32? MaxPort { get; set; }

        //      C# -> System.Int32? MinPort
        // GraphQL -> minPort: Int! (scalar)
        [JsonProperty("minPort")]
        public System.Int32? MinPort { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "K8sClusterPortsInfo";
    }

    public K8sClusterPortsInfo Set(
        KuprClusterPortsType? PortRangeType = null,
        System.String? KuprClusterUuid = null,
        System.Int32? MaxPort = null,
        System.Int32? MinPort = null
    ) 
    {
        if ( PortRangeType != null ) {
            this.PortRangeType = PortRangeType;
        }
        if ( KuprClusterUuid != null ) {
            this.KuprClusterUuid = KuprClusterUuid;
        }
        if ( MaxPort != null ) {
            this.MaxPort = MaxPort;
        }
        if ( MinPort != null ) {
            this.MinPort = MinPort;
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
        //      C# -> KuprClusterPortsType? PortRangeType
        // GraphQL -> portRangeType: KuprClusterPortsType! (enum)
        if (this.PortRangeType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "portRangeType\n" ;
            } else {
                s += ind + "portRangeType\n" ;
            }
        }
        //      C# -> System.String? KuprClusterUuid
        // GraphQL -> kuprClusterUuid: UUID! (scalar)
        if (this.KuprClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "kuprClusterUuid\n" ;
            } else {
                s += ind + "kuprClusterUuid\n" ;
            }
        }
        //      C# -> System.Int32? MaxPort
        // GraphQL -> maxPort: Int! (scalar)
        if (this.MaxPort != null) {
            if (conf.Flat) {
                s += conf.Prefix + "maxPort\n" ;
            } else {
                s += ind + "maxPort\n" ;
            }
        }
        //      C# -> System.Int32? MinPort
        // GraphQL -> minPort: Int! (scalar)
        if (this.MinPort != null) {
            if (conf.Flat) {
                s += conf.Prefix + "minPort\n" ;
            } else {
                s += ind + "minPort\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> KuprClusterPortsType? PortRangeType
        // GraphQL -> portRangeType: KuprClusterPortsType! (enum)
        if (ec.Includes("portRangeType",true))
        {
            if(this.PortRangeType == null) {

                this.PortRangeType = new KuprClusterPortsType();

            } else {


            }
        }
        else if (this.PortRangeType != null && ec.Excludes("portRangeType",true))
        {
            this.PortRangeType = null;
        }
        //      C# -> System.String? KuprClusterUuid
        // GraphQL -> kuprClusterUuid: UUID! (scalar)
        if (ec.Includes("kuprClusterUuid",true))
        {
            if(this.KuprClusterUuid == null) {

                this.KuprClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.KuprClusterUuid != null && ec.Excludes("kuprClusterUuid",true))
        {
            this.KuprClusterUuid = null;
        }
        //      C# -> System.Int32? MaxPort
        // GraphQL -> maxPort: Int! (scalar)
        if (ec.Includes("maxPort",true))
        {
            if(this.MaxPort == null) {

                this.MaxPort = Int32.MinValue;

            } else {


            }
        }
        else if (this.MaxPort != null && ec.Excludes("maxPort",true))
        {
            this.MaxPort = null;
        }
        //      C# -> System.Int32? MinPort
        // GraphQL -> minPort: Int! (scalar)
        if (ec.Includes("minPort",true))
        {
            if(this.MinPort == null) {

                this.MinPort = Int32.MinValue;

            } else {


            }
        }
        else if (this.MinPort != null && ec.Excludes("minPort",true))
        {
            this.MinPort = null;
        }
    }


    #endregion

    } // class K8sClusterPortsInfo
    
    #endregion

    public static class ListK8sClusterPortsInfoExtensions
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
            this List<K8sClusterPortsInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<K8sClusterPortsInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<K8sClusterPortsInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new K8sClusterPortsInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<K8sClusterPortsInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types