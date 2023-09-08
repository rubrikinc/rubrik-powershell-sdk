// BlueprintCdmLocation.cs
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
    #region BlueprintCdmLocation
 
    public class BlueprintCdmLocation: BaseType, BlueprintLocation
    {
        #region members

        //      C# -> BlueprintLocationType? Type
        // GraphQL -> type: BlueprintLocationType! (enum)
        [JsonProperty("type")]
        public BlueprintLocationType? Type { get; set; }

        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        [JsonProperty("locationId")]
        public System.String? LocationId { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BlueprintCdmLocation";
    }

    public BlueprintCdmLocation Set(
        BlueprintLocationType? Type = null,
        System.String? LocationId = null,
        Cluster? Cluster = null
    ) 
    {
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( LocationId != null ) {
            this.LocationId = LocationId;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> BlueprintLocationType? Type
        // GraphQL -> type: BlueprintLocationType! (enum)
        if (this.Type != null) {
            s += ind + "type\n" ;
        }
        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        if (this.LocationId != null) {
            s += ind + "locationId\n" ;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cluster {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> BlueprintLocationType? Type
        // GraphQL -> type: BlueprintLocationType! (enum)
        if (this.Type == null && ec.Includes("type",true))
        {
            this.Type = new BlueprintLocationType();
        }
        //      C# -> System.String? LocationId
        // GraphQL -> locationId: String! (scalar)
        if (this.LocationId == null && ec.Includes("locationId",true))
        {
            this.LocationId = "FETCH";
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        if (this.Cluster == null && ec.Includes("cluster",false))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));
        }
    }


    #endregion

    } // class BlueprintCdmLocation
    
    #endregion

    public static class ListBlueprintCdmLocationExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<BlueprintCdmLocation> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<BlueprintCdmLocation> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BlueprintCdmLocation());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<BlueprintCdmLocation> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types