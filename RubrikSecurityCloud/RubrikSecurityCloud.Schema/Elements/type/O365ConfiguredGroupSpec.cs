// O365ConfiguredGroupSpec.cs
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
    #region O365ConfiguredGroupSpec
    public class O365ConfiguredGroupSpec: BaseType
    {
        #region members

        //      C# -> List<ManagedObjectType>? Workload
        // GraphQL -> workload: [ManagedObjectType!] (enum)
        [JsonProperty("workload")]
        public List<ManagedObjectType>? Workload { get; set; }

        //      C# -> List<System.String>? Pdls
        // GraphQL -> pdls: [String!]! (scalar)
        [JsonProperty("pdls")]
        public List<System.String>? Pdls { get; set; }

        //      C# -> System.String? Wildcard
        // GraphQL -> wildcard: String! (scalar)
        [JsonProperty("wildcard")]
        public System.String? Wildcard { get; set; }

        //      C# -> List<GroupFilterAttributeList>? FilterAttributes
        // GraphQL -> filterAttributes: [GroupFilterAttributeList!]! (type)
        [JsonProperty("filterAttributes")]
        public List<GroupFilterAttributeList>? FilterAttributes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "O365ConfiguredGroupSpec";
    }

    public O365ConfiguredGroupSpec Set(
        List<ManagedObjectType>? Workload = null,
        List<System.String>? Pdls = null,
        System.String? Wildcard = null,
        List<GroupFilterAttributeList>? FilterAttributes = null
    ) 
    {
        if ( Workload != null ) {
            this.Workload = Workload;
        }
        if ( Pdls != null ) {
            this.Pdls = Pdls;
        }
        if ( Wildcard != null ) {
            this.Wildcard = Wildcard;
        }
        if ( FilterAttributes != null ) {
            this.FilterAttributes = FilterAttributes;
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
        //      C# -> List<ManagedObjectType>? Workload
        // GraphQL -> workload: [ManagedObjectType!] (enum)
        if (this.Workload != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workload\n" ;
            } else {
                s += ind + "workload\n" ;
            }
        }
        //      C# -> List<System.String>? Pdls
        // GraphQL -> pdls: [String!]! (scalar)
        if (this.Pdls != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pdls\n" ;
            } else {
                s += ind + "pdls\n" ;
            }
        }
        //      C# -> System.String? Wildcard
        // GraphQL -> wildcard: String! (scalar)
        if (this.Wildcard != null) {
            if (conf.Flat) {
                s += conf.Prefix + "wildcard\n" ;
            } else {
                s += ind + "wildcard\n" ;
            }
        }
        //      C# -> List<GroupFilterAttributeList>? FilterAttributes
        // GraphQL -> filterAttributes: [GroupFilterAttributeList!]! (type)
        if (this.FilterAttributes != null) {
            var fspec = this.FilterAttributes.AsFieldSpec(conf.Child("filterAttributes"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "filterAttributes" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<ManagedObjectType>? Workload
        // GraphQL -> workload: [ManagedObjectType!] (enum)
        if (ec.Includes("workload",true))
        {
            if(this.Workload == null) {

                this.Workload = new List<ManagedObjectType>();

            } else {


            }
        }
        else if (this.Workload != null && ec.Excludes("workload",true))
        {
            this.Workload = null;
        }
        //      C# -> List<System.String>? Pdls
        // GraphQL -> pdls: [String!]! (scalar)
        if (ec.Includes("pdls",true))
        {
            if(this.Pdls == null) {

                this.Pdls = new List<System.String>();

            } else {


            }
        }
        else if (this.Pdls != null && ec.Excludes("pdls",true))
        {
            this.Pdls = null;
        }
        //      C# -> System.String? Wildcard
        // GraphQL -> wildcard: String! (scalar)
        if (ec.Includes("wildcard",true))
        {
            if(this.Wildcard == null) {

                this.Wildcard = "FETCH";

            } else {


            }
        }
        else if (this.Wildcard != null && ec.Excludes("wildcard",true))
        {
            this.Wildcard = null;
        }
        //      C# -> List<GroupFilterAttributeList>? FilterAttributes
        // GraphQL -> filterAttributes: [GroupFilterAttributeList!]! (type)
        if (ec.Includes("filterAttributes",false))
        {
            if(this.FilterAttributes == null) {

                this.FilterAttributes = new List<GroupFilterAttributeList>();
                this.FilterAttributes.ApplyExploratoryFieldSpec(ec.NewChild("filterAttributes"));

            } else {

                this.FilterAttributes.ApplyExploratoryFieldSpec(ec.NewChild("filterAttributes"));

            }
        }
        else if (this.FilterAttributes != null && ec.Excludes("filterAttributes",false))
        {
            this.FilterAttributes = null;
        }
    }


    #endregion

    } // class O365ConfiguredGroupSpec
    
    #endregion

    public static class ListO365ConfiguredGroupSpecExtensions
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
            this List<O365ConfiguredGroupSpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<O365ConfiguredGroupSpec> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<O365ConfiguredGroupSpec> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365ConfiguredGroupSpec());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<O365ConfiguredGroupSpec> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types