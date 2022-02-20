using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace SimpleShapes
{
    class RandomWalker
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Random Rand = new Random();

        // ===================== Constructor =====================
        public RandomWalker(float inX, float inY)
        {
            this.X = inX;
            this.Y = inY;
            
        }

        public void MoveWalker()
        {

            //float RandomAngle = (float)(Rand.Next(0, 360) / (2*Math.PI));
            //this.X = (float)(this.X + (1 * Math.Cos(RandomAngle)));
            //this.Y = (float)(this.Y + (1 * Math.Sin(RandomAngle)));

            //int Choice = Rand.Next(4);
            switch (Rand.Next(4))
            {
                case 0:
                    this.X++;
                    break;
                case 1:
                    this.X--;
                    break;
                case 2:
                    this.Y++;
                    break;
                case 3:
                    this.Y--;
                    break;
                default: //Should never happen
                    break;
            }

            //this.X = (float)(this.X + (2 * (Rand.Next(3) - 1))); // 3 because the highest number is never selected, so this give 0,1,2
            //this.Y = (float)(this.Y + (2 * (Rand.Next(3) - 1)));
        }

        public void DisplayWalkerMethod()
        {
            //Rectangle blueRect = new Rectangle();
            //blueRect.Fill = Brushes.Blue;
            //blueRect.Width = 5;
            //blueRect.Height = 5;

            //Canvas.Children.Add(blueRect);
            //Canvas.SetTop(blueRect, Y);
            //Canvas.SetLeft(blueRect, X);
        }

        

    }
}
