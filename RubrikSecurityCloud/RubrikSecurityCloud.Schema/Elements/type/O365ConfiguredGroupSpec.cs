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

        //      C# -> List<System.String>? Pdls
        // GraphQL -> pdls: [String!]! (scalar)
        [JsonProperty("pdls")]
        public List<System.String>? Pdls { get; set; }

        //      C# -> System.String? Wildcard
        // GraphQL -> wildcard: String! (scalar)
        [JsonProperty("wildcard")]
        public System.String? Wildcard { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "O365ConfiguredGroupSpec";
    }

    public O365ConfiguredGroupSpec Set(
        List<System.String>? Pdls = null,
        System.String? Wildcard = null
    ) 
    {
        if ( Pdls != null ) {
            this.Pdls = Pdls;
        }
        if ( Wildcard != null ) {
            this.Wildcard = Wildcard;
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
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
    }


    #endregion

    } // class O365ConfiguredGroupSpec
    
    #endregion

    public static class ListO365ConfiguredGroupSpecExtensions
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
            this List<O365ConfiguredGroupSpec> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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