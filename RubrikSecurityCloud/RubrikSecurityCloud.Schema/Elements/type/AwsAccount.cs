// AwsAccount.cs
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
    #region AwsAccount
 
    public class AwsAccount: BaseType, CloudAccount
    {
        #region members

        //      C# -> CloudAccountType? CloudProvider
        // GraphQL -> cloudProvider: CloudAccountType! (enum)
        [JsonProperty("cloudProvider")]
        public CloudAccountType? CloudProvider { get; set; }

        //      C# -> ConnectionStatusType? ConnectionStatus
        // GraphQL -> connectionStatus: ConnectionStatusType! (enum)
        [JsonProperty("connectionStatus")]
        public ConnectionStatusType? ConnectionStatus { get; set; }

        //      C# -> System.String? AccessKey
        // GraphQL -> accessKey: String! (scalar)
        [JsonProperty("accessKey")]
        public System.String? AccessKey { get; set; }

        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: String! (scalar)
        [JsonProperty("cloudAccountId")]
        public System.String? CloudAccountId { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsAccount";
    }

    public AwsAccount Set(
        CloudAccountType? CloudProvider = null,
        ConnectionStatusType? ConnectionStatus = null,
        System.String? AccessKey = null,
        System.String? CloudAccountId = null,
        System.String? Description = null,
        System.String? Name = null
    ) 
    {
        if ( CloudProvider != null ) {
            this.CloudProvider = CloudProvider;
        }
        if ( ConnectionStatus != null ) {
            this.ConnectionStatus = ConnectionStatus;
        }
        if ( AccessKey != null ) {
            this.AccessKey = AccessKey;
        }
        if ( CloudAccountId != null ) {
            this.CloudAccountId = CloudAccountId;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( Name != null ) {
            this.Name = Name;
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
        //      C# -> CloudAccountType? CloudProvider
        // GraphQL -> cloudProvider: CloudAccountType! (enum)
        if (this.CloudProvider != null) {
            s += ind + "cloudProvider\n" ;
        }
        //      C# -> ConnectionStatusType? ConnectionStatus
        // GraphQL -> connectionStatus: ConnectionStatusType! (enum)
        if (this.ConnectionStatus != null) {
            s += ind + "connectionStatus\n" ;
        }
        //      C# -> System.String? AccessKey
        // GraphQL -> accessKey: String! (scalar)
        if (this.AccessKey != null) {
            s += ind + "accessKey\n" ;
        }
        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: String! (scalar)
        if (this.CloudAccountId != null) {
            s += ind + "cloudAccountId\n" ;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        if (this.Description != null) {
            s += ind + "description\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> CloudAccountType? CloudProvider
        // GraphQL -> cloudProvider: CloudAccountType! (enum)
        if (this.CloudProvider == null && Exploration.Includes(parent + ".cloudProvider", true))
        {
            this.CloudProvider = new CloudAccountType();
        }
        //      C# -> ConnectionStatusType? ConnectionStatus
        // GraphQL -> connectionStatus: ConnectionStatusType! (enum)
        if (this.ConnectionStatus == null && Exploration.Includes(parent + ".connectionStatus", true))
        {
            this.ConnectionStatus = new ConnectionStatusType();
        }
        //      C# -> System.String? AccessKey
        // GraphQL -> accessKey: String! (scalar)
        if (this.AccessKey == null && Exploration.Includes(parent + ".accessKey", true))
        {
            this.AccessKey = "FETCH";
        }
        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: String! (scalar)
        if (this.CloudAccountId == null && Exploration.Includes(parent + ".cloudAccountId", true))
        {
            this.CloudAccountId = "FETCH";
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
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
    }


    #endregion

    } // class AwsAccount
    
    #endregion

    public static class ListAwsAccountExtensions
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
            this List<AwsAccount> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AwsAccount> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsAccount());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types