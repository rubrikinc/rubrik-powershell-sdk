// PausedClustersInfo.cs
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
    #region PausedClustersInfo
    public class PausedClustersInfo: BaseType
    {
        #region members

        //      C# -> System.Int32? PausedClustersCount
        // GraphQL -> pausedClustersCount: Int! (scalar)
        [JsonProperty("pausedClustersCount")]
        public System.Int32? PausedClustersCount { get; set; }

        //      C# -> List<Cluster>? PausedClusters
        // GraphQL -> pausedClusters: [Cluster!] (type)
        [JsonProperty("pausedClusters")]
        public List<Cluster>? PausedClusters { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PausedClustersInfo";
    }

    public PausedClustersInfo Set(
        System.Int32? PausedClustersCount = null,
        List<Cluster>? PausedClusters = null
    ) 
    {
        if ( PausedClustersCount != null ) {
            this.PausedClustersCount = PausedClustersCount;
        }
        if ( PausedClusters != null ) {
            this.PausedClusters = PausedClusters;
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
        //      C# -> System.Int32? PausedClustersCount
        // GraphQL -> pausedClustersCount: Int! (scalar)
        if (this.PausedClustersCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pausedClustersCount\n" ;
            } else {
                s += ind + "pausedClustersCount\n" ;
            }
        }
        //      C# -> List<Cluster>? PausedClusters
        // GraphQL -> pausedClusters: [Cluster!] (type)
        if (this.PausedClusters != null) {
            var fspec = this.PausedClusters.AsFieldSpec(conf.Child("pausedClusters"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "pausedClusters {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? PausedClustersCount
        // GraphQL -> pausedClustersCount: Int! (scalar)
        if (ec.Includes("pausedClustersCount",true))
        {
            if(this.PausedClustersCount == null) {

                this.PausedClustersCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.PausedClustersCount != null && ec.Excludes("pausedClustersCount",true))
        {
            this.PausedClustersCount = null;
        }
        //      C# -> List<Cluster>? PausedClusters
        // GraphQL -> pausedClusters: [Cluster!] (type)
        if (ec.Includes("pausedClusters",false))
        {
            if(this.PausedClusters == null) {

                this.PausedClusters = new List<Cluster>();
                this.PausedClusters.ApplyExploratoryFieldSpec(ec.NewChild("pausedClusters"));

            } else {

                this.PausedClusters.ApplyExploratoryFieldSpec(ec.NewChild("pausedClusters"));

            }
        }
        else if (this.PausedClusters != null && ec.Excludes("pausedClusters",false))
        {
            this.PausedClusters = null;
        }
    }


    #endregion

    } // class PausedClustersInfo
    
    #endregion

    public static class ListPausedClustersInfoExtensions
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
            this List<PausedClustersInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PausedClustersInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PausedClustersInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PausedClustersInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PausedClustersInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types