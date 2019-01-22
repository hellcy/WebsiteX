﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebsiteX.ASPSMSX2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="https://webservice.aspsms.com/aspsmsx2.asmx", ConfigurationName="ASPSMSX2.ASPSMSX2Soap")]
    public interface ASPSMSX2Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="https://webservice.aspsms.com/aspsmsx2.asmx/SimpleWAPPush", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string SimpleWAPPush(string UserKey, string Password, string Recipients, string Originator, string WapDescription, string WapURL, string DeferredDeliveryTime, string FlashingSMS, string TimeZone, string URLBufferedMessageNotification, string URLDeliveryNotification, string URLNonDeliveryNotification, string AffiliateId);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://webservice.aspsms.com/aspsmsx2.asmx/SimpleWAPPush", ReplyAction="*")]
        System.Threading.Tasks.Task<string> SimpleWAPPushAsync(string UserKey, string Password, string Recipients, string Originator, string WapDescription, string WapURL, string DeferredDeliveryTime, string FlashingSMS, string TimeZone, string URLBufferedMessageNotification, string URLDeliveryNotification, string URLNonDeliveryNotification, string AffiliateId);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://webservice.aspsms.com/aspsmsx2.asmx/SendSimpleTextSMS", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string SendSimpleTextSMS(string UserKey, string Password, string Recipients, string Originator, string MessageText);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://webservice.aspsms.com/aspsmsx2.asmx/SendSimpleTextSMS", ReplyAction="*")]
        System.Threading.Tasks.Task<string> SendSimpleTextSMSAsync(string UserKey, string Password, string Recipients, string Originator, string MessageText);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://webservice.aspsms.com/aspsmsx2.asmx/SendTextSMS", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string SendTextSMS(string UserKey, string Password, string Recipients, string Originator, string MessageText, string DeferredDeliveryTime, string FlashingSMS, string TimeZone, string URLBufferedMessageNotification, string URLDeliveryNotification, string URLNonDeliveryNotification, string AffiliateId);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://webservice.aspsms.com/aspsmsx2.asmx/SendTextSMS", ReplyAction="*")]
        System.Threading.Tasks.Task<string> SendTextSMSAsync(string UserKey, string Password, string Recipients, string Originator, string MessageText, string DeferredDeliveryTime, string FlashingSMS, string TimeZone, string URLBufferedMessageNotification, string URLDeliveryNotification, string URLNonDeliveryNotification, string AffiliateId);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://webservice.aspsms.com/aspsmsx2.asmx/SendUnicodeSMS", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string SendUnicodeSMS(string UserKey, string Password, string Recipients, string Originator, string MessageText, string DeferredDeliveryTime, string FlashingSMS, string TimeZone, string URLBufferedMessageNotification, string URLDeliveryNotification, string URLNonDeliveryNotification, string AffiliateId);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://webservice.aspsms.com/aspsmsx2.asmx/SendUnicodeSMS", ReplyAction="*")]
        System.Threading.Tasks.Task<string> SendUnicodeSMSAsync(string UserKey, string Password, string Recipients, string Originator, string MessageText, string DeferredDeliveryTime, string FlashingSMS, string TimeZone, string URLBufferedMessageNotification, string URLDeliveryNotification, string URLNonDeliveryNotification, string AffiliateId);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://webservice.aspsms.com/aspsmsx2.asmx/CheckCredits", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string CheckCredits(string UserKey, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://webservice.aspsms.com/aspsmsx2.asmx/CheckCredits", ReplyAction="*")]
        System.Threading.Tasks.Task<string> CheckCreditsAsync(string UserKey, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://webservice.aspsms.com/aspsmsx2.asmx/SendOriginatorUnlockCode", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string SendOriginatorUnlockCode(string UserKey, string Password, string Originator);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://webservice.aspsms.com/aspsmsx2.asmx/SendOriginatorUnlockCode", ReplyAction="*")]
        System.Threading.Tasks.Task<string> SendOriginatorUnlockCodeAsync(string UserKey, string Password, string Originator);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://webservice.aspsms.com/aspsmsx2.asmx/UnlockOriginator", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string UnlockOriginator(string UserKey, string Password, string Originator, string OriginatorUnlockCode, string AffiliateId);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://webservice.aspsms.com/aspsmsx2.asmx/UnlockOriginator", ReplyAction="*")]
        System.Threading.Tasks.Task<string> UnlockOriginatorAsync(string UserKey, string Password, string Originator, string OriginatorUnlockCode, string AffiliateId);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://webservice.aspsms.com/aspsmsx2.asmx/CheckOriginatorAuthorization", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string CheckOriginatorAuthorization(string UserKey, string Password, string Originator);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://webservice.aspsms.com/aspsmsx2.asmx/CheckOriginatorAuthorization", ReplyAction="*")]
        System.Threading.Tasks.Task<string> CheckOriginatorAuthorizationAsync(string UserKey, string Password, string Originator);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://webservice.aspsms.com/aspsmsx2.asmx/VerifyToken", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string VerifyToken(string UserKey, string Password, string PhoneNumber, string TokenReference, string VerificationCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://webservice.aspsms.com/aspsmsx2.asmx/VerifyToken", ReplyAction="*")]
        System.Threading.Tasks.Task<string> VerifyTokenAsync(string UserKey, string Password, string PhoneNumber, string TokenReference, string VerificationCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://webservice.aspsms.com/aspsmsx2.asmx/SendTokenSMS", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string SendTokenSMS(string UserKey, string Password, string Originator, string Recipients, string MessageData, string TokenReference, string TokenValidity, string TokenMask, string VerificationCode, string TokenCaseSensitive, string URLBufferedMessageNotification, string URLDeliveryNotification, string URLNonDeliveryNotification, string AffiliateId);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://webservice.aspsms.com/aspsmsx2.asmx/SendTokenSMS", ReplyAction="*")]
        System.Threading.Tasks.Task<string> SendTokenSMSAsync(string UserKey, string Password, string Originator, string Recipients, string MessageData, string TokenReference, string TokenValidity, string TokenMask, string VerificationCode, string TokenCaseSensitive, string URLBufferedMessageNotification, string URLDeliveryNotification, string URLNonDeliveryNotification, string AffiliateId);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://webservice.aspsms.com/aspsmsx2.asmx/InquireDeliveryNotifications", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string InquireDeliveryNotifications(string UserKey, string Password, string TransactionReferenceNumbers);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://webservice.aspsms.com/aspsmsx2.asmx/InquireDeliveryNotifications", ReplyAction="*")]
        System.Threading.Tasks.Task<string> InquireDeliveryNotificationsAsync(string UserKey, string Password, string TransactionReferenceNumbers);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://webservice.aspsms.com/aspsmsx2.asmx/RedeemVoucher", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string RedeemVoucher(string UserKey, string Password, string RedeemCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://webservice.aspsms.com/aspsmsx2.asmx/RedeemVoucher", ReplyAction="*")]
        System.Threading.Tasks.Task<string> RedeemVoucherAsync(string UserKey, string Password, string RedeemCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://webservice.aspsms.com/aspsmsx2.asmx/CreateVoucher", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string CreateVoucher(string UserKey, string Password, string NumberOfVouchers, string AmountCreditsPerVoucher, string Remarks);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://webservice.aspsms.com/aspsmsx2.asmx/CreateVoucher", ReplyAction="*")]
        System.Threading.Tasks.Task<string> CreateVoucherAsync(string UserKey, string Password, string NumberOfVouchers, string AmountCreditsPerVoucher, string Remarks);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://webservice.aspsms.com/aspsmsx2.asmx/GetVoucherTransactions", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        WebsiteX.ASPSMSX2.vouchers[] GetVoucherTransactions(string UserKey, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://webservice.aspsms.com/aspsmsx2.asmx/GetVoucherTransactions", ReplyAction="*")]
        System.Threading.Tasks.Task<WebsiteX.ASPSMSX2.vouchers[]> GetVoucherTransactionsAsync(string UserKey, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://webservice.aspsms.com/aspsmsx2.asmx/GetStatusCodeDescription", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string GetStatusCodeDescription(string StatusCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://webservice.aspsms.com/aspsmsx2.asmx/GetStatusCodeDescription", ReplyAction="*")]
        System.Threading.Tasks.Task<string> GetStatusCodeDescriptionAsync(string StatusCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="https://webservice.aspsms.com/aspsmsx2.asmx/VersionInfo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string VersionInfo();
        
        [System.ServiceModel.OperationContractAttribute(Action="https://webservice.aspsms.com/aspsmsx2.asmx/VersionInfo", ReplyAction="*")]
        System.Threading.Tasks.Task<string> VersionInfoAsync();
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3062.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webservice.aspsms.com/aspsmsx2.asmx")]
    public partial class vouchers : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string voucherCodeField;
        
        private string remarkField;
        
        private string creditsField;
        
        private string createdField;
        
        private string redeemedField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string VoucherCode {
            get {
                return this.voucherCodeField;
            }
            set {
                this.voucherCodeField = value;
                this.RaisePropertyChanged("VoucherCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Remark {
            get {
                return this.remarkField;
            }
            set {
                this.remarkField = value;
                this.RaisePropertyChanged("Remark");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Credits {
            get {
                return this.creditsField;
            }
            set {
                this.creditsField = value;
                this.RaisePropertyChanged("Credits");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Created {
            get {
                return this.createdField;
            }
            set {
                this.createdField = value;
                this.RaisePropertyChanged("Created");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Redeemed {
            get {
                return this.redeemedField;
            }
            set {
                this.redeemedField = value;
                this.RaisePropertyChanged("Redeemed");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ASPSMSX2SoapChannel : WebsiteX.ASPSMSX2.ASPSMSX2Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ASPSMSX2SoapClient : System.ServiceModel.ClientBase<WebsiteX.ASPSMSX2.ASPSMSX2Soap>, WebsiteX.ASPSMSX2.ASPSMSX2Soap {
        
        public ASPSMSX2SoapClient() {
        }
        
        public ASPSMSX2SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ASPSMSX2SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ASPSMSX2SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ASPSMSX2SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string SimpleWAPPush(string UserKey, string Password, string Recipients, string Originator, string WapDescription, string WapURL, string DeferredDeliveryTime, string FlashingSMS, string TimeZone, string URLBufferedMessageNotification, string URLDeliveryNotification, string URLNonDeliveryNotification, string AffiliateId) {
            return base.Channel.SimpleWAPPush(UserKey, Password, Recipients, Originator, WapDescription, WapURL, DeferredDeliveryTime, FlashingSMS, TimeZone, URLBufferedMessageNotification, URLDeliveryNotification, URLNonDeliveryNotification, AffiliateId);
        }
        
        public System.Threading.Tasks.Task<string> SimpleWAPPushAsync(string UserKey, string Password, string Recipients, string Originator, string WapDescription, string WapURL, string DeferredDeliveryTime, string FlashingSMS, string TimeZone, string URLBufferedMessageNotification, string URLDeliveryNotification, string URLNonDeliveryNotification, string AffiliateId) {
            return base.Channel.SimpleWAPPushAsync(UserKey, Password, Recipients, Originator, WapDescription, WapURL, DeferredDeliveryTime, FlashingSMS, TimeZone, URLBufferedMessageNotification, URLDeliveryNotification, URLNonDeliveryNotification, AffiliateId);
        }
        
        public string SendSimpleTextSMS(string UserKey, string Password, string Recipients, string Originator, string MessageText) {
            return base.Channel.SendSimpleTextSMS(UserKey, Password, Recipients, Originator, MessageText);
        }
        
        public System.Threading.Tasks.Task<string> SendSimpleTextSMSAsync(string UserKey, string Password, string Recipients, string Originator, string MessageText) {
            return base.Channel.SendSimpleTextSMSAsync(UserKey, Password, Recipients, Originator, MessageText);
        }
        
        public string SendTextSMS(string UserKey, string Password, string Recipients, string Originator, string MessageText, string DeferredDeliveryTime, string FlashingSMS, string TimeZone, string URLBufferedMessageNotification, string URLDeliveryNotification, string URLNonDeliveryNotification, string AffiliateId) {
            return base.Channel.SendTextSMS(UserKey, Password, Recipients, Originator, MessageText, DeferredDeliveryTime, FlashingSMS, TimeZone, URLBufferedMessageNotification, URLDeliveryNotification, URLNonDeliveryNotification, AffiliateId);
        }
        
        public System.Threading.Tasks.Task<string> SendTextSMSAsync(string UserKey, string Password, string Recipients, string Originator, string MessageText, string DeferredDeliveryTime, string FlashingSMS, string TimeZone, string URLBufferedMessageNotification, string URLDeliveryNotification, string URLNonDeliveryNotification, string AffiliateId) {
            return base.Channel.SendTextSMSAsync(UserKey, Password, Recipients, Originator, MessageText, DeferredDeliveryTime, FlashingSMS, TimeZone, URLBufferedMessageNotification, URLDeliveryNotification, URLNonDeliveryNotification, AffiliateId);
        }
        
        public string SendUnicodeSMS(string UserKey, string Password, string Recipients, string Originator, string MessageText, string DeferredDeliveryTime, string FlashingSMS, string TimeZone, string URLBufferedMessageNotification, string URLDeliveryNotification, string URLNonDeliveryNotification, string AffiliateId) {
            return base.Channel.SendUnicodeSMS(UserKey, Password, Recipients, Originator, MessageText, DeferredDeliveryTime, FlashingSMS, TimeZone, URLBufferedMessageNotification, URLDeliveryNotification, URLNonDeliveryNotification, AffiliateId);
        }
        
        public System.Threading.Tasks.Task<string> SendUnicodeSMSAsync(string UserKey, string Password, string Recipients, string Originator, string MessageText, string DeferredDeliveryTime, string FlashingSMS, string TimeZone, string URLBufferedMessageNotification, string URLDeliveryNotification, string URLNonDeliveryNotification, string AffiliateId) {
            return base.Channel.SendUnicodeSMSAsync(UserKey, Password, Recipients, Originator, MessageText, DeferredDeliveryTime, FlashingSMS, TimeZone, URLBufferedMessageNotification, URLDeliveryNotification, URLNonDeliveryNotification, AffiliateId);
        }
        
        public string CheckCredits(string UserKey, string Password) {
            return base.Channel.CheckCredits(UserKey, Password);
        }
        
        public System.Threading.Tasks.Task<string> CheckCreditsAsync(string UserKey, string Password) {
            return base.Channel.CheckCreditsAsync(UserKey, Password);
        }
        
        public string SendOriginatorUnlockCode(string UserKey, string Password, string Originator) {
            return base.Channel.SendOriginatorUnlockCode(UserKey, Password, Originator);
        }
        
        public System.Threading.Tasks.Task<string> SendOriginatorUnlockCodeAsync(string UserKey, string Password, string Originator) {
            return base.Channel.SendOriginatorUnlockCodeAsync(UserKey, Password, Originator);
        }
        
        public string UnlockOriginator(string UserKey, string Password, string Originator, string OriginatorUnlockCode, string AffiliateId) {
            return base.Channel.UnlockOriginator(UserKey, Password, Originator, OriginatorUnlockCode, AffiliateId);
        }
        
        public System.Threading.Tasks.Task<string> UnlockOriginatorAsync(string UserKey, string Password, string Originator, string OriginatorUnlockCode, string AffiliateId) {
            return base.Channel.UnlockOriginatorAsync(UserKey, Password, Originator, OriginatorUnlockCode, AffiliateId);
        }
        
        public string CheckOriginatorAuthorization(string UserKey, string Password, string Originator) {
            return base.Channel.CheckOriginatorAuthorization(UserKey, Password, Originator);
        }
        
        public System.Threading.Tasks.Task<string> CheckOriginatorAuthorizationAsync(string UserKey, string Password, string Originator) {
            return base.Channel.CheckOriginatorAuthorizationAsync(UserKey, Password, Originator);
        }
        
        public string VerifyToken(string UserKey, string Password, string PhoneNumber, string TokenReference, string VerificationCode) {
            return base.Channel.VerifyToken(UserKey, Password, PhoneNumber, TokenReference, VerificationCode);
        }
        
        public System.Threading.Tasks.Task<string> VerifyTokenAsync(string UserKey, string Password, string PhoneNumber, string TokenReference, string VerificationCode) {
            return base.Channel.VerifyTokenAsync(UserKey, Password, PhoneNumber, TokenReference, VerificationCode);
        }
        
        public string SendTokenSMS(string UserKey, string Password, string Originator, string Recipients, string MessageData, string TokenReference, string TokenValidity, string TokenMask, string VerificationCode, string TokenCaseSensitive, string URLBufferedMessageNotification, string URLDeliveryNotification, string URLNonDeliveryNotification, string AffiliateId) {
            return base.Channel.SendTokenSMS(UserKey, Password, Originator, Recipients, MessageData, TokenReference, TokenValidity, TokenMask, VerificationCode, TokenCaseSensitive, URLBufferedMessageNotification, URLDeliveryNotification, URLNonDeliveryNotification, AffiliateId);
        }
        
        public System.Threading.Tasks.Task<string> SendTokenSMSAsync(string UserKey, string Password, string Originator, string Recipients, string MessageData, string TokenReference, string TokenValidity, string TokenMask, string VerificationCode, string TokenCaseSensitive, string URLBufferedMessageNotification, string URLDeliveryNotification, string URLNonDeliveryNotification, string AffiliateId) {
            return base.Channel.SendTokenSMSAsync(UserKey, Password, Originator, Recipients, MessageData, TokenReference, TokenValidity, TokenMask, VerificationCode, TokenCaseSensitive, URLBufferedMessageNotification, URLDeliveryNotification, URLNonDeliveryNotification, AffiliateId);
        }
        
        public string InquireDeliveryNotifications(string UserKey, string Password, string TransactionReferenceNumbers) {
            return base.Channel.InquireDeliveryNotifications(UserKey, Password, TransactionReferenceNumbers);
        }
        
        public System.Threading.Tasks.Task<string> InquireDeliveryNotificationsAsync(string UserKey, string Password, string TransactionReferenceNumbers) {
            return base.Channel.InquireDeliveryNotificationsAsync(UserKey, Password, TransactionReferenceNumbers);
        }
        
        public string RedeemVoucher(string UserKey, string Password, string RedeemCode) {
            return base.Channel.RedeemVoucher(UserKey, Password, RedeemCode);
        }
        
        public System.Threading.Tasks.Task<string> RedeemVoucherAsync(string UserKey, string Password, string RedeemCode) {
            return base.Channel.RedeemVoucherAsync(UserKey, Password, RedeemCode);
        }
        
        public string CreateVoucher(string UserKey, string Password, string NumberOfVouchers, string AmountCreditsPerVoucher, string Remarks) {
            return base.Channel.CreateVoucher(UserKey, Password, NumberOfVouchers, AmountCreditsPerVoucher, Remarks);
        }
        
        public System.Threading.Tasks.Task<string> CreateVoucherAsync(string UserKey, string Password, string NumberOfVouchers, string AmountCreditsPerVoucher, string Remarks) {
            return base.Channel.CreateVoucherAsync(UserKey, Password, NumberOfVouchers, AmountCreditsPerVoucher, Remarks);
        }
        
        public WebsiteX.ASPSMSX2.vouchers[] GetVoucherTransactions(string UserKey, string Password) {
            return base.Channel.GetVoucherTransactions(UserKey, Password);
        }
        
        public System.Threading.Tasks.Task<WebsiteX.ASPSMSX2.vouchers[]> GetVoucherTransactionsAsync(string UserKey, string Password) {
            return base.Channel.GetVoucherTransactionsAsync(UserKey, Password);
        }
        
        public string GetStatusCodeDescription(string StatusCode) {
            return base.Channel.GetStatusCodeDescription(StatusCode);
        }
        
        public System.Threading.Tasks.Task<string> GetStatusCodeDescriptionAsync(string StatusCode) {
            return base.Channel.GetStatusCodeDescriptionAsync(StatusCode);
        }
        
        public string VersionInfo() {
            return base.Channel.VersionInfo();
        }
        
        public System.Threading.Tasks.Task<string> VersionInfoAsync() {
            return base.Channel.VersionInfoAsync();
        }
    }
}
