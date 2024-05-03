using AutoMapper;
using WithAutoMapper.Dto;
using WithAutoMapper.Entity;

namespace WithAutoMapper.Mapper
{
    public class CarMapper : Profile
    {
        public CarMapper()
        {
            CreateMap<CarDto, Car>();
        }
    }
}
