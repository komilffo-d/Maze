using MazeGenerator;
using Syroot.Windows.IO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Maze
{
    public partial class Admin : Form
    {
        private protected enum StepForm : sbyte
        {
            NOTCREATETEMPLATE = 1,
            CREATEDTEMPLATE,
            SETPOINTENTRY,
            SETPOINTEXIT,
            GENERATEDMAZE,
            EXPORTEDMAZE

        }
        private StepForm stepForm = StepForm.NOTCREATETEMPLATE;
        private bool[,] FillWallsArray;
        private Point startPoint;
        private Point endPoint;
        private uint gridWidth;
        private uint gridHeight;
        public Admin()
        {
            InitializeComponent();

        }

        private void createPattern_Click(object sender, EventArgs e)
        {
            gridWidth = (uint)widthUpDown.Value;
            gridHeight = (uint)heightUpDown.Value;
            DrawMaze();
            Generate.Visible = true;
            stepForm = StepForm.CREATEDTEMPLATE;
        }
        private bool[,] List2DToArray(List<List<bool>> listBoolean)
        {


            int rows = listBoolean.Count;
            int cols = listBoolean[0].Count;

            bool[,] array2D = new bool[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array2D[i, j] = listBoolean[i][j];
                }
            }
            return array2D;
        }
        private void Generate_Click(object sender, EventArgs e)
        {

            if (radioButtonEuler.Checked)
            {
                bool[,] maze = List2DToArray(MazeGeneratorEuler.GenerateMaze(gridWidth / 2, gridHeight / 2));
                DrawMaze(maze);
            }
            else if (radioButtonAldousBroder.Checked)
            {
                bool[,] maze = List2DToArray(new MazeGeneratorAldousBroder().Generate((int)gridWidth, (int)gridHeight));
                (startPoint, endPoint) = FindFreeSpaces(maze);
                DrawMaze(maze);

            }

            stepForm = StepForm.GENERATEDMAZE;

        }
        static Tuple<Point, Point> FindFreeSpaces(bool[,] maze)
        {

            int randomRow, randomCol;
            Point startPoint = new Point();
            Point endPoint = new Point();
            double distance = 0.0;
            do
            {
                Random random = new Random();

                // Генерируйте случайные индексы
                randomRow = random.Next(0, maze.GetLength(0));
                randomCol = random.Next(0, maze.GetLength(1));
                startPoint = new Point(randomRow, randomCol);

                randomRow = random.Next(0, maze.GetLength(0));
                randomCol = random.Next(0, maze.GetLength(1));

                endPoint = new Point(randomRow, randomCol);

                distance = Math.Sqrt(Math.Pow(endPoint.X - startPoint.X, 2) + Math.Pow(endPoint.Y - startPoint.Y, 2));
            } while (distance < 7.0 || maze[startPoint.X, startPoint.Y]==true | maze[endPoint.X, endPoint.Y] == true);

            return new Tuple<Point, Point>(startPoint, endPoint);
        }
        private void DrawMaze(bool[,] mazeMatrix = null)
        {
            float cellWidth = (float)pictureMaze.Width / gridWidth;
            float cellHeight = (float)pictureMaze.Height / gridHeight;

            Pen wallPen = new Pen(Color.Black);
            SolidBrush cellBrush = new SolidBrush(Color.White);
            SolidBrush wallBrush = new SolidBrush(Color.Black);

            SolidBrush startPointBrush = new SolidBrush(Color.Green);

            SolidBrush endPointBrush = new SolidBrush(Color.Red);

            FillWallsArray = mazeMatrix;
            if (pictureMaze.Image == null || pictureMaze.Image.Width != pictureMaze.Width || pictureMaze.Image.Height != pictureMaze.Height)
            {
                if (pictureMaze.Image != null)
                {
                    pictureMaze.Image.Dispose();
                }
                pictureMaze.Image = new Bitmap(pictureMaze.Width, pictureMaze.Height);
            }
            using (Graphics g = Graphics.FromImage(pictureMaze.Image))
            {

                g.Clear(Color.White);
                for (int row = 0; row < gridHeight; row++)
                {
                    for (int col = 0; col < gridWidth; col++)
                    {
                        int x = (int)(col * cellWidth);
                        int y = (int)(row * cellHeight);

                        int nextX = (int)((col + 1) * cellWidth);
                        int nextY = (int)((row + 1) * cellHeight);


                        g.FillRectangle(cellBrush, x, y, cellWidth, cellHeight);
                        g.DrawRectangle(wallPen, x, y, nextX - x, nextY - y);

                        if (FillWallsArray != null && FillWallsArray[row, col] == true)
                            g.FillRectangle(wallBrush, x, y, cellWidth, cellHeight);



                    }
                }

                if (startPoint != null)
                {
                    int x = (int)(startPoint.Y * cellWidth);
                    int y = (int)(startPoint.X * cellHeight);
                    g.FillRectangle(startPointBrush, x, y, cellWidth, cellHeight);
                }

                if (endPoint != null)
                {
                    int x = (int)(endPoint.Y * cellWidth);
                    int y = (int)(endPoint.X * cellHeight);
                    g.FillRectangle(endPointBrush, x, y, cellWidth, cellHeight);
                }


            }
            pictureMaze.Invalidate();

        }
        private void AdminAboutUs_Click(object sender, EventArgs e)
        {
            Form customMessageBox = new Form();
            customMessageBox.Size = new Size(825, 350);
            customMessageBox.Text = "Справочная информация о разработчиках";

            Label label = new Label();
            label.Text = "Самарский университет\nКафедра программных систем\n\nКурсовой проект по дисциплине 'Программная инженерия'\n\nТема проекта: «Автоматизированная система генерирования структуры лабиринта и нахождения выхода из него»\n\nРаботу выполнили обучающиеся группы 6414-020302D:\n    Аденина Елизавета\n    Михайлова Кристина\n\nНаучный руководитель:\n    Зеленко Лариса Сергеевна, доцент кафедры ПС\n\n\nСамара 2023";
            label.AutoSize = true;
            label.Font = new Font("Times New Roman", 11, FontStyle.Bold); // Настройки шрифта
            label.TextAlign = ContentAlignment.MiddleCenter; // Выравнивание текста по центру
            label.Dock = DockStyle.Fill; // Занимает всю доступную площадь
            customMessageBox.Controls.Add(label);

            customMessageBox.ShowDialog();
        }

        private void AdminAboutSys_Click(object sender, EventArgs e)
        {
            string htmlFilePath = $@"{Environment.CurrentDirectory}\admin.html";

            if (File.Exists(htmlFilePath))
            {
                System.Diagnostics.Process.Start(htmlFilePath);
            }
            else
            {
                MessageBox.Show("Файл не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool SaveMatrixToXml(string filePath)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            using (XmlWriter writer = XmlWriter.Create(filePath, settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Matrix");

                for (int i = 0; i < FillWallsArray.GetLength(0); i++)
                {
                    writer.WriteStartElement("Row");

                    for (int j = 0; j < FillWallsArray.GetLength(1); j++)
                    {
                        writer.WriteElementString("Cell", FillWallsArray[i, j].ToString());
                    }

                    writer.WriteEndElement();
                }
                if (startPoint != null)
                {
                    writer.WriteElementString("StartPoint", $"{startPoint.X}:{startPoint.Y}");
                }
                if (endPoint != null)
                {
                    writer.WriteElementString("EndPoint", $"{endPoint.X}:{endPoint.Y}");
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
                MessageBox.Show("Лабиринт успешно сохранён в файл!");
            }
            return true;
        }
        private void saveToFile_Click(object sender, EventArgs e)
        {
            switch (stepForm)
            {
                case StepForm.NOTCREATETEMPLATE:
                    MessageBox.Show("Создайте шаблон!");
                    break;
                case StepForm.CREATEDTEMPLATE:
                    MessageBox.Show("Расставьте точки входа и выхода!");
                    break;
                /*                case StepForm.SETPOINTENTRYEXIT:
                                    MessageBox.Show("Сгенерируйте матрицу!!");

                                    break;*/
                case StepForm.SETPOINTEXIT:
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "XML файлы (*.xml)|*.xml";
                    saveFileDialog.InitialDirectory = KnownFolders.Downloads.Path;
                    if (FillWallsArray is null || FillWallsArray?.Length == 0)
                    {
                        MessageBox.Show("Генерация лабиринта не выполнена!");
                        break;
                    }

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        SaveMatrixToXml(saveFileDialog.FileName);
                        stepForm = StepForm.EXPORTEDMAZE;
                    }
                    break;

                case StepForm.EXPORTEDMAZE:
                    break;
            }



        }

        private void Admin_Load(object sender, EventArgs e)
        {

            Control.ControlCollection modes = modeGroupBox.Controls;

            foreach (RadioButton rdb in modes)
            {
                rdb.MouseUp += ModeRadioButtons_CheckedChanged;
            }
        }
        private void ModeRadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton.Checked == true)
            {
                switch (radioButton.Name)
                {
                    case "radioButtonAdminAuto":
                        EntryExit.Enabled = false;
                        EntryExit.Visible = false;
                        break;
                    case "radioButtonAdminHands":
                        EntryExit.Enabled = true;
                        EntryExit.Visible = true;
                        break;
                }
            }
        }

        private void pictureMaze_Click(object sender, EventArgs e)
        {
            uint gridWidth = (uint)FillWallsArray.GetLength(0);
            uint gridHeight = (uint)FillWallsArray.GetLength(1);
            float cellWidth = (float)pictureMaze.Width / gridWidth;
            float cellHeight = (float)pictureMaze.Height / gridHeight;
            MouseEventArgs me = (MouseEventArgs)e;
            int cellRowIndex = Convert.ToInt32(Math.Floor(me.Y / cellHeight));
            int cellColumnIndex = Convert.ToInt32(Math.Floor(me.X / cellWidth));
            switch (stepForm)
            {
                case StepForm.NOTCREATETEMPLATE:
                    MessageBox.Show("Создайте шаблон!");
                    break;
                case StepForm.GENERATEDMAZE:

                    if (FillWallsArray[cellRowIndex, cellColumnIndex] == false)
                    {
                        startPoint = new Point(cellRowIndex, cellColumnIndex);
                        DrawMaze(FillWallsArray);
                        stepForm = StepForm.SETPOINTENTRY;
                    }

                    break;
                case StepForm.SETPOINTENTRY:
                    if (FillWallsArray[cellRowIndex, cellColumnIndex] == false)
                    {
                        endPoint = new Point(cellRowIndex, cellColumnIndex);
                        DrawMaze(FillWallsArray);
                        stepForm = StepForm.SETPOINTEXIT;
                    }

                    break;
                case StepForm.SETPOINTEXIT:
                    MessageBox.Show("Точки входа и выхода расставлены!");
                    break;

            }


        }
    }
}
