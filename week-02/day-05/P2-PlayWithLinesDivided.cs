using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;



namespace Drawings
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            //Lineplay: set the distance and the color of the lines

            double distance = 10;       // set the distance between lines
            List<Color> colours = new List<Color> { Colors.Purple, Colors.Green }; // set two colours
            int columns = 2;            // how many blocks per row

            DrawTheLines(foxDraw, distance, colours, columns);
        }
        private void DrawTheLines(FoxDraw foxDraw, double distance, List<Color> colour, int blocks)
        {
            //DivideScreen(foxDraw, blocks);
            for (int j = 0; j < blocks; j++)
            {
                for (double i = 0; i < canvas.Width / blocks - distance; i += distance) // topleft part
                {
                    foxDraw.StrokeColor(colour[0]);
                    foxDraw.DrawLine(i + distance, 0, canvas.Width / blocks, i + distance); // topright
                    foxDraw.StrokeColor(colour[1]);
                    foxDraw.DrawLine(0, i + distance, i + distance, canvas.Width / blocks); // bottomleft
                }

                for (double i = 0; i < canvas.Width / blocks - distance; i += distance) // topright part
                {
                    foxDraw.StrokeColor(colour[0]);
                    foxDraw.DrawLine(canvas.Width / blocks + i + distance, 0, canvas.Width, i + distance); // topright
                    foxDraw.StrokeColor(colour[1]);
                    foxDraw.DrawLine(canvas.Width / blocks, i + distance, canvas.Width / blocks + i + distance, canvas.Width / blocks); // bottomleft
                }

                for (double i = 0; i < canvas.Width / blocks - distance; i += distance) // bottomleft part
                {
                    foxDraw.StrokeColor(colour[0]);
                    foxDraw.DrawLine(i + distance, canvas.Height / blocks, canvas.Width / blocks, canvas.Height / blocks + i + distance); // topright
                    foxDraw.StrokeColor(colour[1]);
                    foxDraw.DrawLine(0, canvas.Height / blocks + i + distance, i + distance, canvas.Height); // bottomleft
                }

                for (double i = 0; i < canvas.Width / blocks - distance; i += distance) // bottomright  part
                {
                    foxDraw.StrokeColor(colour[0]);
                    foxDraw.DrawLine(canvas.Width / blocks + i + distance, canvas.Height / blocks, canvas.Width, canvas.Height / blocks + i + distance); // topright
                    foxDraw.StrokeColor(colour[1]);
                    foxDraw.DrawLine(canvas.Width / blocks, canvas.Height / blocks + i + distance, canvas.Width / blocks + i + distance, canvas.Height); // bottomleft
                }
                

            }

        }

     




    }
 }
