using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Acme.BookStore.Books;
using Microsoft.AspNetCore.Authorization;
using Volo.Abp.Application.Services;

namespace Acme.BookStore
{
    [Authorize("Author_Management")]
    public class AuthorAppService : ApplicationService, IAuthorAppService
    {
        public Task<List<BookDto>> GetListAsync()
        {
            return null;
        }

        [AllowAnonymous]
        public Task<BookDto> GetAsync(Guid id)
        {
            return null;
        }

        public async Task CreateAsync(CreateUpdateBookDto input)
        {
            await AuthorizationService.CheckAsync("Author_Management_Create_Books");
        }

        [Authorize("Author_Management_Edit_Books")]
        public Task UpdateAsync(CreateUpdateBookDto input)
        {
            return null;
        }

        [Authorize("Author_Management_Delete_Books")]
        public Task DeleteAsync(CreateUpdateBookDto input)
        {
            return null;
        }
        

    }
}