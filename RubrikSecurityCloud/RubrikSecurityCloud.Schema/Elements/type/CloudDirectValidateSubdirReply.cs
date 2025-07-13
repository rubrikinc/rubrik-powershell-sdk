// CloudDirectValidateSubdirReply.cs
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
    #region CloudDirectValidateSubdirReply
    public class CloudDirectValidateSubdirReply: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsDir
        // GraphQL -> isDir: Boolean! (scalar)
        [JsonProperty("isDir")]
        public System.Boolean? IsDir { get; set; }

        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        [JsonProperty("path")]
        public System.String? Path { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudDirectValidateSubdirReply";
    }

    public CloudDirectValidateSubdirReply Set(
        System.Boolean? IsDir = null,
        System.String? Path = null
    ) 
    {
        if ( IsDir != null ) {
            this.IsDir = IsDir;
        }
        if ( Path != null ) {
            this.Path = Path;
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
        //      C# -> System.Boolean? IsDir
        // GraphQL -> isDir: Boolean! (scalar)
        if (this.IsDir != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isDir\n" ;
            } else {
                s += ind + "isDir\n" ;
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Boolean? IsDir
        // GraphQL -> isDir: Boolean! (scalar)
        if (ec.Includes("isDir",true))
        {
            if(this.IsDir == null) {

                this.IsDir = true;

            } else {


            }
        }
        else if (this.IsDir != null && ec.Excludes("isDir",true))
        {
            this.IsDir = null;
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
    }


    #endregion

    } // class CloudDirectValidateSubdirReply
    
    #endregion

    public static class ListCloudDirectValidateSubdirReplyExtensions
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
            this List<CloudDirectValidateSubdirReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudDirectValidateSubdirReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudDirectValidateSubdirReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudDirectValidateSubdirReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudDirectValidateSubdirReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types