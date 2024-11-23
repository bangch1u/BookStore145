﻿using BookData.Data.Entities;

namespace BookBlazorWasmAdmin.Services
{
    public interface IAuthorApiClient
    {
        Task<List<Author>> GetAllAuthor();
    }
}