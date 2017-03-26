﻿namespace Sagitta.Clients
{
    public class NotificationClient : ApiClient
    {
        public NotificationUserClient User { get; }

        public NotificationClient(PixivClient pixivClient) : base(pixivClient)
        {
            User = new NotificationUserClient(pixivClient);
        }
    }
}