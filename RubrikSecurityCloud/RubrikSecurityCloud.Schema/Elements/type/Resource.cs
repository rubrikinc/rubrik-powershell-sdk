// Resource.cs
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
    #region Resource
    public class Resource: BaseType
    {
        #region members

        //      C# -> ConfigResource? ConfigResource
        // GraphQL -> configResource: ConfigResource (type)
        [JsonProperty("configResource")]
        public ConfigResource? ConfigResource { get; set; }

        //      C# -> WorkloadResource? WorkloadResource
        // GraphQL -> workloadResource: WorkloadResource (type)
        [JsonProperty("workloadResource")]
        public WorkloadResource? WorkloadResource { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Resource";
    }

    public Resource Set(
        ConfigResource? ConfigResource = null,
        WorkloadResource? WorkloadResource = null
    ) 
    {
        if ( ConfigResource != null ) {
            this.ConfigResource = ConfigResource;
        }
        if ( WorkloadResource != null ) {
            this.WorkloadResource = WorkloadResource;
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
        //      C# -> ConfigResource? ConfigResource
        // GraphQL -> configResource: ConfigResource (type)
        if (this.ConfigResource != null) {
            var fspec = this.ConfigResource.AsFieldSpec(conf.Child("configResource"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "configResource" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> WorkloadResource? WorkloadResource
        // GraphQL -> workloadResource: WorkloadResource (type)
        if (this.WorkloadResource != null) {
            var fspec = this.WorkloadResource.AsFieldSpec(conf.Child("workloadResource"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "workloadResource" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ConfigResource? ConfigResource
        // GraphQL -> configResource: ConfigResource (type)
        if (ec.Includes("configResource",false))
        {
            if(this.ConfigResource == null) {

                this.ConfigResource = new ConfigResource();
                this.ConfigResource.ApplyExploratoryFieldSpec(ec.NewChild("configResource"));

            } else {

                this.ConfigResource.ApplyExploratoryFieldSpec(ec.NewChild("configResource"));

            }
        }
        else if (this.ConfigResource != null && ec.Excludes("configResource",false))
        {
            this.ConfigResource = null;
        }
        //      C# -> WorkloadResource? WorkloadResource
        // GraphQL -> workloadResource: WorkloadResource (type)
        if (ec.Includes("workloadResource",false))
        {
            if(this.WorkloadResource == null) {

                this.WorkloadResource = new WorkloadResource();
                this.WorkloadResource.ApplyExploratoryFieldSpec(ec.NewChild("workloadResource"));

            } else {

                this.WorkloadResource.ApplyExploratoryFieldSpec(ec.NewChild("workloadResource"));

            }
        }
        else if (this.WorkloadResource != null && ec.Excludes("workloadResource",false))
        {
            this.WorkloadResource = null;
        }
    }


    #endregion

    } // class Resource
    
    #endregion

    public static class ListResourceExtensions
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
            this List<Resource> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<Resource> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<Resource> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new Resource());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<Resource> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types