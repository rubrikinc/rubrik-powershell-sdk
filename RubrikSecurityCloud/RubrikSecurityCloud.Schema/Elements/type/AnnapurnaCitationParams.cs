// AnnapurnaCitationParams.cs
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
    #region AnnapurnaCitationParams
    public class AnnapurnaCitationParams: BaseType
    {
        #region members

        //      C# -> List<AnnapurnaCitation>? Citations
        // GraphQL -> citations: [AnnapurnaCitation!]! (type)
        [JsonProperty("citations")]
        public List<AnnapurnaCitation>? Citations { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AnnapurnaCitationParams";
    }

    public AnnapurnaCitationParams Set(
        List<AnnapurnaCitation>? Citations = null
    ) 
    {
        if ( Citations != null ) {
            this.Citations = Citations;
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
        //      C# -> List<AnnapurnaCitation>? Citations
        // GraphQL -> citations: [AnnapurnaCitation!]! (type)
        if (this.Citations != null) {
            var fspec = this.Citations.AsFieldSpec(conf.Child("citations"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "citations" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<AnnapurnaCitation>? Citations
        // GraphQL -> citations: [AnnapurnaCitation!]! (type)
        if (ec.Includes("citations",false))
        {
            if(this.Citations == null) {

                this.Citations = new List<AnnapurnaCitation>();
                this.Citations.ApplyExploratoryFieldSpec(ec.NewChild("citations"));

            } else {

                this.Citations.ApplyExploratoryFieldSpec(ec.NewChild("citations"));

            }
        }
        else if (this.Citations != null && ec.Excludes("citations",false))
        {
            this.Citations = null;
        }
    }


    #endregion

    } // class AnnapurnaCitationParams
    
    #endregion

    public static class ListAnnapurnaCitationParamsExtensions
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
            this List<AnnapurnaCitationParams> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AnnapurnaCitationParams> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AnnapurnaCitationParams> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AnnapurnaCitationParams());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AnnapurnaCitationParams> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types