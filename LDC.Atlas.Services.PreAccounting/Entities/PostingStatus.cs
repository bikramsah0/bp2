﻿namespace LDC.Atlas.Services.PreAccounting.Entities
{
    public enum PostingStatus
    {
        Incomplete = 1,
        Held = 2,
        MappingError = 3,
        Authorised = 4,
        Posted = 5,
        Deleted = 6
    }
}