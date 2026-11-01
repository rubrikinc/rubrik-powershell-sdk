// AwsPermissionDiffEntry.cs
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
    #region AwsPermissionDiffEntry
    public class AwsPermissionDiffEntry: BaseType
    {
        #region members

        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        [JsonProperty("feature")]
        public CloudAccountFeature? Feature { get; set; }

        //      C# -> PermissionsGroup? PermissionsGroup
        // GraphQL -> permissionsGroup: PermissionsGroup! (enum)
        [JsonProperty("permissionsGroup")]
        public PermissionsGroup? PermissionsGroup { get; set; }

        //      C# -> AwsPermissionDiffStatus? Status
        // GraphQL -> status: AwsPermissionDiffStatus! (enum)
        [JsonProperty("status")]
        public AwsPermissionDiffStatus? Status { get; set; }

        //      C# -> System.String? IamRoleName
        // GraphQL -> iamRoleName: String! (scalar)
        [JsonProperty("iamRoleName")]
        public System.String? IamRoleName { get; set; }

        //      C# -> List<AwsPermissionStatement>? Added
        // GraphQL -> added: [AwsPermissionStatement!]! (type)
        [JsonProperty("added")]
        public List<AwsPermissionStatement>? Added { get; set; }

        //      C# -> List<AwsPermissionStatement>? Existing
        // GraphQL -> existing: [AwsPermissionStatement!]! (type)
        [JsonProperty("existing")]
        public List<AwsPermissionStatement>? Existing { get; set; }

        //      C# -> List<AwsPermissionModification>? Modified
        // GraphQL -> modified: [AwsPermissionModification!]! (type)
        [JsonProperty("modified")]
        public List<AwsPermissionModification>? Modified { get; set; }

        //      C# -> List<AwsPermissionStatement>? Removed
        // GraphQL -> removed: [AwsPermissionStatement!]! (type)
        [JsonProperty("removed")]
        public List<AwsPermissionStatement>? Removed { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsPermissionDiffEntry";
    }

    public AwsPermissionDiffEntry Set(
        CloudAccountFeature? Feature = null,
        PermissionsGroup? PermissionsGroup = null,
        AwsPermissionDiffStatus? Status = null,
        System.String? IamRoleName = null,
        List<AwsPermissionStatement>? Added = null,
        List<AwsPermissionStatement>? Existing = null,
        List<AwsPermissionModification>? Modified = null,
        List<AwsPermissionStatement>? Removed = null
    ) 
    {
        if ( Feature != null ) {
            this.Feature = Feature;
        }
        if ( PermissionsGroup != null ) {
            this.PermissionsGroup = PermissionsGroup;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( IamRoleName != null ) {
            this.IamRoleName = IamRoleName;
        }
        if ( Added != null ) {
            this.Added = Added;
        }
        if ( Existing != null ) {
            this.Existing = Existing;
        }
        if ( Modified != null ) {
            this.Modified = Modified;
        }
        if ( Removed != null ) {
            this.Removed = Removed;
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
        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        if (this.Feature != null) {
            if (conf.Flat) {
                s += conf.Prefix + "feature\n" ;
            } else {
                s += ind + "feature\n" ;
            }
        }
        //      C# -> PermissionsGroup? PermissionsGroup
        // GraphQL -> permissionsGroup: PermissionsGroup! (enum)
        if (this.PermissionsGroup != null) {
            if (conf.Flat) {
                s += conf.Prefix + "permissionsGroup\n" ;
            } else {
                s += ind + "permissionsGroup\n" ;
            }
        }
        //      C# -> AwsPermissionDiffStatus? Status
        // GraphQL -> status: AwsPermissionDiffStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? IamRoleName
        // GraphQL -> iamRoleName: String! (scalar)
        if (this.IamRoleName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "iamRoleName\n" ;
            } else {
                s += ind + "iamRoleName\n" ;
            }
        }
        //      C# -> List<AwsPermissionStatement>? Added
        // GraphQL -> added: [AwsPermissionStatement!]! (type)
        if (this.Added != null) {
            var fspec = this.Added.AsFieldSpec(conf.Child("added"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "added" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<AwsPermissionStatement>? Existing
        // GraphQL -> existing: [AwsPermissionStatement!]! (type)
        if (this.Existing != null) {
            var fspec = this.Existing.AsFieldSpec(conf.Child("existing"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "existing" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<AwsPermissionModification>? Modified
        // GraphQL -> modified: [AwsPermissionModification!]! (type)
        if (this.Modified != null) {
            var fspec = this.Modified.AsFieldSpec(conf.Child("modified"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "modified" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<AwsPermissionStatement>? Removed
        // GraphQL -> removed: [AwsPermissionStatement!]! (type)
        if (this.Removed != null) {
            var fspec = this.Removed.AsFieldSpec(conf.Child("removed"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "removed" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> CloudAccountFeature? Feature
        // GraphQL -> feature: CloudAccountFeature! (enum)
        if (ec.Includes("feature",true))
        {
            if(this.Feature == null) {

                this.Feature = new CloudAccountFeature();

            } else {


            }
        }
        else if (this.Feature != null && ec.Excludes("feature",true))
        {
            this.Feature = null;
        }
        //      C# -> PermissionsGroup? PermissionsGroup
        // GraphQL -> permissionsGroup: PermissionsGroup! (enum)
        if (ec.Includes("permissionsGroup",true))
        {
            if(this.PermissionsGroup == null) {

                this.PermissionsGroup = new PermissionsGroup();

            } else {


            }
        }
        else if (this.PermissionsGroup != null && ec.Excludes("permissionsGroup",true))
        {
            this.PermissionsGroup = null;
        }
        //      C# -> AwsPermissionDiffStatus? Status
        // GraphQL -> status: AwsPermissionDiffStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new AwsPermissionDiffStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? IamRoleName
        // GraphQL -> iamRoleName: String! (scalar)
        if (ec.Includes("iamRoleName",true))
        {
            if(this.IamRoleName == null) {

                this.IamRoleName = "FETCH";

            } else {


            }
        }
        else if (this.IamRoleName != null && ec.Excludes("iamRoleName",true))
        {
            this.IamRoleName = null;
        }
        //      C# -> List<AwsPermissionStatement>? Added
        // GraphQL -> added: [AwsPermissionStatement!]! (type)
        if (ec.Includes("added",false))
        {
            if(this.Added == null) {

                this.Added = new List<AwsPermissionStatement>();
                this.Added.ApplyExploratoryFieldSpec(ec.NewChild("added"));

            } else {

                this.Added.ApplyExploratoryFieldSpec(ec.NewChild("added"));

            }
        }
        else if (this.Added != null && ec.Excludes("added",false))
        {
            this.Added = null;
        }
        //      C# -> List<AwsPermissionStatement>? Existing
        // GraphQL -> existing: [AwsPermissionStatement!]! (type)
        if (ec.Includes("existing",false))
        {
            if(this.Existing == null) {

                this.Existing = new List<AwsPermissionStatement>();
                this.Existing.ApplyExploratoryFieldSpec(ec.NewChild("existing"));

            } else {

                this.Existing.ApplyExploratoryFieldSpec(ec.NewChild("existing"));

            }
        }
        else if (this.Existing != null && ec.Excludes("existing",false))
        {
            this.Existing = null;
        }
        //      C# -> List<AwsPermissionModification>? Modified
        // GraphQL -> modified: [AwsPermissionModification!]! (type)
        if (ec.Includes("modified",false))
        {
            if(this.Modified == null) {

                this.Modified = new List<AwsPermissionModification>();
                this.Modified.ApplyExploratoryFieldSpec(ec.NewChild("modified"));

            } else {

                this.Modified.ApplyExploratoryFieldSpec(ec.NewChild("modified"));

            }
        }
        else if (this.Modified != null && ec.Excludes("modified",false))
        {
            this.Modified = null;
        }
        //      C# -> List<AwsPermissionStatement>? Removed
        // GraphQL -> removed: [AwsPermissionStatement!]! (type)
        if (ec.Includes("removed",false))
        {
            if(this.Removed == null) {

                this.Removed = new List<AwsPermissionStatement>();
                this.Removed.ApplyExploratoryFieldSpec(ec.NewChild("removed"));

            } else {

                this.Removed.ApplyExploratoryFieldSpec(ec.NewChild("removed"));

            }
        }
        else if (this.Removed != null && ec.Excludes("removed",false))
        {
            this.Removed = null;
        }
    }


    #endregion

    } // class AwsPermissionDiffEntry
    
    #endregion

    public static class ListAwsPermissionDiffEntryExtensions
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
            this List<AwsPermissionDiffEntry> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsPermissionDiffEntry> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsPermissionDiffEntry> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsPermissionDiffEntry());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsPermissionDiffEntry> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types