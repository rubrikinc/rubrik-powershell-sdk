// AwsRoleCustomizationResponseType.cs
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
    #region AwsRoleCustomizationResponseType
    public class AwsRoleCustomizationResponseType: BaseType
    {
        #region members

        //      C# -> System.String? CrossAccountRoleName
        // GraphQL -> crossAccountRoleName: String! (scalar)
        [JsonProperty("crossAccountRoleName")]
        public System.String? CrossAccountRoleName { get; set; }

        //      C# -> System.String? CrossAccountRolePath
        // GraphQL -> crossAccountRolePath: String! (scalar)
        [JsonProperty("crossAccountRolePath")]
        public System.String? CrossAccountRolePath { get; set; }

        //      C# -> System.String? Ec2RecoveryRolePath
        // GraphQL -> ec2RecoveryRolePath: String! (scalar)
        [JsonProperty("ec2RecoveryRolePath")]
        public System.String? Ec2RecoveryRolePath { get; set; }

        //      C# -> System.String? InstanceProfileName
        // GraphQL -> instanceProfileName: String! (scalar)
        [JsonProperty("instanceProfileName")]
        public System.String? InstanceProfileName { get; set; }

        //      C# -> System.String? InstanceProfilePath
        // GraphQL -> instanceProfilePath: String! (scalar)
        [JsonProperty("instanceProfilePath")]
        public System.String? InstanceProfilePath { get; set; }

        //      C# -> System.String? LambdaRoleName
        // GraphQL -> lambdaRoleName: String! (scalar)
        [JsonProperty("lambdaRoleName")]
        public System.String? LambdaRoleName { get; set; }

        //      C# -> System.String? LambdaRolePath
        // GraphQL -> lambdaRolePath: String! (scalar)
        [JsonProperty("lambdaRolePath")]
        public System.String? LambdaRolePath { get; set; }

        //      C# -> System.String? MasterRoleName
        // GraphQL -> masterRoleName: String! (scalar)
        [JsonProperty("masterRoleName")]
        public System.String? MasterRoleName { get; set; }

        //      C# -> System.String? MasterRolePath
        // GraphQL -> masterRolePath: String! (scalar)
        [JsonProperty("masterRolePath")]
        public System.String? MasterRolePath { get; set; }

        //      C# -> System.String? PermissionBoundaryName
        // GraphQL -> permissionBoundaryName: String! (scalar)
        [JsonProperty("permissionBoundaryName")]
        public System.String? PermissionBoundaryName { get; set; }

        //      C# -> System.String? PermissionBoundaryPath
        // GraphQL -> permissionBoundaryPath: String! (scalar)
        [JsonProperty("permissionBoundaryPath")]
        public System.String? PermissionBoundaryPath { get; set; }

        //      C# -> System.String? WorkerRoleName
        // GraphQL -> workerRoleName: String! (scalar)
        [JsonProperty("workerRoleName")]
        public System.String? WorkerRoleName { get; set; }

        //      C# -> System.String? WorkerRolePath
        // GraphQL -> workerRolePath: String! (scalar)
        [JsonProperty("workerRolePath")]
        public System.String? WorkerRolePath { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsRoleCustomizationResponseType";
    }

    public AwsRoleCustomizationResponseType Set(
        System.String? CrossAccountRoleName = null,
        System.String? CrossAccountRolePath = null,
        System.String? Ec2RecoveryRolePath = null,
        System.String? InstanceProfileName = null,
        System.String? InstanceProfilePath = null,
        System.String? LambdaRoleName = null,
        System.String? LambdaRolePath = null,
        System.String? MasterRoleName = null,
        System.String? MasterRolePath = null,
        System.String? PermissionBoundaryName = null,
        System.String? PermissionBoundaryPath = null,
        System.String? WorkerRoleName = null,
        System.String? WorkerRolePath = null
    ) 
    {
        if ( CrossAccountRoleName != null ) {
            this.CrossAccountRoleName = CrossAccountRoleName;
        }
        if ( CrossAccountRolePath != null ) {
            this.CrossAccountRolePath = CrossAccountRolePath;
        }
        if ( Ec2RecoveryRolePath != null ) {
            this.Ec2RecoveryRolePath = Ec2RecoveryRolePath;
        }
        if ( InstanceProfileName != null ) {
            this.InstanceProfileName = InstanceProfileName;
        }
        if ( InstanceProfilePath != null ) {
            this.InstanceProfilePath = InstanceProfilePath;
        }
        if ( LambdaRoleName != null ) {
            this.LambdaRoleName = LambdaRoleName;
        }
        if ( LambdaRolePath != null ) {
            this.LambdaRolePath = LambdaRolePath;
        }
        if ( MasterRoleName != null ) {
            this.MasterRoleName = MasterRoleName;
        }
        if ( MasterRolePath != null ) {
            this.MasterRolePath = MasterRolePath;
        }
        if ( PermissionBoundaryName != null ) {
            this.PermissionBoundaryName = PermissionBoundaryName;
        }
        if ( PermissionBoundaryPath != null ) {
            this.PermissionBoundaryPath = PermissionBoundaryPath;
        }
        if ( WorkerRoleName != null ) {
            this.WorkerRoleName = WorkerRoleName;
        }
        if ( WorkerRolePath != null ) {
            this.WorkerRolePath = WorkerRolePath;
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
        //      C# -> System.String? CrossAccountRoleName
        // GraphQL -> crossAccountRoleName: String! (scalar)
        if (this.CrossAccountRoleName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "crossAccountRoleName\n" ;
            } else {
                s += ind + "crossAccountRoleName\n" ;
            }
        }
        //      C# -> System.String? CrossAccountRolePath
        // GraphQL -> crossAccountRolePath: String! (scalar)
        if (this.CrossAccountRolePath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "crossAccountRolePath\n" ;
            } else {
                s += ind + "crossAccountRolePath\n" ;
            }
        }
        //      C# -> System.String? Ec2RecoveryRolePath
        // GraphQL -> ec2RecoveryRolePath: String! (scalar)
        if (this.Ec2RecoveryRolePath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ec2RecoveryRolePath\n" ;
            } else {
                s += ind + "ec2RecoveryRolePath\n" ;
            }
        }
        //      C# -> System.String? InstanceProfileName
        // GraphQL -> instanceProfileName: String! (scalar)
        if (this.InstanceProfileName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "instanceProfileName\n" ;
            } else {
                s += ind + "instanceProfileName\n" ;
            }
        }
        //      C# -> System.String? InstanceProfilePath
        // GraphQL -> instanceProfilePath: String! (scalar)
        if (this.InstanceProfilePath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "instanceProfilePath\n" ;
            } else {
                s += ind + "instanceProfilePath\n" ;
            }
        }
        //      C# -> System.String? LambdaRoleName
        // GraphQL -> lambdaRoleName: String! (scalar)
        if (this.LambdaRoleName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lambdaRoleName\n" ;
            } else {
                s += ind + "lambdaRoleName\n" ;
            }
        }
        //      C# -> System.String? LambdaRolePath
        // GraphQL -> lambdaRolePath: String! (scalar)
        if (this.LambdaRolePath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lambdaRolePath\n" ;
            } else {
                s += ind + "lambdaRolePath\n" ;
            }
        }
        //      C# -> System.String? MasterRoleName
        // GraphQL -> masterRoleName: String! (scalar)
        if (this.MasterRoleName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "masterRoleName\n" ;
            } else {
                s += ind + "masterRoleName\n" ;
            }
        }
        //      C# -> System.String? MasterRolePath
        // GraphQL -> masterRolePath: String! (scalar)
        if (this.MasterRolePath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "masterRolePath\n" ;
            } else {
                s += ind + "masterRolePath\n" ;
            }
        }
        //      C# -> System.String? PermissionBoundaryName
        // GraphQL -> permissionBoundaryName: String! (scalar)
        if (this.PermissionBoundaryName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "permissionBoundaryName\n" ;
            } else {
                s += ind + "permissionBoundaryName\n" ;
            }
        }
        //      C# -> System.String? PermissionBoundaryPath
        // GraphQL -> permissionBoundaryPath: String! (scalar)
        if (this.PermissionBoundaryPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "permissionBoundaryPath\n" ;
            } else {
                s += ind + "permissionBoundaryPath\n" ;
            }
        }
        //      C# -> System.String? WorkerRoleName
        // GraphQL -> workerRoleName: String! (scalar)
        if (this.WorkerRoleName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workerRoleName\n" ;
            } else {
                s += ind + "workerRoleName\n" ;
            }
        }
        //      C# -> System.String? WorkerRolePath
        // GraphQL -> workerRolePath: String! (scalar)
        if (this.WorkerRolePath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workerRolePath\n" ;
            } else {
                s += ind + "workerRolePath\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? CrossAccountRoleName
        // GraphQL -> crossAccountRoleName: String! (scalar)
        if (ec.Includes("crossAccountRoleName",true))
        {
            if(this.CrossAccountRoleName == null) {

                this.CrossAccountRoleName = "FETCH";

            } else {


            }
        }
        else if (this.CrossAccountRoleName != null && ec.Excludes("crossAccountRoleName",true))
        {
            this.CrossAccountRoleName = null;
        }
        //      C# -> System.String? CrossAccountRolePath
        // GraphQL -> crossAccountRolePath: String! (scalar)
        if (ec.Includes("crossAccountRolePath",true))
        {
            if(this.CrossAccountRolePath == null) {

                this.CrossAccountRolePath = "FETCH";

            } else {


            }
        }
        else if (this.CrossAccountRolePath != null && ec.Excludes("crossAccountRolePath",true))
        {
            this.CrossAccountRolePath = null;
        }
        //      C# -> System.String? Ec2RecoveryRolePath
        // GraphQL -> ec2RecoveryRolePath: String! (scalar)
        if (ec.Includes("ec2RecoveryRolePath",true))
        {
            if(this.Ec2RecoveryRolePath == null) {

                this.Ec2RecoveryRolePath = "FETCH";

            } else {


            }
        }
        else if (this.Ec2RecoveryRolePath != null && ec.Excludes("ec2RecoveryRolePath",true))
        {
            this.Ec2RecoveryRolePath = null;
        }
        //      C# -> System.String? InstanceProfileName
        // GraphQL -> instanceProfileName: String! (scalar)
        if (ec.Includes("instanceProfileName",true))
        {
            if(this.InstanceProfileName == null) {

                this.InstanceProfileName = "FETCH";

            } else {


            }
        }
        else if (this.InstanceProfileName != null && ec.Excludes("instanceProfileName",true))
        {
            this.InstanceProfileName = null;
        }
        //      C# -> System.String? InstanceProfilePath
        // GraphQL -> instanceProfilePath: String! (scalar)
        if (ec.Includes("instanceProfilePath",true))
        {
            if(this.InstanceProfilePath == null) {

                this.InstanceProfilePath = "FETCH";

            } else {


            }
        }
        else if (this.InstanceProfilePath != null && ec.Excludes("instanceProfilePath",true))
        {
            this.InstanceProfilePath = null;
        }
        //      C# -> System.String? LambdaRoleName
        // GraphQL -> lambdaRoleName: String! (scalar)
        if (ec.Includes("lambdaRoleName",true))
        {
            if(this.LambdaRoleName == null) {

                this.LambdaRoleName = "FETCH";

            } else {


            }
        }
        else if (this.LambdaRoleName != null && ec.Excludes("lambdaRoleName",true))
        {
            this.LambdaRoleName = null;
        }
        //      C# -> System.String? LambdaRolePath
        // GraphQL -> lambdaRolePath: String! (scalar)
        if (ec.Includes("lambdaRolePath",true))
        {
            if(this.LambdaRolePath == null) {

                this.LambdaRolePath = "FETCH";

            } else {


            }
        }
        else if (this.LambdaRolePath != null && ec.Excludes("lambdaRolePath",true))
        {
            this.LambdaRolePath = null;
        }
        //      C# -> System.String? MasterRoleName
        // GraphQL -> masterRoleName: String! (scalar)
        if (ec.Includes("masterRoleName",true))
        {
            if(this.MasterRoleName == null) {

                this.MasterRoleName = "FETCH";

            } else {


            }
        }
        else if (this.MasterRoleName != null && ec.Excludes("masterRoleName",true))
        {
            this.MasterRoleName = null;
        }
        //      C# -> System.String? MasterRolePath
        // GraphQL -> masterRolePath: String! (scalar)
        if (ec.Includes("masterRolePath",true))
        {
            if(this.MasterRolePath == null) {

                this.MasterRolePath = "FETCH";

            } else {


            }
        }
        else if (this.MasterRolePath != null && ec.Excludes("masterRolePath",true))
        {
            this.MasterRolePath = null;
        }
        //      C# -> System.String? PermissionBoundaryName
        // GraphQL -> permissionBoundaryName: String! (scalar)
        if (ec.Includes("permissionBoundaryName",true))
        {
            if(this.PermissionBoundaryName == null) {

                this.PermissionBoundaryName = "FETCH";

            } else {


            }
        }
        else if (this.PermissionBoundaryName != null && ec.Excludes("permissionBoundaryName",true))
        {
            this.PermissionBoundaryName = null;
        }
        //      C# -> System.String? PermissionBoundaryPath
        // GraphQL -> permissionBoundaryPath: String! (scalar)
        if (ec.Includes("permissionBoundaryPath",true))
        {
            if(this.PermissionBoundaryPath == null) {

                this.PermissionBoundaryPath = "FETCH";

            } else {


            }
        }
        else if (this.PermissionBoundaryPath != null && ec.Excludes("permissionBoundaryPath",true))
        {
            this.PermissionBoundaryPath = null;
        }
        //      C# -> System.String? WorkerRoleName
        // GraphQL -> workerRoleName: String! (scalar)
        if (ec.Includes("workerRoleName",true))
        {
            if(this.WorkerRoleName == null) {

                this.WorkerRoleName = "FETCH";

            } else {


            }
        }
        else if (this.WorkerRoleName != null && ec.Excludes("workerRoleName",true))
        {
            this.WorkerRoleName = null;
        }
        //      C# -> System.String? WorkerRolePath
        // GraphQL -> workerRolePath: String! (scalar)
        if (ec.Includes("workerRolePath",true))
        {
            if(this.WorkerRolePath == null) {

                this.WorkerRolePath = "FETCH";

            } else {


            }
        }
        else if (this.WorkerRolePath != null && ec.Excludes("workerRolePath",true))
        {
            this.WorkerRolePath = null;
        }
    }


    #endregion

    } // class AwsRoleCustomizationResponseType
    
    #endregion

    public static class ListAwsRoleCustomizationResponseTypeExtensions
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
            this List<AwsRoleCustomizationResponseType> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AwsRoleCustomizationResponseType> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsRoleCustomizationResponseType> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsRoleCustomizationResponseType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsRoleCustomizationResponseType> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types