﻿using Newtonsoft.Json;

namespace Sagitta.Models
{
    /// <summary>
    ///     通知タイプ
    /// </summary>
    public class NotificationType
    {
        /// <summary>
        ///     ID
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        ///     通知タイプ名
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        ///     通知が有効であるかどうか
        /// </summary>
        [JsonProperty("enabled")]
        public bool IsEnabled { get; set; }
    }
}