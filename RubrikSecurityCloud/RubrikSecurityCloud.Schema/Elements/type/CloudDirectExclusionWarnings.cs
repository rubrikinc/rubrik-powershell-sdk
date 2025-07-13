// CloudDirectExclusionWarnings.cs
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
    #region CloudDirectExclusionWarnings
    public class CloudDirectExclusionWarnings: BaseType
    {
        #region members

        //      C# -> System.String? PathOrPattern
        // GraphQL -> pathOrPattern: String! (scalar)
        [JsonProperty("pathOrPattern")]
        public System.String? PathOrPattern { get; set; }

        //      C# -> System.String? Warning
        // GraphQL -> warning: String! (scalar)
        [JsonProperty("warning")]
        public System.String? Warning { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudDirectExclusionWarnings";
    }

    public CloudDirectExclusionWarnings Set(
        System.String? PathOrPattern = null,
        System.String? Warning = null
    ) 
    {
        if ( PathOrPattern != null ) {
            this.PathOrPattern = PathOrPattern;
        }
        if ( Warning != null ) {
            this.Warning = Warning;
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
        //      C# -> System.String? PathOrPattern
        // GraphQL -> pathOrPattern: String! (scalar)
        if (this.PathOrPattern != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pathOrPattern\n" ;
            } else {
                s += ind + "pathOrPattern\n" ;
            }
        }
        //      C# -> System.String? Warning
        // GraphQL -> warning: String! (scalar)
        if (this.Warning != null) {
            if (conf.Flat) {
                s += conf.Prefix + "warning\n" ;
            } else {
                s += ind + "warning\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? PathOrPattern
        // GraphQL -> pathOrPattern: String! (scalar)
        if (ec.Includes("pathOrPattern",true))
        {
            if(this.PathOrPattern == null) {

                this.PathOrPattern = "FETCH";

            } else {


            }
        }
        else if (this.PathOrPattern != null && ec.Excludes("pathOrPattern",true))
        {
            this.PathOrPattern = null;
        }
        //      C# -> System.String? Warning
        // GraphQL -> warning: String! (scalar)
        if (ec.Includes("warning",true))
        {
            if(this.Warning == null) {

                this.Warning = "FETCH";

            } else {


            }
        }
        else if (this.Warning != null && ec.Excludes("warning",true))
        {
            this.Warning = null;
        }
    }


    #endregion

    } // class CloudDirectExclusionWarnings
    
    #endregion

    public static class ListCloudDirectExclusionWarningsExtensions
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
            this List<CloudDirectExclusionWarnings> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudDirectExclusionWarnings> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudDirectExclusionWarnings> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudDirectExclusionWarnings());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudDirectExclusionWarnings> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types