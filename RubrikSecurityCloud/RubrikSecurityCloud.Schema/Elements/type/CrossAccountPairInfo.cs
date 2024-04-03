// CrossAccountPairInfo.cs
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
    #region CrossAccountPairInfo
    public class CrossAccountPairInfo: BaseType
    {
        #region members

        //      C# -> CrossAccountRole? Role
        // GraphQL -> role: CrossAccountRole! (enum)
        [JsonProperty("role")]
        public CrossAccountRole? Role { get; set; }

        //      C# -> CrossAccountStatus? Status
        // GraphQL -> status: CrossAccountStatus! (enum)
        [JsonProperty("status")]
        public CrossAccountStatus? Status { get; set; }

        //      C# -> DateTime? LastSyncedAt
        // GraphQL -> lastSyncedAt: DateTime (scalar)
        [JsonProperty("lastSyncedAt")]
        public DateTime? LastSyncedAt { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? Url
        // GraphQL -> url: String! (scalar)
        [JsonProperty("url")]
        public System.String? Url { get; set; }

        //      C# -> System.String? Uuid
        // GraphQL -> uuid: UUID! (scalar)
        [JsonProperty("uuid")]
        public System.String? Uuid { get; set; }

        //      C# -> CrossAccountOrganization? Organization
        // GraphQL -> organization: CrossAccountOrganization! (type)
        [JsonProperty("organization")]
        public CrossAccountOrganization? Organization { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CrossAccountPairInfo";
    }

    public CrossAccountPairInfo Set(
        CrossAccountRole? Role = null,
        CrossAccountStatus? Status = null,
        DateTime? LastSyncedAt = null,
        System.String? Name = null,
        System.String? Url = null,
        System.String? Uuid = null,
        CrossAccountOrganization? Organization = null
    ) 
    {
        if ( Role != null ) {
            this.Role = Role;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( LastSyncedAt != null ) {
            this.LastSyncedAt = LastSyncedAt;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Url != null ) {
            this.Url = Url;
        }
        if ( Uuid != null ) {
            this.Uuid = Uuid;
        }
        if ( Organization != null ) {
            this.Organization = Organization;
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
        //      C# -> CrossAccountRole? Role
        // GraphQL -> role: CrossAccountRole! (enum)
        if (this.Role != null) {
            if (conf.Flat) {
                s += conf.Prefix + "role\n" ;
            } else {
                s += ind + "role\n" ;
            }
        }
        //      C# -> CrossAccountStatus? Status
        // GraphQL -> status: CrossAccountStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> DateTime? LastSyncedAt
        // GraphQL -> lastSyncedAt: DateTime (scalar)
        if (this.LastSyncedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastSyncedAt\n" ;
            } else {
                s += ind + "lastSyncedAt\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? Url
        // GraphQL -> url: String! (scalar)
        if (this.Url != null) {
            if (conf.Flat) {
                s += conf.Prefix + "url\n" ;
            } else {
                s += ind + "url\n" ;
            }
        }
        //      C# -> System.String? Uuid
        // GraphQL -> uuid: UUID! (scalar)
        if (this.Uuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "uuid\n" ;
            } else {
                s += ind + "uuid\n" ;
            }
        }
        //      C# -> CrossAccountOrganization? Organization
        // GraphQL -> organization: CrossAccountOrganization! (type)
        if (this.Organization != null) {
            var fspec = this.Organization.AsFieldSpec(conf.Child("organization"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "organization" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CrossAccountRole? Role
        // GraphQL -> role: CrossAccountRole! (enum)
        if (ec.Includes("role",true))
        {
            if(this.Role == null) {

                this.Role = new CrossAccountRole();

            } else {


            }
        }
        else if (this.Role != null && ec.Excludes("role",true))
        {
            this.Role = null;
        }
        //      C# -> CrossAccountStatus? Status
        // GraphQL -> status: CrossAccountStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new CrossAccountStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> DateTime? LastSyncedAt
        // GraphQL -> lastSyncedAt: DateTime (scalar)
        if (ec.Includes("lastSyncedAt",true))
        {
            if(this.LastSyncedAt == null) {

                this.LastSyncedAt = new DateTime();

            } else {


            }
        }
        else if (this.LastSyncedAt != null && ec.Excludes("lastSyncedAt",true))
        {
            this.LastSyncedAt = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.String? Url
        // GraphQL -> url: String! (scalar)
        if (ec.Includes("url",true))
        {
            if(this.Url == null) {

                this.Url = "FETCH";

            } else {


            }
        }
        else if (this.Url != null && ec.Excludes("url",true))
        {
            this.Url = null;
        }
        //      C# -> System.String? Uuid
        // GraphQL -> uuid: UUID! (scalar)
        if (ec.Includes("uuid",true))
        {
            if(this.Uuid == null) {

                this.Uuid = "FETCH";

            } else {


            }
        }
        else if (this.Uuid != null && ec.Excludes("uuid",true))
        {
            this.Uuid = null;
        }
        //      C# -> CrossAccountOrganization? Organization
        // GraphQL -> organization: CrossAccountOrganization! (type)
        if (ec.Includes("organization",false))
        {
            if(this.Organization == null) {

                this.Organization = new CrossAccountOrganization();
                this.Organization.ApplyExploratoryFieldSpec(ec.NewChild("organization"));

            } else {

                this.Organization.ApplyExploratoryFieldSpec(ec.NewChild("organization"));

            }
        }
        else if (this.Organization != null && ec.Excludes("organization",false))
        {
            this.Organization = null;
        }
    }


    #endregion

    } // class CrossAccountPairInfo
    
    #endregion

    public static class ListCrossAccountPairInfoExtensions
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
            this List<CrossAccountPairInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CrossAccountPairInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CrossAccountPairInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CrossAccountPairInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CrossAccountPairInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types