﻿namespace WithAutoMapper.Entity
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<string> List { get; set; }
    }
}
