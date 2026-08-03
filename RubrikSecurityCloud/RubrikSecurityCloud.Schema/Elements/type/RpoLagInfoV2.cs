// RpoLagInfoV2.cs
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
    #region RpoLagInfoV2
    public class RpoLagInfoV2: BaseType
    {
        #region members

        //      C# -> RpoLagLevel? LagLevel
        // GraphQL -> lagLevel: RpoLagLevel! (enum)
        [JsonProperty("lagLevel")]
        public RpoLagLevel? LagLevel { get; set; }

        //      C# -> System.Int64? ActualRpoInSecs
        // GraphQL -> actualRpoInSecs: Long! (scalar)
        [JsonProperty("actualRpoInSecs")]
        public System.Int64? ActualRpoInSecs { get; set; }

        //      C# -> System.Int64? ExpectedRpoInSecs
        // GraphQL -> expectedRpoInSecs: Long! (scalar)
        [JsonProperty("expectedRpoInSecs")]
        public System.Int64? ExpectedRpoInSecs { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RpoLagInfoV2";
    }

    public RpoLagInfoV2 Set(
        RpoLagLevel? LagLevel = null,
        System.Int64? ActualRpoInSecs = null,
        System.Int64? ExpectedRpoInSecs = null
    ) 
    {
        if ( LagLevel != null ) {
            this.LagLevel = LagLevel;
        }
        if ( ActualRpoInSecs != null ) {
            this.ActualRpoInSecs = ActualRpoInSecs;
        }
        if ( ExpectedRpoInSecs != null ) {
            this.ExpectedRpoInSecs = ExpectedRpoInSecs;
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
        //      C# -> RpoLagLevel? LagLevel
        // GraphQL -> lagLevel: RpoLagLevel! (enum)
        if (this.LagLevel != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lagLevel\n" ;
            } else {
                s += ind + "lagLevel\n" ;
            }
        }
        //      C# -> System.Int64? ActualRpoInSecs
        // GraphQL -> actualRpoInSecs: Long! (scalar)
        if (this.ActualRpoInSecs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "actualRpoInSecs\n" ;
            } else {
                s += ind + "actualRpoInSecs\n" ;
            }
        }
        //      C# -> System.Int64? ExpectedRpoInSecs
        // GraphQL -> expectedRpoInSecs: Long! (scalar)
        if (this.ExpectedRpoInSecs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "expectedRpoInSecs\n" ;
            } else {
                s += ind + "expectedRpoInSecs\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> RpoLagLevel? LagLevel
        // GraphQL -> lagLevel: RpoLagLevel! (enum)
        if (ec.Includes("lagLevel",true))
        {
            if(this.LagLevel == null) {

                this.LagLevel = new RpoLagLevel();

            } else {


            }
        }
        else if (this.LagLevel != null && ec.Excludes("lagLevel",true))
        {
            this.LagLevel = null;
        }
        //      C# -> System.Int64? ActualRpoInSecs
        // GraphQL -> actualRpoInSecs: Long! (scalar)
        if (ec.Includes("actualRpoInSecs",true))
        {
            if(this.ActualRpoInSecs == null) {

                this.ActualRpoInSecs = new System.Int64();

            } else {


            }
        }
        else if (this.ActualRpoInSecs != null && ec.Excludes("actualRpoInSecs",true))
        {
            this.ActualRpoInSecs = null;
        }
        //      C# -> System.Int64? ExpectedRpoInSecs
        // GraphQL -> expectedRpoInSecs: Long! (scalar)
        if (ec.Includes("expectedRpoInSecs",true))
        {
            if(this.ExpectedRpoInSecs == null) {

                this.ExpectedRpoInSecs = new System.Int64();

            } else {


            }
        }
        else if (this.ExpectedRpoInSecs != null && ec.Excludes("expectedRpoInSecs",true))
        {
            this.ExpectedRpoInSecs = null;
        }
    }


    #endregion

    } // class RpoLagInfoV2
    
    #endregion

    public static class ListRpoLagInfoV2Extensions
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
            this List<RpoLagInfoV2> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RpoLagInfoV2> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RpoLagInfoV2> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RpoLagInfoV2());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RpoLagInfoV2> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types