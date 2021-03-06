﻿using Newtonsoft.Json;

namespace Sagitta.Models
{
    /// <summary>
    ///     小説
    /// </summary>
    public class Novel : Work
    {
        /// <summary>
        ///     文字数
        /// </summary>
        [JsonProperty("text_length")]
        public int TextLength { get; set; }
    }
}