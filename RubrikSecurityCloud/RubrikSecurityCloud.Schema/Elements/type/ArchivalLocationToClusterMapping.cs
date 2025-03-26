// ArchivalLocationToClusterMapping.cs
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
    #region ArchivalLocationToClusterMapping
    public class ArchivalLocationToClusterMapping: BaseType
    {
        #region members

        //      C# -> SlaArchivalCluster? Cluster
        // GraphQL -> cluster: SlaArchivalCluster (type)
        [JsonProperty("cluster")]
        public SlaArchivalCluster? Cluster { get; set; }

        //      C# -> DlsArchivalLocation? Location
        // GraphQL -> location: DlsArchivalLocation (type)
        [JsonProperty("location")]
        public DlsArchivalLocation? Location { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ArchivalLocationToClusterMapping";
    }

    public ArchivalLocationToClusterMapping Set(
        SlaArchivalCluster? Cluster = null,
        DlsArchivalLocation? Location = null
    ) 
    {
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( Location != null ) {
            this.Location = Location;
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
        //      C# -> SlaArchivalCluster? Cluster
        // GraphQL -> cluster: SlaArchivalCluster (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(conf.Child("cluster"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cluster" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> DlsArchivalLocation? Location
        // GraphQL -> location: DlsArchivalLocation (type)
        if (this.Location != null) {
            var fspec = this.Location.AsFieldSpec(conf.Child("location"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "location" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> SlaArchivalCluster? Cluster
        // GraphQL -> cluster: SlaArchivalCluster (type)
        if (ec.Includes("cluster",false))
        {
            if(this.Cluster == null) {

                this.Cluster = new SlaArchivalCluster();
                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            } else {

                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            }
        }
        else if (this.Cluster != null && ec.Excludes("cluster",false))
        {
            this.Cluster = null;
        }
        //      C# -> DlsArchivalLocation? Location
        // GraphQL -> location: DlsArchivalLocation (type)
        if (ec.Includes("location",false))
        {
            if(this.Location == null) {

                this.Location = new DlsArchivalLocation();
                this.Location.ApplyExploratoryFieldSpec(ec.NewChild("location"));

            } else {

                this.Location.ApplyExploratoryFieldSpec(ec.NewChild("location"));

            }
        }
        else if (this.Location != null && ec.Excludes("location",false))
        {
            this.Location = null;
        }
    }


    #endregion

    } // class ArchivalLocationToClusterMapping
    
    #endregion

    public static class ListArchivalLocationToClusterMappingExtensions
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
            this List<ArchivalLocationToClusterMapping> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ArchivalLocationToClusterMapping> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ArchivalLocationToClusterMapping> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ArchivalLocationToClusterMapping());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ArchivalLocationToClusterMapping> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types