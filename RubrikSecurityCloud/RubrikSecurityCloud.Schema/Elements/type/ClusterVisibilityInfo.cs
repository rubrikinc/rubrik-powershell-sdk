// ClusterVisibilityInfo.cs
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
    #region ClusterVisibilityInfo
    public class ClusterVisibilityInfo: BaseType
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> ClusterVisibilityConfig? ClusterVisibilityConfig
        // GraphQL -> clusterVisibilityConfig: ClusterVisibilityConfig (type)
        [JsonProperty("clusterVisibilityConfig")]
        public ClusterVisibilityConfig? ClusterVisibilityConfig { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClusterVisibilityInfo";
    }

    public ClusterVisibilityInfo Set(
        System.String? Name = null,
        ClusterVisibilityConfig? ClusterVisibilityConfig = null
    ) 
    {
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( ClusterVisibilityConfig != null ) {
            this.ClusterVisibilityConfig = ClusterVisibilityConfig;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> ClusterVisibilityConfig? ClusterVisibilityConfig
        // GraphQL -> clusterVisibilityConfig: ClusterVisibilityConfig (type)
        if (this.ClusterVisibilityConfig != null) {
            var fspec = this.ClusterVisibilityConfig.AsFieldSpec(conf.Child("clusterVisibilityConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "clusterVisibilityConfig" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
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
        //      C# -> ClusterVisibilityConfig? ClusterVisibilityConfig
        // GraphQL -> clusterVisibilityConfig: ClusterVisibilityConfig (type)
        if (ec.Includes("clusterVisibilityConfig",false))
        {
            if(this.ClusterVisibilityConfig == null) {

                this.ClusterVisibilityConfig = new ClusterVisibilityConfig();
                this.ClusterVisibilityConfig.ApplyExploratoryFieldSpec(ec.NewChild("clusterVisibilityConfig"));

            } else {

                this.ClusterVisibilityConfig.ApplyExploratoryFieldSpec(ec.NewChild("clusterVisibilityConfig"));

            }
        }
        else if (this.ClusterVisibilityConfig != null && ec.Excludes("clusterVisibilityConfig",false))
        {
            this.ClusterVisibilityConfig = null;
        }
    }


    #endregion

    } // class ClusterVisibilityInfo
    
    #endregion

    public static class ListClusterVisibilityInfoExtensions
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
            this List<ClusterVisibilityInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ClusterVisibilityInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClusterVisibilityInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterVisibilityInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterVisibilityInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types