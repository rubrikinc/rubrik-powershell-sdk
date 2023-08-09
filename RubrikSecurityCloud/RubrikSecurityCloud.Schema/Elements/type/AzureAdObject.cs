// AzureAdObject.cs
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
    #region AzureAdObject
    public class AzureAdObject: BaseType
    {
        #region members

        //      C# -> AzureAdObjectType? Type
        // GraphQL -> type: AzureAdObjectType! (enum)
        [JsonProperty("type")]
        public AzureAdObjectType? Type { get; set; }

        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        [JsonProperty("objectId")]
        public System.String? ObjectId { get; set; }

        //      C# -> Object? Object
        // GraphQL -> object: Object! (type)
        [JsonProperty("object")]
        public Object? Object { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureAdObject";
    }

    public AzureAdObject Set(
        AzureAdObjectType? Type = null,
        System.String? ObjectId = null,
        Object? Object = null
    ) 
    {
        if ( Type != null ) {
            this.Type = Type;
        }
        if ( ObjectId != null ) {
            this.ObjectId = ObjectId;
        }
        if ( Object != null ) {
            this.Object = Object;
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
        //      C# -> AzureAdObjectType? Type
        // GraphQL -> type: AzureAdObjectType! (enum)
        if (this.Type != null) {
            s += ind + "type\n" ;
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (this.ObjectId != null) {
            s += ind + "objectId\n" ;
        }
        //      C# -> Object? Object
        // GraphQL -> object: Object! (type)
        if (this.Object != null) {
            var fspec = this.Object.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "object {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> AzureAdObjectType? Type
        // GraphQL -> type: AzureAdObjectType! (enum)
        if (this.Type == null && Exploration.Includes(parent + ".type", true))
        {
            this.Type = new AzureAdObjectType();
        }
        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        if (this.ObjectId == null && Exploration.Includes(parent + ".objectId", true))
        {
            this.ObjectId = "FETCH";
        }
        //      C# -> Object? Object
        // GraphQL -> object: Object! (type)
        if (this.Object == null && Exploration.Includes(parent + ".object"))
        {
            this.Object = new Object();
            this.Object.ApplyExploratoryFieldSpec(parent + ".object");
        }
    }


    #endregion

    } // class AzureAdObject
    
    #endregion

    public static class ListAzureAdObjectExtensions
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
            this List<AzureAdObject> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureAdObject> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureAdObject());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types