namespace WithAutoMapper.Dto
{
    public record struct CarDto(int id, string name, string ex, ICollection<string> list)
    {
    }
}
