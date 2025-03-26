// OraclePdbApplicationContainer.cs
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
    #region OraclePdbApplicationContainer
    public class OraclePdbApplicationContainer: BaseType
    {
        #region members

        //      C# -> List<System.String>? ApplicationPdbs
        // GraphQL -> applicationPdbs: [String!]! (scalar)
        [JsonProperty("applicationPdbs")]
        public List<System.String>? ApplicationPdbs { get; set; }

        //      C# -> System.String? ApplicationRoot
        // GraphQL -> applicationRoot: String! (scalar)
        [JsonProperty("applicationRoot")]
        public System.String? ApplicationRoot { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "OraclePdbApplicationContainer";
    }

    public OraclePdbApplicationContainer Set(
        List<System.String>? ApplicationPdbs = null,
        System.String? ApplicationRoot = null
    ) 
    {
        if ( ApplicationPdbs != null ) {
            this.ApplicationPdbs = ApplicationPdbs;
        }
        if ( ApplicationRoot != null ) {
            this.ApplicationRoot = ApplicationRoot;
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
        //      C# -> List<System.String>? ApplicationPdbs
        // GraphQL -> applicationPdbs: [String!]! (scalar)
        if (this.ApplicationPdbs != null) {
            if (conf.Flat) {
                s += conf.Prefix + "applicationPdbs\n" ;
            } else {
                s += ind + "applicationPdbs\n" ;
            }
        }
        //      C# -> System.String? ApplicationRoot
        // GraphQL -> applicationRoot: String! (scalar)
        if (this.ApplicationRoot != null) {
            if (conf.Flat) {
                s += conf.Prefix + "applicationRoot\n" ;
            } else {
                s += ind + "applicationRoot\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<System.String>? ApplicationPdbs
        // GraphQL -> applicationPdbs: [String!]! (scalar)
        if (ec.Includes("applicationPdbs",true))
        {
            if(this.ApplicationPdbs == null) {

                this.ApplicationPdbs = new List<System.String>();

            } else {


            }
        }
        else if (this.ApplicationPdbs != null && ec.Excludes("applicationPdbs",true))
        {
            this.ApplicationPdbs = null;
        }
        //      C# -> System.String? ApplicationRoot
        // GraphQL -> applicationRoot: String! (scalar)
        if (ec.Includes("applicationRoot",true))
        {
            if(this.ApplicationRoot == null) {

                this.ApplicationRoot = "FETCH";

            } else {


            }
        }
        else if (this.ApplicationRoot != null && ec.Excludes("applicationRoot",true))
        {
            this.ApplicationRoot = null;
        }
    }


    #endregion

    } // class OraclePdbApplicationContainer
    
    #endregion

    public static class ListOraclePdbApplicationContainerExtensions
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
            this List<OraclePdbApplicationContainer> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<OraclePdbApplicationContainer> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<OraclePdbApplicationContainer> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OraclePdbApplicationContainer());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<OraclePdbApplicationContainer> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types