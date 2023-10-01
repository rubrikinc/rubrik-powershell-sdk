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
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "configuredGroupMetadata {\n" + fspec + ind + "}\n" ;
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
            this List<O365GroupMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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