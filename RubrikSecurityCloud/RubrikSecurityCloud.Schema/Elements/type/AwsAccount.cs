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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> CloudAccountType? CloudProvider
        // GraphQL -> cloudProvider: CloudAccountType! (enum)
        if (this.CloudProvider != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudProvider\n" ;
            } else {
                s += ind + "cloudProvider\n" ;
            }
        }
        //      C# -> ConnectionStatusType? ConnectionStatus
        // GraphQL -> connectionStatus: ConnectionStatusType! (enum)
        if (this.ConnectionStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "connectionStatus\n" ;
            } else {
                s += ind + "connectionStatus\n" ;
            }
        }
        //      C# -> System.String? AccessKey
        // GraphQL -> accessKey: String! (scalar)
        if (this.AccessKey != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accessKey\n" ;
            } else {
                s += ind + "accessKey\n" ;
            }
        }
        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: String! (scalar)
        if (this.CloudAccountId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudAccountId\n" ;
            } else {
                s += ind + "cloudAccountId\n" ;
            }
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        if (this.Description != null) {
            if (conf.Flat) {
                s += conf.Prefix + "description\n" ;
            } else {
                s += ind + "description\n" ;
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CloudAccountType? CloudProvider
        // GraphQL -> cloudProvider: CloudAccountType! (enum)
        if (ec.Includes("cloudProvider",true))
        {
            if(this.CloudProvider == null) {

                this.CloudProvider = new CloudAccountType();

            } else {


            }
        }
        else if (this.CloudProvider != null && ec.Excludes("cloudProvider",true))
        {
            this.CloudProvider = null;
        }
        //      C# -> ConnectionStatusType? ConnectionStatus
        // GraphQL -> connectionStatus: ConnectionStatusType! (enum)
        if (ec.Includes("connectionStatus",true))
        {
            if(this.ConnectionStatus == null) {

                this.ConnectionStatus = new ConnectionStatusType();

            } else {


            }
        }
        else if (this.ConnectionStatus != null && ec.Excludes("connectionStatus",true))
        {
            this.ConnectionStatus = null;
        }
        //      C# -> System.String? AccessKey
        // GraphQL -> accessKey: String! (scalar)
        if (ec.Includes("accessKey",true))
        {
            if(this.AccessKey == null) {

                this.AccessKey = "FETCH";

            } else {


            }
        }
        else if (this.AccessKey != null && ec.Excludes("accessKey",true))
        {
            this.AccessKey = null;
        }
        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: String! (scalar)
        if (ec.Includes("cloudAccountId",true))
        {
            if(this.CloudAccountId == null) {

                this.CloudAccountId = "FETCH";

            } else {


            }
        }
        else if (this.CloudAccountId != null && ec.Excludes("cloudAccountId",true))
        {
            this.CloudAccountId = null;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        if (ec.Includes("description",true))
        {
            if(this.Description == null) {

                this.Description = "FETCH";

            } else {


            }
        }
        else if (this.Description != null && ec.Excludes("description",true))
        {
            this.Description = null;
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
    }


    #endregion

    } // class AwsAccount
    
    #endregion

    public static class ListAwsAccountExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<AwsAccount> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsAccount> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsAccount> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsAccount());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsAccount> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types