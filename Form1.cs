using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace DigitalImageProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }


        private int threshold = 0;

        private void customizeDesign()
        {
            EdgePanel.Visible = false;
            FilterPanel.Visible = false;
            SpecialPanel.Visible = false;
        }

        private void hideSubMenu()
        {
            if(EdgePanel.Visible == true)
            {
                EdgePanel.Visible = false;
            }
            if(FilterPanel.Visible == true)
            {
                FilterPanel.Visible = false;
            }
            if(SpecialPanel.Visible == true)
            {
                SpecialPanel.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void Load_Image_Click(object sender, EventArgs e)
        {
            /*
             * This function operates under the click condition.
             * A Dialog Window will open, where the user will select a file
             * The File will be filter under image condition and be displayed on the window's form
            */

            OpenFileDialog imagefileopen = new OpenFileDialog();                                                                    // Create a FileDialog Object
            imagefileopen.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)| *.jpg; *.jpeg; *.gif; *.bmp; *.png";           // Filter the FileDialog input file
            if (imagefileopen.ShowDialog() == DialogResult.OK)                                                                      // If the given file is a image    
            {
                OpenImageDisplay.Image = new Bitmap(imagefileopen.FileName);                                                        // Open the image inside the picture box
                OpenImageDisplay.Size = OpenImageDisplay.Image.Size;
            }
        }

        private delegate Color MakeColorDelegate(Bitmap orignal, int x, int y);                                                     

        /*
         * MakeColorScale methods use in conjunction w/
         * delegate - MakeColorDelegate
         * method - MakeScale
         */

        private Color MakeGrayScale(Bitmap original, int x, int y)
        {
            Color orignalColor = original.GetPixel(x, y);
            int grayScale = (int)((orignalColor.R * 0.3) + (orignalColor.G * 0.59) + (orignalColor.B * 0.11));
            Color newColor = Color.FromArgb(grayScale, grayScale, grayScale);
            return newColor;
        }
        private Color MakeUScale(Bitmap original, int x, int y)
        {
            Color originalColor = original.GetPixel(x, y);
            int uScale = (int)((originalColor.R * -0.147) + (originalColor.G * -0.289) + (originalColor.B * 0.437));
            if (uScale < 0)
            {
                uScale = 0;
            }

            if (uScale > 255)
            {
                uScale = 255;
            }
            Color newColor = Color.FromArgb(uScale, uScale, uScale);
            return newColor;
        }
        private Color MakeVScale(Bitmap original, int x, int y)
        {
            Color originalColor = original.GetPixel(x, y);
            int vScale = (int)((originalColor.R * 0.615) + (originalColor.G * -0.515) + (originalColor.B * -0.100));
            if (vScale < 0)
            {
                vScale = 0;
            }

            if (vScale > 255)
            {
                vScale = 255;
            }
            Color newColor = Color.FromArgb(vScale, vScale, vScale);
            return newColor;
        }
        private Color MakeIScale(Bitmap original, int x, int y)
        {
            Color originalColor = original.GetPixel(x, y);
            int iScale = (int)((originalColor.R * 0.596) + (originalColor.G * -0.275) + (originalColor.B * -0.321));
            if (iScale < 0)
            {
                iScale = 0;
            }

            if (iScale > 255)
            {
                iScale = 255;
            }
            Color newColor = Color.FromArgb(iScale, iScale, iScale);
            return newColor;
        }
        private Color MakeQScale(Bitmap original, int x, int y)
        {
            Color originalColor = original.GetPixel(x, y);
            int qScale = (int)((originalColor.R * 0.212) + (originalColor.G * -0.523) + (originalColor.B * 0.311));
            if (qScale < 0)
            {
                qScale = 0;
            }

            if (qScale > 255)
            {
                qScale = 255;
            }
            Color newColor = Color.FromArgb(qScale, qScale, qScale);
            return newColor;
        }
        private Color MakeCrScale(Bitmap original, int x, int y)
        {
            Color originalColor = original.GetPixel(x, y);
            int crScale = (int)((originalColor.R * 0.500) + (originalColor.G * -0.419) + (originalColor.B * -0.081));
            if (crScale < 0)
            {
                crScale = 0;
            }

            if (crScale > 255)
            {
                crScale = 255;
            }
            Color newColor = Color.FromArgb(crScale, crScale, crScale);
            return newColor;
        }
        private Color MakeCbScale(Bitmap original, int x, int y)
        {
            Color originalColor = original.GetPixel(x, y);
            int cbScale = (int)((originalColor.R * -0.169) + (originalColor.G * -0.331) + (originalColor.B * 0.500));
            if (cbScale < 0)
            {
                cbScale = 0;
            }

            if (cbScale > 255)
            {
                cbScale = 255;
            }
            Color newColor = Color.FromArgb(cbScale, cbScale, cbScale);
            return newColor;
        }
        private Color MakeRedScale(Bitmap original, int x, int y)
        {
            Color originalColor = original.GetPixel(x, y);
            Color redColor = Color.FromArgb(originalColor.R, originalColor.R, originalColor.R);
            return redColor;
        }
        private Color MakeGreenScale(Bitmap original, int x, int y)
        {
            Color originalColor = original.GetPixel(x, y);
            Color greenColor = Color.FromArgb(originalColor.G, originalColor.G, originalColor.G);
            return greenColor;
        }
        private Color MakeBlueScale(Bitmap original, int x, int y)
        {
            Color originalColor = original.GetPixel(x, y);
            Color blueColor = Color.FromArgb(originalColor.B, originalColor.B, originalColor.B);
            return blueColor;
        }
        private Bitmap MakeScale(Bitmap original, MakeColorDelegate makeColor)
        {
            /*
             * The MakeScale function will iterate through the bitmap computing 
             * a new value for the pixel with a given filter. The filter is pass 
             * in by the makeColor delegate. The given delegate will point to one 
             * of the MakeColorScales which will alter the color for the given pixel.
             */
            try
            {
                Bitmap newBitmap = new Bitmap(original.Width, original.Height);
                for(int i = 0; i < original.Width; i++)
                {
                    for(int j = 0; j < original.Height; j++)
                    {
                        Color newColor = makeColor(original, i, j);
                        newBitmap.SetPixel(i, j, newColor);
                    }
                }

                return newBitmap;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }

        private void ColorClick(MakeColorDelegate colorDelegate)
        {

            /*
             * A general template for the click color buttons that generates a new 
             * form and display a filtered image.
             */

            Form newForm = new Scale();                                                 // Create a new form
            Bitmap imageInstance = (Bitmap)OpenImageDisplay.Image;                      // Grab the image inside the PictureBox
            Bitmap newInstance = new Bitmap(imageInstance.Width, imageInstance.Height); // Create a new Bitmap that is the same size as the image 

            if (imageInstance != null)
            {
                newInstance = MakeScale(imageInstance, colorDelegate);                  // Apply the filter 
                Generate_TempPict(newForm, newInstance);                                               
            }

        }

        private void Generate_TempPict(Form newForm, Bitmap newInstance)
        {
            PictureBox tempPict = new PictureBox();                                     // Create a new picturebox for the newForm
            tempPict.Size = newInstance.Size;                                           // Make the new picturebox the same size as the picture
            newForm.Controls.Add(tempPict);                                             // Add the new picturebox into our newform
            tempPict.Image = newInstance;                                               // Add the inmage to the new pictureBox
            newForm.Show();                                                             // Display newForm
        }
        /*
         * All Color Click methods operate the same way. It method will begin by 
         * creating a delegate that points to a MakeColor function. We will then 
         * run ColorClick method with the given delegate.
         */

        private void Gray_Scale_Click(object sender, EventArgs e)
        {
            MakeColorDelegate grayDelegate = new MakeColorDelegate(MakeGrayScale);
            ColorClick(grayDelegate);
        }
        private void Red_Click(object sender, EventArgs e)
        {
            MakeColorDelegate redDelegate = new MakeColorDelegate(MakeRedScale);
            ColorClick(redDelegate);
        }
        private void Green_Click(object sender, EventArgs e)
        {
            MakeColorDelegate greenDelegate = new MakeColorDelegate(MakeGreenScale);
            ColorClick(greenDelegate);
        }
        private void Blue_Click(object sender, EventArgs e)
        {
            MakeColorDelegate blueDelegate = new MakeColorDelegate(MakeBlueScale);
            ColorClick(blueDelegate);
        }
        private void U_Click(object sender, EventArgs e)
        {
            MakeColorDelegate uDelegate = new MakeColorDelegate(MakeUScale);
            ColorClick(uDelegate);
        }
        private void V_Click(object sender, EventArgs e)
        {
            MakeColorDelegate vDelegate = new MakeColorDelegate(MakeVScale);
            ColorClick(vDelegate);
        }
        private void I_Click(object sender, EventArgs e)
        {
            MakeColorDelegate iDelegate = new MakeColorDelegate(MakeIScale);
            ColorClick(iDelegate);
        }
        private void Q_Click(object sender, EventArgs e)
        {
            MakeColorDelegate qDelegate = new MakeColorDelegate(MakeQScale);
            ColorClick(qDelegate);
        }
        private void Cr_Click(object sender, EventArgs e)
        {
            MakeColorDelegate crDelegate = new MakeColorDelegate(MakeCrScale);
            ColorClick(crDelegate);
        }
        private void Cb_Click(object sender, EventArgs e)
        {
            MakeColorDelegate cbDelegate = new MakeColorDelegate(MakeCbScale);
            ColorClick(cbDelegate);
        }

        private int[,] Prewitt_Vertical = new int[3, 3]  { 
                                                           {-1, 0, 1},
                                                           {-1, 0, 1},
                                                           {-1, 0, 1}, 
        };

        private int[,] Prewitt_Horizontal = new int[3, 3] { 
                                                           {-1,-1,-1},
                                                           { 0, 0, 0},
                                                           { 1, 1, 1} 
        };

        private int[,] Prewitt_Diagonal = new int[3, 3] { 
                                                         { 0, 1, 1},
                                                         {-1, 0, 1},
                                                         {-1,-1, 0} 
        };

        private int[,] Sobel_Vertical = new int[3, 3]  { 
                                                         {-1, 0, 1},
                                                         {-2, 0, 2},
                                                         {-1, 0, 1} 
        };

        private int[,] Sobel_Horizontal = new int[3, 3] { 
                                                          {-1,-2,-1},
                                                          { 0, 0, 0},
                                                          { 1, 2, 1} 
        };

        private int[,] Sobel_Diagonal = new int[3, 3] { 
                                                       { 0, 1, 2},
                                                       {-1, 0, 1},
                                                       {-2,-1, 0} 
        };

        private int[,] Robert_Vertical = new int[2, 2] { 
                                                        {1, 0},
                                                        {0, -1},
        };

        private int[,] Robert_Horizontal = new int[2, 2] { 
                                                         { 0, 1},
                                                         {-1, 0},
        };

        private int[,] Robert_Diagonal = new int[2, 2] {
                                                         {0, 0},
                                                         {0, 0},
        };

        private Bitmap Pad_Bitmap(Bitmap original)
        {
            Bitmap newBitmap = new Bitmap(original.Width + 2, original.Height + 2);

            for(int i = 0; i < newBitmap.Width; i++)
            {
                for(int j = 0; j < newBitmap.Height; j++)
                {
                    if (i < 2 || j < 2 || i > newBitmap.Width - 2 || j > newBitmap.Height - 2)
                    {
                        newBitmap.SetPixel(i, j, Color.Black);
                    }
                    else
                    {
                        Color originalColor = original.GetPixel(i - 2, j - 2);
                        newBitmap.SetPixel(i, j, originalColor);
                    }
                }
            }

            return newBitmap;
        }

        private int Convolution(int[,] filter, int[,] pixelMap)
        {
            int total = 0;
            for (int i = 0; i < filter.GetLength(0); i++)
            {
                for (int j = 0; j < filter.GetLength(1); j++)
                {
                    total += filter[i, j] * pixelMap[i, j];
                }
            }
            return total;
        }

        private int Calculate_Pixel_Distance(int[,] pixelMap, int[,] verticalFilter, int[,] horizontalFilter, int[,] diagonalFilter)
        {
            int verticalScale = Convolution(verticalFilter, pixelMap);
            int horizontalScale = Convolution(horizontalFilter, pixelMap);
            int diagonalScale = Convolution(diagonalFilter, pixelMap);

            int distance = verticalScale * verticalScale + horizontalScale * horizontalScale + diagonalScale * diagonalScale;
            int pixel = (int)Math.Sqrt(distance);
            while (pixel > 255)
            {
                pixel = pixel - 255;
            }

            if (pixel < threshold)
            {
                pixel = 0;
            }
            return pixel;
        }

        private Bitmap ScanImage(Bitmap newImage, int[,] verticalFilter, int[,] horizontalFilter, int[,] diagonalFilter)
        {
            int pixel;
            Bitmap original = (Bitmap)(OpenImageDisplay.Image);
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);
            MakeColorDelegate grayDelegate = new MakeColorDelegate(MakeGrayScale);
            Bitmap grayBitmap = MakeScale(Pad_Bitmap((Bitmap)OpenImageDisplay.Image), grayDelegate);

            for (int i = 2; i < grayBitmap.Width - 2; i++)
            {
                for(int j = 2; j < grayBitmap.Height - 2; j++)
                {
                    int[,] pixelnxn;
                    if(verticalFilter.Length == 9)
                    {
                        pixelnxn = new int[3, 3]   { 
                                                    { grayBitmap.GetPixel(i - 1, j - 1).G, grayBitmap.GetPixel(i - 0, j - 1).G, grayBitmap.GetPixel(i + 1, j - 1).G },
                                                    { grayBitmap.GetPixel(i - 1, j - 0).G, grayBitmap.GetPixel(i - 0, j - 0).G, grayBitmap.GetPixel(i + 1, j - 0).G },
                                                    { grayBitmap.GetPixel(i - 1, j + 1).G, grayBitmap.GetPixel(i - 0, j + 1).G, grayBitmap.GetPixel(i + 1, j + 1).G }
                        };
                    }
                    else
                    {
                        pixelnxn = new int[2, 2] { 
                                                   {grayBitmap.GetPixel(i - 1, j - 1).G, grayBitmap.GetPixel(i - 0, j - 1).G},
                                                   {grayBitmap.GetPixel(i - 1, j - 0).G, grayBitmap.GetPixel(i - 0, j - 0).G},
                        };

                    }

                    pixel = Calculate_Pixel_Distance(pixelnxn, verticalFilter, horizontalFilter, diagonalFilter); 
                    Color newColor = Color.FromArgb(pixel, pixel, pixel);
                    newBitmap.SetPixel(i - 2, j - 2, newColor);
                }
            }
            return newBitmap;
        }

        private void Prewitt_Click(object sender, EventArgs e)
        {
            Form newForm = new EdgeDetection();
            Bitmap imageInstance = (Bitmap) OpenImageDisplay.Image;
            Bitmap newInstance = ScanImage(imageInstance, Prewitt_Vertical, Prewitt_Horizontal, Prewitt_Diagonal);

            if(imageInstance != null)
            {
                Generate_TempPict(newForm, newInstance);
            }
        }

        private void Sobel_Click(object sender, EventArgs e)
        {
            Form newForm = new EdgeDetection();
            Bitmap imageInstance = (Bitmap)OpenImageDisplay.Image;
            Bitmap newInstance = ScanImage(imageInstance, Sobel_Vertical, Sobel_Horizontal, Sobel_Diagonal);

            if (imageInstance != null)
            {
                Generate_TempPict(newForm, newInstance);
            }
        }

        private void Robert_Click(object sender, EventArgs e)
        {
            Form newForm = new EdgeDetection();
            Bitmap imageInstance = (Bitmap)OpenImageDisplay.Image;
            Bitmap newInstance = ScanImage(imageInstance, Robert_Vertical, Robert_Horizontal, Robert_Diagonal);

            if (imageInstance != null)
            {
                Generate_TempPict(newForm, newInstance);
            }
        }

        private void ThreshBar_Scroll(object sender, ScrollEventArgs e)
        {
            threshold = ThreshBar.Value;
            ThreshLabel.Text = "Threshold : " + ThreshBar.Value.ToString();
        }

        private Color Sinc_Interpolation(Bitmap original, int x, int y)
        {
            int red = 0; int green = 0; int blue = 0;
            int x_coord; int y_coord;
            for(int i = -3; i < 4; i++)
            {

                if(x + i < 0)
                {
                    x_coord = Math.Abs(x - i);
                }
                else if (x + i >= original.Width)
                {
                    x_coord = x - i;
                }
                else
                {
                    x_coord = x + i;
                }

                Color originalColor = original.GetPixel(x_coord, y);
                red += originalColor.R * (int)((Math.Sin((0.5 - i) * Math.PI) / ((0.5 - i) * Math.PI)) * 100);
                green += originalColor.G * (int)((Math.Sin((0.5 - i) * Math.PI) / ((0.5 - i) * Math.PI)) * 100);
                blue += originalColor.B * (int)((Math.Sin((0.5 - i) * Math.PI) / ((0.5 - i) * Math.PI)) * 100);
            }

            red = red / 100;
            green = green / 100;
            blue = blue / 100;

            if (red < 0)
            {
                green = green - red;
                blue = blue - red;
                red = 0;
            }
            if (green < 0)
            {
                red = red - green;
                blue = blue - green;
                green = 0;
            }
            if (blue < 0)
            {
                red = red - blue;
                green = green - blue;
                blue = 0;
            }

            if (red > 255)
            {
                red = 255;
            }
            if (green > 255)
            {
                green = 255;
            }
            if(blue > 255)
            {
                blue = 255;
            }

            return Color.FromArgb(red, green, blue);
        }

        private Bitmap Double_Image(Bitmap original)
        {
            
            try
            {
                Bitmap newBitmap = new Bitmap(original.Width * 2 , original.Height);

                for (int i = 0; i < original.Width; i++)
                {
                    for(int j = 0; j < original.Height; j++)
                    {
                        Color originalColor = Sinc_Interpolation(original, i, j);
                        newBitmap.SetPixel(2 * i, j, originalColor);
                        newBitmap.SetPixel(2 * i + 1, j, originalColor);
                    }
                }
                return newBitmap;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw new NotImplementedException();
            }
            
        }


        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EdgeButton_Click(object sender, EventArgs e)
        {
            showSubMenu(EdgePanel);
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            showSubMenu(FilterPanel);
        }

        private void SFilterButton_Click(object sender, EventArgs e)
        {
            showSubMenu(SpecialPanel);
        }

        private void Double_Click(object sender, EventArgs e)
        {
            Form newForm = new DoubleForm();
            Bitmap imageInstance = (Bitmap)OpenImageDisplay.Image;
            Bitmap newInstance = new Bitmap(imageInstance.Width * 2, imageInstance.Height);

            if(imageInstance != null)
            {
                newInstance = Double_Image(imageInstance);
                Generate_TempPict(newForm, newInstance);
            }
        }

        string serverIP = "localhost";
        int port = 8080;
        private void Client_Click(object sender, EventArgs e)
        {
            TcpClient client = new TcpClient(serverIP, port);
            NetworkStream stream = client.GetStream();

            Image img = OpenImageDisplay.Image;
            IFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, img);
        }
    }
}
