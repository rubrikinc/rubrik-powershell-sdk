// AwsNativeRoot.cs
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
    #region AwsNativeRoot
    public class AwsNativeRoot: BaseType
    {
        #region members

        //      C# -> AwsNativeHierarchyObjectConnection? ObjectTypeDescendantConnection
        // GraphQL -> objectTypeDescendantConnection: AwsNativeHierarchyObjectConnection! (type)
        [JsonProperty("objectTypeDescendantConnection")]
        public AwsNativeHierarchyObjectConnection? ObjectTypeDescendantConnection { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsNativeRoot";
    }

    public AwsNativeRoot Set(
        AwsNativeHierarchyObjectConnection? ObjectTypeDescendantConnection = null
    ) 
    {
        if ( ObjectTypeDescendantConnection != null ) {
            this.ObjectTypeDescendantConnection = ObjectTypeDescendantConnection;
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
        //      C# -> AwsNativeHierarchyObjectConnection? ObjectTypeDescendantConnection
        // GraphQL -> objectTypeDescendantConnection: AwsNativeHierarchyObjectConnection! (type)
        if (this.ObjectTypeDescendantConnection != null) {
            var fspec = this.ObjectTypeDescendantConnection.AsFieldSpec(conf.Child("objectTypeDescendantConnection"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "objectTypeDescendantConnection {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AwsNativeHierarchyObjectConnection? ObjectTypeDescendantConnection
        // GraphQL -> objectTypeDescendantConnection: AwsNativeHierarchyObjectConnection! (type)
        if (ec.Includes("objectTypeDescendantConnection",false))
        {
            if(this.ObjectTypeDescendantConnection == null) {

                this.ObjectTypeDescendantConnection = new AwsNativeHierarchyObjectConnection();
                this.ObjectTypeDescendantConnection.ApplyExploratoryFieldSpec(ec.NewChild("objectTypeDescendantConnection"));

            } else {

                this.ObjectTypeDescendantConnection.ApplyExploratoryFieldSpec(ec.NewChild("objectTypeDescendantConnection"));

            }
        }
        else if (this.ObjectTypeDescendantConnection != null && ec.Excludes("objectTypeDescendantConnection",false))
        {
            this.ObjectTypeDescendantConnection = null;
        }
    }


    #endregion

    } // class AwsNativeRoot
    
    #endregion

    public static class ListAwsNativeRootExtensions
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
            this List<AwsNativeRoot> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AwsNativeRoot> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsNativeRoot());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsNativeRoot> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types