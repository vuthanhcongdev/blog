﻿namespace Ext.Blog.Core.Models.Auth.Responses
{
    public class AuthenticatedResult
    {
        public required string Token { get; set; }
        public required string RefreshToken { get; set; }
    }
}
