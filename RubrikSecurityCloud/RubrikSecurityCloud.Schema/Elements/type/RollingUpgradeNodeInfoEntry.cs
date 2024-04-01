// RollingUpgradeNodeInfoEntry.cs
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
    #region RollingUpgradeNodeInfoEntry
    public class RollingUpgradeNodeInfoEntry: BaseType
    {
        #region members

        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String! (scalar)
        [JsonProperty("nodeName")]
        public System.String? NodeName { get; set; }

        //      C# -> RollingUpgradeNodeInfo? RuNodeInfo
        // GraphQL -> ruNodeInfo: RollingUpgradeNodeInfo (type)
        [JsonProperty("ruNodeInfo")]
        public RollingUpgradeNodeInfo? RuNodeInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RollingUpgradeNodeInfoEntry";
    }

    public RollingUpgradeNodeInfoEntry Set(
        System.String? NodeName = null,
        RollingUpgradeNodeInfo? RuNodeInfo = null
    ) 
    {
        if ( NodeName != null ) {
            this.NodeName = NodeName;
        }
        if ( RuNodeInfo != null ) {
            this.RuNodeInfo = RuNodeInfo;
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
        //      C# -> System.String? NodeName
        // GraphQL -> nodeName: String! (scalar)
        if (this.NodeName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nodeName\n" ;
            } else {
                s += ind + "nodeName\n" ;
            }
        }
        //      C# -> RollingUpgradeNodeInfo? RuNodeInfo
        // GraphQL -> ruNodeInfo: RollingUpgradeNodeInfo (type)
        if (this.RuNodeInfo != null) {
            var fspec = this.RuNodeInfo.AsFieldSpec(conf.Child("ruNodeInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "ruNodeInfo {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
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
        //      C# -> RollingUpgradeNodeInfo? RuNodeInfo
        // GraphQL -> ruNodeInfo: RollingUpgradeNodeInfo (type)
        if (ec.Includes("ruNodeInfo",false))
        {
            if(this.RuNodeInfo == null) {

                this.RuNodeInfo = new RollingUpgradeNodeInfo();
                this.RuNodeInfo.ApplyExploratoryFieldSpec(ec.NewChild("ruNodeInfo"));

            } else {

                this.RuNodeInfo.ApplyExploratoryFieldSpec(ec.NewChild("ruNodeInfo"));

            }
        }
        else if (this.RuNodeInfo != null && ec.Excludes("ruNodeInfo",false))
        {
            this.RuNodeInfo = null;
        }
    }


    #endregion

    } // class RollingUpgradeNodeInfoEntry
    
    #endregion

    public static class ListRollingUpgradeNodeInfoEntryExtensions
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
            this List<RollingUpgradeNodeInfoEntry> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RollingUpgradeNodeInfoEntry> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RollingUpgradeNodeInfoEntry> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RollingUpgradeNodeInfoEntry());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RollingUpgradeNodeInfoEntry> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types