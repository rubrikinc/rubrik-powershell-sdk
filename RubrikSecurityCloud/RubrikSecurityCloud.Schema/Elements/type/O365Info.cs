// O365Info.cs
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
    #region O365Info
    public class O365Info: BaseType
    {
        #region members

        //      C# -> System.String? FileId
        // GraphQL -> fileId: String! (scalar)
        [JsonProperty("fileId")]
        public System.String? FileId { get; set; }

        //      C# -> System.String? SharepointId
        // GraphQL -> sharepointId: String! (scalar)
        [JsonProperty("sharepointId")]
        public System.String? SharepointId { get; set; }

        //      C# -> MetadataFields? Metadata
        // GraphQL -> metadata: MetadataFields (type)
        [JsonProperty("metadata")]
        public MetadataFields? Metadata { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "O365Info";
    }

    public O365Info Set(
        System.String? FileId = null,
        System.String? SharepointId = null,
        MetadataFields? Metadata = null
    ) 
    {
        if ( FileId != null ) {
            this.FileId = FileId;
        }
        if ( SharepointId != null ) {
            this.SharepointId = SharepointId;
        }
        if ( Metadata != null ) {
            this.Metadata = Metadata;
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
        //      C# -> System.String? SharepointId
        // GraphQL -> sharepointId: String! (scalar)
        if (this.SharepointId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sharepointId\n" ;
            } else {
                s += ind + "sharepointId\n" ;
            }
        }
        //      C# -> MetadataFields? Metadata
        // GraphQL -> metadata: MetadataFields (type)
        if (this.Metadata != null) {
            var fspec = this.Metadata.AsFieldSpec(conf.Child("metadata"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "metadata" + " " + "{\n" + fspec + ind + "}\n" ;
                }
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
        //      C# -> System.String? SharepointId
        // GraphQL -> sharepointId: String! (scalar)
        if (ec.Includes("sharepointId",true))
        {
            if(this.SharepointId == null) {

                this.SharepointId = "FETCH";

            } else {


            }
        }
        else if (this.SharepointId != null && ec.Excludes("sharepointId",true))
        {
            this.SharepointId = null;
        }
        //      C# -> MetadataFields? Metadata
        // GraphQL -> metadata: MetadataFields (type)
        if (ec.Includes("metadata",false))
        {
            if(this.Metadata == null) {

                this.Metadata = new MetadataFields();
                this.Metadata.ApplyExploratoryFieldSpec(ec.NewChild("metadata"));

            } else {

                this.Metadata.ApplyExploratoryFieldSpec(ec.NewChild("metadata"));

            }
        }
        else if (this.Metadata != null && ec.Excludes("metadata",false))
        {
            this.Metadata = null;
        }
    }


    #endregion

    } // class O365Info
    
    #endregion

    public static class ListO365InfoExtensions
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
            this List<O365Info> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<O365Info> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<O365Info> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365Info());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<O365Info> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types