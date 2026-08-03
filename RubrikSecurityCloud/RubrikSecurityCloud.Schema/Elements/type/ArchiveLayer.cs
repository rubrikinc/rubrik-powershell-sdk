// ArchiveLayer.cs
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
    #region ArchiveLayer
    public class ArchiveLayer: BaseType
    {
        #region members

        //      C# -> System.String? FilePath
        // GraphQL -> filePath: String! (scalar)
        [JsonProperty("filePath")]
        public System.String? FilePath { get; set; }

        //      C# -> System.String? Sha256Hash
        // GraphQL -> sha256Hash: String! (scalar)
        [JsonProperty("sha256Hash")]
        public System.String? Sha256Hash { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ArchiveLayer";
    }

    public ArchiveLayer Set(
        System.String? FilePath = null,
        System.String? Sha256Hash = null
    ) 
    {
        if ( FilePath != null ) {
            this.FilePath = FilePath;
        }
        if ( Sha256Hash != null ) {
            this.Sha256Hash = Sha256Hash;
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
        //      C# -> System.String? FilePath
        // GraphQL -> filePath: String! (scalar)
        if (this.FilePath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "filePath\n" ;
            } else {
                s += ind + "filePath\n" ;
            }
        }
        //      C# -> System.String? Sha256Hash
        // GraphQL -> sha256Hash: String! (scalar)
        if (this.Sha256Hash != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sha256Hash\n" ;
            } else {
                s += ind + "sha256Hash\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? FilePath
        // GraphQL -> filePath: String! (scalar)
        if (ec.Includes("filePath",true))
        {
            if(this.FilePath == null) {

                this.FilePath = "FETCH";

            } else {


            }
        }
        else if (this.FilePath != null && ec.Excludes("filePath",true))
        {
            this.FilePath = null;
        }
        //      C# -> System.String? Sha256Hash
        // GraphQL -> sha256Hash: String! (scalar)
        if (ec.Includes("sha256Hash",true))
        {
            if(this.Sha256Hash == null) {

                this.Sha256Hash = "FETCH";

            } else {


            }
        }
        else if (this.Sha256Hash != null && ec.Excludes("sha256Hash",true))
        {
            this.Sha256Hash = null;
        }
    }


    #endregion

    } // class ArchiveLayer
    
    #endregion

    public static class ListArchiveLayerExtensions
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
            this List<ArchiveLayer> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ArchiveLayer> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ArchiveLayer> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ArchiveLayer());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ArchiveLayer> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types