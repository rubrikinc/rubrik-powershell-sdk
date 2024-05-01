// GcpCloudAccountMissingPermissionsForAddition.cs
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
    #region GcpCloudAccountMissingPermissionsForAddition
    public class GcpCloudAccountMissingPermissionsForAddition: BaseType
    {
        #region members

        //      C# -> List<System.String>? MissingPermissions
        // GraphQL -> missingPermissions: [String!]! (scalar)
        [JsonProperty("missingPermissions")]
        public List<System.String>? MissingPermissions { get; set; }

        //      C# -> System.String? ProjectId
        // GraphQL -> projectId: String! (scalar)
        [JsonProperty("projectId")]
        public System.String? ProjectId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GcpCloudAccountMissingPermissionsForAddition";
    }

    public GcpCloudAccountMissingPermissionsForAddition Set(
        List<System.String>? MissingPermissions = null,
        System.String? ProjectId = null
    ) 
    {
        if ( MissingPermissions != null ) {
            this.MissingPermissions = MissingPermissions;
        }
        if ( ProjectId != null ) {
            this.ProjectId = ProjectId;
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
        //      C# -> List<System.String>? MissingPermissions
        // GraphQL -> missingPermissions: [String!]! (scalar)
        if (this.MissingPermissions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "missingPermissions\n" ;
            } else {
                s += ind + "missingPermissions\n" ;
            }
        }
        //      C# -> System.String? ProjectId
        // GraphQL -> projectId: String! (scalar)
        if (this.ProjectId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "projectId\n" ;
            } else {
                s += ind + "projectId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? MissingPermissions
        // GraphQL -> missingPermissions: [String!]! (scalar)
        if (ec.Includes("missingPermissions",true))
        {
            if(this.MissingPermissions == null) {

                this.MissingPermissions = new List<System.String>();

            } else {


            }
        }
        else if (this.MissingPermissions != null && ec.Excludes("missingPermissions",true))
        {
            this.MissingPermissions = null;
        }
        //      C# -> System.String? ProjectId
        // GraphQL -> projectId: String! (scalar)
        if (ec.Includes("projectId",true))
        {
            if(this.ProjectId == null) {

                this.ProjectId = "FETCH";

            } else {


            }
        }
        else if (this.ProjectId != null && ec.Excludes("projectId",true))
        {
            this.ProjectId = null;
        }
    }


    #endregion

    } // class GcpCloudAccountMissingPermissionsForAddition
    
    #endregion

    public static class ListGcpCloudAccountMissingPermissionsForAdditionExtensions
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
            this List<GcpCloudAccountMissingPermissionsForAddition> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GcpCloudAccountMissingPermissionsForAddition> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GcpCloudAccountMissingPermissionsForAddition> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GcpCloudAccountMissingPermissionsForAddition());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GcpCloudAccountMissingPermissionsForAddition> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types