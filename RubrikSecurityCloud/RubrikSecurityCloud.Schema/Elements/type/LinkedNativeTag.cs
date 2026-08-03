// LinkedNativeTag.cs
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
    #region LinkedNativeTag
    public class LinkedNativeTag: BaseType
    {
        #region members

        //      C# -> NativeTagSource? Source
        // GraphQL -> source: NativeTagSource! (enum)
        [JsonProperty("source")]
        public NativeTagSource? Source { get; set; }

        //      C# -> System.Int32? AssignedObjectsCount
        // GraphQL -> assignedObjectsCount: Int! (scalar)
        [JsonProperty("assignedObjectsCount")]
        public System.Int32? AssignedObjectsCount { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> RubrikClusterRef? RubrikCluster
        // GraphQL -> rubrikCluster: RubrikClusterRef (type)
        [JsonProperty("rubrikCluster")]
        public RubrikClusterRef? RubrikCluster { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "LinkedNativeTag";
    }

    public LinkedNativeTag Set(
        NativeTagSource? Source = null,
        System.Int32? AssignedObjectsCount = null,
        System.String? Id = null,
        System.String? Name = null,
        RubrikClusterRef? RubrikCluster = null
    ) 
    {
        if ( Source != null ) {
            this.Source = Source;
        }
        if ( AssignedObjectsCount != null ) {
            this.AssignedObjectsCount = AssignedObjectsCount;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( RubrikCluster != null ) {
            this.RubrikCluster = RubrikCluster;
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
        //      C# -> NativeTagSource? Source
        // GraphQL -> source: NativeTagSource! (enum)
        if (this.Source != null) {
            if (conf.Flat) {
                s += conf.Prefix + "source\n" ;
            } else {
                s += ind + "source\n" ;
            }
        }
        //      C# -> System.Int32? AssignedObjectsCount
        // GraphQL -> assignedObjectsCount: Int! (scalar)
        if (this.AssignedObjectsCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "assignedObjectsCount\n" ;
            } else {
                s += ind + "assignedObjectsCount\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> RubrikClusterRef? RubrikCluster
        // GraphQL -> rubrikCluster: RubrikClusterRef (type)
        if (this.RubrikCluster != null) {
            var fspec = this.RubrikCluster.AsFieldSpec(conf.Child("rubrikCluster"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "rubrikCluster" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> NativeTagSource? Source
        // GraphQL -> source: NativeTagSource! (enum)
        if (ec.Includes("source",true))
        {
            if(this.Source == null) {

                this.Source = new NativeTagSource();

            } else {


            }
        }
        else if (this.Source != null && ec.Excludes("source",true))
        {
            this.Source = null;
        }
        //      C# -> System.Int32? AssignedObjectsCount
        // GraphQL -> assignedObjectsCount: Int! (scalar)
        if (ec.Includes("assignedObjectsCount",true))
        {
            if(this.AssignedObjectsCount == null) {

                this.AssignedObjectsCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.AssignedObjectsCount != null && ec.Excludes("assignedObjectsCount",true))
        {
            this.AssignedObjectsCount = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> RubrikClusterRef? RubrikCluster
        // GraphQL -> rubrikCluster: RubrikClusterRef (type)
        if (ec.Includes("rubrikCluster",false))
        {
            if(this.RubrikCluster == null) {

                this.RubrikCluster = new RubrikClusterRef();
                this.RubrikCluster.ApplyExploratoryFieldSpec(ec.NewChild("rubrikCluster"));

            } else {

                this.RubrikCluster.ApplyExploratoryFieldSpec(ec.NewChild("rubrikCluster"));

            }
        }
        else if (this.RubrikCluster != null && ec.Excludes("rubrikCluster",false))
        {
            this.RubrikCluster = null;
        }
    }


    #endregion

    } // class LinkedNativeTag
    
    #endregion

    public static class ListLinkedNativeTagExtensions
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
            this List<LinkedNativeTag> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<LinkedNativeTag> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<LinkedNativeTag> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new LinkedNativeTag());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<LinkedNativeTag> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types