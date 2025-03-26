// AwsIamPairsWithMissingPermission.cs
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
    #region AwsIamPairsWithMissingPermission
    public class AwsIamPairsWithMissingPermission: BaseType
    {
        #region members

        //      C# -> List<PermissionsGroup>? MissingPermissionsGroups
        // GraphQL -> missingPermissionsGroups: [PermissionsGroup!]! (enum)
        [JsonProperty("missingPermissionsGroups")]
        public List<PermissionsGroup>? MissingPermissionsGroups { get; set; }

        //      C# -> AwsIamPair? AwsIamPair
        // GraphQL -> awsIamPair: AwsIamPair! (type)
        [JsonProperty("awsIamPair")]
        public AwsIamPair? AwsIamPair { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsIamPairsWithMissingPermission";
    }

    public AwsIamPairsWithMissingPermission Set(
        List<PermissionsGroup>? MissingPermissionsGroups = null,
        AwsIamPair? AwsIamPair = null
    ) 
    {
        if ( MissingPermissionsGroups != null ) {
            this.MissingPermissionsGroups = MissingPermissionsGroups;
        }
        if ( AwsIamPair != null ) {
            this.AwsIamPair = AwsIamPair;
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
        //      C# -> List<PermissionsGroup>? MissingPermissionsGroups
        // GraphQL -> missingPermissionsGroups: [PermissionsGroup!]! (enum)
        if (this.MissingPermissionsGroups != null) {
            if (conf.Flat) {
                s += conf.Prefix + "missingPermissionsGroups\n" ;
            } else {
                s += ind + "missingPermissionsGroups\n" ;
            }
        }
        //      C# -> AwsIamPair? AwsIamPair
        // GraphQL -> awsIamPair: AwsIamPair! (type)
        if (this.AwsIamPair != null) {
            var fspec = this.AwsIamPair.AsFieldSpec(conf.Child("awsIamPair"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsIamPair" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<PermissionsGroup>? MissingPermissionsGroups
        // GraphQL -> missingPermissionsGroups: [PermissionsGroup!]! (enum)
        if (ec.Includes("missingPermissionsGroups",true))
        {
            if(this.MissingPermissionsGroups == null) {

                this.MissingPermissionsGroups = new List<PermissionsGroup>();

            } else {


            }
        }
        else if (this.MissingPermissionsGroups != null && ec.Excludes("missingPermissionsGroups",true))
        {
            this.MissingPermissionsGroups = null;
        }
        //      C# -> AwsIamPair? AwsIamPair
        // GraphQL -> awsIamPair: AwsIamPair! (type)
        if (ec.Includes("awsIamPair",false))
        {
            if(this.AwsIamPair == null) {

                this.AwsIamPair = new AwsIamPair();
                this.AwsIamPair.ApplyExploratoryFieldSpec(ec.NewChild("awsIamPair"));

            } else {

                this.AwsIamPair.ApplyExploratoryFieldSpec(ec.NewChild("awsIamPair"));

            }
        }
        else if (this.AwsIamPair != null && ec.Excludes("awsIamPair",false))
        {
            this.AwsIamPair = null;
        }
    }


    #endregion

    } // class AwsIamPairsWithMissingPermission
    
    #endregion

    public static class ListAwsIamPairsWithMissingPermissionExtensions
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
            this List<AwsIamPairsWithMissingPermission> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsIamPairsWithMissingPermission> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsIamPairsWithMissingPermission> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsIamPairsWithMissingPermission());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsIamPairsWithMissingPermission> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types