// AwsEc2Instance.cs
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
    #region AwsEc2Instance
    public class AwsEc2Instance: BaseType
    {
        #region members

        //      C# -> System.String? ImageId
        // GraphQL -> imageId: String! (scalar)
        [JsonProperty("imageId")]
        public System.String? ImageId { get; set; }

        //      C# -> System.String? InstanceId
        // GraphQL -> instanceId: String! (scalar)
        [JsonProperty("instanceId")]
        public System.String? InstanceId { get; set; }

        //      C# -> System.String? InstanceName
        // GraphQL -> instanceName: String! (scalar)
        [JsonProperty("instanceName")]
        public System.String? InstanceName { get; set; }

        //      C# -> System.String? InstanceType
        // GraphQL -> instanceType: String! (scalar)
        [JsonProperty("instanceType")]
        public System.String? InstanceType { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsEc2Instance";
    }

    public AwsEc2Instance Set(
        System.String? ImageId = null,
        System.String? InstanceId = null,
        System.String? InstanceName = null,
        System.String? InstanceType = null
    ) 
    {
        if ( ImageId != null ) {
            this.ImageId = ImageId;
        }
        if ( InstanceId != null ) {
            this.InstanceId = InstanceId;
        }
        if ( InstanceName != null ) {
            this.InstanceName = InstanceName;
        }
        if ( InstanceType != null ) {
            this.InstanceType = InstanceType;
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
        //      C# -> System.String? ImageId
        // GraphQL -> imageId: String! (scalar)
        if (this.ImageId != null) {
            s += ind + "imageId\n" ;
        }
        //      C# -> System.String? InstanceId
        // GraphQL -> instanceId: String! (scalar)
        if (this.InstanceId != null) {
            s += ind + "instanceId\n" ;
        }
        //      C# -> System.String? InstanceName
        // GraphQL -> instanceName: String! (scalar)
        if (this.InstanceName != null) {
            s += ind + "instanceName\n" ;
        }
        //      C# -> System.String? InstanceType
        // GraphQL -> instanceType: String! (scalar)
        if (this.InstanceType != null) {
            s += ind + "instanceType\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? ImageId
        // GraphQL -> imageId: String! (scalar)
        if (this.ImageId == null && Exploration.Includes(parent + ".imageId", true))
        {
            this.ImageId = "FETCH";
        }
        //      C# -> System.String? InstanceId
        // GraphQL -> instanceId: String! (scalar)
        if (this.InstanceId == null && Exploration.Includes(parent + ".instanceId", true))
        {
            this.InstanceId = "FETCH";
        }
        //      C# -> System.String? InstanceName
        // GraphQL -> instanceName: String! (scalar)
        if (this.InstanceName == null && Exploration.Includes(parent + ".instanceName", true))
        {
            this.InstanceName = "FETCH";
        }
        //      C# -> System.String? InstanceType
        // GraphQL -> instanceType: String! (scalar)
        if (this.InstanceType == null && Exploration.Includes(parent + ".instanceType", true))
        {
            this.InstanceType = "FETCH";
        }
    }


    #endregion

    } // class AwsEc2Instance
    
    #endregion

    public static class ListAwsEc2InstanceExtensions
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
            this List<AwsEc2Instance> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AwsEc2Instance> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsEc2Instance());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types