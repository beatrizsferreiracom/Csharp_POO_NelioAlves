using Figuras.Entities.Enums;
using System;

namespace Figuras.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}