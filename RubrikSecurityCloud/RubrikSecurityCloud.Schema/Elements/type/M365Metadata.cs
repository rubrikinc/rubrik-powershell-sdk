// M365Metadata.cs
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
    #region M365Metadata
    public class M365Metadata: BaseType
    {
        #region members

        //      C# -> System.String? FileId
        // GraphQL -> fileId: String! (scalar)
        [JsonProperty("fileId")]
        public System.String? FileId { get; set; }

        //      C# -> System.String? ParentObjectId
        // GraphQL -> parentObjectId: UUID! (scalar)
        [JsonProperty("parentObjectId")]
        public System.String? ParentObjectId { get; set; }

        //      C# -> System.String? ParentObjectType
        // GraphQL -> parentObjectType: UUID! (scalar)
        [JsonProperty("parentObjectType")]
        public System.String? ParentObjectType { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "M365Metadata";
    }

    public M365Metadata Set(
        System.String? FileId = null,
        System.String? ParentObjectId = null,
        System.String? ParentObjectType = null
    ) 
    {
        if ( FileId != null ) {
            this.FileId = FileId;
        }
        if ( ParentObjectId != null ) {
            this.ParentObjectId = ParentObjectId;
        }
        if ( ParentObjectType != null ) {
            this.ParentObjectType = ParentObjectType;
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
        //      C# -> System.String? FileId
        // GraphQL -> fileId: String! (scalar)
        if (this.FileId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fileId\n" ;
            } else {
                s += ind + "fileId\n" ;
            }
        }
        //      C# -> System.String? ParentObjectId
        // GraphQL -> parentObjectId: UUID! (scalar)
        if (this.ParentObjectId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "parentObjectId\n" ;
            } else {
                s += ind + "parentObjectId\n" ;
            }
        }
        //      C# -> System.String? ParentObjectType
        // GraphQL -> parentObjectType: UUID! (scalar)
        if (this.ParentObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "parentObjectType\n" ;
            } else {
                s += ind + "parentObjectType\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? FileId
        // GraphQL -> fileId: String! (scalar)
        if (ec.Includes("fileId",true))
        {
            if(this.FileId == null) {

                this.FileId = "FETCH";

            } else {


            }
        }
        else if (this.FileId != null && ec.Excludes("fileId",true))
        {
            this.FileId = null;
        }
        //      C# -> System.String? ParentObjectId
        // GraphQL -> parentObjectId: UUID! (scalar)
        if (ec.Includes("parentObjectId",true))
        {
            if(this.ParentObjectId == null) {

                this.ParentObjectId = "FETCH";

            } else {


            }
        }
        else if (this.ParentObjectId != null && ec.Excludes("parentObjectId",true))
        {
            this.ParentObjectId = null;
        }
        //      C# -> System.String? ParentObjectType
        // GraphQL -> parentObjectType: UUID! (scalar)
        if (ec.Includes("parentObjectType",true))
        {
            if(this.ParentObjectType == null) {

                this.ParentObjectType = "FETCH";

            } else {


            }
        }
        else if (this.ParentObjectType != null && ec.Excludes("parentObjectType",true))
        {
            this.ParentObjectType = null;
        }
    }


    #endregion

    } // class M365Metadata
    
    #endregion

    public static class ListM365MetadataExtensions
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
            this List<M365Metadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<M365Metadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<M365Metadata> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new M365Metadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<M365Metadata> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types