﻿using System.Threading.Tasks;

using Sagitta.Extensions;
using Sagitta.Models;

namespace Sagitta.Clients
{
    /// <summary>
    ///     通知関連 API
    /// </summary>
    public class NotificationClient : ApiClient
    {
        /// <inheritdoc />
        internal NotificationClient(PixivClient pixivClient) : base(pixivClient) { }

        /// <summary>
        ///     通知設定を取得します。
        /// </summary>
        /// <returns></returns>
        public async Task<NotificationSettings> SettingsAsync()
        {
            var response = await PixivClient.GetAsync("https://app-api.pixiv.net/v1/notification/settings", PixivClient.EmptyParameter).Stay();
            return response["notification_settings"].ToObject<NotificationSettings>();
        }
    }
}