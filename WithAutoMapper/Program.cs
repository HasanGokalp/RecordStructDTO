using AutoMapper;
using WithAutoMapper.Dto;
using WithAutoMapper.Entity;

class Program
{
    static void Main(string[] args)
    {
        var config = new MapperConfiguration(cfg => {
            cfg.CreateMap<Car, CarDto>().ReverseMap();
        });
        IMapper mapper = config.CreateMapper();

        var myClass = new Car { Id = 1, Name = "haso" };

        var dst = mapper.Map<Car, CarDto>(myClass);

        var myClass2 = new CarDto { id = 1, name = "hasoo" };

        var dst2 = mapper.Map<CarDto, Car>(myClass2);

        Console.WriteLine(dst.name);
        Console.WriteLine(dst2.Name);

    }
}