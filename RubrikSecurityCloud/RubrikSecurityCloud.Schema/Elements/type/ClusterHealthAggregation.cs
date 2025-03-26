// ClusterHealthAggregation.cs
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
    #region ClusterHealthAggregation
    public class ClusterHealthAggregation: BaseType
    {
        #region members

        //      C# -> System.Int64? Fatal
        // GraphQL -> fatal: Long! (scalar)
        [JsonProperty("fatal")]
        public System.Int64? Fatal { get; set; }

        //      C# -> System.Int64? Ok
        // GraphQL -> ok: Long! (scalar)
        [JsonProperty("ok")]
        public System.Int64? Ok { get; set; }

        //      C# -> System.Int64? Warning
        // GraphQL -> warning: Long! (scalar)
        [JsonProperty("warning")]
        public System.Int64? Warning { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClusterHealthAggregation";
    }

    public ClusterHealthAggregation Set(
        System.Int64? Fatal = null,
        System.Int64? Ok = null,
        System.Int64? Warning = null
    ) 
    {
        if ( Fatal != null ) {
            this.Fatal = Fatal;
        }
        if ( Ok != null ) {
            this.Ok = Ok;
        }
        if ( Warning != null ) {
            this.Warning = Warning;
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
        //      C# -> System.Int64? Fatal
        // GraphQL -> fatal: Long! (scalar)
        if (this.Fatal != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fatal\n" ;
            } else {
                s += ind + "fatal\n" ;
            }
        }
        //      C# -> System.Int64? Ok
        // GraphQL -> ok: Long! (scalar)
        if (this.Ok != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ok\n" ;
            } else {
                s += ind + "ok\n" ;
            }
        }
        //      C# -> System.Int64? Warning
        // GraphQL -> warning: Long! (scalar)
        if (this.Warning != null) {
            if (conf.Flat) {
                s += conf.Prefix + "warning\n" ;
            } else {
                s += ind + "warning\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int64? Fatal
        // GraphQL -> fatal: Long! (scalar)
        if (ec.Includes("fatal",true))
        {
            if(this.Fatal == null) {

                this.Fatal = new System.Int64();

            } else {


            }
        }
        else if (this.Fatal != null && ec.Excludes("fatal",true))
        {
            this.Fatal = null;
        }
        //      C# -> System.Int64? Ok
        // GraphQL -> ok: Long! (scalar)
        if (ec.Includes("ok",true))
        {
            if(this.Ok == null) {

                this.Ok = new System.Int64();

            } else {


            }
        }
        else if (this.Ok != null && ec.Excludes("ok",true))
        {
            this.Ok = null;
        }
        //      C# -> System.Int64? Warning
        // GraphQL -> warning: Long! (scalar)
        if (ec.Includes("warning",true))
        {
            if(this.Warning == null) {

                this.Warning = new System.Int64();

            } else {


            }
        }
        else if (this.Warning != null && ec.Excludes("warning",true))
        {
            this.Warning = null;
        }
    }


    #endregion

    } // class ClusterHealthAggregation
    
    #endregion

    public static class ListClusterHealthAggregationExtensions
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
            this List<ClusterHealthAggregation> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ClusterHealthAggregation> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClusterHealthAggregation> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterHealthAggregation());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterHealthAggregation> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types