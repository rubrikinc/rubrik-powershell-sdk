// RbacPermission.cs
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
    #region RbacPermission
    public class RbacPermission: BaseType
    {
        #region members

        //      C# -> List<Operation>? Operations
        // GraphQL -> operations: [Operation!]! (enum)
        [JsonProperty("operations")]
        public List<Operation>? Operations { get; set; }

        //      C# -> RbacObject? RbacObject
        // GraphQL -> rbacObject: RbacObject! (type)
        [JsonProperty("rbacObject")]
        public RbacObject? RbacObject { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RbacPermission";
    }

    public RbacPermission Set(
        List<Operation>? Operations = null,
        RbacObject? RbacObject = null
    ) 
    {
        if ( Operations != null ) {
            this.Operations = Operations;
        }
        if ( RbacObject != null ) {
            this.RbacObject = RbacObject;
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
        //      C# -> List<Operation>? Operations
        // GraphQL -> operations: [Operation!]! (enum)
        if (this.Operations != null) {
            if (conf.Flat) {
                s += conf.Prefix + "operations\n" ;
            } else {
                s += ind + "operations\n" ;
            }
        }
        //      C# -> RbacObject? RbacObject
        // GraphQL -> rbacObject: RbacObject! (type)
        if (this.RbacObject != null) {
            var fspec = this.RbacObject.AsFieldSpec(conf.Child("rbacObject"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "rbacObject {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<Operation>? Operations
        // GraphQL -> operations: [Operation!]! (enum)
        if (ec.Includes("operations",true))
        {
            if(this.Operations == null) {

                this.Operations = new List<Operation>();

            } else {


            }
        }
        else if (this.Operations != null && ec.Excludes("operations",true))
        {
            this.Operations = null;
        }
        //      C# -> RbacObject? RbacObject
        // GraphQL -> rbacObject: RbacObject! (type)
        if (ec.Includes("rbacObject",false))
        {
            if(this.RbacObject == null) {

                this.RbacObject = new RbacObject();
                this.RbacObject.ApplyExploratoryFieldSpec(ec.NewChild("rbacObject"));

            } else {

                this.RbacObject.ApplyExploratoryFieldSpec(ec.NewChild("rbacObject"));

            }
        }
        else if (this.RbacObject != null && ec.Excludes("rbacObject",false))
        {
            this.RbacObject = null;
        }
    }


    #endregion

    } // class RbacPermission
    
    #endregion

    public static class ListRbacPermissionExtensions
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
            this List<RbacPermission> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RbacPermission> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RbacPermission());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RbacPermission> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types