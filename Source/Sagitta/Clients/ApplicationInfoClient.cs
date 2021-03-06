﻿using System.Threading.Tasks;

using Sagitta.Extensions;
using Sagitta.Models;

namespace Sagitta.Clients
{
    /// <summary>
    ///     アプリケーション情報関連 API
    /// </summary>
    public class ApplicationInfoClient : ApiClient
    {
        /// <inheritdoc />
        internal ApplicationInfoClient(PixivClient pixivClient) : base(pixivClient) { }

        // ReSharper disable once InconsistentNaming
        /// <summary>
        ///     Pixiv for iOS の情報を取得します。
        /// </summary>
        /// <returns><see cref="ApplicationInfo" /> モデル</returns>
        public async Task<ApplicationInfo> iOSAsync()
        {
            var response = await PixivClient.GetAsync("https://app-api.pixiv.net/v1/application-info/ios", PixivClient.EmptyParameter).Stay();
            return response["application-info"].ToObject<ApplicationInfo>();
        }
    }
}