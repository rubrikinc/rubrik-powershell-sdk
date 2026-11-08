// WorkloadResource.cs
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
    #region WorkloadResource
    public class WorkloadResource: BaseType
    {
        #region members

        //      C# -> CloudNativeObjectType? ObjectType
        // GraphQL -> objectType: CloudNativeObjectType! (enum)
        [JsonProperty("objectType")]
        public CloudNativeObjectType? ObjectType { get; set; }

        //      C# -> System.String? MoId
        // GraphQL -> moId: UUID! (scalar)
        [JsonProperty("moId")]
        public System.String? MoId { get; set; }

        //      C# -> ApplicationResourceMetadata? Resource
        // GraphQL -> resource: ApplicationResourceMetadata! (type)
        [JsonProperty("resource")]
        public ApplicationResourceMetadata? Resource { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "WorkloadResource";
    }

    public WorkloadResource Set(
        CloudNativeObjectType? ObjectType = null,
        System.String? MoId = null,
        ApplicationResourceMetadata? Resource = null
    ) 
    {
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( MoId != null ) {
            this.MoId = MoId;
        }
        if ( Resource != null ) {
            this.Resource = Resource;
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
        //      C# -> CloudNativeObjectType? ObjectType
        // GraphQL -> objectType: CloudNativeObjectType! (enum)
        if (this.ObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectType\n" ;
            } else {
                s += ind + "objectType\n" ;
            }
        }
        //      C# -> System.String? MoId
        // GraphQL -> moId: UUID! (scalar)
        if (this.MoId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "moId\n" ;
            } else {
                s += ind + "moId\n" ;
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> CloudNativeObjectType? ObjectType
        // GraphQL -> objectType: CloudNativeObjectType! (enum)
        if (ec.Includes("objectType",true))
        {
            if(this.ObjectType == null) {

                this.ObjectType = new CloudNativeObjectType();

            } else {


            }
        }
        else if (this.ObjectType != null && ec.Excludes("objectType",true))
        {
            this.ObjectType = null;
        }
        //      C# -> System.String? MoId
        // GraphQL -> moId: UUID! (scalar)
        if (ec.Includes("moId",true))
        {
            if(this.MoId == null) {

                this.MoId = "FETCH";

            } else {


            }
        }
        else if (this.MoId != null && ec.Excludes("moId",true))
        {
            this.MoId = null;
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
    }


    #endregion

    } // class WorkloadResource
    
    #endregion

    public static class ListWorkloadResourceExtensions
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
            this List<WorkloadResource> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<WorkloadResource> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<WorkloadResource> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new WorkloadResource());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<WorkloadResource> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types