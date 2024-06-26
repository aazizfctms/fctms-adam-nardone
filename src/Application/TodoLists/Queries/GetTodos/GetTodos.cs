﻿using FctmsDemoApp.Application.Common.Interfaces;
using FctmsDemoApp.Application.Common.Models;
using FctmsDemoApp.Application.Common.Security;
using FctmsDemoApp.Domain.Enums;

namespace FctmsDemoApp.Application.TodoLists.Queries.GetTodos;

[Authorize]
public record GetTodosQuery : IRequest<TodosVm>;

public class GetTodosQueryHandler : IRequestHandler<GetTodosQuery, TodosVm>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetTodosQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<TodosVm> Handle(GetTodosQuery request, CancellationToken cancellationToken)
    {
        var priorityLevels = Enum.GetValues(typeof(PriorityLevel))
            .Cast<PriorityLevel>()
            .Select(p => new LookupDto { Id = (int)p, Title = p.ToString() })
            .ToList();
        
        var todoLists = await _context.TodoLists
            .AsNoTracking()
            .ProjectTo<TodoListDto>(_mapper.ConfigurationProvider)
            .OrderBy(t => t.Title)
            .ToListAsync(cancellationToken);
        
        return new TodosVm
        {
            PriorityLevels = priorityLevels,
            Lists = todoLists
        };
    }
}
