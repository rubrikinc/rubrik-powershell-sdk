// K8sRbsInfo.cs
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
    #region K8sRbsInfo
    public class K8sRbsInfo: BaseType
    {
        #region members

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
        return "K8sRbsInfo";
    }

    public K8sRbsInfo Set(
        System.String? KuprClusterUuid = null,
        System.Int32? MaxPort = null,
        System.Int32? MinPort = null
    ) 
    {
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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
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

    } // class K8sRbsInfo
    
    #endregion

    public static class ListK8sRbsInfoExtensions
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
            this List<K8sRbsInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<K8sRbsInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<K8sRbsInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new K8sRbsInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<K8sRbsInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types