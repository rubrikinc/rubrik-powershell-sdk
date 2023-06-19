// CheckGuestOsResult.cs
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
    #region CheckGuestOsResult
    public class CheckGuestOsResult: BaseType
    {
        #region members

        //      C# -> GuestOs? InstanceOs
        // GraphQL -> instanceOs: GuestOS! (enum)
        [JsonProperty("instanceOs")]
        public GuestOs? InstanceOs { get; set; }

        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String! (scalar)
        [JsonProperty("errorMessage")]
        public System.String? ErrorMessage { get; set; }

        //      C# -> System.String? InstanceId
        // GraphQL -> instanceId: String! (scalar)
        [JsonProperty("instanceId")]
        public System.String? InstanceId { get; set; }

        //      C# -> System.String? InstanceType
        // GraphQL -> instanceType: String! (scalar)
        [JsonProperty("instanceType")]
        public System.String? InstanceType { get; set; }

        //      C# -> VsphereVm? Instance
        // GraphQL -> instance: VsphereVm! (type)
        [JsonProperty("instance")]
        public VsphereVm? Instance { get; set; }


        #endregion

    #region methods

    public CheckGuestOsResult Set(
        GuestOs? InstanceOs = null,
        System.String? ErrorMessage = null,
        System.String? InstanceId = null,
        System.String? InstanceType = null,
        VsphereVm? Instance = null
    ) 
    {
        if ( InstanceOs != null ) {
            this.InstanceOs = InstanceOs;
        }
        if ( ErrorMessage != null ) {
            this.ErrorMessage = ErrorMessage;
        }
        if ( InstanceId != null ) {
            this.InstanceId = InstanceId;
        }
        if ( InstanceType != null ) {
            this.InstanceType = InstanceType;
        }
        if ( Instance != null ) {
            this.Instance = Instance;
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
        //      C# -> GuestOs? InstanceOs
        // GraphQL -> instanceOs: GuestOS! (enum)
        if (this.InstanceOs != null) {
            s += ind + "instanceOs\n" ;
        }
        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String! (scalar)
        if (this.ErrorMessage != null) {
            s += ind + "errorMessage\n" ;
        }
        //      C# -> System.String? InstanceId
        // GraphQL -> instanceId: String! (scalar)
        if (this.InstanceId != null) {
            s += ind + "instanceId\n" ;
        }
        //      C# -> System.String? InstanceType
        // GraphQL -> instanceType: String! (scalar)
        if (this.InstanceType != null) {
            s += ind + "instanceType\n" ;
        }
        //      C# -> VsphereVm? Instance
        // GraphQL -> instance: VsphereVm! (type)
        if (this.Instance != null) {
            var fspec = this.Instance.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "instance {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> GuestOs? InstanceOs
        // GraphQL -> instanceOs: GuestOS! (enum)
        if (this.InstanceOs == null && Exploration.Includes(parent + ".instanceOs", true))
        {
            this.InstanceOs = new GuestOs();
        }
        //      C# -> System.String? ErrorMessage
        // GraphQL -> errorMessage: String! (scalar)
        if (this.ErrorMessage == null && Exploration.Includes(parent + ".errorMessage", true))
        {
            this.ErrorMessage = "FETCH";
        }
        //      C# -> System.String? InstanceId
        // GraphQL -> instanceId: String! (scalar)
        if (this.InstanceId == null && Exploration.Includes(parent + ".instanceId", true))
        {
            this.InstanceId = "FETCH";
        }
        //      C# -> System.String? InstanceType
        // GraphQL -> instanceType: String! (scalar)
        if (this.InstanceType == null && Exploration.Includes(parent + ".instanceType", true))
        {
            this.InstanceType = "FETCH";
        }
        //      C# -> VsphereVm? Instance
        // GraphQL -> instance: VsphereVm! (type)
        if (this.Instance == null && Exploration.Includes(parent + ".instance"))
        {
            this.Instance = new VsphereVm();
            this.Instance.ApplyExploratoryFieldSpec(parent + ".instance");
        }
    }


    #endregion

    } // class CheckGuestOsResult
    
    #endregion

    public static class ListCheckGuestOsResultExtensions
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
            this List<CheckGuestOsResult> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CheckGuestOsResult> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CheckGuestOsResult());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types