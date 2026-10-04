// AwsPermissionStatement.cs
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
    #region AwsPermissionStatement
    public class AwsPermissionStatement: BaseType
    {
        #region members

        //      C# -> System.String? ConditionJson
        // GraphQL -> conditionJson: String! (scalar)
        [JsonProperty("conditionJson")]
        public System.String? ConditionJson { get; set; }

        //      C# -> System.String? Effect
        // GraphQL -> effect: String! (scalar)
        [JsonProperty("effect")]
        public System.String? Effect { get; set; }

        //      C# -> System.String? IamRoleName
        // GraphQL -> iamRoleName: String! (scalar)
        [JsonProperty("iamRoleName")]
        public System.String? IamRoleName { get; set; }

        //      C# -> List<System.String>? Resources
        // GraphQL -> resources: [String!]! (scalar)
        [JsonProperty("resources")]
        public List<System.String>? Resources { get; set; }

        //      C# -> List<AwsActionWithUseCase>? Actions
        // GraphQL -> actions: [AwsActionWithUseCase!]! (type)
        [JsonProperty("actions")]
        public List<AwsActionWithUseCase>? Actions { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsPermissionStatement";
    }

    public AwsPermissionStatement Set(
        System.String? ConditionJson = null,
        System.String? Effect = null,
        System.String? IamRoleName = null,
        List<System.String>? Resources = null,
        List<AwsActionWithUseCase>? Actions = null
    ) 
    {
        if ( ConditionJson != null ) {
            this.ConditionJson = ConditionJson;
        }
        if ( Effect != null ) {
            this.Effect = Effect;
        }
        if ( IamRoleName != null ) {
            this.IamRoleName = IamRoleName;
        }
        if ( Resources != null ) {
            this.Resources = Resources;
        }
        if ( Actions != null ) {
            this.Actions = Actions;
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
        //      C# -> System.String? ConditionJson
        // GraphQL -> conditionJson: String! (scalar)
        if (this.ConditionJson != null) {
            if (conf.Flat) {
                s += conf.Prefix + "conditionJson\n" ;
            } else {
                s += ind + "conditionJson\n" ;
            }
        }
        //      C# -> System.String? Effect
        // GraphQL -> effect: String! (scalar)
        if (this.Effect != null) {
            if (conf.Flat) {
                s += conf.Prefix + "effect\n" ;
            } else {
                s += ind + "effect\n" ;
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
        //      C# -> List<System.String>? Resources
        // GraphQL -> resources: [String!]! (scalar)
        if (this.Resources != null) {
            if (conf.Flat) {
                s += conf.Prefix + "resources\n" ;
            } else {
                s += ind + "resources\n" ;
            }
        }
        //      C# -> List<AwsActionWithUseCase>? Actions
        // GraphQL -> actions: [AwsActionWithUseCase!]! (type)
        if (this.Actions != null) {
            var fspec = this.Actions.AsFieldSpec(conf.Child("actions"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "actions" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? ConditionJson
        // GraphQL -> conditionJson: String! (scalar)
        if (ec.Includes("conditionJson",true))
        {
            if(this.ConditionJson == null) {

                this.ConditionJson = "FETCH";

            } else {


            }
        }
        else if (this.ConditionJson != null && ec.Excludes("conditionJson",true))
        {
            this.ConditionJson = null;
        }
        //      C# -> System.String? Effect
        // GraphQL -> effect: String! (scalar)
        if (ec.Includes("effect",true))
        {
            if(this.Effect == null) {

                this.Effect = "FETCH";

            } else {


            }
        }
        else if (this.Effect != null && ec.Excludes("effect",true))
        {
            this.Effect = null;
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
        //      C# -> List<System.String>? Resources
        // GraphQL -> resources: [String!]! (scalar)
        if (ec.Includes("resources",true))
        {
            if(this.Resources == null) {

                this.Resources = new List<System.String>();

            } else {


            }
        }
        else if (this.Resources != null && ec.Excludes("resources",true))
        {
            this.Resources = null;
        }
        //      C# -> List<AwsActionWithUseCase>? Actions
        // GraphQL -> actions: [AwsActionWithUseCase!]! (type)
        if (ec.Includes("actions",false))
        {
            if(this.Actions == null) {

                this.Actions = new List<AwsActionWithUseCase>();
                this.Actions.ApplyExploratoryFieldSpec(ec.NewChild("actions"));

            } else {

                this.Actions.ApplyExploratoryFieldSpec(ec.NewChild("actions"));

            }
        }
        else if (this.Actions != null && ec.Excludes("actions",false))
        {
            this.Actions = null;
        }
    }


    #endregion

    } // class AwsPermissionStatement
    
    #endregion

    public static class ListAwsPermissionStatementExtensions
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
            this List<AwsPermissionStatement> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsPermissionStatement> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsPermissionStatement> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsPermissionStatement());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsPermissionStatement> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types