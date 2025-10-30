// AzureAdLocalAdminPassword.cs
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
    #region AzureAdLocalAdminPassword
    public class AzureAdLocalAdminPassword: BaseType
    {
        #region members

        //      C# -> System.String? AccountName
        // GraphQL -> accountName: String! (scalar)
        [JsonProperty("accountName")]
        public System.String? AccountName { get; set; }

        //      C# -> System.String? AccountSid
        // GraphQL -> accountSid: String! (scalar)
        [JsonProperty("accountSid")]
        public System.String? AccountSid { get; set; }

        //      C# -> System.String? DeviceName
        // GraphQL -> deviceName: String! (scalar)
        [JsonProperty("deviceName")]
        public System.String? DeviceName { get; set; }

        //      C# -> DateTime? LastBackupDateTime
        // GraphQL -> lastBackupDateTime: DateTime (scalar)
        [JsonProperty("lastBackupDateTime")]
        public DateTime? LastBackupDateTime { get; set; }

        //      C# -> System.String? Password
        // GraphQL -> password: String (scalar)
        [JsonProperty("password")]
        public System.String? Password { get; set; }

        //      C# -> DateTime? RefreshDateTime
        // GraphQL -> refreshDateTime: DateTime (scalar)
        [JsonProperty("refreshDateTime")]
        public DateTime? RefreshDateTime { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureAdLocalAdminPassword";
    }

    public AzureAdLocalAdminPassword Set(
        System.String? AccountName = null,
        System.String? AccountSid = null,
        System.String? DeviceName = null,
        DateTime? LastBackupDateTime = null,
        System.String? Password = null,
        DateTime? RefreshDateTime = null
    ) 
    {
        if ( AccountName != null ) {
            this.AccountName = AccountName;
        }
        if ( AccountSid != null ) {
            this.AccountSid = AccountSid;
        }
        if ( DeviceName != null ) {
            this.DeviceName = DeviceName;
        }
        if ( LastBackupDateTime != null ) {
            this.LastBackupDateTime = LastBackupDateTime;
        }
        if ( Password != null ) {
            this.Password = Password;
        }
        if ( RefreshDateTime != null ) {
            this.RefreshDateTime = RefreshDateTime;
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
        //      C# -> System.String? AccountName
        // GraphQL -> accountName: String! (scalar)
        if (this.AccountName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accountName\n" ;
            } else {
                s += ind + "accountName\n" ;
            }
        }
        //      C# -> System.String? AccountSid
        // GraphQL -> accountSid: String! (scalar)
        if (this.AccountSid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accountSid\n" ;
            } else {
                s += ind + "accountSid\n" ;
            }
        }
        //      C# -> System.String? DeviceName
        // GraphQL -> deviceName: String! (scalar)
        if (this.DeviceName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "deviceName\n" ;
            } else {
                s += ind + "deviceName\n" ;
            }
        }
        //      C# -> DateTime? LastBackupDateTime
        // GraphQL -> lastBackupDateTime: DateTime (scalar)
        if (this.LastBackupDateTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastBackupDateTime\n" ;
            } else {
                s += ind + "lastBackupDateTime\n" ;
            }
        }
        //      C# -> System.String? Password
        // GraphQL -> password: String (scalar)
        if (this.Password != null) {
            if (conf.Flat) {
                s += conf.Prefix + "password\n" ;
            } else {
                s += ind + "password\n" ;
            }
        }
        //      C# -> DateTime? RefreshDateTime
        // GraphQL -> refreshDateTime: DateTime (scalar)
        if (this.RefreshDateTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "refreshDateTime\n" ;
            } else {
                s += ind + "refreshDateTime\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? AccountName
        // GraphQL -> accountName: String! (scalar)
        if (ec.Includes("accountName",true))
        {
            if(this.AccountName == null) {

                this.AccountName = "FETCH";

            } else {


            }
        }
        else if (this.AccountName != null && ec.Excludes("accountName",true))
        {
            this.AccountName = null;
        }
        //      C# -> System.String? AccountSid
        // GraphQL -> accountSid: String! (scalar)
        if (ec.Includes("accountSid",true))
        {
            if(this.AccountSid == null) {

                this.AccountSid = "FETCH";

            } else {


            }
        }
        else if (this.AccountSid != null && ec.Excludes("accountSid",true))
        {
            this.AccountSid = null;
        }
        //      C# -> System.String? DeviceName
        // GraphQL -> deviceName: String! (scalar)
        if (ec.Includes("deviceName",true))
        {
            if(this.DeviceName == null) {

                this.DeviceName = "FETCH";

            } else {


            }
        }
        else if (this.DeviceName != null && ec.Excludes("deviceName",true))
        {
            this.DeviceName = null;
        }
        //      C# -> DateTime? LastBackupDateTime
        // GraphQL -> lastBackupDateTime: DateTime (scalar)
        if (ec.Includes("lastBackupDateTime",true))
        {
            if(this.LastBackupDateTime == null) {

                this.LastBackupDateTime = new DateTime();

            } else {


            }
        }
        else if (this.LastBackupDateTime != null && ec.Excludes("lastBackupDateTime",true))
        {
            this.LastBackupDateTime = null;
        }
        //      C# -> System.String? Password
        // GraphQL -> password: String (scalar)
        if (ec.Includes("password",true))
        {
            if(this.Password == null) {

                this.Password = "FETCH";

            } else {


            }
        }
        else if (this.Password != null && ec.Excludes("password",true))
        {
            this.Password = null;
        }
        //      C# -> DateTime? RefreshDateTime
        // GraphQL -> refreshDateTime: DateTime (scalar)
        if (ec.Includes("refreshDateTime",true))
        {
            if(this.RefreshDateTime == null) {

                this.RefreshDateTime = new DateTime();

            } else {


            }
        }
        else if (this.RefreshDateTime != null && ec.Excludes("refreshDateTime",true))
        {
            this.RefreshDateTime = null;
        }
    }


    #endregion

    } // class AzureAdLocalAdminPassword
    
    #endregion

    public static class ListAzureAdLocalAdminPasswordExtensions
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
            this List<AzureAdLocalAdminPassword> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureAdLocalAdminPassword> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureAdLocalAdminPassword> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureAdLocalAdminPassword());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureAdLocalAdminPassword> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types