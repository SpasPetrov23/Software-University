using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationExercise
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get => this.length;
            set
            {
                string sideName = "Length";
                this.Validation(value, sideName);
                this.length = value;
            }
        }
        public double Width
        {
            get => this.width;
            set
            {
                string sideName = "Width";
                this.Validation(value, sideName);
                this.width = value;
            }
        }
        public double Height
        {
            get => this.height;
            set
            {
                string sideName = "Height";
                this.Validation(value, sideName);
                this.height = value;
            }
        }

        private void Validation(double value, string sideName)
        {
            if (value <= 0)
            {
                Console.WriteLine($"{sideName} cannot be zero or negative.");
                System.Environment.Exit(0);
            }
            
        }

        public double Volume()
        {
            double volume = this.Length* this.Width * this.Height;
            return volume;
        }

        public double LateralSurfaceArea()
        {
            double lateralSurfaceArea = 2 * (this.Length * this.Height) + 2 * (this.Width * this.Height);
            return lateralSurfaceArea;
        }

        public double SurfaceArea()
        {
            double surfaceArea = 2 * (this.Length * this.Width) + 2 * (this.Length * this.Height) + 2 * (this.Width * this.Height);
            return surfaceArea;
        }
    }
}
