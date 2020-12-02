using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace City_Traffic_Simulation_Application
{
    public partial class Traffic_simulaator : Form
    {
        Grid grid;
        Point mouseDown;
        bool dragTypeOne;
        int selectedCell = 0;
        int firstSelection = 0;
        bool runningSimulation;

        Point loc = new Point(300, 50);
        //creating the draw area 
        Car car;
        List<Car> carList;
        Graphics drawarea;


        public Traffic_simulaator()
        {
            InitializeComponent();
            runningSimulation = false;
            pb3.AllowDrop = true;
            pb2.AllowDrop = true;
            p1.AllowDrop = true;
            pb4.AllowDrop = true;

            grid = new Grid();
            // instanciating the draw area 
            carList = new List<Car>();
            carList.Add(new Car(new Point(225, 25), 15, 15));

            carList.Add(new Car(new Point(225, 50), 15, 15));

            //carList.Add(new Car(new Point(300, 50), 15, 15));
            
           drawarea = p1.CreateGraphics(); // to create the cars on the picture box with the crossing
            timer1.Interval = 100;
        }


        private void determineCell(DragEventArgs e)
        {
            //Point cursor = PointToClient(Cursor.Position);
            //int column = ((cursor.X - panel1.Left) / 300) + 1;
            //int row = (cursor.Y - panel1.Top) / 300;
            //selectedCell = row * 4 + column;

        }

        private void panel1_DragOver(object sender, DragEventArgs e)
        {
            // Allows the drag and drop
            e.Effect = DragDropEffects.All;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            //List<Panel> listP = new List<Panel>();
            // Takes the image from where you selected, the one to be dropped and showed in panel
            Panel destination = (Panel)sender;
            destination.Size = new Size(250, 250);
            destination.BackgroundImage = (Bitmap)e.Data.GetData(typeof(Bitmap));


            Point cursor = PointToClient(Cursor.Position);
            Point drawPoint = new Point();

            //Finding out which cell the crossing is dropped on
            determineCell(e);
            drawPoint = grid.Cells[selectedCell - 1].Location;
            //if (e.AllowedEffect == DragDropEffects.Move)
            //{
            //    foreach (Panel p in listP)
            //    {
            //        if(p.Location == mouseDown && !grid.Cells[selectedCell - 1].Taken)
            //        {
            //            p.Location = drawPoint;
            //            destination.Location = drawPoint;

            //            grid.Cells[selectedCell - 1].Taken = true;

            //        }
            //    }
            //}



        }

        private void Mouse_Down(object sender, MouseEventArgs e)
        {
            //Point cursor = PointToClient(Cursor.Position);
            //int column = ((cursor.X - panel1.Left) / 300) + 1;
            //int row = (cursor.Y - panel1.Top) / 300;
            //selectedCell = row * 4 + column;
            //mouseDown = grid.Cells[selectedCell - 1].Location;
            //firstSelection = selectedCell;
        }

        private void pbcrossing1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragTypeOne = true;
                pbcrossing1.DoDragDrop(pbcrossing1.Image, DragDropEffects.Copy);
            }
        }

        private void pbcrossing2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragTypeOne = true;
                pbcrossing2.DoDragDrop(pbcrossing2.Image, DragDropEffects.Copy);
            }
        }

        private void pictureBox2_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;// to set some default effect  when it is drag and drop
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

            pbcrossing1.DoDragDrop(pbcrossing1.Image, DragDropEffects.Copy);
        }

        private void pbcrossing1_MouseClick(object sender, MouseEventArgs e)
        {
            pbcrossing1.DoDragDrop(pbcrossing1.Image, DragDropEffects.Copy);
        }

        //private void panel1_DragEnter(object sender, DragEventArgs e)
        //{
        //    if (e.Data.GetDataPresent(DataFormats.Bitmap) &&
        //    (e.AllowedEffect & DragDropEffects.Copy) != 0)
        //    {
        //        // Allow this.
        //        e.Effect = DragDropEffects.Copy;
        //    }
        //    else
        //    {
        //        // Don't allow any other drop.
        //        e.Effect = DragDropEffects.None;
        //    }
        //}

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //Displays the image on panel when mouse click is released
            Panel source = (Panel)sender;
            DoDragDrop(source.BackgroundImage,
                       DragDropEffects.Copy);
        }

        private void panel2_DragDrop(object sender, DragEventArgs e)
        {
            Panel destination = (Panel)sender;
            destination.Size = new Size(250, 250);
            destination.BackgroundImage = (Bitmap)e.Data.GetData(typeof(Bitmap));
        }

        //private void panel2_DragEnter(object sender, DragEventArgs e)
        //{
        //    //if (e.Data.GetDataPresent(DataFormats.Bitmap) &&
        //    //(e.AllowedEffect & DragDropEffects.Copy) != 0)
        //    //{
        //    //    // Allow this.
        //    //    e.Effect = DragDropEffects.Copy;
        //    //}
        //    //else
        //    //{
        //    //    // Don't allow any other drop.
        //    //    e.Effect = DragDropEffects.None;
        //    //}
        //}

        private void panel2_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            Panel source = (Panel)sender;
            DoDragDrop(source.BackgroundImage,
                       DragDropEffects.Copy);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            timer1.Start();

            Pen p = new Pen(Color.Yellow);
          
        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            p1.Refresh();
            foreach (Car c in carList)
            {
                c.Location = new Point(c.Location.X, c.Location.Y + 1);
                c.Draw(ref drawarea);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pb3_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void pb4_DragDrop(object sender, DragEventArgs e)
        {
            pb3.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pb3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pb4_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pb1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pb1_DragDrop(object sender, DragEventArgs e)
        {
            pb1.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pb1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pb2_DragDrop(object sender, DragEventArgs e)
        {
            pb2.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pb2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pb4_DragEnter_1(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pb4_DragDrop_1(object sender, DragEventArgs e)
        {
            pb4.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void pic1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pic1_DragDrop(object sender, DragEventArgs e)
        {
          //  pic1.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void panel1_DragDrop_1(object sender, DragEventArgs e)
        {
         //   panel1.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void p1_DragDrop(object sender, DragEventArgs e)
        {
            p1.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        private void p1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }
    }
    
}