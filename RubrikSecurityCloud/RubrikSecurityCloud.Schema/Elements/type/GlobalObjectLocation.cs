// GlobalObjectLocation.cs
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
    #region GlobalObjectLocation
    public class GlobalObjectLocation: BaseType
    {
        #region members

        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        [JsonProperty("clusterName")]
        public System.String? ClusterName { get; set; }

        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        [JsonProperty("fid")]
        public System.String? Fid { get; set; }

        //      C# -> System.Boolean? IsManagedObject
        // GraphQL -> isManagedObject: Boolean! (scalar)
        [JsonProperty("isManagedObject")]
        public System.Boolean? IsManagedObject { get; set; }

        //      C# -> System.String? LocationType
        // GraphQL -> locationType: String! (scalar)
        [JsonProperty("locationType")]
        public System.String? LocationType { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? PhysicalPath
        // GraphQL -> physicalPath: String! (scalar)
        [JsonProperty("physicalPath")]
        public System.String? PhysicalPath { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GlobalObjectLocation";
    }

    public GlobalObjectLocation Set(
        System.String? ClusterName = null,
        System.String? Fid = null,
        System.Boolean? IsManagedObject = null,
        System.String? LocationType = null,
        System.String? Name = null,
        System.String? PhysicalPath = null
    ) 
    {
        if ( ClusterName != null ) {
            this.ClusterName = ClusterName;
        }
        if ( Fid != null ) {
            this.Fid = Fid;
        }
        if ( IsManagedObject != null ) {
            this.IsManagedObject = IsManagedObject;
        }
        if ( LocationType != null ) {
            this.LocationType = LocationType;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( PhysicalPath != null ) {
            this.PhysicalPath = PhysicalPath;
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
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (this.ClusterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterName\n" ;
            } else {
                s += ind + "clusterName\n" ;
            }
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        if (this.Fid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fid\n" ;
            } else {
                s += ind + "fid\n" ;
            }
        }
        //      C# -> System.Boolean? IsManagedObject
        // GraphQL -> isManagedObject: Boolean! (scalar)
        if (this.IsManagedObject != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isManagedObject\n" ;
            } else {
                s += ind + "isManagedObject\n" ;
            }
        }
        //      C# -> System.String? LocationType
        // GraphQL -> locationType: String! (scalar)
        if (this.LocationType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "locationType\n" ;
            } else {
                s += ind + "locationType\n" ;
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
        //      C# -> System.String? PhysicalPath
        // GraphQL -> physicalPath: String! (scalar)
        if (this.PhysicalPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "physicalPath\n" ;
            } else {
                s += ind + "physicalPath\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (ec.Includes("clusterName",true))
        {
            if(this.ClusterName == null) {

                this.ClusterName = "FETCH";

            } else {


            }
        }
        else if (this.ClusterName != null && ec.Excludes("clusterName",true))
        {
            this.ClusterName = null;
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        if (ec.Includes("fid",true))
        {
            if(this.Fid == null) {

                this.Fid = "FETCH";

            } else {


            }
        }
        else if (this.Fid != null && ec.Excludes("fid",true))
        {
            this.Fid = null;
        }
        //      C# -> System.Boolean? IsManagedObject
        // GraphQL -> isManagedObject: Boolean! (scalar)
        if (ec.Includes("isManagedObject",true))
        {
            if(this.IsManagedObject == null) {

                this.IsManagedObject = true;

            } else {


            }
        }
        else if (this.IsManagedObject != null && ec.Excludes("isManagedObject",true))
        {
            this.IsManagedObject = null;
        }
        //      C# -> System.String? LocationType
        // GraphQL -> locationType: String! (scalar)
        if (ec.Includes("locationType",true))
        {
            if(this.LocationType == null) {

                this.LocationType = "FETCH";

            } else {


            }
        }
        else if (this.LocationType != null && ec.Excludes("locationType",true))
        {
            this.LocationType = null;
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
        //      C# -> System.String? PhysicalPath
        // GraphQL -> physicalPath: String! (scalar)
        if (ec.Includes("physicalPath",true))
        {
            if(this.PhysicalPath == null) {

                this.PhysicalPath = "FETCH";

            } else {


            }
        }
        else if (this.PhysicalPath != null && ec.Excludes("physicalPath",true))
        {
            this.PhysicalPath = null;
        }
    }


    #endregion

    } // class GlobalObjectLocation
    
    #endregion

    public static class ListGlobalObjectLocationExtensions
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
            this List<GlobalObjectLocation> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GlobalObjectLocation> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GlobalObjectLocation> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GlobalObjectLocation());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GlobalObjectLocation> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types