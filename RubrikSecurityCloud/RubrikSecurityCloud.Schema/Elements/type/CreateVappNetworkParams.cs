// CreateVappNetworkParams.cs
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
    #region CreateVappNetworkParams
    public class CreateVappNetworkParams: BaseType
    {
        #region members

        //      C# -> System.String? NewName
        // GraphQL -> newName: String (scalar)
        [JsonProperty("newName")]
        public System.String? NewName { get; set; }

        //      C# -> VappNetworkSummary? VappNetworkSummary
        // GraphQL -> vappNetworkSummary: VappNetworkSummary (type)
        [JsonProperty("vappNetworkSummary")]
        public VappNetworkSummary? VappNetworkSummary { get; set; }


        #endregion

    #region methods

    public CreateVappNetworkParams Set(
        System.String? NewName = null,
        VappNetworkSummary? VappNetworkSummary = null
    ) 
    {
        if ( NewName != null ) {
            this.NewName = NewName;
        }
        if ( VappNetworkSummary != null ) {
            this.VappNetworkSummary = VappNetworkSummary;
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
        //      C# -> System.String? NewName
        // GraphQL -> newName: String (scalar)
        if (this.NewName != null) {
            s += ind + "newName\n" ;
        }
        //      C# -> VappNetworkSummary? VappNetworkSummary
        // GraphQL -> vappNetworkSummary: VappNetworkSummary (type)
        if (this.VappNetworkSummary != null) {
            var fspec = this.VappNetworkSummary.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "vappNetworkSummary {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? NewName
        // GraphQL -> newName: String (scalar)
        if (this.NewName == null && Exploration.Includes(parent + ".newName", true))
        {
            this.NewName = "FETCH";
        }
        //      C# -> VappNetworkSummary? VappNetworkSummary
        // GraphQL -> vappNetworkSummary: VappNetworkSummary (type)
        if (this.VappNetworkSummary == null && Exploration.Includes(parent + ".vappNetworkSummary"))
        {
            this.VappNetworkSummary = new VappNetworkSummary();
            this.VappNetworkSummary.ApplyExploratoryFieldSpec(parent + ".vappNetworkSummary");
        }
    }


    #endregion

    } // class CreateVappNetworkParams
    
    #endregion

    public static class ListCreateVappNetworkParamsExtensions
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
            this List<CreateVappNetworkParams> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CreateVappNetworkParams> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CreateVappNetworkParams());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types