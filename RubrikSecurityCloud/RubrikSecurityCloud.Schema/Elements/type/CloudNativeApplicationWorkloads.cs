// CloudNativeApplicationWorkloads.cs
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
    #region CloudNativeApplicationWorkloads
    public class CloudNativeApplicationWorkloads: BaseType
    {
        #region members

        //      C# -> CloudNativeObjectType? ObjectType
        // GraphQL -> objectType: CloudNativeObjectType! (enum)
        [JsonProperty("objectType")]
        public CloudNativeObjectType? ObjectType { get; set; }

        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }

        //      C# -> List<System.String>? WorkloadIds
        // GraphQL -> workloadIds: [UUID!]! (scalar)
        [JsonProperty("workloadIds")]
        public List<System.String>? WorkloadIds { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudNativeApplicationWorkloads";
    }

    public CloudNativeApplicationWorkloads Set(
        CloudNativeObjectType? ObjectType = null,
        System.Int32? Count = null,
        List<System.String>? WorkloadIds = null
    ) 
    {
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( Count != null ) {
            this.Count = Count;
        }
        if ( WorkloadIds != null ) {
            this.WorkloadIds = WorkloadIds;
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
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count != null) {
            if (conf.Flat) {
                s += conf.Prefix + "count\n" ;
            } else {
                s += ind + "count\n" ;
            }
        }
        //      C# -> List<System.String>? WorkloadIds
        // GraphQL -> workloadIds: [UUID!]! (scalar)
        if (this.WorkloadIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloadIds\n" ;
            } else {
                s += ind + "workloadIds\n" ;
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
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (ec.Includes("count",true))
        {
            if(this.Count == null) {

                this.Count = Int32.MinValue;

            } else {


            }
        }
        else if (this.Count != null && ec.Excludes("count",true))
        {
            this.Count = null;
        }
        //      C# -> List<System.String>? WorkloadIds
        // GraphQL -> workloadIds: [UUID!]! (scalar)
        if (ec.Includes("workloadIds",true))
        {
            if(this.WorkloadIds == null) {

                this.WorkloadIds = new List<System.String>();

            } else {


            }
        }
        else if (this.WorkloadIds != null && ec.Excludes("workloadIds",true))
        {
            this.WorkloadIds = null;
        }
    }


    #endregion

    } // class CloudNativeApplicationWorkloads
    
    #endregion

    public static class ListCloudNativeApplicationWorkloadsExtensions
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
            this List<CloudNativeApplicationWorkloads> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudNativeApplicationWorkloads> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudNativeApplicationWorkloads> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudNativeApplicationWorkloads());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudNativeApplicationWorkloads> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types