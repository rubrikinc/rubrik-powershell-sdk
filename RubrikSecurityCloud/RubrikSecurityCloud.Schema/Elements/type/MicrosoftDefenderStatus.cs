// MicrosoftDefenderStatus.cs
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
    #region MicrosoftDefenderStatus
    public class MicrosoftDefenderStatus: BaseType
    {
        #region members

        //      C# -> MicrosoftDefenderStatusCode? Code
        // GraphQL -> code: MicrosoftDefenderStatusCode! (enum)
        [JsonProperty("code")]
        public MicrosoftDefenderStatusCode? Code { get; set; }

        //      C# -> DateTime? CredentialExpiresAt
        // GraphQL -> credentialExpiresAt: DateTime (scalar)
        [JsonProperty("credentialExpiresAt")]
        public DateTime? CredentialExpiresAt { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MicrosoftDefenderStatus";
    }

    public MicrosoftDefenderStatus Set(
        MicrosoftDefenderStatusCode? Code = null,
        DateTime? CredentialExpiresAt = null
    ) 
    {
        if ( Code != null ) {
            this.Code = Code;
        }
        if ( CredentialExpiresAt != null ) {
            this.CredentialExpiresAt = CredentialExpiresAt;
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
        //      C# -> MicrosoftDefenderStatusCode? Code
        // GraphQL -> code: MicrosoftDefenderStatusCode! (enum)
        if (this.Code != null) {
            if (conf.Flat) {
                s += conf.Prefix + "code\n" ;
            } else {
                s += ind + "code\n" ;
            }
        }
        //      C# -> DateTime? CredentialExpiresAt
        // GraphQL -> credentialExpiresAt: DateTime (scalar)
        if (this.CredentialExpiresAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "credentialExpiresAt\n" ;
            } else {
                s += ind + "credentialExpiresAt\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> MicrosoftDefenderStatusCode? Code
        // GraphQL -> code: MicrosoftDefenderStatusCode! (enum)
        if (ec.Includes("code",true))
        {
            if(this.Code == null) {

                this.Code = new MicrosoftDefenderStatusCode();

            } else {


            }
        }
        else if (this.Code != null && ec.Excludes("code",true))
        {
            this.Code = null;
        }
        //      C# -> DateTime? CredentialExpiresAt
        // GraphQL -> credentialExpiresAt: DateTime (scalar)
        if (ec.Includes("credentialExpiresAt",true))
        {
            if(this.CredentialExpiresAt == null) {

                this.CredentialExpiresAt = new DateTime();

            } else {


            }
        }
        else if (this.CredentialExpiresAt != null && ec.Excludes("credentialExpiresAt",true))
        {
            this.CredentialExpiresAt = null;
        }
    }


    #endregion

    } // class MicrosoftDefenderStatus
    
    #endregion

    public static class ListMicrosoftDefenderStatusExtensions
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
            this List<MicrosoftDefenderStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MicrosoftDefenderStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MicrosoftDefenderStatus> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MicrosoftDefenderStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MicrosoftDefenderStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types