// UpdateNutanixPrismCentralReply.cs
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
    #region UpdateNutanixPrismCentralReply
    public class UpdateNutanixPrismCentralReply: BaseType
    {
        #region members

        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        [JsonProperty("hostname")]
        public System.String? Hostname { get; set; }

        //      C# -> System.Boolean? IsDrEnabled
        // GraphQL -> isDrEnabled: Boolean (scalar)
        [JsonProperty("isDrEnabled")]
        public System.Boolean? IsDrEnabled { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }

        //      C# -> RefreshableObjectConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: RefreshableObjectConnectionStatus (type)
        [JsonProperty("connectionStatus")]
        public RefreshableObjectConnectionStatus? ConnectionStatus { get; set; }

        //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
        // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
        [JsonProperty("pendingSlaDomain")]
        public ManagedObjectPendingSlaInfo? PendingSlaDomain { get; set; }

        //      C# -> AsyncRequestStatus? RefreshJobAsyncReqStatus
        // GraphQL -> refreshJobAsyncReqStatus: AsyncRequestStatus (type)
        [JsonProperty("refreshJobAsyncReqStatus")]
        public AsyncRequestStatus? RefreshJobAsyncReqStatus { get; set; }

        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        [JsonProperty("slaAssignable")]
        public SlaAssignable? SlaAssignable { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UpdateNutanixPrismCentralReply";
    }

    public UpdateNutanixPrismCentralReply Set(
        System.String? Hostname = null,
        System.Boolean? IsDrEnabled = null,
        System.String? Username = null,
        RefreshableObjectConnectionStatus? ConnectionStatus = null,
        ManagedObjectPendingSlaInfo? PendingSlaDomain = null,
        AsyncRequestStatus? RefreshJobAsyncReqStatus = null,
        SlaAssignable? SlaAssignable = null
    ) 
    {
        if ( Hostname != null ) {
            this.Hostname = Hostname;
        }
        if ( IsDrEnabled != null ) {
            this.IsDrEnabled = IsDrEnabled;
        }
        if ( Username != null ) {
            this.Username = Username;
        }
        if ( ConnectionStatus != null ) {
            this.ConnectionStatus = ConnectionStatus;
        }
        if ( PendingSlaDomain != null ) {
            this.PendingSlaDomain = PendingSlaDomain;
        }
        if ( RefreshJobAsyncReqStatus != null ) {
            this.RefreshJobAsyncReqStatus = RefreshJobAsyncReqStatus;
        }
        if ( SlaAssignable != null ) {
            this.SlaAssignable = SlaAssignable;
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
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (this.Hostname != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostname\n" ;
            } else {
                s += ind + "hostname\n" ;
            }
        }
        //      C# -> System.Boolean? IsDrEnabled
        // GraphQL -> isDrEnabled: Boolean (scalar)
        if (this.IsDrEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isDrEnabled\n" ;
            } else {
                s += ind + "isDrEnabled\n" ;
            }
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (this.Username != null) {
            if (conf.Flat) {
                s += conf.Prefix + "username\n" ;
            } else {
                s += ind + "username\n" ;
            }
        }
        //      C# -> RefreshableObjectConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: RefreshableObjectConnectionStatus (type)
        if (this.ConnectionStatus != null) {
            var fspec = this.ConnectionStatus.AsFieldSpec(conf.Child("connectionStatus"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "connectionStatus" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
        // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
        if (this.PendingSlaDomain != null) {
            var fspec = this.PendingSlaDomain.AsFieldSpec(conf.Child("pendingSlaDomain"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "pendingSlaDomain" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> AsyncRequestStatus? RefreshJobAsyncReqStatus
        // GraphQL -> refreshJobAsyncReqStatus: AsyncRequestStatus (type)
        if (this.RefreshJobAsyncReqStatus != null) {
            var fspec = this.RefreshJobAsyncReqStatus.AsFieldSpec(conf.Child("refreshJobAsyncReqStatus"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "refreshJobAsyncReqStatus" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (this.SlaAssignable != null) {
            var fspec = this.SlaAssignable.AsFieldSpec(conf.Child("slaAssignable"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "slaAssignable" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (ec.Includes("hostname",true))
        {
            if(this.Hostname == null) {

                this.Hostname = "FETCH";

            } else {


            }
        }
        else if (this.Hostname != null && ec.Excludes("hostname",true))
        {
            this.Hostname = null;
        }
        //      C# -> System.Boolean? IsDrEnabled
        // GraphQL -> isDrEnabled: Boolean (scalar)
        if (ec.Includes("isDrEnabled",true))
        {
            if(this.IsDrEnabled == null) {

                this.IsDrEnabled = true;

            } else {


            }
        }
        else if (this.IsDrEnabled != null && ec.Excludes("isDrEnabled",true))
        {
            this.IsDrEnabled = null;
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        if (ec.Includes("username",true))
        {
            if(this.Username == null) {

                this.Username = "FETCH";

            } else {


            }
        }
        else if (this.Username != null && ec.Excludes("username",true))
        {
            this.Username = null;
        }
        //      C# -> RefreshableObjectConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: RefreshableObjectConnectionStatus (type)
        if (ec.Includes("connectionStatus",false))
        {
            if(this.ConnectionStatus == null) {

                this.ConnectionStatus = new RefreshableObjectConnectionStatus();
                this.ConnectionStatus.ApplyExploratoryFieldSpec(ec.NewChild("connectionStatus"));

            } else {

                this.ConnectionStatus.ApplyExploratoryFieldSpec(ec.NewChild("connectionStatus"));

            }
        }
        else if (this.ConnectionStatus != null && ec.Excludes("connectionStatus",false))
        {
            this.ConnectionStatus = null;
        }
        //      C# -> ManagedObjectPendingSlaInfo? PendingSlaDomain
        // GraphQL -> pendingSlaDomain: ManagedObjectPendingSlaInfo (type)
        if (ec.Includes("pendingSlaDomain",false))
        {
            if(this.PendingSlaDomain == null) {

                this.PendingSlaDomain = new ManagedObjectPendingSlaInfo();
                this.PendingSlaDomain.ApplyExploratoryFieldSpec(ec.NewChild("pendingSlaDomain"));

            } else {

                this.PendingSlaDomain.ApplyExploratoryFieldSpec(ec.NewChild("pendingSlaDomain"));

            }
        }
        else if (this.PendingSlaDomain != null && ec.Excludes("pendingSlaDomain",false))
        {
            this.PendingSlaDomain = null;
        }
        //      C# -> AsyncRequestStatus? RefreshJobAsyncReqStatus
        // GraphQL -> refreshJobAsyncReqStatus: AsyncRequestStatus (type)
        if (ec.Includes("refreshJobAsyncReqStatus",false))
        {
            if(this.RefreshJobAsyncReqStatus == null) {

                this.RefreshJobAsyncReqStatus = new AsyncRequestStatus();
                this.RefreshJobAsyncReqStatus.ApplyExploratoryFieldSpec(ec.NewChild("refreshJobAsyncReqStatus"));

            } else {

                this.RefreshJobAsyncReqStatus.ApplyExploratoryFieldSpec(ec.NewChild("refreshJobAsyncReqStatus"));

            }
        }
        else if (this.RefreshJobAsyncReqStatus != null && ec.Excludes("refreshJobAsyncReqStatus",false))
        {
            this.RefreshJobAsyncReqStatus = null;
        }
        //      C# -> SlaAssignable? SlaAssignable
        // GraphQL -> slaAssignable: SlaAssignable (type)
        if (ec.Includes("slaAssignable",false))
        {
            if(this.SlaAssignable == null) {

                this.SlaAssignable = new SlaAssignable();
                this.SlaAssignable.ApplyExploratoryFieldSpec(ec.NewChild("slaAssignable"));

            } else {

                this.SlaAssignable.ApplyExploratoryFieldSpec(ec.NewChild("slaAssignable"));

            }
        }
        else if (this.SlaAssignable != null && ec.Excludes("slaAssignable",false))
        {
            this.SlaAssignable = null;
        }
    }


    #endregion

    } // class UpdateNutanixPrismCentralReply
    
    #endregion

    public static class ListUpdateNutanixPrismCentralReplyExtensions
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
            this List<UpdateNutanixPrismCentralReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<UpdateNutanixPrismCentralReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UpdateNutanixPrismCentralReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateNutanixPrismCentralReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UpdateNutanixPrismCentralReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types