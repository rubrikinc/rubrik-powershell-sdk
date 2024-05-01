// ArchivalLocationUpgradeInfo.cs
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
    #region ArchivalLocationUpgradeInfo
    public class ArchivalLocationUpgradeInfo: BaseType
    {
        #region members

        //      C# -> UpgradeStatus? UpgradeStatus
        // GraphQL -> upgradeStatus: UpgradeStatus! (enum)
        [JsonProperty("upgradeStatus")]
        public UpgradeStatus? UpgradeStatus { get; set; }

        //      C# -> ArchivalLocationUpgradeUnsupportedReason? UpgradeUnsupportedReason
        // GraphQL -> upgradeUnsupportedReason: ArchivalLocationUpgradeUnsupportedReason! (enum)
        [JsonProperty("upgradeUnsupportedReason")]
        public ArchivalLocationUpgradeUnsupportedReason? UpgradeUnsupportedReason { get; set; }

        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        [JsonProperty("locationId")]
        public System.String? LocationId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ArchivalLocationUpgradeInfo";
    }

    public ArchivalLocationUpgradeInfo Set(
        UpgradeStatus? UpgradeStatus = null,
        ArchivalLocationUpgradeUnsupportedReason? UpgradeUnsupportedReason = null,
        System.String? LocationId = null
    ) 
    {
        if ( UpgradeStatus != null ) {
            this.UpgradeStatus = UpgradeStatus;
        }
        if ( UpgradeUnsupportedReason != null ) {
            this.UpgradeUnsupportedReason = UpgradeUnsupportedReason;
        }
        if ( LocationId != null ) {
            this.LocationId = LocationId;
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
        //      C# -> UpgradeStatus? UpgradeStatus
        // GraphQL -> upgradeStatus: UpgradeStatus! (enum)
        if (this.UpgradeStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "upgradeStatus\n" ;
            } else {
                s += ind + "upgradeStatus\n" ;
            }
        }
        //      C# -> ArchivalLocationUpgradeUnsupportedReason? UpgradeUnsupportedReason
        // GraphQL -> upgradeUnsupportedReason: ArchivalLocationUpgradeUnsupportedReason! (enum)
        if (this.UpgradeUnsupportedReason != null) {
            if (conf.Flat) {
                s += conf.Prefix + "upgradeUnsupportedReason\n" ;
            } else {
                s += ind + "upgradeUnsupportedReason\n" ;
            }
        }
        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        if (this.LocationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "locationId\n" ;
            } else {
                s += ind + "locationId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> UpgradeStatus? UpgradeStatus
        // GraphQL -> upgradeStatus: UpgradeStatus! (enum)
        if (ec.Includes("upgradeStatus",true))
        {
            if(this.UpgradeStatus == null) {

                this.UpgradeStatus = new UpgradeStatus();

            } else {


            }
        }
        else if (this.UpgradeStatus != null && ec.Excludes("upgradeStatus",true))
        {
            this.UpgradeStatus = null;
        }
        //      C# -> ArchivalLocationUpgradeUnsupportedReason? UpgradeUnsupportedReason
        // GraphQL -> upgradeUnsupportedReason: ArchivalLocationUpgradeUnsupportedReason! (enum)
        if (ec.Includes("upgradeUnsupportedReason",true))
        {
            if(this.UpgradeUnsupportedReason == null) {

                this.UpgradeUnsupportedReason = new ArchivalLocationUpgradeUnsupportedReason();

            } else {


            }
        }
        else if (this.UpgradeUnsupportedReason != null && ec.Excludes("upgradeUnsupportedReason",true))
        {
            this.UpgradeUnsupportedReason = null;
        }
        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        if (ec.Includes("locationId",true))
        {
            if(this.LocationId == null) {

                this.LocationId = "FETCH";

            } else {


            }
        }
        else if (this.LocationId != null && ec.Excludes("locationId",true))
        {
            this.LocationId = null;
        }
    }


    #endregion

    } // class ArchivalLocationUpgradeInfo
    
    #endregion

    public static class ListArchivalLocationUpgradeInfoExtensions
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
            this List<ArchivalLocationUpgradeInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ArchivalLocationUpgradeInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ArchivalLocationUpgradeInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ArchivalLocationUpgradeInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ArchivalLocationUpgradeInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types