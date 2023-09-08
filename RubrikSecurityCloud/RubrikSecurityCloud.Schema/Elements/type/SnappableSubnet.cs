// SnappableSubnet.cs
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
    #region SnappableSubnet
    public class SnappableSubnet: BaseType
    {
        #region members

        //      C# -> System.String? AvailabilityZone
        // GraphQL -> availabilityZone: String! (scalar)
        [JsonProperty("availabilityZone")]
        public System.String? AvailabilityZone { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? SubnetId
        // GraphQL -> subnetId: String! (scalar)
        [JsonProperty("subnetId")]
        public System.String? SubnetId { get; set; }

        //      C# -> AddressBlockV4? CidrBlock
        // GraphQL -> cidrBlock: AddressBlockV4 (type)
        [JsonProperty("cidrBlock")]
        public AddressBlockV4? CidrBlock { get; set; }

        //      C# -> Vpc? Vpc
        // GraphQL -> vpc: Vpc (type)
        [JsonProperty("vpc")]
        public Vpc? Vpc { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SnappableSubnet";
    }

    public SnappableSubnet Set(
        System.String? AvailabilityZone = null,
        System.String? Id = null,
        System.String? Name = null,
        System.String? SubnetId = null,
        AddressBlockV4? CidrBlock = null,
        Vpc? Vpc = null
    ) 
    {
        if ( AvailabilityZone != null ) {
            this.AvailabilityZone = AvailabilityZone;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( SubnetId != null ) {
            this.SubnetId = SubnetId;
        }
        if ( CidrBlock != null ) {
            this.CidrBlock = CidrBlock;
        }
        if ( Vpc != null ) {
            this.Vpc = Vpc;
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
        //      C# -> System.String? AvailabilityZone
        // GraphQL -> availabilityZone: String! (scalar)
        if (this.AvailabilityZone != null) {
            s += ind + "availabilityZone\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? SubnetId
        // GraphQL -> subnetId: String! (scalar)
        if (this.SubnetId != null) {
            s += ind + "subnetId\n" ;
        }
        //      C# -> AddressBlockV4? CidrBlock
        // GraphQL -> cidrBlock: AddressBlockV4 (type)
        if (this.CidrBlock != null) {
            var fspec = this.CidrBlock.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cidrBlock {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> Vpc? Vpc
        // GraphQL -> vpc: Vpc (type)
        if (this.Vpc != null) {
            var fspec = this.Vpc.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "vpc {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? AvailabilityZone
        // GraphQL -> availabilityZone: String! (scalar)
        if (this.AvailabilityZone == null && ec.Includes("availabilityZone",true))
        {
            this.AvailabilityZone = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? SubnetId
        // GraphQL -> subnetId: String! (scalar)
        if (this.SubnetId == null && ec.Includes("subnetId",true))
        {
            this.SubnetId = "FETCH";
        }
        //      C# -> AddressBlockV4? CidrBlock
        // GraphQL -> cidrBlock: AddressBlockV4 (type)
        if (this.CidrBlock == null && ec.Includes("cidrBlock",false))
        {
            this.CidrBlock = new AddressBlockV4();
            this.CidrBlock.ApplyExploratoryFieldSpec(ec.NewChild("cidrBlock"));
        }
        //      C# -> Vpc? Vpc
        // GraphQL -> vpc: Vpc (type)
        if (this.Vpc == null && ec.Includes("vpc",false))
        {
            this.Vpc = new Vpc();
            this.Vpc.ApplyExploratoryFieldSpec(ec.NewChild("vpc"));
        }
    }


    #endregion

    } // class SnappableSubnet
    
    #endregion

    public static class ListSnappableSubnetExtensions
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
            this List<SnappableSubnet> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SnappableSubnet> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SnappableSubnet());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<SnappableSubnet> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types