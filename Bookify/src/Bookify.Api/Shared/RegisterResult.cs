﻿namespace Bookify.Api.Shared;

public class RegisterResult
{
    public bool Success { get; set; }
    public IEnumerable<string> Errors { get; set; }
}
