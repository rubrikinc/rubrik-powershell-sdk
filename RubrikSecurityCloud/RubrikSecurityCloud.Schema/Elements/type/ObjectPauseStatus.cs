// ObjectPauseStatus.cs
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
    #region ObjectPauseStatus
    public class ObjectPauseStatus: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsDirectlyPaused
        // GraphQL -> isDirectlyPaused: Boolean! (scalar)
        [JsonProperty("isDirectlyPaused")]
        public System.Boolean? IsDirectlyPaused { get; set; }

        //      C# -> System.Boolean? IsEffectivelyPaused
        // GraphQL -> isEffectivelyPaused: Boolean! (scalar)
        [JsonProperty("isEffectivelyPaused")]
        public System.Boolean? IsEffectivelyPaused { get; set; }

        //      C# -> List<ObjectPausedSource>? PausedSources
        // GraphQL -> pausedSources: [ObjectPausedSource!]! (type)
        [JsonProperty("pausedSources")]
        public List<ObjectPausedSource>? PausedSources { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ObjectPauseStatus";
    }

    public ObjectPauseStatus Set(
        System.Boolean? IsDirectlyPaused = null,
        System.Boolean? IsEffectivelyPaused = null,
        List<ObjectPausedSource>? PausedSources = null
    ) 
    {
        if ( IsDirectlyPaused != null ) {
            this.IsDirectlyPaused = IsDirectlyPaused;
        }
        if ( IsEffectivelyPaused != null ) {
            this.IsEffectivelyPaused = IsEffectivelyPaused;
        }
        if ( PausedSources != null ) {
            this.PausedSources = PausedSources;
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
        //      C# -> System.Boolean? IsDirectlyPaused
        // GraphQL -> isDirectlyPaused: Boolean! (scalar)
        if (this.IsDirectlyPaused != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isDirectlyPaused\n" ;
            } else {
                s += ind + "isDirectlyPaused\n" ;
            }
        }
        //      C# -> System.Boolean? IsEffectivelyPaused
        // GraphQL -> isEffectivelyPaused: Boolean! (scalar)
        if (this.IsEffectivelyPaused != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isEffectivelyPaused\n" ;
            } else {
                s += ind + "isEffectivelyPaused\n" ;
            }
        }
        //      C# -> List<ObjectPausedSource>? PausedSources
        // GraphQL -> pausedSources: [ObjectPausedSource!]! (type)
        if (this.PausedSources != null) {
            var fspec = this.PausedSources.AsFieldSpec(conf.Child("pausedSources"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "pausedSources" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? IsDirectlyPaused
        // GraphQL -> isDirectlyPaused: Boolean! (scalar)
        if (ec.Includes("isDirectlyPaused",true))
        {
            if(this.IsDirectlyPaused == null) {

                this.IsDirectlyPaused = true;

            } else {


            }
        }
        else if (this.IsDirectlyPaused != null && ec.Excludes("isDirectlyPaused",true))
        {
            this.IsDirectlyPaused = null;
        }
        //      C# -> System.Boolean? IsEffectivelyPaused
        // GraphQL -> isEffectivelyPaused: Boolean! (scalar)
        if (ec.Includes("isEffectivelyPaused",true))
        {
            if(this.IsEffectivelyPaused == null) {

                this.IsEffectivelyPaused = true;

            } else {


            }
        }
        else if (this.IsEffectivelyPaused != null && ec.Excludes("isEffectivelyPaused",true))
        {
            this.IsEffectivelyPaused = null;
        }
        //      C# -> List<ObjectPausedSource>? PausedSources
        // GraphQL -> pausedSources: [ObjectPausedSource!]! (type)
        if (ec.Includes("pausedSources",false))
        {
            if(this.PausedSources == null) {

                this.PausedSources = new List<ObjectPausedSource>();
                this.PausedSources.ApplyExploratoryFieldSpec(ec.NewChild("pausedSources"));

            } else {

                this.PausedSources.ApplyExploratoryFieldSpec(ec.NewChild("pausedSources"));

            }
        }
        else if (this.PausedSources != null && ec.Excludes("pausedSources",false))
        {
            this.PausedSources = null;
        }
    }


    #endregion

    } // class ObjectPauseStatus
    
    #endregion

    public static class ListObjectPauseStatusExtensions
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
            this List<ObjectPauseStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ObjectPauseStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ObjectPauseStatus> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ObjectPauseStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ObjectPauseStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types