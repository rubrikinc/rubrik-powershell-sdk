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
            this List<SnapshotDelta> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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