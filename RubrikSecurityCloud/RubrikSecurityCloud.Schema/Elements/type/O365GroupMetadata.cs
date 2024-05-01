// O365GroupMetadata.cs
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
    #region O365GroupMetadata
    public class O365GroupMetadata: BaseType
    {
        #region members

        //      C# -> O365ConfiguredGroupMetadata? ConfiguredGroupMetadata
        // GraphQL -> configuredGroupMetadata: O365ConfiguredGroupMetadata (type)
        [JsonProperty("configuredGroupMetadata")]
        public O365ConfiguredGroupMetadata? ConfiguredGroupMetadata { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "O365GroupMetadata";
    }

    public O365GroupMetadata Set(
        O365ConfiguredGroupMetadata? ConfiguredGroupMetadata = null
    ) 
    {
        if ( ConfiguredGroupMetadata != null ) {
            this.ConfiguredGroupMetadata = ConfiguredGroupMetadata;
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
        //      C# -> O365ConfiguredGroupMetadata? ConfiguredGroupMetadata
        // GraphQL -> configuredGroupMetadata: O365ConfiguredGroupMetadata (type)
        if (this.ConfiguredGroupMetadata != null) {
            var fspec = this.ConfiguredGroupMetadata.AsFieldSpec(conf.Child("configuredGroupMetadata"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "configuredGroupMetadata" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> O365ConfiguredGroupMetadata? ConfiguredGroupMetadata
        // GraphQL -> configuredGroupMetadata: O365ConfiguredGroupMetadata (type)
        if (ec.Includes("configuredGroupMetadata",false))
        {
            if(this.ConfiguredGroupMetadata == null) {

                this.ConfiguredGroupMetadata = new O365ConfiguredGroupMetadata();
                this.ConfiguredGroupMetadata.ApplyExploratoryFieldSpec(ec.NewChild("configuredGroupMetadata"));

            } else {

                this.ConfiguredGroupMetadata.ApplyExploratoryFieldSpec(ec.NewChild("configuredGroupMetadata"));

            }
        }
        else if (this.ConfiguredGroupMetadata != null && ec.Excludes("configuredGroupMetadata",false))
        {
            this.ConfiguredGroupMetadata = null;
        }
    }


    #endregion

    } // class O365GroupMetadata
    
    #endregion

    public static class ListO365GroupMetadataExtensions
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
            this List<O365GroupMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<O365GroupMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<O365GroupMetadata> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365GroupMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<O365GroupMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types