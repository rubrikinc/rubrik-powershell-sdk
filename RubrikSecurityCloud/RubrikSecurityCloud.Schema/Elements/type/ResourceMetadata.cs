// ResourceMetadata.cs
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
    #region ResourceMetadata
    public class ResourceMetadata: BaseType
    {
        #region members

        //      C# -> ResourceMetadataUnion? Metadata
        // GraphQL -> metadata: ResourceMetadataUnion! (union)
        [JsonProperty("metadata")]
        public ResourceMetadataUnion? Metadata { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ResourceMetadata";
    }

    public ResourceMetadata Set(
        ResourceMetadataUnion? Metadata = null
    ) 
    {
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
        //      C# -> ResourceMetadataUnion? Metadata
        // GraphQL -> metadata: ResourceMetadataUnion! (union)
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
        //      C# -> ResourceMetadataUnion? Metadata
        // GraphQL -> metadata: ResourceMetadataUnion! (union)
        if (ec.Includes("metadata",false))
        {
            if(this.Metadata == null) {

                var impls = new List<ResourceMetadataUnion>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("metadata"));
                this.Metadata = (ResourceMetadataUnion)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<ResourceMetadataUnion>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("metadata"));
                this.Metadata = (ResourceMetadataUnion)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.Metadata != null && ec.Excludes("metadata",false))
        {
            this.Metadata = null;
        }
    }


    #endregion

    } // class ResourceMetadata
    
    #endregion

    public static class ListResourceMetadataExtensions
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
            this List<ResourceMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ResourceMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ResourceMetadata> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ResourceMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ResourceMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types