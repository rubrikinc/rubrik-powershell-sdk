// CloudAccountSub.cs
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
    #region CloudAccountSub
    public class CloudAccountSub: BaseType
    {
        #region members

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? OwnerId
        // GraphQL -> ownerId: String! (scalar)
        [JsonProperty("ownerId")]
        public System.String? OwnerId { get; set; }

        //      C# -> System.String? SecurityGroupId
        // GraphQL -> securityGroupId: String! (scalar)
        [JsonProperty("securityGroupId")]
        public System.String? SecurityGroupId { get; set; }

        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        [JsonProperty("vpcId")]
        public System.String? VpcId { get; set; }


        #endregion

    #region methods

    public CloudAccountSub Set(
        System.String? Description = null,
        System.String? Name = null,
        System.String? OwnerId = null,
        System.String? SecurityGroupId = null,
        System.String? VpcId = null
    ) 
    {
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( OwnerId != null ) {
            this.OwnerId = OwnerId;
        }
        if ( SecurityGroupId != null ) {
            this.SecurityGroupId = SecurityGroupId;
        }
        if ( VpcId != null ) {
            this.VpcId = VpcId;
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
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            s += ind + "description\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? OwnerId
        // GraphQL -> ownerId: String! (scalar)
        if (this.OwnerId != null) {
            s += ind + "ownerId\n" ;
        }
        //      C# -> System.String? SecurityGroupId
        // GraphQL -> securityGroupId: String! (scalar)
        if (this.SecurityGroupId != null) {
            s += ind + "securityGroupId\n" ;
        }
        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        if (this.VpcId != null) {
            s += ind + "vpcId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description == null && Exploration.Includes(parent + ".description", true))
        {
            this.Description = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? OwnerId
        // GraphQL -> ownerId: String! (scalar)
        if (this.OwnerId == null && Exploration.Includes(parent + ".ownerId", true))
        {
            this.OwnerId = "FETCH";
        }
        //      C# -> System.String? SecurityGroupId
        // GraphQL -> securityGroupId: String! (scalar)
        if (this.SecurityGroupId == null && Exploration.Includes(parent + ".securityGroupId", true))
        {
            this.SecurityGroupId = "FETCH";
        }
        //      C# -> System.String? VpcId
        // GraphQL -> vpcId: String! (scalar)
        if (this.VpcId == null && Exploration.Includes(parent + ".vpcId", true))
        {
            this.VpcId = "FETCH";
        }
    }


    #endregion

    } // class CloudAccountSub
    
    #endregion

    public static class ListCloudAccountSubExtensions
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
            this List<CloudAccountSub> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CloudAccountSub> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudAccountSub());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types