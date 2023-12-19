using Syroot.Windows.IO;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using RadioButton = System.Windows.Forms.RadioButton;

namespace Maze
{
    public partial class Gamer : Form
    {
        private protected enum StepForm : sbyte
        {
            UNLOADMAZE = 1,
            LOADEDMAZE,
            BEGANPASS,
            ENDPASS

        }

        private StepForm stepForm = StepForm.UNLOADMAZE;
        private bool[,] FillWallsArray;
        private Tuple<int, int> startPoint = null;
        private Tuple<int, int> endPoint = null;
        SolidBrush wallBrush = new SolidBrush(Color.Orange);
        public Gamer()
        {
            InitializeComponent();
        }

        private void aboutUs_Click(object sender, EventArgs e)
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

        private void aboutSys_Click(object sender, EventArgs e)
        {
            string htmlFilePath = $@"{Environment.CurrentDirectory}\gamer.html";

            if (File.Exists(htmlFilePath))
            {
                System.Diagnostics.Process.Start(htmlFilePath);
            }
            else
            {
                MessageBox.Show("Файл не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Gamer_KeyDown(object sender, KeyEventArgs e)
        {
            if (FillWallsArray is null || FillWallsArray?.Length == 0)
                return;
            int gridWidth = FillWallsArray.GetLength(1);
            int gridHeight = FillWallsArray.GetLength(0);
            float cellWidth = (float)pictureMaze.Width / gridWidth;
            float cellHeight = (float)pictureMaze.Height / gridHeight;

            int cellRowIndex = Convert.ToInt32(Math.Floor(pictureBox2.Top / cellHeight));
            int cellColumnIndex = Convert.ToInt32(Math.Floor(pictureBox2.Left / cellWidth));

            if (e.KeyCode == Keys.Left && pictureBox2.Location.X > 0 && cellColumnIndex > 0 && FillWallsArray[cellRowIndex, cellColumnIndex - 1] == false)
                pictureBox2.Left = Convert.ToInt32(Math.Floor(pictureBox2.Left / cellWidth) * cellWidth - cellWidth + 0.5f);
            else if (e.KeyCode == Keys.Right && pictureBox2.Right < pictureMaze.Width && cellColumnIndex < FillWallsArray.GetLength(1) && FillWallsArray[cellRowIndex, cellColumnIndex + 1] == false)
                pictureBox2.Left = Convert.ToInt32(Math.Floor(pictureBox2.Left / cellWidth) * cellWidth + cellWidth + 0.5f);
            else if (e.KeyCode == Keys.Up && pictureBox2.Location.Y > 0 && cellRowIndex > 0 && FillWallsArray[cellRowIndex - 1, cellColumnIndex] == false)
                pictureBox2.Top = Convert.ToInt32(Math.Floor(pictureBox2.Top / cellHeight) * cellHeight - cellHeight + 0.5f);
            else if (e.KeyCode == Keys.Down && pictureBox2.Bottom < pictureMaze.Height && cellRowIndex < FillWallsArray.GetLength(0) && FillWallsArray[cellRowIndex + 1, cellColumnIndex] == false)
                pictureBox2.Top = Convert.ToInt32(Math.Floor(pictureBox2.Top / cellHeight) * cellHeight + cellHeight + 0.5f);


             cellRowIndex = Convert.ToInt32(Math.Floor(pictureBox2.Top / cellHeight));
             cellColumnIndex = Convert.ToInt32(Math.Floor(pictureBox2.Left / cellWidth));
            if ((cellRowIndex, cellColumnIndex) == (endPoint.Item1, endPoint.Item2))
            {
                MessageBox.Show("Лабиринт пройден!");
            }
        }
        private void MoveCharacter(int cellRowIndex,int cellColumnIndex)
        {

/*            int cellColumnIndex = Convert.ToInt32(Math.Floor(pictureBox2.Left / cellWidth));*/
            if (FillWallsArray is null || FillWallsArray?.Length == 0)
                return;
            int gridWidth = FillWallsArray.GetLength(1);
            int gridHeight = FillWallsArray.GetLength(0);
            float cellWidth = (float)pictureMaze.Width / gridWidth;
            float cellHeight = (float)pictureMaze.Height / gridHeight;
            pictureBox2.Left = Convert.ToInt32(cellColumnIndex * cellWidth + 0.5f);
            pictureBox2.Top = Convert.ToInt32(cellRowIndex * cellHeight + 0.5f);

            cellRowIndex = Convert.ToInt32(Math.Floor(pictureBox2.Top / cellHeight));
            cellColumnIndex = Convert.ToInt32(Math.Floor(pictureBox2.Left / cellWidth));
            if ((cellRowIndex, cellColumnIndex) == (endPoint.Item1, endPoint.Item2))
            {
                MessageBox.Show("Лабиринт пройден!");
            }
        }

        private bool[,] ReadMatrixFromXml(string filePath)
        {
            XmlReader XMLReader = XmlReader.Create(filePath);
            int rows = 0;
            int cols = 0;
            bool[,] matrix;

            while (XMLReader.Read())
            {
                int count = 0;
                if (XMLReader.NodeType == XmlNodeType.Element && XMLReader.Name == "Row")
                {
                    rows++;
                    XMLReader.ReadToDescendant("Cell");

                    do
                    {
                        count++;
                    } while (XMLReader.ReadToNextSibling("Cell"));
                }
                cols = Math.Max(cols, count);
            }

            XMLReader = XmlReader.Create(filePath);

            matrix = new bool[rows, cols];

            int currentRow = 0;
            int currentCol = 0;

            while (XMLReader.Read())
            {
                if (XMLReader.NodeType == XmlNodeType.Element && XMLReader.Name == "Cell")
                {
                    matrix[currentRow, currentCol] = bool.Parse(XMLReader.ReadElementContentAsString());
                    currentCol++;
                }
                else if (XMLReader.NodeType == XmlNodeType.EndElement && XMLReader.Name == "Row")
                {
                    currentRow++;
                    currentCol = 0;
                }
                else if (XMLReader.NodeType == XmlNodeType.Element && XMLReader.Name == "StartPoint")
                {
                    string[] location = XMLReader.ReadElementContentAsString().Split(':');
                    startPoint = new Tuple<int, int>(int.Parse(location[0]), int.Parse(location[1]));
                }
                else if (XMLReader.NodeType == XmlNodeType.Element && XMLReader.Name == "EndPoint")
                {
                    string[] location = XMLReader.ReadElementContentAsString().Split(':');
                    endPoint = new Tuple<int, int>(int.Parse(location[0]), int.Parse(location[1]));
                }
            }

            return matrix;
        }
        private void DrawMaze()
        {
            if (FillWallsArray is null || FillWallsArray?.Length == 0)
                return;
            int gridWidth = (int)FillWallsArray.GetLength(1);
            int gridHeight = (int)FillWallsArray.GetLength(0);

            float cellWidth = (float)pictureMaze.Width / gridWidth;
            float cellHeight = (float)pictureMaze.Height / gridHeight;

            Pen wallPen = new Pen(Color.Black);
            SolidBrush cellBrush = new SolidBrush(Color.White);
            SolidBrush startPointBrush = new SolidBrush(Color.Green);

            SolidBrush endPointBrush = new SolidBrush(Color.Red);
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

                        if (FillWallsArray != null  && FillWallsArray[row, col] == true)
                        {
                            g.FillRectangle(wallBrush, x, y, cellWidth, cellHeight);
                        }

                    }
                }
                if (startPoint != null)
                {
                    int x = (int)(startPoint.Item2 * cellWidth);
                    int y = (int)(startPoint.Item1 * cellHeight);
                    g.FillRectangle(startPointBrush, x, y, cellWidth, cellHeight);
                }

                if (endPoint != null)
                {
                    int x = (int)(endPoint.Item2 * cellWidth);
                    int y = (int)(endPoint.Item1 * cellHeight);
                    g.FillRectangle(endPointBrush, x, y, cellWidth, cellHeight);
                }
            }


            pictureMaze.Invalidate();

        }
        private void outputMazeFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "XML файлы (*.xml)|*.xml";
            openFileDialog.InitialDirectory = KnownFolders.Downloads.Path;



            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FillWallsArray = ReadMatrixFromXml(openFileDialog.FileName);
                DrawMaze();
                stepForm = StepForm.LOADEDMAZE;
                MessageBox.Show("Лабиринт успешно загружен из файла!");

            }
        }

        private void Gamer_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                e.IsInputKey = true;
            }
        }

        private void Gamer_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                control.PreviewKeyDown += new PreviewKeyDownEventHandler(Gamer_PreviewKeyDown);
            }
            Control.ControlCollection themes = ThemeGroupBox.Controls;

            foreach (RadioButton rdb in themes)
            {
                rdb.MouseUp += ThemeRadioButtons_CheckedChanged;
            }
        }
        private void ThemeRadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton.Checked == true)
            {
                switch (radioButton.Name)
                {
                    case "radioButtonHalloween":
                        wallBrush = new SolidBrush(Color.Orange);
                        break;
                    case "radioButtonForest":
                        wallBrush = new SolidBrush(Color.Green);
                        break;
                    case "radioButtonNewYear":
                        wallBrush = new SolidBrush(Color.Blue);
                        break;
                    case "radioButtonSea":
                        wallBrush = new SolidBrush(Color.Aqua);
                        break;
                }
            }
        }
        private async void startGame_Click(object sender, EventArgs e)
        {
            switch (stepForm)
            {
                case StepForm.UNLOADMAZE:
                    break;
                case StepForm.LOADEDMAZE:
                    if (FillWallsArray is null || FillWallsArray?.Length == 0)
                        return;
                    int gridWidth = FillWallsArray.GetLength(1);
                    int gridHeight = FillWallsArray.GetLength(0);
                    float cellWidth = (float)pictureMaze.Width / gridWidth;
                    float cellHeight = (float)pictureMaze.Height / gridHeight;
                    Image image = Image.FromFile(@"Resources\mario.png");

                    Bitmap bit = new Bitmap(image);
                    bit.MakeTransparent();

                    pictureBox2.Image = bit;
                    pictureBox2.Size = Size.Round(new SizeF(Convert.ToInt32(cellWidth), Convert.ToInt32(cellHeight)));
                    pictureMaze.Controls.Add(pictureBox2);
                    pictureBox2.BackColor = Color.Transparent;
                    int X=Convert.ToInt32(startPoint.Item2 * cellWidth + 0.5f);
                    int Y= Convert.ToInt32((startPoint.Item1) * cellHeight + 0.5f);
                    pictureBox2.Location = new Point(X, Y);
                    pictureBox2.Enabled = true;
                    pictureBox2.Visible = true;

                    pictureMaze.Invalidate();
                    pictureBox2.Invalidate();
                    stepForm = StepForm.BEGANPASS;
                    break;
                case StepForm.BEGANPASS:
                    int rows = FillWallsArray.GetLength(0);
                    int columns = FillWallsArray.GetLength(1);

                    int[,] intArray = new int[rows, columns];

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            intArray[i, j] = FillWallsArray[i, j] ? 1 : 0;
                        }
                    }
                    var searcher = new WaveResolver(WaveResolver.SearchMethod.Path4);
                    var start = new WaveResolver.Point(startPoint.Item1,startPoint.Item2);
                    var end = new WaveResolver.Point(endPoint.Item1, endPoint.Item2);
                    var path = searcher.Search(intArray, start, end);
                    foreach (var item in path)
                    {
                        
                        

                        await Task.Delay(1000);
                        MoveCharacter(item.X, item.Y);
                    }
                    break;
                case StepForm.ENDPASS:
                    break;
                default:
                    break;
            }


        }
        public static void Count(object obj)
        {
            int x = (int)obj;
            for (int i = 1; i < 9; i++, x++)
            {
                Console.WriteLine($"{x * i}");
            }
        }

    }

}

