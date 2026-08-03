// LinkedGpoMetadata.cs
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
    #region LinkedGpoMetadata
    public class LinkedGpoMetadata: BaseType
    {
        #region members

        //      C# -> System.String? GpoName
        // GraphQL -> gpoName: String! (scalar)
        [JsonProperty("gpoName")]
        public System.String? GpoName { get; set; }

        //      C# -> List<System.String>? ManagedBy
        // GraphQL -> managedBy: [String!]! (scalar)
        [JsonProperty("managedBy")]
        public List<System.String>? ManagedBy { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "LinkedGpoMetadata";
    }

    public LinkedGpoMetadata Set(
        System.String? GpoName = null,
        List<System.String>? ManagedBy = null
    ) 
    {
        if ( GpoName != null ) {
            this.GpoName = GpoName;
        }
        if ( ManagedBy != null ) {
            this.ManagedBy = ManagedBy;
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
        //      C# -> System.String? GpoName
        // GraphQL -> gpoName: String! (scalar)
        if (this.GpoName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "gpoName\n" ;
            } else {
                s += ind + "gpoName\n" ;
            }
        }
        //      C# -> List<System.String>? ManagedBy
        // GraphQL -> managedBy: [String!]! (scalar)
        if (this.ManagedBy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "managedBy\n" ;
            } else {
                s += ind + "managedBy\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? GpoName
        // GraphQL -> gpoName: String! (scalar)
        if (ec.Includes("gpoName",true))
        {
            if(this.GpoName == null) {

                this.GpoName = "FETCH";

            } else {


            }
        }
        else if (this.GpoName != null && ec.Excludes("gpoName",true))
        {
            this.GpoName = null;
        }
        //      C# -> List<System.String>? ManagedBy
        // GraphQL -> managedBy: [String!]! (scalar)
        if (ec.Includes("managedBy",true))
        {
            if(this.ManagedBy == null) {

                this.ManagedBy = new List<System.String>();

            } else {


            }
        }
        else if (this.ManagedBy != null && ec.Excludes("managedBy",true))
        {
            this.ManagedBy = null;
        }
    }


    #endregion

    } // class LinkedGpoMetadata
    
    #endregion

    public static class ListLinkedGpoMetadataExtensions
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
            this List<LinkedGpoMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<LinkedGpoMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<LinkedGpoMetadata> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new LinkedGpoMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<LinkedGpoMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types