// Object.cs
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
    #region Object
    public class Object: BaseType
    {
        #region members

        //      C# -> AzureAdGroup? AzureAdGroup
        // GraphQL -> azureAdGroup: AzureAdGroup (type)
        [JsonProperty("azureAdGroup")]
        public AzureAdGroup? AzureAdGroup { get; set; }

        //      C# -> AzureAdUser? AzureAdUser
        // GraphQL -> azureAdUser: AzureAdUser (type)
        [JsonProperty("azureAdUser")]
        public AzureAdUser? AzureAdUser { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Object";
    }

    public Object Set(
        AzureAdGroup? AzureAdGroup = null,
        AzureAdUser? AzureAdUser = null
    ) 
    {
        if ( AzureAdGroup != null ) {
            this.AzureAdGroup = AzureAdGroup;
        }
        if ( AzureAdUser != null ) {
            this.AzureAdUser = AzureAdUser;
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
        //      C# -> AzureAdGroup? AzureAdGroup
        // GraphQL -> azureAdGroup: AzureAdGroup (type)
        if (this.AzureAdGroup != null) {
            var fspec = this.AzureAdGroup.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "azureAdGroup {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> AzureAdUser? AzureAdUser
        // GraphQL -> azureAdUser: AzureAdUser (type)
        if (this.AzureAdUser != null) {
            var fspec = this.AzureAdUser.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "azureAdUser {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> AzureAdGroup? AzureAdGroup
        // GraphQL -> azureAdGroup: AzureAdGroup (type)
        if (this.AzureAdGroup == null && Exploration.Includes(parent + ".azureAdGroup"))
        {
            this.AzureAdGroup = new AzureAdGroup();
            this.AzureAdGroup.ApplyExploratoryFieldSpec(parent + ".azureAdGroup");
        }
        //      C# -> AzureAdUser? AzureAdUser
        // GraphQL -> azureAdUser: AzureAdUser (type)
        if (this.AzureAdUser == null && Exploration.Includes(parent + ".azureAdUser"))
        {
            this.AzureAdUser = new AzureAdUser();
            this.AzureAdUser.ApplyExploratoryFieldSpec(parent + ".azureAdUser");
        }
    }


    #endregion

    } // class Object
    
    #endregion

    public static class ListObjectExtensions
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
            this List<Object> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Object> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new Object());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types