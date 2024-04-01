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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<RbacPermission> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RbacPermission> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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