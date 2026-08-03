// K8sResourceTypeCount.cs
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
    #region K8sResourceTypeCount
    public class K8sResourceTypeCount: BaseType
    {
        #region members

        //      C# -> System.String? ApiGroup
        // GraphQL -> apiGroup: String! (scalar)
        [JsonProperty("apiGroup")]
        public System.String? ApiGroup { get; set; }

        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }

        //      C# -> System.String? ResourceType
        // GraphQL -> resourceType: String! (scalar)
        [JsonProperty("resourceType")]
        public System.String? ResourceType { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "K8sResourceTypeCount";
    }

    public K8sResourceTypeCount Set(
        System.String? ApiGroup = null,
        System.Int32? Count = null,
        System.String? ResourceType = null
    ) 
    {
        if ( ApiGroup != null ) {
            this.ApiGroup = ApiGroup;
        }
        if ( Count != null ) {
            this.Count = Count;
        }
        if ( ResourceType != null ) {
            this.ResourceType = ResourceType;
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
        //      C# -> System.String? ApiGroup
        // GraphQL -> apiGroup: String! (scalar)
        if (this.ApiGroup != null) {
            if (conf.Flat) {
                s += conf.Prefix + "apiGroup\n" ;
            } else {
                s += ind + "apiGroup\n" ;
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
        //      C# -> System.String? ResourceType
        // GraphQL -> resourceType: String! (scalar)
        if (this.ResourceType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resourceType\n" ;
            } else {
                s += ind + "resourceType\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? ApiGroup
        // GraphQL -> apiGroup: String! (scalar)
        if (ec.Includes("apiGroup",true))
        {
            if(this.ApiGroup == null) {

                this.ApiGroup = "FETCH";

            } else {


            }
        }
        else if (this.ApiGroup != null && ec.Excludes("apiGroup",true))
        {
            this.ApiGroup = null;
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
        //      C# -> System.String? ResourceType
        // GraphQL -> resourceType: String! (scalar)
        if (ec.Includes("resourceType",true))
        {
            if(this.ResourceType == null) {

                this.ResourceType = "FETCH";

            } else {


            }
        }
        else if (this.ResourceType != null && ec.Excludes("resourceType",true))
        {
            this.ResourceType = null;
        }
    }


    #endregion

    } // class K8sResourceTypeCount
    
    #endregion

    public static class ListK8sResourceTypeCountExtensions
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
            this List<K8sResourceTypeCount> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<K8sResourceTypeCount> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<K8sResourceTypeCount> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new K8sResourceTypeCount());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<K8sResourceTypeCount> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types