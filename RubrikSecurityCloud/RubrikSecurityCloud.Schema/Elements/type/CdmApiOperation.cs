// CdmApiOperation.cs
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
    #region CdmApiOperation
    public class CdmApiOperation: BaseType
    {
        #region members

        //      C# -> System.String? Method
        // GraphQL -> method: String! (scalar)
        [JsonProperty("method")]
        public System.String? Method { get; set; }

        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        [JsonProperty("path")]
        public System.String? Path { get; set; }

        //      C# -> List<System.String>? Versions
        // GraphQL -> versions: [String!]! (scalar)
        [JsonProperty("versions")]
        public List<System.String>? Versions { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CdmApiOperation";
    }

    public CdmApiOperation Set(
        System.String? Method = null,
        System.String? Path = null,
        List<System.String>? Versions = null
    ) 
    {
        if ( Method != null ) {
            this.Method = Method;
        }
        if ( Path != null ) {
            this.Path = Path;
        }
        if ( Versions != null ) {
            this.Versions = Versions;
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
        //      C# -> System.String? Method
        // GraphQL -> method: String! (scalar)
        if (this.Method != null) {
            if (conf.Flat) {
                s += conf.Prefix + "method\n" ;
            } else {
                s += ind + "method\n" ;
            }
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (this.Path != null) {
            if (conf.Flat) {
                s += conf.Prefix + "path\n" ;
            } else {
                s += ind + "path\n" ;
            }
        }
        //      C# -> List<System.String>? Versions
        // GraphQL -> versions: [String!]! (scalar)
        if (this.Versions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "versions\n" ;
            } else {
                s += ind + "versions\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? Method
        // GraphQL -> method: String! (scalar)
        if (ec.Includes("method",true))
        {
            if(this.Method == null) {

                this.Method = "FETCH";

            } else {


            }
        }
        else if (this.Method != null && ec.Excludes("method",true))
        {
            this.Method = null;
        }
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
        //      C# -> List<System.String>? Versions
        // GraphQL -> versions: [String!]! (scalar)
        if (ec.Includes("versions",true))
        {
            if(this.Versions == null) {

                this.Versions = new List<System.String>();

            } else {


            }
        }
        else if (this.Versions != null && ec.Excludes("versions",true))
        {
            this.Versions = null;
        }
    }


    #endregion

    } // class CdmApiOperation
    
    #endregion

    public static class ListCdmApiOperationExtensions
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
            this List<CdmApiOperation> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CdmApiOperation> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CdmApiOperation> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmApiOperation());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CdmApiOperation> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types