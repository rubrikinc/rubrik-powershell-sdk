// RollingUpgradeNodeInfo.cs
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
    #region RollingUpgradeNodeInfo
    public class RollingUpgradeNodeInfo: BaseType
    {
        #region members

        //      C# -> System.String? RuEndTs
        // GraphQL -> ruEndTs: String! (scalar)
        [JsonProperty("ruEndTs")]
        public System.String? RuEndTs { get; set; }

        //      C# -> System.String? RuStartTs
        // GraphQL -> ruStartTs: String! (scalar)
        [JsonProperty("ruStartTs")]
        public System.String? RuStartTs { get; set; }

        //      C# -> CurrentStateInfo? CurrentStateInfo
        // GraphQL -> currentStateInfo: CurrentStateInfo (type)
        [JsonProperty("currentStateInfo")]
        public CurrentStateInfo? CurrentStateInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RollingUpgradeNodeInfo";
    }

    public RollingUpgradeNodeInfo Set(
        System.String? RuEndTs = null,
        System.String? RuStartTs = null,
        CurrentStateInfo? CurrentStateInfo = null
    ) 
    {
        if ( RuEndTs != null ) {
            this.RuEndTs = RuEndTs;
        }
        if ( RuStartTs != null ) {
            this.RuStartTs = RuStartTs;
        }
        if ( CurrentStateInfo != null ) {
            this.CurrentStateInfo = CurrentStateInfo;
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
        //      C# -> System.String? RuEndTs
        // GraphQL -> ruEndTs: String! (scalar)
        if (this.RuEndTs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ruEndTs\n" ;
            } else {
                s += ind + "ruEndTs\n" ;
            }
        }
        //      C# -> System.String? RuStartTs
        // GraphQL -> ruStartTs: String! (scalar)
        if (this.RuStartTs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ruStartTs\n" ;
            } else {
                s += ind + "ruStartTs\n" ;
            }
        }
        //      C# -> CurrentStateInfo? CurrentStateInfo
        // GraphQL -> currentStateInfo: CurrentStateInfo (type)
        if (this.CurrentStateInfo != null) {
            var fspec = this.CurrentStateInfo.AsFieldSpec(conf.Child("currentStateInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "currentStateInfo {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? RuEndTs
        // GraphQL -> ruEndTs: String! (scalar)
        if (ec.Includes("ruEndTs",true))
        {
            if(this.RuEndTs == null) {

                this.RuEndTs = "FETCH";

            } else {


            }
        }
        else if (this.RuEndTs != null && ec.Excludes("ruEndTs",true))
        {
            this.RuEndTs = null;
        }
        //      C# -> System.String? RuStartTs
        // GraphQL -> ruStartTs: String! (scalar)
        if (ec.Includes("ruStartTs",true))
        {
            if(this.RuStartTs == null) {

                this.RuStartTs = "FETCH";

            } else {


            }
        }
        else if (this.RuStartTs != null && ec.Excludes("ruStartTs",true))
        {
            this.RuStartTs = null;
        }
        //      C# -> CurrentStateInfo? CurrentStateInfo
        // GraphQL -> currentStateInfo: CurrentStateInfo (type)
        if (ec.Includes("currentStateInfo",false))
        {
            if(this.CurrentStateInfo == null) {

                this.CurrentStateInfo = new CurrentStateInfo();
                this.CurrentStateInfo.ApplyExploratoryFieldSpec(ec.NewChild("currentStateInfo"));

            } else {

                this.CurrentStateInfo.ApplyExploratoryFieldSpec(ec.NewChild("currentStateInfo"));

            }
        }
        else if (this.CurrentStateInfo != null && ec.Excludes("currentStateInfo",false))
        {
            this.CurrentStateInfo = null;
        }
    }


    #endregion

    } // class RollingUpgradeNodeInfo
    
    #endregion

    public static class ListRollingUpgradeNodeInfoExtensions
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
            this List<RollingUpgradeNodeInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RollingUpgradeNodeInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RollingUpgradeNodeInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RollingUpgradeNodeInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RollingUpgradeNodeInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types