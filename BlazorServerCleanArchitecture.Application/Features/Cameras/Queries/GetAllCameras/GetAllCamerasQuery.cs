using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

public record GetAllCamerasQuery : IRequest<List<GetAllCamerasDto>>;


internal class GetAllPlayersQueryHandler: IRequestHandler<GetAllCamerasQuery, List<GetAllCamerasDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public GetAllPlayersQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<List<GetAllCamerasDto>> Handle(GetAllCamerasQuery query, CancellationToken cancellationToken)
    {
        return await _unitOfWork.Repository<Camera>().Entities
               .ProjectTo<GetAllCamerasDto>(_mapper.ConfigurationProvider)
               .ToListAsync(cancellationToken);
    }
}
