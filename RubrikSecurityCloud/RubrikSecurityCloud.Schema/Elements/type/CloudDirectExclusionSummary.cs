// CloudDirectExclusionSummary.cs
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
    #region CloudDirectExclusionSummary
    public class CloudDirectExclusionSummary: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsMoreExclusionsPresent
        // GraphQL -> isMoreExclusionsPresent: Boolean! (scalar)
        [JsonProperty("isMoreExclusionsPresent")]
        public System.Boolean? IsMoreExclusionsPresent { get; set; }

        //      C# -> List<System.String>? Paths
        // GraphQL -> paths: [String!]! (scalar)
        [JsonProperty("paths")]
        public List<System.String>? Paths { get; set; }

        //      C# -> List<System.String>? Patterns
        // GraphQL -> patterns: [String!]! (scalar)
        [JsonProperty("patterns")]
        public List<System.String>? Patterns { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudDirectExclusionSummary";
    }

    public CloudDirectExclusionSummary Set(
        System.Boolean? IsMoreExclusionsPresent = null,
        List<System.String>? Paths = null,
        List<System.String>? Patterns = null
    ) 
    {
        if ( IsMoreExclusionsPresent != null ) {
            this.IsMoreExclusionsPresent = IsMoreExclusionsPresent;
        }
        if ( Paths != null ) {
            this.Paths = Paths;
        }
        if ( Patterns != null ) {
            this.Patterns = Patterns;
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
        //      C# -> System.Boolean? IsMoreExclusionsPresent
        // GraphQL -> isMoreExclusionsPresent: Boolean! (scalar)
        if (this.IsMoreExclusionsPresent != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isMoreExclusionsPresent\n" ;
            } else {
                s += ind + "isMoreExclusionsPresent\n" ;
            }
        }
        //      C# -> List<System.String>? Paths
        // GraphQL -> paths: [String!]! (scalar)
        if (this.Paths != null) {
            if (conf.Flat) {
                s += conf.Prefix + "paths\n" ;
            } else {
                s += ind + "paths\n" ;
            }
        }
        //      C# -> List<System.String>? Patterns
        // GraphQL -> patterns: [String!]! (scalar)
        if (this.Patterns != null) {
            if (conf.Flat) {
                s += conf.Prefix + "patterns\n" ;
            } else {
                s += ind + "patterns\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? IsMoreExclusionsPresent
        // GraphQL -> isMoreExclusionsPresent: Boolean! (scalar)
        if (ec.Includes("isMoreExclusionsPresent",true))
        {
            if(this.IsMoreExclusionsPresent == null) {

                this.IsMoreExclusionsPresent = true;

            } else {


            }
        }
        else if (this.IsMoreExclusionsPresent != null && ec.Excludes("isMoreExclusionsPresent",true))
        {
            this.IsMoreExclusionsPresent = null;
        }
        //      C# -> List<System.String>? Paths
        // GraphQL -> paths: [String!]! (scalar)
        if (ec.Includes("paths",true))
        {
            if(this.Paths == null) {

                this.Paths = new List<System.String>();

            } else {


            }
        }
        else if (this.Paths != null && ec.Excludes("paths",true))
        {
            this.Paths = null;
        }
        //      C# -> List<System.String>? Patterns
        // GraphQL -> patterns: [String!]! (scalar)
        if (ec.Includes("patterns",true))
        {
            if(this.Patterns == null) {

                this.Patterns = new List<System.String>();

            } else {


            }
        }
        else if (this.Patterns != null && ec.Excludes("patterns",true))
        {
            this.Patterns = null;
        }
    }


    #endregion

    } // class CloudDirectExclusionSummary
    
    #endregion

    public static class ListCloudDirectExclusionSummaryExtensions
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
            this List<CloudDirectExclusionSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudDirectExclusionSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudDirectExclusionSummary> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudDirectExclusionSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudDirectExclusionSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types