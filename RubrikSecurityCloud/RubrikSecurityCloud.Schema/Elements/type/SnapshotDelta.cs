// SnapshotDelta.cs
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
    #region SnapshotDelta
    public class SnapshotDelta: BaseType
    {
        #region members

        //      C# -> DeltaType? DeltaType
        // GraphQL -> deltaType: DeltaType! (enum)
        [JsonProperty("deltaType")]
        public DeltaType? DeltaType { get; set; }

        //      C# -> System.Int64? DeltaAmount
        // GraphQL -> deltaAmount: Long! (scalar)
        [JsonProperty("deltaAmount")]
        public System.Int64? DeltaAmount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SnapshotDelta";
    }

    public SnapshotDelta Set(
        DeltaType? DeltaType = null,
        System.Int64? DeltaAmount = null
    ) 
    {
        if ( DeltaType != null ) {
            this.DeltaType = DeltaType;
        }
        if ( DeltaAmount != null ) {
            this.DeltaAmount = DeltaAmount;
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
        //      C# -> DeltaType? DeltaType
        // GraphQL -> deltaType: DeltaType! (enum)
        if (this.DeltaType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "deltaType\n" ;
            } else {
                s += ind + "deltaType\n" ;
            }
        }
        //      C# -> System.Int64? DeltaAmount
        // GraphQL -> deltaAmount: Long! (scalar)
        if (this.DeltaAmount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "deltaAmount\n" ;
            } else {
                s += ind + "deltaAmount\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DeltaType? DeltaType
        // GraphQL -> deltaType: DeltaType! (enum)
        if (ec.Includes("deltaType",true))
        {
            if(this.DeltaType == null) {

                this.DeltaType = new DeltaType();

            } else {


            }
        }
        else if (this.DeltaType != null && ec.Excludes("deltaType",true))
        {
            this.DeltaType = null;
        }
        //      C# -> System.Int64? DeltaAmount
        // GraphQL -> deltaAmount: Long! (scalar)
        if (ec.Includes("deltaAmount",true))
        {
            if(this.DeltaAmount == null) {

                this.DeltaAmount = new System.Int64();

            } else {


            }
        }
        else if (this.DeltaAmount != null && ec.Excludes("deltaAmount",true))
        {
            this.DeltaAmount = null;
        }
    }


    #endregion

    } // class SnapshotDelta
    
    #endregion

    public static class ListSnapshotDeltaExtensions
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
            this List<SnapshotDelta> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SnapshotDelta> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SnapshotDelta> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SnapshotDelta());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SnapshotDelta> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types