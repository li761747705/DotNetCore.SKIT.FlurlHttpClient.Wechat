﻿namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [PUT] /merchants 接口的请求。</para>
    /// </summary>
    [WechatTenpaySensitive]
    public class ModifyHKSubMerchantRequest : WechatTenpayRequest
    {
        public static class Types
        {
            public class Contact : AddHKSubMerchantRequest.Types.Contact
            {
            }

            public class Business : AddHKSubMerchantRequest.Types.Business
            {
            }

            public class Director : AddHKSubMerchantRequest.Types.Director
            {
            }

            public class Principal : AddHKSubMerchantRequest.Types.Principal
            {
            }
        }

        /// <summary>
        /// 获取或设置机构商户号。如果不指定将使用构造 <see cref="WechatTenpayClient"/> 时的 <see cref="WechatTenpayClientOptions.MerchantId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_mchid")]
        public string? MerchantId { get; set; }

        /// <summary>
        /// 获取或设置机构微信 AppId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sp_appid")]
        [System.Text.Json.Serialization.JsonPropertyName("sp_appid")]
        public string AppId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sub_mchid")]
        [System.Text.Json.Serialization.JsonPropertyName("sub_mchid")]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置渠道号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_id")]
        [System.Text.Json.Serialization.JsonPropertyName("channel_id")]
        public string? ChannelId { get; set; }

        /// <summary>
        /// 获取或设置商户类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_type")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_type")]
        public string MerchantType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置子商户全称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name")]
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string MerchantName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置子商户简称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shortname")]
        [System.Text.Json.Serialization.JsonPropertyName("shortname")]
        public string MerchantShortName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置注册国家或地区代码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("merchant_country_code")]
        [System.Text.Json.Serialization.JsonPropertyName("merchant_country_code")]
        public string CountryCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置公司电话号码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("office_phone")]
        [System.Text.Json.Serialization.JsonPropertyName("office_phone")]
        public string OfficePhoneNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置联系人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contact")]
        [System.Text.Json.Serialization.JsonPropertyName("contact")]
        public Types.Contact Contact { get; set; } = new Types.Contact();

        /// <summary>
        /// 获取或设置商业类目编码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business_category")]
        [System.Text.Json.Serialization.JsonPropertyName("business_category")]
        public int BusinessCategoryCode { get; set; }

        /// <summary>
        /// 获取或设置公司注册文件编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("registration_certificate_number")]
        [System.Text.Json.Serialization.JsonPropertyName("registration_certificate_number")]
        public string RegistrationCertificateNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置公司注册文件过期时间字符串（格式：yyyy-MM-dd / PERMANENT）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("registration_certificate_date")]
        [System.Text.Json.Serialization.JsonPropertyName("registration_certificate_date")]
        public string RegistrationCertificateDateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置公司注册文件照片 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("registration_certificate_copy")]
        [System.Text.Json.Serialization.JsonPropertyName("registration_certificate_copy")]
        public string? RegistrationCertificateCopyMediaId { get; set; }

        /// <summary>
        /// 获取或设置子商户银行结算账户信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settlement_bank_number")]
        [System.Text.Json.Serialization.JsonPropertyName("settlement_bank_number")]
        public string SettlementBankNumber { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置业务信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("business")]
        [System.Text.Json.Serialization.JsonPropertyName("business")]
        public Types.Business Business { get; set; } = new Types.Business();

        /// <summary>
        /// 获取或设置董事信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("director")]
        [System.Text.Json.Serialization.JsonPropertyName("director")]
        public Types.Director? Director { get; set; }

        /// <summary>
        /// 获取或设置负责人信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("principal")]
        [System.Text.Json.Serialization.JsonPropertyName("principal")]
        public Types.Principal? Principal { get; set; }
    }
}
