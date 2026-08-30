// MysqlTopologyReplicaInfo.cs
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
    #region MysqlTopologyReplicaInfo
    public class MysqlTopologyReplicaInfo: BaseType
    {
        #region members

        //      C# -> MysqldbInstanceAuthenticationType? AuthenticationType
        // GraphQL -> authenticationType: MysqldbInstanceAuthenticationType (enum)
        [JsonProperty("authenticationType")]
        public MysqldbInstanceAuthenticationType? AuthenticationType { get; set; }

        //      C# -> KosmosTopologyReplicaRole? Role
        // GraphQL -> role: KosmosTopologyReplicaRole! (enum)
        [JsonProperty("role")]
        public KosmosTopologyReplicaRole? Role { get; set; }

        //      C# -> KosmosTopologyReplicaStatus? Status
        // GraphQL -> status: KosmosTopologyReplicaStatus! (enum)
        [JsonProperty("status")]
        public KosmosTopologyReplicaStatus? Status { get; set; }

        //      C# -> System.String? BindIpAddress
        // GraphQL -> bindIpAddress: String (scalar)
        [JsonProperty("bindIpAddress")]
        public System.String? BindIpAddress { get; set; }

        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        [JsonProperty("hostId")]
        public System.String? HostId { get; set; }

        //      C# -> System.String? MysqlBinaryPath
        // GraphQL -> mysqlBinaryPath: String (scalar)
        [JsonProperty("mysqlBinaryPath")]
        public System.String? MysqlBinaryPath { get; set; }

        //      C# -> System.String? MysqlVersion
        // GraphQL -> mysqlVersion: String (scalar)
        [JsonProperty("mysqlVersion")]
        public System.String? MysqlVersion { get; set; }

        //      C# -> System.Int32? PortNumber
        // GraphQL -> portNumber: Int (scalar)
        [JsonProperty("portNumber")]
        public System.Int32? PortNumber { get; set; }

        //      C# -> System.String? ReplicaId
        // GraphQL -> replicaId: String! (scalar)
        [JsonProperty("replicaId")]
        public System.String? ReplicaId { get; set; }

        //      C# -> System.String? ReplicaName
        // GraphQL -> replicaName: String! (scalar)
        [JsonProperty("replicaName")]
        public System.String? ReplicaName { get; set; }

        //      C# -> System.String? SocketFilePath
        // GraphQL -> socketFilePath: String (scalar)
        [JsonProperty("socketFilePath")]
        public System.String? SocketFilePath { get; set; }

        //      C# -> System.String? SslCaCertFilePath
        // GraphQL -> sslCaCertFilePath: String (scalar)
        [JsonProperty("sslCaCertFilePath")]
        public System.String? SslCaCertFilePath { get; set; }

        //      C# -> System.String? SslCertFilePath
        // GraphQL -> sslCertFilePath: String (scalar)
        [JsonProperty("sslCertFilePath")]
        public System.String? SslCertFilePath { get; set; }

        //      C# -> System.String? SslKeyFilePath
        // GraphQL -> sslKeyFilePath: String (scalar)
        [JsonProperty("sslKeyFilePath")]
        public System.String? SslKeyFilePath { get; set; }

        //      C# -> List<System.String>? StatusMessages
        // GraphQL -> statusMessages: [String!]! (scalar)
        [JsonProperty("statusMessages")]
        public List<System.String>? StatusMessages { get; set; }

        //      C# -> System.String? SystemUsername
        // GraphQL -> systemUsername: String (scalar)
        [JsonProperty("systemUsername")]
        public System.String? SystemUsername { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String (scalar)
        [JsonProperty("username")]
        public System.String? Username { get; set; }

        //      C# -> List<KosmosUserMessage>? StatusMessageDetails
        // GraphQL -> statusMessageDetails: [KosmosUserMessage!]! (type)
        [JsonProperty("statusMessageDetails")]
        public List<KosmosUserMessage>? StatusMessageDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MysqlTopologyReplicaInfo";
    }

    public MysqlTopologyReplicaInfo Set(
        MysqldbInstanceAuthenticationType? AuthenticationType = null,
        KosmosTopologyReplicaRole? Role = null,
        KosmosTopologyReplicaStatus? Status = null,
        System.String? BindIpAddress = null,
        System.String? HostId = null,
        System.String? MysqlBinaryPath = null,
        System.String? MysqlVersion = null,
        System.Int32? PortNumber = null,
        System.String? ReplicaId = null,
        System.String? ReplicaName = null,
        System.String? SocketFilePath = null,
        System.String? SslCaCertFilePath = null,
        System.String? SslCertFilePath = null,
        System.String? SslKeyFilePath = null,
        List<System.String>? StatusMessages = null,
        System.String? SystemUsername = null,
        System.String? Username = null,
        List<KosmosUserMessage>? StatusMessageDetails = null
    ) 
    {
        if ( AuthenticationType != null ) {
            this.AuthenticationType = AuthenticationType;
        }
        if ( Role != null ) {
            this.Role = Role;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( BindIpAddress != null ) {
            this.BindIpAddress = BindIpAddress;
        }
        if ( HostId != null ) {
            this.HostId = HostId;
        }
        if ( MysqlBinaryPath != null ) {
            this.MysqlBinaryPath = MysqlBinaryPath;
        }
        if ( MysqlVersion != null ) {
            this.MysqlVersion = MysqlVersion;
        }
        if ( PortNumber != null ) {
            this.PortNumber = PortNumber;
        }
        if ( ReplicaId != null ) {
            this.ReplicaId = ReplicaId;
        }
        if ( ReplicaName != null ) {
            this.ReplicaName = ReplicaName;
        }
        if ( SocketFilePath != null ) {
            this.SocketFilePath = SocketFilePath;
        }
        if ( SslCaCertFilePath != null ) {
            this.SslCaCertFilePath = SslCaCertFilePath;
        }
        if ( SslCertFilePath != null ) {
            this.SslCertFilePath = SslCertFilePath;
        }
        if ( SslKeyFilePath != null ) {
            this.SslKeyFilePath = SslKeyFilePath;
        }
        if ( StatusMessages != null ) {
            this.StatusMessages = StatusMessages;
        }
        if ( SystemUsername != null ) {
            this.SystemUsername = SystemUsername;
        }
        if ( Username != null ) {
            this.Username = Username;
        }
        if ( StatusMessageDetails != null ) {
            this.StatusMessageDetails = StatusMessageDetails;
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
        //      C# -> MysqldbInstanceAuthenticationType? AuthenticationType
        // GraphQL -> authenticationType: MysqldbInstanceAuthenticationType (enum)
        if (this.AuthenticationType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "authenticationType\n" ;
            } else {
                s += ind + "authenticationType\n" ;
            }
        }
        //      C# -> KosmosTopologyReplicaRole? Role
        // GraphQL -> role: KosmosTopologyReplicaRole! (enum)
        if (this.Role != null) {
            if (conf.Flat) {
                s += conf.Prefix + "role\n" ;
            } else {
                s += ind + "role\n" ;
            }
        }
        //      C# -> KosmosTopologyReplicaStatus? Status
        // GraphQL -> status: KosmosTopologyReplicaStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? BindIpAddress
        // GraphQL -> bindIpAddress: String (scalar)
        if (this.BindIpAddress != null) {
            if (conf.Flat) {
                s += conf.Prefix + "bindIpAddress\n" ;
            } else {
                s += ind + "bindIpAddress\n" ;
            }
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        if (this.HostId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hostId\n" ;
            } else {
                s += ind + "hostId\n" ;
            }
        }
        //      C# -> System.String? MysqlBinaryPath
        // GraphQL -> mysqlBinaryPath: String (scalar)
        if (this.MysqlBinaryPath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mysqlBinaryPath\n" ;
            } else {
                s += ind + "mysqlBinaryPath\n" ;
            }
        }
        //      C# -> System.String? MysqlVersion
        // GraphQL -> mysqlVersion: String (scalar)
        if (this.MysqlVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mysqlVersion\n" ;
            } else {
                s += ind + "mysqlVersion\n" ;
            }
        }
        //      C# -> System.Int32? PortNumber
        // GraphQL -> portNumber: Int (scalar)
        if (this.PortNumber != null) {
            if (conf.Flat) {
                s += conf.Prefix + "portNumber\n" ;
            } else {
                s += ind + "portNumber\n" ;
            }
        }
        //      C# -> System.String? ReplicaId
        // GraphQL -> replicaId: String! (scalar)
        if (this.ReplicaId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "replicaId\n" ;
            } else {
                s += ind + "replicaId\n" ;
            }
        }
        //      C# -> System.String? ReplicaName
        // GraphQL -> replicaName: String! (scalar)
        if (this.ReplicaName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "replicaName\n" ;
            } else {
                s += ind + "replicaName\n" ;
            }
        }
        //      C# -> System.String? SocketFilePath
        // GraphQL -> socketFilePath: String (scalar)
        if (this.SocketFilePath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "socketFilePath\n" ;
            } else {
                s += ind + "socketFilePath\n" ;
            }
        }
        //      C# -> System.String? SslCaCertFilePath
        // GraphQL -> sslCaCertFilePath: String (scalar)
        if (this.SslCaCertFilePath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sslCaCertFilePath\n" ;
            } else {
                s += ind + "sslCaCertFilePath\n" ;
            }
        }
        //      C# -> System.String? SslCertFilePath
        // GraphQL -> sslCertFilePath: String (scalar)
        if (this.SslCertFilePath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sslCertFilePath\n" ;
            } else {
                s += ind + "sslCertFilePath\n" ;
            }
        }
        //      C# -> System.String? SslKeyFilePath
        // GraphQL -> sslKeyFilePath: String (scalar)
        if (this.SslKeyFilePath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sslKeyFilePath\n" ;
            } else {
                s += ind + "sslKeyFilePath\n" ;
            }
        }
        //      C# -> List<System.String>? StatusMessages
        // GraphQL -> statusMessages: [String!]! (scalar)
        if (this.StatusMessages != null) {
            if (conf.Flat) {
                s += conf.Prefix + "statusMessages\n" ;
            } else {
                s += ind + "statusMessages\n" ;
            }
        }
        //      C# -> System.String? SystemUsername
        // GraphQL -> systemUsername: String (scalar)
        if (this.SystemUsername != null) {
            if (conf.Flat) {
                s += conf.Prefix + "systemUsername\n" ;
            } else {
                s += ind + "systemUsername\n" ;
            }
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String (scalar)
        if (this.Username != null) {
            if (conf.Flat) {
                s += conf.Prefix + "username\n" ;
            } else {
                s += ind + "username\n" ;
            }
        }
        //      C# -> List<KosmosUserMessage>? StatusMessageDetails
        // GraphQL -> statusMessageDetails: [KosmosUserMessage!]! (type)
        if (this.StatusMessageDetails != null) {
            var fspec = this.StatusMessageDetails.AsFieldSpec(conf.Child("statusMessageDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "statusMessageDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> MysqldbInstanceAuthenticationType? AuthenticationType
        // GraphQL -> authenticationType: MysqldbInstanceAuthenticationType (enum)
        if (ec.Includes("authenticationType",true))
        {
            if(this.AuthenticationType == null) {

                this.AuthenticationType = new MysqldbInstanceAuthenticationType();

            } else {


            }
        }
        else if (this.AuthenticationType != null && ec.Excludes("authenticationType",true))
        {
            this.AuthenticationType = null;
        }
        //      C# -> KosmosTopologyReplicaRole? Role
        // GraphQL -> role: KosmosTopologyReplicaRole! (enum)
        if (ec.Includes("role",true))
        {
            if(this.Role == null) {

                this.Role = new KosmosTopologyReplicaRole();

            } else {


            }
        }
        else if (this.Role != null && ec.Excludes("role",true))
        {
            this.Role = null;
        }
        //      C# -> KosmosTopologyReplicaStatus? Status
        // GraphQL -> status: KosmosTopologyReplicaStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new KosmosTopologyReplicaStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? BindIpAddress
        // GraphQL -> bindIpAddress: String (scalar)
        if (ec.Includes("bindIpAddress",true))
        {
            if(this.BindIpAddress == null) {

                this.BindIpAddress = "FETCH";

            } else {


            }
        }
        else if (this.BindIpAddress != null && ec.Excludes("bindIpAddress",true))
        {
            this.BindIpAddress = null;
        }
        //      C# -> System.String? HostId
        // GraphQL -> hostId: String! (scalar)
        if (ec.Includes("hostId",true))
        {
            if(this.HostId == null) {

                this.HostId = "FETCH";

            } else {


            }
        }
        else if (this.HostId != null && ec.Excludes("hostId",true))
        {
            this.HostId = null;
        }
        //      C# -> System.String? MysqlBinaryPath
        // GraphQL -> mysqlBinaryPath: String (scalar)
        if (ec.Includes("mysqlBinaryPath",true))
        {
            if(this.MysqlBinaryPath == null) {

                this.MysqlBinaryPath = "FETCH";

            } else {


            }
        }
        else if (this.MysqlBinaryPath != null && ec.Excludes("mysqlBinaryPath",true))
        {
            this.MysqlBinaryPath = null;
        }
        //      C# -> System.String? MysqlVersion
        // GraphQL -> mysqlVersion: String (scalar)
        if (ec.Includes("mysqlVersion",true))
        {
            if(this.MysqlVersion == null) {

                this.MysqlVersion = "FETCH";

            } else {


            }
        }
        else if (this.MysqlVersion != null && ec.Excludes("mysqlVersion",true))
        {
            this.MysqlVersion = null;
        }
        //      C# -> System.Int32? PortNumber
        // GraphQL -> portNumber: Int (scalar)
        if (ec.Includes("portNumber",true))
        {
            if(this.PortNumber == null) {

                this.PortNumber = Int32.MinValue;

            } else {


            }
        }
        else if (this.PortNumber != null && ec.Excludes("portNumber",true))
        {
            this.PortNumber = null;
        }
        //      C# -> System.String? ReplicaId
        // GraphQL -> replicaId: String! (scalar)
        if (ec.Includes("replicaId",true))
        {
            if(this.ReplicaId == null) {

                this.ReplicaId = "FETCH";

            } else {


            }
        }
        else if (this.ReplicaId != null && ec.Excludes("replicaId",true))
        {
            this.ReplicaId = null;
        }
        //      C# -> System.String? ReplicaName
        // GraphQL -> replicaName: String! (scalar)
        if (ec.Includes("replicaName",true))
        {
            if(this.ReplicaName == null) {

                this.ReplicaName = "FETCH";

            } else {


            }
        }
        else if (this.ReplicaName != null && ec.Excludes("replicaName",true))
        {
            this.ReplicaName = null;
        }
        //      C# -> System.String? SocketFilePath
        // GraphQL -> socketFilePath: String (scalar)
        if (ec.Includes("socketFilePath",true))
        {
            if(this.SocketFilePath == null) {

                this.SocketFilePath = "FETCH";

            } else {


            }
        }
        else if (this.SocketFilePath != null && ec.Excludes("socketFilePath",true))
        {
            this.SocketFilePath = null;
        }
        //      C# -> System.String? SslCaCertFilePath
        // GraphQL -> sslCaCertFilePath: String (scalar)
        if (ec.Includes("sslCaCertFilePath",true))
        {
            if(this.SslCaCertFilePath == null) {

                this.SslCaCertFilePath = "FETCH";

            } else {


            }
        }
        else if (this.SslCaCertFilePath != null && ec.Excludes("sslCaCertFilePath",true))
        {
            this.SslCaCertFilePath = null;
        }
        //      C# -> System.String? SslCertFilePath
        // GraphQL -> sslCertFilePath: String (scalar)
        if (ec.Includes("sslCertFilePath",true))
        {
            if(this.SslCertFilePath == null) {

                this.SslCertFilePath = "FETCH";

            } else {


            }
        }
        else if (this.SslCertFilePath != null && ec.Excludes("sslCertFilePath",true))
        {
            this.SslCertFilePath = null;
        }
        //      C# -> System.String? SslKeyFilePath
        // GraphQL -> sslKeyFilePath: String (scalar)
        if (ec.Includes("sslKeyFilePath",true))
        {
            if(this.SslKeyFilePath == null) {

                this.SslKeyFilePath = "FETCH";

            } else {


            }
        }
        else if (this.SslKeyFilePath != null && ec.Excludes("sslKeyFilePath",true))
        {
            this.SslKeyFilePath = null;
        }
        //      C# -> List<System.String>? StatusMessages
        // GraphQL -> statusMessages: [String!]! (scalar)
        if (ec.Includes("statusMessages",true))
        {
            if(this.StatusMessages == null) {

                this.StatusMessages = new List<System.String>();

            } else {


            }
        }
        else if (this.StatusMessages != null && ec.Excludes("statusMessages",true))
        {
            this.StatusMessages = null;
        }
        //      C# -> System.String? SystemUsername
        // GraphQL -> systemUsername: String (scalar)
        if (ec.Includes("systemUsername",true))
        {
            if(this.SystemUsername == null) {

                this.SystemUsername = "FETCH";

            } else {


            }
        }
        else if (this.SystemUsername != null && ec.Excludes("systemUsername",true))
        {
            this.SystemUsername = null;
        }
        //      C# -> System.String? Username
        // GraphQL -> username: String (scalar)
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
        //      C# -> List<KosmosUserMessage>? StatusMessageDetails
        // GraphQL -> statusMessageDetails: [KosmosUserMessage!]! (type)
        if (ec.Includes("statusMessageDetails",false))
        {
            if(this.StatusMessageDetails == null) {

                this.StatusMessageDetails = new List<KosmosUserMessage>();
                this.StatusMessageDetails.ApplyExploratoryFieldSpec(ec.NewChild("statusMessageDetails"));

            } else {

                this.StatusMessageDetails.ApplyExploratoryFieldSpec(ec.NewChild("statusMessageDetails"));

            }
        }
        else if (this.StatusMessageDetails != null && ec.Excludes("statusMessageDetails",false))
        {
            this.StatusMessageDetails = null;
        }
    }


    #endregion

    } // class MysqlTopologyReplicaInfo
    
    #endregion

    public static class ListMysqlTopologyReplicaInfoExtensions
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
            this List<MysqlTopologyReplicaInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MysqlTopologyReplicaInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MysqlTopologyReplicaInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MysqlTopologyReplicaInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MysqlTopologyReplicaInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types