// ThreatHuntSnapshotInfo.cs
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
    #region ThreatHuntSnapshotInfo
    public class ThreatHuntSnapshotInfo: BaseType
    {
        #region members

        //      C# -> System.String? HuntId
        // GraphQL -> huntId: String! (scalar)
        [JsonProperty("huntId")]
        public System.String? HuntId { get; set; }

        //      C# -> System.String? HuntName
        // GraphQL -> huntName: String! (scalar)
        [JsonProperty("huntName")]
        public System.String? HuntName { get; set; }

        //      C# -> System.Int64? NumMatches
        // GraphQL -> numMatches: Long! (scalar)
        [JsonProperty("numMatches")]
        public System.Int64? NumMatches { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ThreatHuntSnapshotInfo";
    }

    public ThreatHuntSnapshotInfo Set(
        System.String? HuntId = null,
        System.String? HuntName = null,
        System.Int64? NumMatches = null
    ) 
    {
        if ( HuntId != null ) {
            this.HuntId = HuntId;
        }
        if ( HuntName != null ) {
            this.HuntName = HuntName;
        }
        if ( NumMatches != null ) {
            this.NumMatches = NumMatches;
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
        //      C# -> System.String? HuntId
        // GraphQL -> huntId: String! (scalar)
        if (this.HuntId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "huntId\n" ;
            } else {
                s += ind + "huntId\n" ;
            }
        }
        //      C# -> System.String? HuntName
        // GraphQL -> huntName: String! (scalar)
        if (this.HuntName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "huntName\n" ;
            } else {
                s += ind + "huntName\n" ;
            }
        }
        //      C# -> System.Int64? NumMatches
        // GraphQL -> numMatches: Long! (scalar)
        if (this.NumMatches != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numMatches\n" ;
            } else {
                s += ind + "numMatches\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? HuntId
        // GraphQL -> huntId: String! (scalar)
        if (ec.Includes("huntId",true))
        {
            if(this.HuntId == null) {

                this.HuntId = "FETCH";

            } else {


            }
        }
        else if (this.HuntId != null && ec.Excludes("huntId",true))
        {
            this.HuntId = null;
        }
        //      C# -> System.String? HuntName
        // GraphQL -> huntName: String! (scalar)
        if (ec.Includes("huntName",true))
        {
            if(this.HuntName == null) {

                this.HuntName = "FETCH";

            } else {


            }
        }
        else if (this.HuntName != null && ec.Excludes("huntName",true))
        {
            this.HuntName = null;
        }
        //      C# -> System.Int64? NumMatches
        // GraphQL -> numMatches: Long! (scalar)
        if (ec.Includes("numMatches",true))
        {
            if(this.NumMatches == null) {

                this.NumMatches = new System.Int64();

            } else {


            }
        }
        else if (this.NumMatches != null && ec.Excludes("numMatches",true))
        {
            this.NumMatches = null;
        }
    }


    #endregion

    } // class ThreatHuntSnapshotInfo
    
    #endregion

    public static class ListThreatHuntSnapshotInfoExtensions
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
            this List<ThreatHuntSnapshotInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ThreatHuntSnapshotInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ThreatHuntSnapshotInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ThreatHuntSnapshotInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ThreatHuntSnapshotInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types