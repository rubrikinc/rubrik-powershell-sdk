// DefenderAlertMetadata.cs
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
    #region DefenderAlertMetadata
 
    public class DefenderAlertMetadata: BaseType, ResourceMetadataUnion
    {
        #region members

        //      C# -> ViolationPrincipalType? ActorIdentityType
        // GraphQL -> actorIdentityType: ViolationPrincipalType! (enum)
        [JsonProperty("actorIdentityType")]
        public ViolationPrincipalType? ActorIdentityType { get; set; }

        //      C# -> PrivilegeType? ActorPrivilegeType
        // GraphQL -> actorPrivilegeType: PrivilegeType! (enum)
        [JsonProperty("actorPrivilegeType")]
        public PrivilegeType? ActorPrivilegeType { get; set; }

        //      C# -> IdentityStatus? TargetIdentityStatus
        // GraphQL -> targetIdentityStatus: IdentityStatus! (enum)
        [JsonProperty("targetIdentityStatus")]
        public IdentityStatus? TargetIdentityStatus { get; set; }

        //      C# -> ViolationPrincipalType? TargetIdentityType
        // GraphQL -> targetIdentityType: ViolationPrincipalType! (enum)
        [JsonProperty("targetIdentityType")]
        public ViolationPrincipalType? TargetIdentityType { get; set; }

        //      C# -> IdpType? TargetIdpType
        // GraphQL -> targetIdpType: IdpType! (enum)
        [JsonProperty("targetIdpType")]
        public IdpType? TargetIdpType { get; set; }

        //      C# -> PrivilegeType? TargetPrivilegeType
        // GraphQL -> targetPrivilegeType: PrivilegeType! (enum)
        [JsonProperty("targetPrivilegeType")]
        public PrivilegeType? TargetPrivilegeType { get; set; }

        //      C# -> System.String? ActorIdentityId
        // GraphQL -> actorIdentityId: String! (scalar)
        [JsonProperty("actorIdentityId")]
        public System.String? ActorIdentityId { get; set; }

        //      C# -> System.String? ActorIdentityName
        // GraphQL -> actorIdentityName: String! (scalar)
        [JsonProperty("actorIdentityName")]
        public System.String? ActorIdentityName { get; set; }

        //      C# -> System.String? TargetIdentityName
        // GraphQL -> targetIdentityName: String! (scalar)
        [JsonProperty("targetIdentityName")]
        public System.String? TargetIdentityName { get; set; }

        //      C# -> System.String? TargetIdentitySource
        // GraphQL -> targetIdentitySource: String! (scalar)
        [JsonProperty("targetIdentitySource")]
        public System.String? TargetIdentitySource { get; set; }

        //      C# -> System.String? TargetIdentityUniqueIdentifier
        // GraphQL -> targetIdentityUniqueIdentifier: String! (scalar)
        [JsonProperty("targetIdentityUniqueIdentifier")]
        public System.String? TargetIdentityUniqueIdentifier { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DefenderAlertMetadata";
    }

    public DefenderAlertMetadata Set(
        ViolationPrincipalType? ActorIdentityType = null,
        PrivilegeType? ActorPrivilegeType = null,
        IdentityStatus? TargetIdentityStatus = null,
        ViolationPrincipalType? TargetIdentityType = null,
        IdpType? TargetIdpType = null,
        PrivilegeType? TargetPrivilegeType = null,
        System.String? ActorIdentityId = null,
        System.String? ActorIdentityName = null,
        System.String? TargetIdentityName = null,
        System.String? TargetIdentitySource = null,
        System.String? TargetIdentityUniqueIdentifier = null
    ) 
    {
        if ( ActorIdentityType != null ) {
            this.ActorIdentityType = ActorIdentityType;
        }
        if ( ActorPrivilegeType != null ) {
            this.ActorPrivilegeType = ActorPrivilegeType;
        }
        if ( TargetIdentityStatus != null ) {
            this.TargetIdentityStatus = TargetIdentityStatus;
        }
        if ( TargetIdentityType != null ) {
            this.TargetIdentityType = TargetIdentityType;
        }
        if ( TargetIdpType != null ) {
            this.TargetIdpType = TargetIdpType;
        }
        if ( TargetPrivilegeType != null ) {
            this.TargetPrivilegeType = TargetPrivilegeType;
        }
        if ( ActorIdentityId != null ) {
            this.ActorIdentityId = ActorIdentityId;
        }
        if ( ActorIdentityName != null ) {
            this.ActorIdentityName = ActorIdentityName;
        }
        if ( TargetIdentityName != null ) {
            this.TargetIdentityName = TargetIdentityName;
        }
        if ( TargetIdentitySource != null ) {
            this.TargetIdentitySource = TargetIdentitySource;
        }
        if ( TargetIdentityUniqueIdentifier != null ) {
            this.TargetIdentityUniqueIdentifier = TargetIdentityUniqueIdentifier;
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
        //      C# -> ViolationPrincipalType? ActorIdentityType
        // GraphQL -> actorIdentityType: ViolationPrincipalType! (enum)
        if (this.ActorIdentityType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "actorIdentityType\n" ;
            } else {
                s += ind + "actorIdentityType\n" ;
            }
        }
        //      C# -> PrivilegeType? ActorPrivilegeType
        // GraphQL -> actorPrivilegeType: PrivilegeType! (enum)
        if (this.ActorPrivilegeType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "actorPrivilegeType\n" ;
            } else {
                s += ind + "actorPrivilegeType\n" ;
            }
        }
        //      C# -> IdentityStatus? TargetIdentityStatus
        // GraphQL -> targetIdentityStatus: IdentityStatus! (enum)
        if (this.TargetIdentityStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetIdentityStatus\n" ;
            } else {
                s += ind + "targetIdentityStatus\n" ;
            }
        }
        //      C# -> ViolationPrincipalType? TargetIdentityType
        // GraphQL -> targetIdentityType: ViolationPrincipalType! (enum)
        if (this.TargetIdentityType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetIdentityType\n" ;
            } else {
                s += ind + "targetIdentityType\n" ;
            }
        }
        //      C# -> IdpType? TargetIdpType
        // GraphQL -> targetIdpType: IdpType! (enum)
        if (this.TargetIdpType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetIdpType\n" ;
            } else {
                s += ind + "targetIdpType\n" ;
            }
        }
        //      C# -> PrivilegeType? TargetPrivilegeType
        // GraphQL -> targetPrivilegeType: PrivilegeType! (enum)
        if (this.TargetPrivilegeType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetPrivilegeType\n" ;
            } else {
                s += ind + "targetPrivilegeType\n" ;
            }
        }
        //      C# -> System.String? ActorIdentityId
        // GraphQL -> actorIdentityId: String! (scalar)
        if (this.ActorIdentityId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "actorIdentityId\n" ;
            } else {
                s += ind + "actorIdentityId\n" ;
            }
        }
        //      C# -> System.String? ActorIdentityName
        // GraphQL -> actorIdentityName: String! (scalar)
        if (this.ActorIdentityName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "actorIdentityName\n" ;
            } else {
                s += ind + "actorIdentityName\n" ;
            }
        }
        //      C# -> System.String? TargetIdentityName
        // GraphQL -> targetIdentityName: String! (scalar)
        if (this.TargetIdentityName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetIdentityName\n" ;
            } else {
                s += ind + "targetIdentityName\n" ;
            }
        }
        //      C# -> System.String? TargetIdentitySource
        // GraphQL -> targetIdentitySource: String! (scalar)
        if (this.TargetIdentitySource != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetIdentitySource\n" ;
            } else {
                s += ind + "targetIdentitySource\n" ;
            }
        }
        //      C# -> System.String? TargetIdentityUniqueIdentifier
        // GraphQL -> targetIdentityUniqueIdentifier: String! (scalar)
        if (this.TargetIdentityUniqueIdentifier != null) {
            if (conf.Flat) {
                s += conf.Prefix + "targetIdentityUniqueIdentifier\n" ;
            } else {
                s += ind + "targetIdentityUniqueIdentifier\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ViolationPrincipalType? ActorIdentityType
        // GraphQL -> actorIdentityType: ViolationPrincipalType! (enum)
        if (ec.Includes("actorIdentityType",true))
        {
            if(this.ActorIdentityType == null) {

                this.ActorIdentityType = new ViolationPrincipalType();

            } else {


            }
        }
        else if (this.ActorIdentityType != null && ec.Excludes("actorIdentityType",true))
        {
            this.ActorIdentityType = null;
        }
        //      C# -> PrivilegeType? ActorPrivilegeType
        // GraphQL -> actorPrivilegeType: PrivilegeType! (enum)
        if (ec.Includes("actorPrivilegeType",true))
        {
            if(this.ActorPrivilegeType == null) {

                this.ActorPrivilegeType = new PrivilegeType();

            } else {


            }
        }
        else if (this.ActorPrivilegeType != null && ec.Excludes("actorPrivilegeType",true))
        {
            this.ActorPrivilegeType = null;
        }
        //      C# -> IdentityStatus? TargetIdentityStatus
        // GraphQL -> targetIdentityStatus: IdentityStatus! (enum)
        if (ec.Includes("targetIdentityStatus",true))
        {
            if(this.TargetIdentityStatus == null) {

                this.TargetIdentityStatus = new IdentityStatus();

            } else {


            }
        }
        else if (this.TargetIdentityStatus != null && ec.Excludes("targetIdentityStatus",true))
        {
            this.TargetIdentityStatus = null;
        }
        //      C# -> ViolationPrincipalType? TargetIdentityType
        // GraphQL -> targetIdentityType: ViolationPrincipalType! (enum)
        if (ec.Includes("targetIdentityType",true))
        {
            if(this.TargetIdentityType == null) {

                this.TargetIdentityType = new ViolationPrincipalType();

            } else {


            }
        }
        else if (this.TargetIdentityType != null && ec.Excludes("targetIdentityType",true))
        {
            this.TargetIdentityType = null;
        }
        //      C# -> IdpType? TargetIdpType
        // GraphQL -> targetIdpType: IdpType! (enum)
        if (ec.Includes("targetIdpType",true))
        {
            if(this.TargetIdpType == null) {

                this.TargetIdpType = new IdpType();

            } else {


            }
        }
        else if (this.TargetIdpType != null && ec.Excludes("targetIdpType",true))
        {
            this.TargetIdpType = null;
        }
        //      C# -> PrivilegeType? TargetPrivilegeType
        // GraphQL -> targetPrivilegeType: PrivilegeType! (enum)
        if (ec.Includes("targetPrivilegeType",true))
        {
            if(this.TargetPrivilegeType == null) {

                this.TargetPrivilegeType = new PrivilegeType();

            } else {


            }
        }
        else if (this.TargetPrivilegeType != null && ec.Excludes("targetPrivilegeType",true))
        {
            this.TargetPrivilegeType = null;
        }
        //      C# -> System.String? ActorIdentityId
        // GraphQL -> actorIdentityId: String! (scalar)
        if (ec.Includes("actorIdentityId",true))
        {
            if(this.ActorIdentityId == null) {

                this.ActorIdentityId = "FETCH";

            } else {


            }
        }
        else if (this.ActorIdentityId != null && ec.Excludes("actorIdentityId",true))
        {
            this.ActorIdentityId = null;
        }
        //      C# -> System.String? ActorIdentityName
        // GraphQL -> actorIdentityName: String! (scalar)
        if (ec.Includes("actorIdentityName",true))
        {
            if(this.ActorIdentityName == null) {

                this.ActorIdentityName = "FETCH";

            } else {


            }
        }
        else if (this.ActorIdentityName != null && ec.Excludes("actorIdentityName",true))
        {
            this.ActorIdentityName = null;
        }
        //      C# -> System.String? TargetIdentityName
        // GraphQL -> targetIdentityName: String! (scalar)
        if (ec.Includes("targetIdentityName",true))
        {
            if(this.TargetIdentityName == null) {

                this.TargetIdentityName = "FETCH";

            } else {


            }
        }
        else if (this.TargetIdentityName != null && ec.Excludes("targetIdentityName",true))
        {
            this.TargetIdentityName = null;
        }
        //      C# -> System.String? TargetIdentitySource
        // GraphQL -> targetIdentitySource: String! (scalar)
        if (ec.Includes("targetIdentitySource",true))
        {
            if(this.TargetIdentitySource == null) {

                this.TargetIdentitySource = "FETCH";

            } else {


            }
        }
        else if (this.TargetIdentitySource != null && ec.Excludes("targetIdentitySource",true))
        {
            this.TargetIdentitySource = null;
        }
        //      C# -> System.String? TargetIdentityUniqueIdentifier
        // GraphQL -> targetIdentityUniqueIdentifier: String! (scalar)
        if (ec.Includes("targetIdentityUniqueIdentifier",true))
        {
            if(this.TargetIdentityUniqueIdentifier == null) {

                this.TargetIdentityUniqueIdentifier = "FETCH";

            } else {


            }
        }
        else if (this.TargetIdentityUniqueIdentifier != null && ec.Excludes("targetIdentityUniqueIdentifier",true))
        {
            this.TargetIdentityUniqueIdentifier = null;
        }
    }


    #endregion

    } // class DefenderAlertMetadata
    
    #endregion

    public static class ListDefenderAlertMetadataExtensions
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
            this List<DefenderAlertMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DefenderAlertMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DefenderAlertMetadata> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DefenderAlertMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DefenderAlertMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types