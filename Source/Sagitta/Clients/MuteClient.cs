﻿using System.Collections.Generic;
using System.Threading.Tasks;

using Sagitta.Extensions;
using Sagitta.Helpers;
using Sagitta.Models;

namespace Sagitta.Clients
{
    /// <summary>
    ///     ミュート関連 API
    /// </summary>
    public class MuteClient : ApiClient
    {
        /// <inheritdoc />
        internal MuteClient(PixivClient pixivClient) : base(pixivClient) { }

        /// <summary>
        ///     指定したタグのミュートを解除します。
        /// </summary>
        /// <param name="tags">タグ名</param>
        public async Task DeleteAsync(string[] tags)
        {
            Ensure.ArraySizeNotZero(tags, nameof(tags));

            var parameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("delete_tags[]", string.Join(",", tags))
            };

            await PixivClient.PostAsync("https://app-api.pixiv.net/v1/mute/edit", parameters).Stay();
        }

        /// <summary>
        ///     ミュートリストを取得します。
        /// </summary>
        /// <returns>
        ///     <see cref="MuteList" />
        /// </returns>
        public async Task<MuteList> ListAsync()
        {
            return await PixivClient.GetAsync<MuteList>("https://app-api.pixiv.net/v1/mute/list", PixivClient.EmptyParameter).Stay();
        }
    }
}