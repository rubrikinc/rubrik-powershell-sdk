// ExtendRscAutoUpgradeDateReply.cs
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
    #region ExtendRscAutoUpgradeDateReply
    public class ExtendRscAutoUpgradeDateReply: BaseType
    {
        #region members

        //      C# -> DateTime? AutoUpgradeDate
        // GraphQL -> autoUpgradeDate: DateTime (scalar)
        [JsonProperty("autoUpgradeDate")]
        public DateTime? AutoUpgradeDate { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ExtendRscAutoUpgradeDateReply";
    }

    public ExtendRscAutoUpgradeDateReply Set(
        DateTime? AutoUpgradeDate = null
    ) 
    {
        if ( AutoUpgradeDate != null ) {
            this.AutoUpgradeDate = AutoUpgradeDate;
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
        //      C# -> DateTime? AutoUpgradeDate
        // GraphQL -> autoUpgradeDate: DateTime (scalar)
        if (this.AutoUpgradeDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "autoUpgradeDate\n" ;
            } else {
                s += ind + "autoUpgradeDate\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DateTime? AutoUpgradeDate
        // GraphQL -> autoUpgradeDate: DateTime (scalar)
        if (ec.Includes("autoUpgradeDate",true))
        {
            if(this.AutoUpgradeDate == null) {

                this.AutoUpgradeDate = new DateTime();

            } else {


            }
        }
        else if (this.AutoUpgradeDate != null && ec.Excludes("autoUpgradeDate",true))
        {
            this.AutoUpgradeDate = null;
        }
    }


    #endregion

    } // class ExtendRscAutoUpgradeDateReply
    
    #endregion

    public static class ListExtendRscAutoUpgradeDateReplyExtensions
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
            this List<ExtendRscAutoUpgradeDateReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ExtendRscAutoUpgradeDateReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ExtendRscAutoUpgradeDateReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ExtendRscAutoUpgradeDateReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ExtendRscAutoUpgradeDateReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types