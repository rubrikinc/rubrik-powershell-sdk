// MissedSnapshot.cs
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
    #region MissedSnapshot
    public class MissedSnapshot: BaseType
    {
        #region members

        //      C# -> List<System.String>? ArchivalLocationType
        // GraphQL -> archivalLocationType: [String!]! (scalar)
        [JsonProperty("archivalLocationType")]
        public List<System.String>? ArchivalLocationType { get; set; }

        //      C# -> DateTime? MissedSnapshotTime
        // GraphQL -> missedSnapshotTime: DateTime (scalar)
        [JsonProperty("missedSnapshotTime")]
        public DateTime? MissedSnapshotTime { get; set; }

        //      C# -> List<MissedSnapshotTimeUnitConfig>? MissedSnapshotTimeUnits
        // GraphQL -> missedSnapshotTimeUnits: [MissedSnapshotTimeUnitConfig!]! (type)
        [JsonProperty("missedSnapshotTimeUnits")]
        public List<MissedSnapshotTimeUnitConfig>? MissedSnapshotTimeUnits { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MissedSnapshot";
    }

    public MissedSnapshot Set(
        List<System.String>? ArchivalLocationType = null,
        DateTime? MissedSnapshotTime = null,
        List<MissedSnapshotTimeUnitConfig>? MissedSnapshotTimeUnits = null
    ) 
    {
        if ( ArchivalLocationType != null ) {
            this.ArchivalLocationType = ArchivalLocationType;
        }
        if ( MissedSnapshotTime != null ) {
            this.MissedSnapshotTime = MissedSnapshotTime;
        }
        if ( MissedSnapshotTimeUnits != null ) {
            this.MissedSnapshotTimeUnits = MissedSnapshotTimeUnits;
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
        //      C# -> List<System.String>? ArchivalLocationType
        // GraphQL -> archivalLocationType: [String!]! (scalar)
        if (this.ArchivalLocationType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "archivalLocationType\n" ;
            } else {
                s += ind + "archivalLocationType\n" ;
            }
        }
        //      C# -> DateTime? MissedSnapshotTime
        // GraphQL -> missedSnapshotTime: DateTime (scalar)
        if (this.MissedSnapshotTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "missedSnapshotTime\n" ;
            } else {
                s += ind + "missedSnapshotTime\n" ;
            }
        }
        //      C# -> List<MissedSnapshotTimeUnitConfig>? MissedSnapshotTimeUnits
        // GraphQL -> missedSnapshotTimeUnits: [MissedSnapshotTimeUnitConfig!]! (type)
        if (this.MissedSnapshotTimeUnits != null) {
            var fspec = this.MissedSnapshotTimeUnits.AsFieldSpec(conf.Child("missedSnapshotTimeUnits"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "missedSnapshotTimeUnits {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? ArchivalLocationType
        // GraphQL -> archivalLocationType: [String!]! (scalar)
        if (ec.Includes("archivalLocationType",true))
        {
            if(this.ArchivalLocationType == null) {

                this.ArchivalLocationType = new List<System.String>();

            } else {


            }
        }
        else if (this.ArchivalLocationType != null && ec.Excludes("archivalLocationType",true))
        {
            this.ArchivalLocationType = null;
        }
        //      C# -> DateTime? MissedSnapshotTime
        // GraphQL -> missedSnapshotTime: DateTime (scalar)
        if (ec.Includes("missedSnapshotTime",true))
        {
            if(this.MissedSnapshotTime == null) {

                this.MissedSnapshotTime = new DateTime();

            } else {


            }
        }
        else if (this.MissedSnapshotTime != null && ec.Excludes("missedSnapshotTime",true))
        {
            this.MissedSnapshotTime = null;
        }
        //      C# -> List<MissedSnapshotTimeUnitConfig>? MissedSnapshotTimeUnits
        // GraphQL -> missedSnapshotTimeUnits: [MissedSnapshotTimeUnitConfig!]! (type)
        if (ec.Includes("missedSnapshotTimeUnits",false))
        {
            if(this.MissedSnapshotTimeUnits == null) {

                this.MissedSnapshotTimeUnits = new List<MissedSnapshotTimeUnitConfig>();
                this.MissedSnapshotTimeUnits.ApplyExploratoryFieldSpec(ec.NewChild("missedSnapshotTimeUnits"));

            } else {

                this.MissedSnapshotTimeUnits.ApplyExploratoryFieldSpec(ec.NewChild("missedSnapshotTimeUnits"));

            }
        }
        else if (this.MissedSnapshotTimeUnits != null && ec.Excludes("missedSnapshotTimeUnits",false))
        {
            this.MissedSnapshotTimeUnits = null;
        }
    }


    #endregion

    } // class MissedSnapshot
    
    #endregion

    public static class ListMissedSnapshotExtensions
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
            this List<MissedSnapshot> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MissedSnapshot> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MissedSnapshot());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MissedSnapshot> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types