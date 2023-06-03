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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> DateTime? AutoUpgradeDate
        // GraphQL -> autoUpgradeDate: DateTime (scalar)
        if (this.AutoUpgradeDate != null) {
            s += ind + "autoUpgradeDate\n" ;
        }
        //      C# -> DateTime? FinalAutoUpgradeDate
        // GraphQL -> finalAutoUpgradeDate: DateTime (scalar)
        if (this.FinalAutoUpgradeDate != null) {
            s += ind + "finalAutoUpgradeDate\n" ;
        }
        //      C# -> System.Boolean? IsAutoUpgradeEnabled
        // GraphQL -> isAutoUpgradeEnabled: Boolean! (scalar)
        if (this.IsAutoUpgradeEnabled != null) {
            s += ind + "isAutoUpgradeEnabled\n" ;
        }
        //      C# -> System.Boolean? IsUpgradeDateExtendable
        // GraphQL -> isUpgradeDateExtendable: Boolean! (scalar)
        if (this.IsUpgradeDateExtendable != null) {
            s += ind + "isUpgradeDateExtendable\n" ;
        }
        //      C# -> System.Int32? RemainingDays
        // GraphQL -> remainingDays: Int! (scalar)
        if (this.RemainingDays != null) {
            s += ind + "remainingDays\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> DateTime? AutoUpgradeDate
        // GraphQL -> autoUpgradeDate: DateTime (scalar)
        if (this.AutoUpgradeDate == null && Exploration.Includes(parent + ".autoUpgradeDate", true))
        {
            this.AutoUpgradeDate = new DateTime();
        }
        //      C# -> DateTime? FinalAutoUpgradeDate
        // GraphQL -> finalAutoUpgradeDate: DateTime (scalar)
        if (this.FinalAutoUpgradeDate == null && Exploration.Includes(parent + ".finalAutoUpgradeDate", true))
        {
            this.FinalAutoUpgradeDate = new DateTime();
        }
        //      C# -> System.Boolean? IsAutoUpgradeEnabled
        // GraphQL -> isAutoUpgradeEnabled: Boolean! (scalar)
        if (this.IsAutoUpgradeEnabled == null && Exploration.Includes(parent + ".isAutoUpgradeEnabled", true))
        {
            this.IsAutoUpgradeEnabled = true;
        }
        //      C# -> System.Boolean? IsUpgradeDateExtendable
        // GraphQL -> isUpgradeDateExtendable: Boolean! (scalar)
        if (this.IsUpgradeDateExtendable == null && Exploration.Includes(parent + ".isUpgradeDateExtendable", true))
        {
            this.IsUpgradeDateExtendable = true;
        }
        //      C# -> System.Int32? RemainingDays
        // GraphQL -> remainingDays: Int! (scalar)
        if (this.RemainingDays == null && Exploration.Includes(parent + ".remainingDays", true))
        {
            this.RemainingDays = new System.Int32();
        }
    }


    #endregion

    } // class RscAutoUpgradeInfo
    
    #endregion

    public static class ListRscAutoUpgradeInfoExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<RscAutoUpgradeInfo> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RscAutoUpgradeInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RscAutoUpgradeInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types