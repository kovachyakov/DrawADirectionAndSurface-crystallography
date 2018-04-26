using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawADirection
{
    public class MyForm : Form
    {
        static int PictureW=300;
        static int PictureH=300;

        static int PictureWH = 400;
        static int PictureHH = 308;

        static int xMove = 30;
        static int yMove = 30;

        Bitmap picture = new Bitmap(PictureW,PictureH);
        Bitmap pictureH = new Bitmap(PictureWH, PictureHH);
        public MyForm()
        {
            DrawACube(picture);
            DrawACube(pictureH);
            DrawAFrame(picture);
            DrawAFrame(pictureH);
            DrawAHex();

            var tabPage1 = new TabPage()
            {
                Text ="direction"
            };
            var tabPage2 = new TabPage()
            {
                Text = "surface"
            };
            var tabPage1H = new TabPage()
            {
                Text = "direction"
            };
            var tabPage2H = new TabPage()
            {
                Text = "surface"
            };
            var tabPageCube = new TabPage()
            {
                Text = "Cube"
            };
            var tabPageHex = new TabPage()
            {
                Text = "Hex"
            };


            var updateB = new Button()
            {
                Size = new Size(80, 30),
                Text = "Update",
                Location = new Point(20, PictureH + 30)
            };

            var erase = new Button()
            {
                Size = new Size(80, 30),
                Text = "Erase text",
                Location = new Point(20, PictureH + 60)
            };

            var tabControl = new TabControl()
            {
                Location = new Point(updateB.Width + 40, PictureH + 30),
                Size = new Size(260, 120),
            };
            var tabControlH = new TabControl()
            {
                Location = new Point(updateB.Width + 40, PictureH + 30),
                Size = new Size(310, 120),
            };
            var tabControlOfEverything = new TabControl()
            {
                Location = new Point(0, 0),
                Size = new Size(440, 500),
            };


            var labelD = new Label()
            {
                Size = new Size(100, 40),
                Text = "[u,v,w]",
                Location = new Point(5, 5),
                Font = new Font("Arial", 20, FontStyle.Regular)
            };
            var labelBracketsD = new Label()
            {
                Size = new Size(260, 40),
                Text = "[        ,        ,        ]",
                Location = new Point(5, 5 + 40),
                Font = new Font("Arial", 20, FontStyle.Regular)
            };
            var labelS = new Label()
            {
                Size = new Size(100, 40),
                Text = "(h,k,l)",
                Location = new Point(5, 5),
                Font = new Font("Arial", 20, FontStyle.Regular)
            };
            var labelBracketsS = new Label()
            {
                Size = new Size(260, 40),
                Text = "(        ,        ,        )",
                Location = new Point(5, 5 + 40),
                Font = new Font("Arial", 20, FontStyle.Regular)
            };

            var u = new TextBox()
            {
                Font = new Font("Arial", 20, FontStyle.Regular),
                Size = new Size(60, 30),
                Text = "u",
                Location = new Point(20, 40)
            };
            var v = new TextBox()
            {
                Font = new Font("Arial", 20, FontStyle.Regular),
                Size = new Size(60, 30),
                Text = "v",
                Location = new Point(90, 40),
            };
            var w = new TextBox()
            {
                Font = new Font("Arial", 20, FontStyle.Regular),
                Size = new Size(60, 30),
                Text = "w",
                Location = new Point(160, 40),
            };

            var h = new TextBox()
            {
                Font = new Font("Arial", 20, FontStyle.Regular),
                Size = new Size(60, 30),
                Text = "h",
                Location = new Point(20, 40)
            };
            var k = new TextBox()
            {
                Font = new Font("Arial", 20, FontStyle.Regular),
                Size = new Size(60, 30),
                Text = "k",
                Location = new Point(90, 40)
            };
            var l = new TextBox()
            {
                Font = new Font("Arial", 20, FontStyle.Regular),
                Size = new Size(60, 30),
                Text = "l",
                Location = new Point(160, 40)
            };

            var answerPic = new PictureBox
            {
                Location = new Point(20, 20),
                Size = new Size(PictureW, PictureH)
            };
            var answerPicH = new PictureBox
            {
                Location = new Point(20, 20),
                Size = new Size(PictureWH, PictureHH)
            };
            answerPic.Image = picture;
            answerPicH.Image = pictureH;
            
            #region//HEX
            var updateBH = new Button()
            {
                Size = new Size(80, 30),
                Text = "Update",
                Location = new Point(20, PictureH + 30)
            };
            var eraseH = new Button()
            {
                Size = new Size(80, 30),
                Text = "Erase text",
                Location = new Point(20, PictureH + 60)
            };

            var uH = new TextBox()
            {
                Font = new Font("Arial", 20, FontStyle.Regular),
                Size = new Size(60, 30),
                Text = "u",
                Location = new Point(20, 40)
            };
            var vH = new TextBox()
            {
                Font = new Font("Arial", 20, FontStyle.Regular),
                Size = new Size(60, 30),
                Text = "v",
                Location = new Point(90, 40),
            };
            var tH = new TextBox()
            {
                Font = new Font("Arial", 20, FontStyle.Regular),
                Size = new Size(60, 30),
                Text = "t",
                Location = new Point(160, 40),
            };
            var wH = new TextBox()
            {
                Font = new Font("Arial", 20, FontStyle.Regular),
                Size = new Size(60, 30),
                Text = "w",
                Location = new Point(230, 40),
            };

            var hH = new TextBox()
            {
                Font = new Font("Arial", 20, FontStyle.Regular),
                Size = new Size(60, 30),
                Text = "h",
                Location = new Point(20, 40)
            };
            var kH = new TextBox()
            {
                Font = new Font("Arial", 20, FontStyle.Regular),
                Size = new Size(60, 30),
                Text = "k",
                Location = new Point(90, 40)
            };
            var tHSurf = new TextBox()
            {
                Font = new Font("Arial", 20, FontStyle.Regular),
                Size = new Size(60, 30),
                Text = "t",
                Location = new Point(160, 40)
            };
            var lH = new TextBox()
            {
                Font = new Font("Arial", 20, FontStyle.Regular),
                Size = new Size(60, 30),
                Text = "l",
                Location = new Point(230, 40)
            };

            var labelDH = new Label()
            {
                Size = new Size(120, 40),
                Text = "[u,v,t,w]",
                Location = new Point(5, 5),
                Font = new Font("Arial", 20, FontStyle.Regular)
            };
            var labelBracketsDH = new Label()
            {
                Size = new Size(300, 40),
                Text = "[        ,        ,        ,        ]",
                Location = new Point(5, 5 + 40),
                Font = new Font("Arial", 20, FontStyle.Regular)
            };
            var labelSH = new Label()
            {
                Size = new Size(110, 40),
                Text = "(h,k,t,l)",
                Location = new Point(5, 5),
                Font = new Font("Arial", 20, FontStyle.Regular)
            };
            var labelBracketsSH = new Label()
            {
                Size = new Size(300, 40),
                Text = "(        ,        ,        ,        )",
                Location = new Point(5, 5 + 40),
                Font = new Font("Arial", 20, FontStyle.Regular)
            };
            #endregion

            #region//Add conrols 
            updateB.Click += (sender, args) => picture = new Bitmap(PictureW, PictureH);
            updateB.Click += (sender, args) => DrawACube(picture);
            updateB.Click += (sender, args) => DrawAFrame(picture);
            updateB.Click += (sender, args) => DrawADir(picture, u.Text, v.Text, w.Text);
            updateB.Click += (sender, args) => DrawASurface(picture, h.Text, k.Text, l.Text);
            updateB.Click += (sender, args) => answerPic.Image = picture;

            erase.Click += (sender, args) =>
            {
                u.Text = ""; v.Text = ""; w.Text = "";
                h.Text = ""; k.Text = ""; l.Text = "";
            };

            updateBH.Click += (sender, args) => pictureH = new Bitmap(PictureWH, PictureHH);
            updateBH.Click += (sender, args) => DrawACube(pictureH);
            updateBH.Click += (sender, args) => DrawAFrame(pictureH);
            updateBH.Click += (sender, args) => DrawAHex();
            updateBH.Click += (sender, args) => DrawADir(pictureH, uH.Text, vH.Text, wH.Text);
            updateBH.Click += (sender, args) => DrawASurface(pictureH, hH.Text, kH.Text, lH.Text);
            updateBH.Click += (sender, args) => answerPicH.Image = pictureH;

            eraseH.Click += (sender, args) =>
            {
                uH.Text = ""; vH.Text = ""; tH.Text = ""; wH.Text = "";
                hH.Text = ""; kH.Text = ""; tHSurf.Text = ""; lH.Text = "";
            };

            tabPage1.Controls.Add(u);
            tabPage1.Controls.Add(v);
            tabPage1.Controls.Add(w);
            tabPage1.Controls.Add(labelD);
            tabPage1.Controls.Add(labelBracketsD);

            tabPage2.Controls.Add(h);
            tabPage2.Controls.Add(k);
            tabPage2.Controls.Add(l);
            tabPage2.Controls.Add(labelS);
            tabPage2.Controls.Add(labelBracketsS);


            tabPage1H.Controls.Add(uH);
            tabPage1H.Controls.Add(vH);
            tabPage1H.Controls.Add(tH);
            tabPage1H.Controls.Add(wH);
            tabPage1H.Controls.Add(labelDH);
            tabPage1H.Controls.Add(labelBracketsDH);

            tabPage2H.Controls.Add(hH);
            tabPage2H.Controls.Add(kH);
            tabPage2H.Controls.Add(tHSurf);
            tabPage2H.Controls.Add(lH);
            tabPage2H.Controls.Add(labelSH);
            tabPage2H.Controls.Add(labelBracketsSH);



            tabControl.TabPages.Add(tabPage1);
            tabControl.TabPages.Add(tabPage2);

            tabControlH.TabPages.Add(tabPage1H);
            tabControlH.TabPages.Add(tabPage2H);

            tabControlOfEverything.TabPages.Add(tabPageCube);
            tabControlOfEverything.TabPages.Add(tabPageHex);

            tabPageHex.Controls.Add(tabControlH);
            tabPageHex.Controls.Add(answerPicH);
            tabPageHex.Controls.Add(updateBH);
            tabPageHex.Controls.Add(eraseH);

            tabPageCube.Controls.Add(tabControl);
            tabPageCube.Controls.Add(answerPic);
            tabPageCube.Controls.Add(updateB);
            tabPageCube.Controls.Add(erase);

            Controls.Add(tabControlOfEverything);

            //Controls.Add(tabControl);
            //Controls.Add(answerPic);
            //Controls.Add(updateB);
            //Controls.Add(erase);
            #endregion 

            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
        }



        public void DrawADir(Image Pic, string uS, string vS, string wS)
        {
            using (Graphics gr = Graphics.FromImage(Pic))
            {
                float u;
                float v;
                float w;
                try
                {
                    if (Pic.Width > 300)
                    {
                        gr.TranslateTransform(110.0F, 24.0F);
                        u = 2 * (float)Convert.ToDouble(uS) + (float)Convert.ToDouble(vS);
                        v = 2 * (float)Convert.ToDouble(vS) + (float)Convert.ToDouble(uS);
                        w = (float)Convert.ToDouble(wS);
                    }
                    else
                    {
                        u = (float)Convert.ToDouble(uS);
                        v = (float)Convert.ToDouble(vS);
                        w = (float)Convert.ToDouble(wS);
                    }


                    if ((Math.Abs(u) > 1) || (Math.Abs(v) > 1) || (Math.Abs(w) > 1))
                    {
                        float max = Math.Max(Math.Abs(u), Math.Max(Math.Abs(v), Math.Abs(w)));
                        u /= max;
                        v /= max;
                        w /= max;
                    }

                    Pen dashedP = new Pen(Color.Red, 3);
                    dashedP.DashPattern = new float[] { 2.0F, 2.0F };

                    float StartPx = 40;
                    float StartPy = 200;

                    if ((u < 0) && (v < 0) && (w < 0))
                    {
                        StartPx = 200;
                        StartPy = 50;
                    }
                    else if ((u < 0) && (v < 0))
                    {
                        StartPx = 200;
                        StartPy = 250;
                    }
                    else if ((u < 0) && (w < 0))
                    {
                        StartPx = 0;
                        StartPy = 50;
                    }
                    else if ((v < 0) && (w < 0))
                    {
                        StartPx = 240;
                        StartPy = 0;
                    }
                    else if (u < 0)
                    {
                        StartPx = 0;
                        StartPy = 250;
                    }
                    else if (v < 0)
                    {
                        StartPx = 240;
                        StartPy = 200;
                    }
                    else if (w < 0)
                    {
                        StartPx = 40;
                        StartPy = 0;
                    }


                    gr.DrawLine(dashedP, StartPx + xMove, StartPy + yMove,
                          v * 200 - u * 40 + StartPx + xMove,
                          -w * 200 + StartPy + yMove + u * 50);
                    gr.DrawEllipse(new Pen(Color.Cyan, 5), StartPx + xMove - 1, StartPy + yMove - 1, 4, 4);

                    if (Pic.Width > 300)
                    {
                        gr.TranslateTransform(-110.0F, -24.0F);
                    }
                }
                catch (Exception)
                {
                }
                
            }
            
        }

        public void DrawASurface(Image Pic, string hS, string kS, string lS)
        {
            using (Graphics gr = Graphics.FromImage(Pic))
            {
                float h;
                float k;
                float l;
                bool triengle = true;
                try
                {
                    if (Pic.Width > 300)
                    {
                     
                        gr.TranslateTransform(110.0F, 24.0F);

                        h = 2 * (float)Convert.ToDouble(hS) + (float)Convert.ToDouble(kS);
                        k = 2 * (float)Convert.ToDouble(kS) + (float)Convert.ToDouble(hS);
                        l = (float)Convert.ToDouble(lS);
                    }
                    else
                    {
                        h = (float)Convert.ToDouble(hS);
                        k = (float)Convert.ToDouble(kS);
                        l = (float)Convert.ToDouble(lS);
                    }
                    

                    float StartPx = 40;
                    float StartPy = 200;

                    Pen dashedP = new Pen(Color.Green, 3);
                    dashedP.DashPattern = new float[] { 2.0F, 2.0F };

                    if ((h < 0) && (k < 0) && (l < 0))
                    {
                        StartPx = 200;
                        StartPy = 50;
                    }
                    else if ((h < 0) && (k < 0))
                    {
                        StartPx = 200;
                        StartPy = 250;
                    }
                    else if ((k < 0) && (l < 0))
                    {
                        StartPx = 240;
                        StartPy = 0;
                    }
                    else if ((h < 0) && (l < 0))
                    {
                        StartPx = 0;
                        StartPy = 50;
                    }
                    else if ((h < 0))
                    {
                        StartPx = 0;
                        StartPy = 250;
                    }
                    else if ((k < 0))
                    {
                        StartPx = 240;
                        StartPy = 200;
                    }
                    else if ((l < 0))
                    {
                        StartPx = 40;
                        StartPy = 0;
                    }
                    
                    if ((h == 0) || (l == 0) || (k == 0)) 
                    {
                        triengle = false;
                    }

                    float hx = StartPx - 40 / h;
                    float hy = StartPy + 50 / h;
                    float kx = StartPx + 200 / k;
                    float ky = StartPy;
                    float lx = StartPx;
                    float ly = StartPy - 200 / l;

                    if (triengle)
                    {
                        gr.DrawLine(dashedP, lx + xMove, ly + yMove, kx + xMove, ky + yMove);
                        gr.DrawLine(dashedP, kx + xMove, ky + yMove, hx + xMove, hy + yMove);
                        gr.DrawLine(dashedP, hx + xMove, hy + yMove, lx + xMove, ly + yMove);
                    }
                    else
                    {
                        if ((h == 0) && (k == 0))
                        {

                            gr.DrawLine(dashedP, lx + xMove, ly + yMove, lx + xMove - 40, ly + yMove + 50);
                            gr.DrawLine(dashedP, lx + xMove - 40, ly + yMove + 50, lx + xMove + 160, ly + yMove + 50);
                            gr.DrawLine(dashedP, lx + xMove + 160, ly + yMove + 50, lx + xMove + 200, ly + yMove);
                            gr.DrawLine(dashedP, lx + xMove + 200, ly + yMove, lx + xMove, ly + yMove);
                        }
                        else if ((k == 0) && (l == 0))
                        {

                            gr.DrawLine(dashedP, hx + xMove, hy + yMove, hx + xMove + 200, hy + yMove);
                            gr.DrawLine(dashedP, hx + xMove + 200, hy + yMove, hx + xMove + 200, hy + yMove - 200);
                            gr.DrawLine(dashedP, hx + xMove + 200, hy + yMove - 200, hx + xMove, hy + yMove - 200);
                            gr.DrawLine(dashedP, hx + xMove, hy + yMove - 200, hx + xMove, hy + yMove);

                        }
                        else if ((l == 0) && (h == 0))
                        {

                            gr.DrawLine(dashedP, kx + xMove, ky + yMove, kx + xMove, ky + yMove - 200);
                            gr.DrawLine(dashedP, kx + xMove, ky + yMove - 200, kx + xMove - 40, ky + yMove - 150);
                            gr.DrawLine(dashedP, kx + xMove - 40, ky + yMove - 150, kx + xMove - 40, ky + yMove + 50);
                            gr.DrawLine(dashedP, kx + xMove - 40, ky + yMove + 50, kx + xMove, ky + yMove);
                        }
                        else if (h == 0)
                        {
                            gr.DrawLine(dashedP, kx + xMove, ky + yMove, lx + xMove, ly + yMove);
                            gr.DrawLine(dashedP, lx + xMove, ly + yMove, lx + xMove - 40, ly + yMove + 50);
                            gr.DrawLine(dashedP, lx + xMove - 40, ly + yMove + 50, kx + xMove - 40, ky + yMove + 50);
                            gr.DrawLine(dashedP, kx + xMove - 40, ky + yMove + 50, kx + xMove, ky + yMove);
                        }
                        else if (k == 0)
                        {
                            gr.DrawLine(dashedP, hx + xMove, hy + yMove, lx + xMove, ly + yMove);
                            gr.DrawLine(dashedP, lx + xMove, ly + yMove, lx + xMove + 200, ly + yMove);
                            gr.DrawLine(dashedP, lx + xMove + 200, ly + yMove, hx + xMove + 200, hy + yMove);
                            gr.DrawLine(dashedP, hx + xMove + 200, hy + yMove, hx + xMove, hy + yMove);
                        }
                        else if (l == 0)
                        {
                            gr.DrawLine(dashedP, hx + xMove, hy + yMove, kx + xMove, ky + yMove);
                            gr.DrawLine(dashedP, kx + xMove, ky + yMove, kx + xMove, ky + yMove - 200);
                            gr.DrawLine(dashedP, kx + xMove, ky + yMove - 200, hx + xMove, hy + yMove - 200);
                            gr.DrawLine(dashedP, hx + xMove, hy + yMove - 200, hx + xMove, hy + yMove);
                        }

                    }

                    gr.DrawEllipse(new Pen(Color.Cyan, 5), StartPx + xMove - 1, StartPy + yMove - 1, 4, 4);
                    if (Pic.Width > 300)
                    {
                        gr.TranslateTransform(-110.0F, -24.0F);
                    }
                }
                catch (Exception)
                {
                }

            }

        }

        public void DrawACube(Image Pic)
        {
            using (Graphics gr = Graphics.FromImage(Pic))
            {
                if (Pic.Width!=300)
                {
                    gr.TranslateTransform(110.0F,24.0F);
                }
                
                Pen p = new Pen(Color.Blue, 2);

                Pen dashedP = new Pen(Color.Blue, 2);
                dashedP.DashPattern =new float[]{5.0F, 5.0F};

                gr.DrawLine(p, 40 + xMove, 0 + yMove, 240 + xMove, 0 + yMove);
                gr.DrawLine(p, 40 + xMove, 0 + yMove, 0 + xMove, 50 + yMove);
                gr.DrawLine(p, 240 + xMove, 0 + yMove, 200 + xMove, 50 + yMove);
                gr.DrawLine(p, 240 + xMove, 0 + yMove, 240 + xMove, 200 + yMove);
                gr.DrawLine(p, 240 + xMove, 200 + yMove, 200 + xMove, 250 + yMove);

                gr.DrawLine(dashedP, 40.0F + xMove, 200.0F + yMove, 40.0F + xMove, 0.0F + yMove);
                gr.DrawLine(dashedP, 40.0F + xMove, 200.0F + yMove, 10 + xMove, 240.0F + yMove);
                gr.DrawLine(dashedP, 40.0F + xMove, 200.0F + yMove, 240.0F + xMove, 200.0F + yMove);

                gr.DrawRectangle(p, 0 + xMove, 50 + yMove, 200, 200);
            }
        }

        public void DrawAHex()
        {
            using (Graphics gr = Graphics.FromImage(pictureH))
            {

                Pen p = new Pen(Color.Black, 1);
                Pen dashedP = new Pen(Color.Black, 1);
                dashedP.DashPattern = new float[] { 5.0F, 5.0F };

                gr.TranslateTransform(110.0F, 24.0F);

                gr.DrawLine(p, 0 + xMove, 250 + yMove, -100 + xMove, 200 + yMove);
                gr.DrawLine(p, -100 + xMove, 200 + yMove, -100 + xMove, 0 + yMove);
                gr.DrawLine(p, 0 + xMove, 50 + yMove, -100 + xMove, 0 + yMove);

                gr.DrawLine(p, -100 + xMove, 0 + yMove, 40 + xMove, 0 + yMove);
                gr.DrawLine(p, -100 + xMove, 0 + yMove, -60 + xMove, -50 + yMove);
                gr.DrawLine(p, -60 + xMove, -50 + yMove, 40 + xMove, 0 + yMove);

                gr.DrawLine(p, 240 + xMove, 0 + yMove, 140 + xMove, -50 + yMove);
                gr.DrawLine(p, 140 + xMove, -50 + yMove, 40 + xMove, 0 + yMove);

                gr.DrawLine(p, 40 + xMove, 0 + yMove, 200 + xMove, 50 + yMove);
                gr.DrawLine(p, -60 + xMove, -50 + yMove, 140 + xMove, -50 + yMove);

                gr.DrawLine(dashedP, -60 + xMove, -50 + yMove, -60 + xMove, 150 + yMove);
                gr.DrawLine(dashedP, -60 + xMove, 150 + yMove, -100 + xMove, 200 + yMove);
                gr.DrawLine(dashedP, -100 + xMove, 200 + yMove, 40 + xMove, 200 + yMove);
                gr.DrawLine(dashedP, 40 + xMove, 200 + yMove, -60 + xMove, 150 + yMove);
                gr.DrawLine(dashedP, 140 + xMove, -50 + yMove, 140 + xMove, 150 + yMove);
                gr.DrawLine(dashedP,  140 + xMove, 150 + yMove, 40 + xMove, 200 + yMove);
                gr.DrawLine(dashedP, 140 + xMove, 150 + yMove, 240 + xMove, 200 + yMove);
                gr.DrawLine(dashedP, 140 + xMove, 150 + yMove, -60 + xMove, 150 + yMove);
                gr.DrawLine(dashedP, 40 + xMove, 200 + yMove, 200 + xMove, 250 + yMove);
                

                gr.TranslateTransform(-110.0F, -24.0F);
                
            }
        }

        public void DrawAFrame(Image Pic)
        {
            using (Graphics gr = Graphics.FromImage(Pic))
            {
                Pen p = new Pen(Color.Black, 1);
                gr.DrawRectangle(p, 1, 1, Pic.Width - 2, Pic.Height - 2);
            }
            
        }

        public static void Main()
        {
            Form my = new MyForm();
            my.Width = 455;
            my.Height = 535;


            Application.Run(my);
        }

       
    }
}
