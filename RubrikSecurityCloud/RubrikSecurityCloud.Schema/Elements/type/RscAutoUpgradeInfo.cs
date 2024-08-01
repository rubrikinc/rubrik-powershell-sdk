// RscAutoUpgradeInfo.cs
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
    #region RscAutoUpgradeInfo
    public class RscAutoUpgradeInfo: BaseType
    {
        #region members

        //      C# -> DateTime? AutoUpgradeDate
        // GraphQL -> autoUpgradeDate: DateTime (scalar)
        [JsonProperty("autoUpgradeDate")]
        public DateTime? AutoUpgradeDate { get; set; }

        //      C# -> DateTime? FinalAutoUpgradeDate
        // GraphQL -> finalAutoUpgradeDate: DateTime (scalar)
        [JsonProperty("finalAutoUpgradeDate")]
        public DateTime? FinalAutoUpgradeDate { get; set; }

        //      C# -> System.Boolean? IsAutoUpgradeEnabled
        // GraphQL -> isAutoUpgradeEnabled: Boolean! (scalar)
        [JsonProperty("isAutoUpgradeEnabled")]
        public System.Boolean? IsAutoUpgradeEnabled { get; set; }

        //      C# -> System.Boolean? IsUpgradeDateExtendable
        // GraphQL -> isUpgradeDateExtendable: Boolean! (scalar)
        [JsonProperty("isUpgradeDateExtendable")]
        public System.Boolean? IsUpgradeDateExtendable { get; set; }

        //      C# -> System.Int32? RemainingDays
        // GraphQL -> remainingDays: Int! (scalar)
        [JsonProperty("remainingDays")]
        public System.Int32? RemainingDays { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RscAutoUpgradeInfo";
    }

    public RscAutoUpgradeInfo Set(
        DateTime? AutoUpgradeDate = null,
        DateTime? FinalAutoUpgradeDate = null,
        System.Boolean? IsAutoUpgradeEnabled = null,
        System.Boolean? IsUpgradeDateExtendable = null,
        System.Int32? RemainingDays = null
    ) 
    {
        if ( AutoUpgradeDate != null ) {
            this.AutoUpgradeDate = AutoUpgradeDate;
        }
        if ( FinalAutoUpgradeDate != null ) {
            this.FinalAutoUpgradeDate = FinalAutoUpgradeDate;
        }
        if ( IsAutoUpgradeEnabled != null ) {
            this.IsAutoUpgradeEnabled = IsAutoUpgradeEnabled;
        }
        if ( IsUpgradeDateExtendable != null ) {
            this.IsUpgradeDateExtendable = IsUpgradeDateExtendable;
        }
        if ( RemainingDays != null ) {
            this.RemainingDays = RemainingDays;
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
        //      C# -> DateTime? FinalAutoUpgradeDate
        // GraphQL -> finalAutoUpgradeDate: DateTime (scalar)
        if (this.FinalAutoUpgradeDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "finalAutoUpgradeDate\n" ;
            } else {
                s += ind + "finalAutoUpgradeDate\n" ;
            }
        }
        //      C# -> System.Boolean? IsAutoUpgradeEnabled
        // GraphQL -> isAutoUpgradeEnabled: Boolean! (scalar)
        if (this.IsAutoUpgradeEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isAutoUpgradeEnabled\n" ;
            } else {
                s += ind + "isAutoUpgradeEnabled\n" ;
            }
        }
        //      C# -> System.Boolean? IsUpgradeDateExtendable
        // GraphQL -> isUpgradeDateExtendable: Boolean! (scalar)
        if (this.IsUpgradeDateExtendable != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isUpgradeDateExtendable\n" ;
            } else {
                s += ind + "isUpgradeDateExtendable\n" ;
            }
        }
        //      C# -> System.Int32? RemainingDays
        // GraphQL -> remainingDays: Int! (scalar)
        if (this.RemainingDays != null) {
            if (conf.Flat) {
                s += conf.Prefix + "remainingDays\n" ;
            } else {
                s += ind + "remainingDays\n" ;
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
        //      C# -> DateTime? FinalAutoUpgradeDate
        // GraphQL -> finalAutoUpgradeDate: DateTime (scalar)
        if (ec.Includes("finalAutoUpgradeDate",true))
        {
            if(this.FinalAutoUpgradeDate == null) {

                this.FinalAutoUpgradeDate = new DateTime();

            } else {


            }
        }
        else if (this.FinalAutoUpgradeDate != null && ec.Excludes("finalAutoUpgradeDate",true))
        {
            this.FinalAutoUpgradeDate = null;
        }
        //      C# -> System.Boolean? IsAutoUpgradeEnabled
        // GraphQL -> isAutoUpgradeEnabled: Boolean! (scalar)
        if (ec.Includes("isAutoUpgradeEnabled",true))
        {
            if(this.IsAutoUpgradeEnabled == null) {

                this.IsAutoUpgradeEnabled = true;

            } else {


            }
        }
        else if (this.IsAutoUpgradeEnabled != null && ec.Excludes("isAutoUpgradeEnabled",true))
        {
            this.IsAutoUpgradeEnabled = null;
        }
        //      C# -> System.Boolean? IsUpgradeDateExtendable
        // GraphQL -> isUpgradeDateExtendable: Boolean! (scalar)
        if (ec.Includes("isUpgradeDateExtendable",true))
        {
            if(this.IsUpgradeDateExtendable == null) {

                this.IsUpgradeDateExtendable = true;

            } else {


            }
        }
        else if (this.IsUpgradeDateExtendable != null && ec.Excludes("isUpgradeDateExtendable",true))
        {
            this.IsUpgradeDateExtendable = null;
        }
        //      C# -> System.Int32? RemainingDays
        // GraphQL -> remainingDays: Int! (scalar)
        if (ec.Includes("remainingDays",true))
        {
            if(this.RemainingDays == null) {

                this.RemainingDays = Int32.MinValue;

            } else {


            }
        }
        else if (this.RemainingDays != null && ec.Excludes("remainingDays",true))
        {
            this.RemainingDays = null;
        }
    }


    #endregion

    } // class RscAutoUpgradeInfo
    
    #endregion

    public static class ListRscAutoUpgradeInfoExtensions
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
            this List<RscAutoUpgradeInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RscAutoUpgradeInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RscAutoUpgradeInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RscAutoUpgradeInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RscAutoUpgradeInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types