// ConfigResource.cs
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
    #region ConfigResource
    public class ConfigResource: BaseType
    {
        #region members

        //      C# -> ConfigResourceType? ResourceType
        // GraphQL -> resourceType: ConfigResourceType! (enum)
        [JsonProperty("resourceType")]
        public ConfigResourceType? ResourceType { get; set; }

        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        [JsonProperty("id")]
        public System.Int64? Id { get; set; }

        //      C# -> System.String? Metadata
        // GraphQL -> metadata: String! (scalar)
        [JsonProperty("metadata")]
        public System.String? Metadata { get; set; }

        //      C# -> ApplicationResourceMetadata? Resource
        // GraphQL -> resource: ApplicationResourceMetadata! (type)
        [JsonProperty("resource")]
        public ApplicationResourceMetadata? Resource { get; set; }

        //      C# -> SpecificResource? SpecificResource
        // GraphQL -> specificResource: SpecificResource (type)
        [JsonProperty("specificResource")]
        public SpecificResource? SpecificResource { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ConfigResource";
    }

    public ConfigResource Set(
        ConfigResourceType? ResourceType = null,
        System.Int64? Id = null,
        System.String? Metadata = null,
        ApplicationResourceMetadata? Resource = null,
        SpecificResource? SpecificResource = null
    ) 
    {
        if ( ResourceType != null ) {
            this.ResourceType = ResourceType;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Metadata != null ) {
            this.Metadata = Metadata;
        }
        if ( Resource != null ) {
            this.Resource = Resource;
        }
        if ( SpecificResource != null ) {
            this.SpecificResource = SpecificResource;
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
        //      C# -> ConfigResourceType? ResourceType
        // GraphQL -> resourceType: ConfigResourceType! (enum)
        if (this.ResourceType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceType\n" ;
            } else {
                s += ind + "resourceType\n" ;
            }
        }
        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.String? Metadata
        // GraphQL -> metadata: String! (scalar)
        if (this.Metadata != null) {
            if (conf.Flat) {
                s += conf.Prefix + "metadata\n" ;
            } else {
                s += ind + "metadata\n" ;
            }
        }
        //      C# -> ApplicationResourceMetadata? Resource
        // GraphQL -> resource: ApplicationResourceMetadata! (type)
        if (this.Resource != null) {
            var fspec = this.Resource.AsFieldSpec(conf.Child("resource"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "resource" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SpecificResource? SpecificResource
        // GraphQL -> specificResource: SpecificResource (type)
        if (this.SpecificResource != null) {
            var fspec = this.SpecificResource.AsFieldSpec(conf.Child("specificResource"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "specificResource" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ConfigResourceType? ResourceType
        // GraphQL -> resourceType: ConfigResourceType! (enum)
        if (ec.Includes("resourceType",true))
        {
            if(this.ResourceType == null) {

                this.ResourceType = new ConfigResourceType();

            } else {


            }
        }
        else if (this.ResourceType != null && ec.Excludes("resourceType",true))
        {
            this.ResourceType = null;
        }
        //      C# -> System.Int64? Id
        // GraphQL -> id: Long! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = new System.Int64();

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.String? Metadata
        // GraphQL -> metadata: String! (scalar)
        if (ec.Includes("metadata",true))
        {
            if(this.Metadata == null) {

                this.Metadata = "FETCH";

            } else {


            }
        }
        else if (this.Metadata != null && ec.Excludes("metadata",true))
        {
            this.Metadata = null;
        }
        //      C# -> ApplicationResourceMetadata? Resource
        // GraphQL -> resource: ApplicationResourceMetadata! (type)
        if (ec.Includes("resource",false))
        {
            if(this.Resource == null) {

                this.Resource = new ApplicationResourceMetadata();
                this.Resource.ApplyExploratoryFieldSpec(ec.NewChild("resource"));

            } else {

                this.Resource.ApplyExploratoryFieldSpec(ec.NewChild("resource"));

            }
        }
        else if (this.Resource != null && ec.Excludes("resource",false))
        {
            this.Resource = null;
        }
        //      C# -> SpecificResource? SpecificResource
        // GraphQL -> specificResource: SpecificResource (type)
        if (ec.Includes("specificResource",false))
        {
            if(this.SpecificResource == null) {

                this.SpecificResource = new SpecificResource();
                this.SpecificResource.ApplyExploratoryFieldSpec(ec.NewChild("specificResource"));

            } else {

                this.SpecificResource.ApplyExploratoryFieldSpec(ec.NewChild("specificResource"));

            }
        }
        else if (this.SpecificResource != null && ec.Excludes("specificResource",false))
        {
            this.SpecificResource = null;
        }
    }


    #endregion

    } // class ConfigResource
    
    #endregion

    public static class ListConfigResourceExtensions
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
            this List<ConfigResource> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ConfigResource> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ConfigResource> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ConfigResource());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ConfigResource> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types