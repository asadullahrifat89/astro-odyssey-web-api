﻿namespace AstroOdysseyCore
{
    public class GetGameProfileQuery : RequestBase<QueryRecordResponse<GameProfile>>
    {
        public string UserId { get; set; } = string.Empty;
    }
}
