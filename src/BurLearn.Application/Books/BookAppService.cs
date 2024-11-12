using System;
using BurLearn.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace BurLearn.Books;

public class BookAppService :
    CrudAppService<
        Book, //The Book entity
        BookDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateBookDto>, //Used to create/update a book
    IBookAppService //implement the IBookAppService
{
    public BookAppService(IRepository<Book, Guid> repository)
        : base(repository)
    {
        GetPolicyName = BurLearnPermissions.Books.Default;
        GetListPolicyName = BurLearnPermissions.Books.Default;
        CreatePolicyName = BurLearnPermissions.Books.Create;
        UpdatePolicyName = BurLearnPermissions.Books.Edit;
        DeletePolicyName = BurLearnPermissions.Books.Delete;
    }
}