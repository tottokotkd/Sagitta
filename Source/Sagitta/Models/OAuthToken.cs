﻿using Newtonsoft.Json;

namespace Sagitta.Models
{
    internal class OAuthResponse
    {
        [JsonProperty("response")]
        public OAuthToken Response { get; set; }
    }

    public class OAuthToken
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("expires_in")]
        public int ExpiresIn { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        [JsonProperty("device_token")]
        public string DeviceToken { get; set; }

        [JsonProperty("user")]
        public Me User { get; set; }
    }
}