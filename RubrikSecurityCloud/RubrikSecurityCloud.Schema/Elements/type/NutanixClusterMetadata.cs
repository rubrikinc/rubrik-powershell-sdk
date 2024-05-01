// NutanixClusterMetadata.cs
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
    #region NutanixClusterMetadata
    public class NutanixClusterMetadata: BaseType
    {
        #region members

        //      C# -> NutanixSnapshotConsistencyMandate? SnapshotConsistencyMandate
        // GraphQL -> snapshotConsistencyMandate: NutanixSnapshotConsistencyMandate! (enum)
        [JsonProperty("snapshotConsistencyMandate")]
        public NutanixSnapshotConsistencyMandate? SnapshotConsistencyMandate { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NutanixClusterMetadata";
    }

    public NutanixClusterMetadata Set(
        NutanixSnapshotConsistencyMandate? SnapshotConsistencyMandate = null
    ) 
    {
        if ( SnapshotConsistencyMandate != null ) {
            this.SnapshotConsistencyMandate = SnapshotConsistencyMandate;
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
        //      C# -> NutanixSnapshotConsistencyMandate? SnapshotConsistencyMandate
        // GraphQL -> snapshotConsistencyMandate: NutanixSnapshotConsistencyMandate! (enum)
        if (this.SnapshotConsistencyMandate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotConsistencyMandate\n" ;
            } else {
                s += ind + "snapshotConsistencyMandate\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> NutanixSnapshotConsistencyMandate? SnapshotConsistencyMandate
        // GraphQL -> snapshotConsistencyMandate: NutanixSnapshotConsistencyMandate! (enum)
        if (ec.Includes("snapshotConsistencyMandate",true))
        {
            if(this.SnapshotConsistencyMandate == null) {

                this.SnapshotConsistencyMandate = new NutanixSnapshotConsistencyMandate();

            } else {


            }
        }
        else if (this.SnapshotConsistencyMandate != null && ec.Excludes("snapshotConsistencyMandate",true))
        {
            this.SnapshotConsistencyMandate = null;
        }
    }


    #endregion

    } // class NutanixClusterMetadata
    
    #endregion

    public static class ListNutanixClusterMetadataExtensions
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
            this List<NutanixClusterMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NutanixClusterMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NutanixClusterMetadata> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NutanixClusterMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NutanixClusterMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types