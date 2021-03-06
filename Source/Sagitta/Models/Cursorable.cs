﻿using System;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace Sagitta.Models
{
    /// <summary>
    ///     ページング可能なレスポンスに対するベースクラスです。
    /// </summary>
    public interface ICursorable
    {
        /// <summary>
        ///     <see cref="PixivClient" /> インスタンス
        /// </summary>
        PixivClient PixivClient { set; }
    }

    /// <inheritdoc />
    public class Cursorable<T> : ICursorable
    {
        /// <summary>
        ///     次のページへのアクセス URL
        /// </summary>
        [JsonProperty("next_url")]
        public string NextUrl { get; set; }

        /// <inheritdoc />
        public PixivClient PixivClient { private get; set; }

        /// <summary>
        ///     次ページを取得します。
        /// </summary>
        /// <returns>
        ///     次ページのオブジェクト (<see cref="Cursorable{T}" />)
        /// </returns>
        public Task<T> NextAsync()
        {
            if (string.IsNullOrWhiteSpace(NextUrl))
                throw new NotSupportedException("This object does not have URL for next page.");
            return PixivClient.GetAsync<T>(NextUrl, PixivClient.EmptyParameter, false);
        }
    }
}