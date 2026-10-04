using System;
using Figuras.Entities.Enums;

namespace Figuras.Entities
{
    // Abstract class to prevent direct instances
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        // Abstract method to prevent direct instantiation of the incomplete base class
        public abstract double Area();
    }
}