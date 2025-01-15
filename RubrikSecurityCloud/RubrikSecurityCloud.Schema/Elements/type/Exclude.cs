// Exclude.cs
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
    #region Exclude
    public class Exclude: BaseType
    {
        #region members

        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        [JsonProperty("path")]
        public System.String? Path { get; set; }

        //      C# -> System.String? Pattern
        // GraphQL -> pattern: String! (scalar)
        [JsonProperty("pattern")]
        public System.String? Pattern { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Exclude";
    }

    public Exclude Set(
        System.String? Path = null,
        System.String? Pattern = null
    ) 
    {
        if ( Path != null ) {
            this.Path = Path;
        }
        if ( Pattern != null ) {
            this.Pattern = Pattern;
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
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (this.Path != null) {
            if (conf.Flat) {
                s += conf.Prefix + "path\n" ;
            } else {
                s += ind + "path\n" ;
            }
        }
        //      C# -> System.String? Pattern
        // GraphQL -> pattern: String! (scalar)
        if (this.Pattern != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pattern\n" ;
            } else {
                s += ind + "pattern\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (ec.Includes("path",true))
        {
            if(this.Path == null) {

                this.Path = "FETCH";

            } else {


            }
        }
        else if (this.Path != null && ec.Excludes("path",true))
        {
            this.Path = null;
        }
        //      C# -> System.String? Pattern
        // GraphQL -> pattern: String! (scalar)
        if (ec.Includes("pattern",true))
        {
            if(this.Pattern == null) {

                this.Pattern = "FETCH";

            } else {


            }
        }
        else if (this.Pattern != null && ec.Excludes("pattern",true))
        {
            this.Pattern = null;
        }
    }


    #endregion

    } // class Exclude
    
    #endregion

    public static class ListExcludeExtensions
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
            this List<Exclude> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<Exclude> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Exclude> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Exclude());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Exclude> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types