using System;

namespace Auto_Auction.Models
{
    public class Dimensions
    {
        public double Length { get; }
        public double Width { get; }
        public double Height { get; }

        public Dimensions(double length, double width, double height)
        {
            if (length <= 0 || width <= 0 || height <= 0)
                throw new ArgumentException("All dimensions must be greater than 0");

            Length = length;
            Width = width;
            Height = height;
        }

        public override string ToString()
            => $"{Length} x {Width} x {Height} cm";
    }
}
