﻿using System.Collections.Generic;
using System.Threading.Tasks;

using Sagitta.Extensions;
using Sagitta.Helpers;
using Sagitta.Models;

namespace Sagitta.Clients
{
    /// <summary>
    ///     イラストシリーズ関連 API
    /// </summary>
    public class IllustSeriesClient : ApiClient
    {
        /// <inheritdoc />
        internal IllustSeriesClient(PixivClient pixivClient) : base(pixivClient) { }

        /// <summary>
        ///     シリーズについての情報を取得します。
        /// </summary>
        /// <param name="illustId">イラスト ID</param>
        /// <param name="filter">フィルター (`for_ios` が有効)</param>
        /// <returns>
        ///     <see cref="IllustSeries" />
        /// </returns>
        public async Task<IllustSeries> IllustAsync(long illustId, string filter = "")
        {
            Ensure.GreaterThanZero(illustId, nameof(illustId));

            var parameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("illust_id", illustId.ToString())
            };
            if (!string.IsNullOrWhiteSpace(filter))
                parameters.Add(new KeyValuePair<string, string>("filter", filter));

            return await PixivClient.GetAsync<IllustSeries>("https://app-api.pixiv.net/v1/illust-series/illust", parameters).Stay();
        }
    }
}