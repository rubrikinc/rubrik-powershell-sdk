// EnableLambdaForSnappableReply.cs
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
    #region EnableLambdaForSnappableReply
    public class EnableLambdaForSnappableReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? DiffFmdEnabled
        // GraphQL -> diffFmdEnabled: Boolean! (scalar)
        [JsonProperty("diffFmdEnabled")]
        public System.Boolean? DiffFmdEnabled { get; set; }

        //      C# -> System.Boolean? FullFmdEnabled
        // GraphQL -> fullFmdEnabled: Boolean! (scalar)
        [JsonProperty("fullFmdEnabled")]
        public System.Boolean? FullFmdEnabled { get; set; }

        //      C# -> System.String? SnappableFid
        // GraphQL -> snappableFid: String! (scalar)
        [JsonProperty("snappableFid")]
        public System.String? SnappableFid { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "EnableLambdaForSnappableReply";
    }

    public EnableLambdaForSnappableReply Set(
        System.Boolean? DiffFmdEnabled = null,
        System.Boolean? FullFmdEnabled = null,
        System.String? SnappableFid = null
    ) 
    {
        if ( DiffFmdEnabled != null ) {
            this.DiffFmdEnabled = DiffFmdEnabled;
        }
        if ( FullFmdEnabled != null ) {
            this.FullFmdEnabled = FullFmdEnabled;
        }
        if ( SnappableFid != null ) {
            this.SnappableFid = SnappableFid;
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
        //      C# -> System.Boolean? DiffFmdEnabled
        // GraphQL -> diffFmdEnabled: Boolean! (scalar)
        if (this.DiffFmdEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "diffFmdEnabled\n" ;
            } else {
                s += ind + "diffFmdEnabled\n" ;
            }
        }
        //      C# -> System.Boolean? FullFmdEnabled
        // GraphQL -> fullFmdEnabled: Boolean! (scalar)
        if (this.FullFmdEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fullFmdEnabled\n" ;
            } else {
                s += ind + "fullFmdEnabled\n" ;
            }
        }
        //      C# -> System.String? SnappableFid
        // GraphQL -> snappableFid: String! (scalar)
        if (this.SnappableFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snappableFid\n" ;
            } else {
                s += ind + "snappableFid\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Boolean? DiffFmdEnabled
        // GraphQL -> diffFmdEnabled: Boolean! (scalar)
        if (ec.Includes("diffFmdEnabled",true))
        {
            if(this.DiffFmdEnabled == null) {

                this.DiffFmdEnabled = true;

            } else {


            }
        }
        else if (this.DiffFmdEnabled != null && ec.Excludes("diffFmdEnabled",true))
        {
            this.DiffFmdEnabled = null;
        }
        //      C# -> System.Boolean? FullFmdEnabled
        // GraphQL -> fullFmdEnabled: Boolean! (scalar)
        if (ec.Includes("fullFmdEnabled",true))
        {
            if(this.FullFmdEnabled == null) {

                this.FullFmdEnabled = true;

            } else {


            }
        }
        else if (this.FullFmdEnabled != null && ec.Excludes("fullFmdEnabled",true))
        {
            this.FullFmdEnabled = null;
        }
        //      C# -> System.String? SnappableFid
        // GraphQL -> snappableFid: String! (scalar)
        if (ec.Includes("snappableFid",true))
        {
            if(this.SnappableFid == null) {

                this.SnappableFid = "FETCH";

            } else {


            }
        }
        else if (this.SnappableFid != null && ec.Excludes("snappableFid",true))
        {
            this.SnappableFid = null;
        }
    }


    #endregion

    } // class EnableLambdaForSnappableReply
    
    #endregion

    public static class ListEnableLambdaForSnappableReplyExtensions
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
            this List<EnableLambdaForSnappableReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<EnableLambdaForSnappableReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<EnableLambdaForSnappableReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new EnableLambdaForSnappableReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<EnableLambdaForSnappableReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types