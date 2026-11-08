// GetCloudNativeApplicationWorkloadsByConfigSnapshotReply.cs
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
    #region GetCloudNativeApplicationWorkloadsByConfigSnapshotReply
    public class GetCloudNativeApplicationWorkloadsByConfigSnapshotReply: BaseType
    {
        #region members

        //      C# -> List<ConfigResourceType>? PresentConfigTypes
        // GraphQL -> presentConfigTypes: [ConfigResourceType!]! (enum)
        [JsonProperty("presentConfigTypes")]
        public List<ConfigResourceType>? PresentConfigTypes { get; set; }

        //      C# -> List<ConfigResourceInfo>? ConfigResources
        // GraphQL -> configResources: [ConfigResourceInfo!]! (type)
        [JsonProperty("configResources")]
        public List<ConfigResourceInfo>? ConfigResources { get; set; }

        //      C# -> List<CloudNativeApplicationWorkloads>? WorkloadGroups
        // GraphQL -> workloadGroups: [CloudNativeApplicationWorkloads!]! (type)
        [JsonProperty("workloadGroups")]
        public List<CloudNativeApplicationWorkloads>? WorkloadGroups { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GetCloudNativeApplicationWorkloadsByConfigSnapshotReply";
    }

    public GetCloudNativeApplicationWorkloadsByConfigSnapshotReply Set(
        List<ConfigResourceType>? PresentConfigTypes = null,
        List<ConfigResourceInfo>? ConfigResources = null,
        List<CloudNativeApplicationWorkloads>? WorkloadGroups = null
    ) 
    {
        if ( PresentConfigTypes != null ) {
            this.PresentConfigTypes = PresentConfigTypes;
        }
        if ( ConfigResources != null ) {
            this.ConfigResources = ConfigResources;
        }
        if ( WorkloadGroups != null ) {
            this.WorkloadGroups = WorkloadGroups;
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
        //      C# -> List<ConfigResourceType>? PresentConfigTypes
        // GraphQL -> presentConfigTypes: [ConfigResourceType!]! (enum)
        if (this.PresentConfigTypes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "presentConfigTypes\n" ;
            } else {
                s += ind + "presentConfigTypes\n" ;
            }
        }
        //      C# -> List<ConfigResourceInfo>? ConfigResources
        // GraphQL -> configResources: [ConfigResourceInfo!]! (type)
        if (this.ConfigResources != null) {
            var fspec = this.ConfigResources.AsFieldSpec(conf.Child("configResources"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "configResources" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<CloudNativeApplicationWorkloads>? WorkloadGroups
        // GraphQL -> workloadGroups: [CloudNativeApplicationWorkloads!]! (type)
        if (this.WorkloadGroups != null) {
            var fspec = this.WorkloadGroups.AsFieldSpec(conf.Child("workloadGroups"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "workloadGroups" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<ConfigResourceType>? PresentConfigTypes
        // GraphQL -> presentConfigTypes: [ConfigResourceType!]! (enum)
        if (ec.Includes("presentConfigTypes",true))
        {
            if(this.PresentConfigTypes == null) {

                this.PresentConfigTypes = new List<ConfigResourceType>();

            } else {


            }
        }
        else if (this.PresentConfigTypes != null && ec.Excludes("presentConfigTypes",true))
        {
            this.PresentConfigTypes = null;
        }
        //      C# -> List<ConfigResourceInfo>? ConfigResources
        // GraphQL -> configResources: [ConfigResourceInfo!]! (type)
        if (ec.Includes("configResources",false))
        {
            if(this.ConfigResources == null) {

                this.ConfigResources = new List<ConfigResourceInfo>();
                this.ConfigResources.ApplyExploratoryFieldSpec(ec.NewChild("configResources"));

            } else {

                this.ConfigResources.ApplyExploratoryFieldSpec(ec.NewChild("configResources"));

            }
        }
        else if (this.ConfigResources != null && ec.Excludes("configResources",false))
        {
            this.ConfigResources = null;
        }
        //      C# -> List<CloudNativeApplicationWorkloads>? WorkloadGroups
        // GraphQL -> workloadGroups: [CloudNativeApplicationWorkloads!]! (type)
        if (ec.Includes("workloadGroups",false))
        {
            if(this.WorkloadGroups == null) {

                this.WorkloadGroups = new List<CloudNativeApplicationWorkloads>();
                this.WorkloadGroups.ApplyExploratoryFieldSpec(ec.NewChild("workloadGroups"));

            } else {

                this.WorkloadGroups.ApplyExploratoryFieldSpec(ec.NewChild("workloadGroups"));

            }
        }
        else if (this.WorkloadGroups != null && ec.Excludes("workloadGroups",false))
        {
            this.WorkloadGroups = null;
        }
    }


    #endregion

    } // class GetCloudNativeApplicationWorkloadsByConfigSnapshotReply
    
    #endregion

    public static class ListGetCloudNativeApplicationWorkloadsByConfigSnapshotReplyExtensions
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
            this List<GetCloudNativeApplicationWorkloadsByConfigSnapshotReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GetCloudNativeApplicationWorkloadsByConfigSnapshotReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GetCloudNativeApplicationWorkloadsByConfigSnapshotReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GetCloudNativeApplicationWorkloadsByConfigSnapshotReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GetCloudNativeApplicationWorkloadsByConfigSnapshotReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types