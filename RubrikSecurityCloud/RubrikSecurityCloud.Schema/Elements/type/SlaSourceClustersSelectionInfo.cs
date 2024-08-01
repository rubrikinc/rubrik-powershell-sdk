// SlaSourceClustersSelectionInfo.cs
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
    #region SlaSourceClustersSelectionInfo
    public class SlaSourceClustersSelectionInfo: BaseType
    {
        #region members

        //      C# -> List<SlaSourceClustersDisableReason>? DisableReasons
        // GraphQL -> disableReasons: [SlaSourceClustersDisableReason!]! (enum)
        [JsonProperty("disableReasons")]
        public List<SlaSourceClustersDisableReason>? DisableReasons { get; set; }

        //      C# -> SlaDataLocationCluster? Cluster
        // GraphQL -> cluster: SlaDataLocationCluster! (type)
        [JsonProperty("cluster")]
        public SlaDataLocationCluster? Cluster { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SlaSourceClustersSelectionInfo";
    }

    public SlaSourceClustersSelectionInfo Set(
        List<SlaSourceClustersDisableReason>? DisableReasons = null,
        SlaDataLocationCluster? Cluster = null
    ) 
    {
        if ( DisableReasons != null ) {
            this.DisableReasons = DisableReasons;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
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
        //      C# -> List<SlaSourceClustersDisableReason>? DisableReasons
        // GraphQL -> disableReasons: [SlaSourceClustersDisableReason!]! (enum)
        if (this.DisableReasons != null) {
            if (conf.Flat) {
                s += conf.Prefix + "disableReasons\n" ;
            } else {
                s += ind + "disableReasons\n" ;
            }
        }
        //      C# -> SlaDataLocationCluster? Cluster
        // GraphQL -> cluster: SlaDataLocationCluster! (type)
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<SlaSourceClustersDisableReason>? DisableReasons
        // GraphQL -> disableReasons: [SlaSourceClustersDisableReason!]! (enum)
        if (ec.Includes("disableReasons",true))
        {
            if(this.DisableReasons == null) {

                this.DisableReasons = new List<SlaSourceClustersDisableReason>();

            } else {


            }
        }
        else if (this.DisableReasons != null && ec.Excludes("disableReasons",true))
        {
            this.DisableReasons = null;
        }
        //      C# -> SlaDataLocationCluster? Cluster
        // GraphQL -> cluster: SlaDataLocationCluster! (type)
        if (ec.Includes("cluster",false))
        {
            if(this.Cluster == null) {

                this.Cluster = new SlaDataLocationCluster();
                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            } else {

                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            }
        }
        else if (this.Cluster != null && ec.Excludes("cluster",false))
        {
            this.Cluster = null;
        }
    }


    #endregion

    } // class SlaSourceClustersSelectionInfo
    
    #endregion

    public static class ListSlaSourceClustersSelectionInfoExtensions
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
            this List<SlaSourceClustersSelectionInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SlaSourceClustersSelectionInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SlaSourceClustersSelectionInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SlaSourceClustersSelectionInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SlaSourceClustersSelectionInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types