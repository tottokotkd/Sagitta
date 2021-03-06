﻿using System.Collections.Generic;
using System.Threading.Tasks;

using Sagitta.Extensions;
using Sagitta.Models;

namespace Sagitta.Clients
{
    /// <summary>
    ///     Pixivision (旧 pixiv Spotlight) 関連 API
    /// </summary>
    public class SpotlightClient : ApiClient
    {
        /// <inheritdoc />
        internal SpotlightClient(PixivClient pixivClient) : base(pixivClient) { }

        /// <summary>
        ///     指定したカテゴリーの Pixivision (旧 pixiv Spotlight) の記事一覧を取得します。
        /// </summary>
        /// <param name="category">カテゴリー</param>
        /// <param name="offset">オフセット</param>
        /// <param name="filter">フィルター (`for_ios` が有効)</param>
        /// <returns>
        ///     <see cref="SpotlightArticleCollection" />
        /// </returns>
        public async Task<SpotlightArticleCollection> ArticlesAsync(string category = "all", long offset = 0, string filter = "")
        {
            var parameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("category", category)
            };
            if (offset > 0)
                parameters.Add(new KeyValuePair<string, string>("offset", offset.ToString()));
            if (!string.IsNullOrWhiteSpace(filter))
                parameters.Add(new KeyValuePair<string, string>("filter", filter));

            return await PixivClient.GetAsync<SpotlightArticleCollection>("https://app-api.pixiv.net/v1/spotlight/article", parameters).Stay();
        }
    }
}