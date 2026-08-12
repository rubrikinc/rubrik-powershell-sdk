// SigninAnomalyMetadata.cs
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
    #region SigninAnomalyMetadata
 
    public class SigninAnomalyMetadata: BaseType, ResourceMetadataUnion
    {
        #region members

        //      C# -> IdpType? IdpType
        // GraphQL -> idpType: IdpType! (enum)
        [JsonProperty("idpType")]
        public IdpType? IdpType { get; set; }

        //      C# -> ViolationPrincipalType? PrincipalType
        // GraphQL -> principalType: ViolationPrincipalType! (enum)
        [JsonProperty("principalType")]
        public ViolationPrincipalType? PrincipalType { get; set; }

        //      C# -> DateTime? CreationTime
        // GraphQL -> creationTime: DateTime (scalar)
        [JsonProperty("creationTime")]
        public DateTime? CreationTime { get; set; }

        //      C# -> DateTime? DetectedOn
        // GraphQL -> detectedOn: DateTime (scalar)
        [JsonProperty("detectedOn")]
        public DateTime? DetectedOn { get; set; }

        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        [JsonProperty("displayName")]
        public System.String? DisplayName { get; set; }

        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        [JsonProperty("domainName")]
        public System.String? DomainName { get; set; }

        //      C# -> System.String? DomainUniqueId
        // GraphQL -> domainUniqueId: String! (scalar)
        [JsonProperty("domainUniqueId")]
        public System.String? DomainUniqueId { get; set; }

        //      C# -> DateTime? LastSeen
        // GraphQL -> lastSeen: DateTime (scalar)
        [JsonProperty("lastSeen")]
        public DateTime? LastSeen { get; set; }

        //      C# -> System.String? UniqueId
        // GraphQL -> uniqueId: String! (scalar)
        [JsonProperty("uniqueId")]
        public System.String? UniqueId { get; set; }

        //      C# -> List<SigninAnomalyActor>? Actors
        // GraphQL -> actors: [SigninAnomalyActor!]! (type)
        [JsonProperty("actors")]
        public List<SigninAnomalyActor>? Actors { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SigninAnomalyMetadata";
    }

    public SigninAnomalyMetadata Set(
        IdpType? IdpType = null,
        ViolationPrincipalType? PrincipalType = null,
        DateTime? CreationTime = null,
        DateTime? DetectedOn = null,
        System.String? DisplayName = null,
        System.String? DomainName = null,
        System.String? DomainUniqueId = null,
        DateTime? LastSeen = null,
        System.String? UniqueId = null,
        List<SigninAnomalyActor>? Actors = null
    ) 
    {
        if ( IdpType != null ) {
            this.IdpType = IdpType;
        }
        if ( PrincipalType != null ) {
            this.PrincipalType = PrincipalType;
        }
        if ( CreationTime != null ) {
            this.CreationTime = CreationTime;
        }
        if ( DetectedOn != null ) {
            this.DetectedOn = DetectedOn;
        }
        if ( DisplayName != null ) {
            this.DisplayName = DisplayName;
        }
        if ( DomainName != null ) {
            this.DomainName = DomainName;
        }
        if ( DomainUniqueId != null ) {
            this.DomainUniqueId = DomainUniqueId;
        }
        if ( LastSeen != null ) {
            this.LastSeen = LastSeen;
        }
        if ( UniqueId != null ) {
            this.UniqueId = UniqueId;
        }
        if ( Actors != null ) {
            this.Actors = Actors;
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
        //      C# -> IdpType? IdpType
        // GraphQL -> idpType: IdpType! (enum)
        if (this.IdpType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "idpType\n" ;
            } else {
                s += ind + "idpType\n" ;
            }
        }
        //      C# -> ViolationPrincipalType? PrincipalType
        // GraphQL -> principalType: ViolationPrincipalType! (enum)
        if (this.PrincipalType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "principalType\n" ;
            } else {
                s += ind + "principalType\n" ;
            }
        }
        //      C# -> DateTime? CreationTime
        // GraphQL -> creationTime: DateTime (scalar)
        if (this.CreationTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "creationTime\n" ;
            } else {
                s += ind + "creationTime\n" ;
            }
        }
        //      C# -> DateTime? DetectedOn
        // GraphQL -> detectedOn: DateTime (scalar)
        if (this.DetectedOn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "detectedOn\n" ;
            } else {
                s += ind + "detectedOn\n" ;
            }
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (this.DisplayName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "displayName\n" ;
            } else {
                s += ind + "displayName\n" ;
            }
        }
        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        if (this.DomainName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "domainName\n" ;
            } else {
                s += ind + "domainName\n" ;
            }
        }
        //      C# -> System.String? DomainUniqueId
        // GraphQL -> domainUniqueId: String! (scalar)
        if (this.DomainUniqueId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "domainUniqueId\n" ;
            } else {
                s += ind + "domainUniqueId\n" ;
            }
        }
        //      C# -> DateTime? LastSeen
        // GraphQL -> lastSeen: DateTime (scalar)
        if (this.LastSeen != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastSeen\n" ;
            } else {
                s += ind + "lastSeen\n" ;
            }
        }
        //      C# -> System.String? UniqueId
        // GraphQL -> uniqueId: String! (scalar)
        if (this.UniqueId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "uniqueId\n" ;
            } else {
                s += ind + "uniqueId\n" ;
            }
        }
        //      C# -> List<SigninAnomalyActor>? Actors
        // GraphQL -> actors: [SigninAnomalyActor!]! (type)
        if (this.Actors != null) {
            var fspec = this.Actors.AsFieldSpec(conf.Child("actors"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "actors" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> IdpType? IdpType
        // GraphQL -> idpType: IdpType! (enum)
        if (ec.Includes("idpType",true))
        {
            if(this.IdpType == null) {

                this.IdpType = new IdpType();

            } else {


            }
        }
        else if (this.IdpType != null && ec.Excludes("idpType",true))
        {
            this.IdpType = null;
        }
        //      C# -> ViolationPrincipalType? PrincipalType
        // GraphQL -> principalType: ViolationPrincipalType! (enum)
        if (ec.Includes("principalType",true))
        {
            if(this.PrincipalType == null) {

                this.PrincipalType = new ViolationPrincipalType();

            } else {


            }
        }
        else if (this.PrincipalType != null && ec.Excludes("principalType",true))
        {
            this.PrincipalType = null;
        }
        //      C# -> DateTime? CreationTime
        // GraphQL -> creationTime: DateTime (scalar)
        if (ec.Includes("creationTime",true))
        {
            if(this.CreationTime == null) {

                this.CreationTime = new DateTime();

            } else {


            }
        }
        else if (this.CreationTime != null && ec.Excludes("creationTime",true))
        {
            this.CreationTime = null;
        }
        //      C# -> DateTime? DetectedOn
        // GraphQL -> detectedOn: DateTime (scalar)
        if (ec.Includes("detectedOn",true))
        {
            if(this.DetectedOn == null) {

                this.DetectedOn = new DateTime();

            } else {


            }
        }
        else if (this.DetectedOn != null && ec.Excludes("detectedOn",true))
        {
            this.DetectedOn = null;
        }
        //      C# -> System.String? DisplayName
        // GraphQL -> displayName: String! (scalar)
        if (ec.Includes("displayName",true))
        {
            if(this.DisplayName == null) {

                this.DisplayName = "FETCH";

            } else {


            }
        }
        else if (this.DisplayName != null && ec.Excludes("displayName",true))
        {
            this.DisplayName = null;
        }
        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        if (ec.Includes("domainName",true))
        {
            if(this.DomainName == null) {

                this.DomainName = "FETCH";

            } else {


            }
        }
        else if (this.DomainName != null && ec.Excludes("domainName",true))
        {
            this.DomainName = null;
        }
        //      C# -> System.String? DomainUniqueId
        // GraphQL -> domainUniqueId: String! (scalar)
        if (ec.Includes("domainUniqueId",true))
        {
            if(this.DomainUniqueId == null) {

                this.DomainUniqueId = "FETCH";

            } else {


            }
        }
        else if (this.DomainUniqueId != null && ec.Excludes("domainUniqueId",true))
        {
            this.DomainUniqueId = null;
        }
        //      C# -> DateTime? LastSeen
        // GraphQL -> lastSeen: DateTime (scalar)
        if (ec.Includes("lastSeen",true))
        {
            if(this.LastSeen == null) {

                this.LastSeen = new DateTime();

            } else {


            }
        }
        else if (this.LastSeen != null && ec.Excludes("lastSeen",true))
        {
            this.LastSeen = null;
        }
        //      C# -> System.String? UniqueId
        // GraphQL -> uniqueId: String! (scalar)
        if (ec.Includes("uniqueId",true))
        {
            if(this.UniqueId == null) {

                this.UniqueId = "FETCH";

            } else {


            }
        }
        else if (this.UniqueId != null && ec.Excludes("uniqueId",true))
        {
            this.UniqueId = null;
        }
        //      C# -> List<SigninAnomalyActor>? Actors
        // GraphQL -> actors: [SigninAnomalyActor!]! (type)
        if (ec.Includes("actors",false))
        {
            if(this.Actors == null) {

                this.Actors = new List<SigninAnomalyActor>();
                this.Actors.ApplyExploratoryFieldSpec(ec.NewChild("actors"));

            } else {

                this.Actors.ApplyExploratoryFieldSpec(ec.NewChild("actors"));

            }
        }
        else if (this.Actors != null && ec.Excludes("actors",false))
        {
            this.Actors = null;
        }
    }


    #endregion

    } // class SigninAnomalyMetadata
    
    #endregion

    public static class ListSigninAnomalyMetadataExtensions
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
            this List<SigninAnomalyMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SigninAnomalyMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SigninAnomalyMetadata> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SigninAnomalyMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SigninAnomalyMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types