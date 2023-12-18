using Syroot.Windows.IO;
using System;
using System.Drawing;
using System.IO;
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
            int gridWidth = FillWallsArray.GetLength(0);
            int gridHeight = FillWallsArray.GetLength(1);
            float cellWidth = (float)pictureMaze.Width / gridWidth;
            float cellHeight = (float)pictureMaze.Height / gridHeight;

            int cellRowIndex = Convert.ToInt32(Math.Floor(pictureBox2.Top / cellWidth));
            int cellColumnIndex = Convert.ToInt32(Math.Floor(pictureBox2.Left / cellWidth));

            if (e.KeyCode == Keys.Left && pictureBox2.Location.X > 0 && cellColumnIndex > 0 && FillWallsArray[cellRowIndex, cellColumnIndex - 1] == false)
                pictureBox2.Left = Convert.ToInt32(Math.Floor(pictureBox2.Left / cellWidth) * cellWidth - cellWidth + 0.5f);
            else if (e.KeyCode == Keys.Right && pictureBox2.Right < pictureMaze.Width && cellColumnIndex < FillWallsArray.GetLength(1) && FillWallsArray[cellRowIndex, cellColumnIndex + 1] == false)
                pictureBox2.Left = Convert.ToInt32(Math.Floor(pictureBox2.Left / cellWidth) * cellWidth + cellWidth + 0.5f);
            else if (e.KeyCode == Keys.Up && pictureBox2.Location.Y > 0 && cellRowIndex > 0 && FillWallsArray[cellRowIndex - 1, cellColumnIndex] == false)
                pictureBox2.Top = Convert.ToInt32(Math.Floor(pictureBox2.Top / cellHeight) * cellHeight - cellHeight + 0.5f);
            else if (e.KeyCode == Keys.Down && pictureBox2.Bottom < pictureMaze.Height && cellRowIndex < FillWallsArray.GetLength(0) && FillWallsArray[cellRowIndex + 1, cellColumnIndex] == false)
                pictureBox2.Top = Convert.ToInt32(Math.Floor(pictureBox2.Top / cellHeight) * cellHeight + cellHeight + 0.5f);
        }


        private static bool[,] ReadMatrixFromXml(string filePath)
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
            }

            return matrix;
        }
        private void DrawMaze()
        {
            if (FillWallsArray is null || FillWallsArray?.Length == 0)
                return;
            int gridWidth = (int)FillWallsArray.GetLength(0);
            int gridHeight = (int)FillWallsArray.GetLength(1);

            float cellWidth = (float)pictureMaze.Width / gridWidth;
            float cellHeight = (float)pictureMaze.Height / gridHeight;

            Pen wallPen = new Pen(Color.Black, 2f);
            SolidBrush cellBrush = new SolidBrush(Color.White);

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
                for (int row = 0; row < gridWidth; row++)
                {
                    for (int col = 0; col < gridHeight; col++)
                    {
                        int x = (int)(col * cellWidth);
                        int y = (int)(row * cellHeight);

                        int nextX = (int)((col + 1) * cellWidth);
                        int nextY = (int)((row + 1) * cellHeight);


                        g.FillRectangle(cellBrush, x, y, cellWidth, cellHeight);
                        g.DrawRectangle(Pens.Black, x, y, nextX - x, nextY - y);

                        if (FillWallsArray[row, col] == true)
                        {
                            g.FillRectangle(wallBrush, x, y, cellWidth, cellHeight);
                        }

                    }
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

            foreach (RadioButton chkBox in themes)
            {
                chkBox.MouseUp += ThemeradioButtons_CheckedChanged;
            }
        }
        private void ThemeradioButtons_CheckedChanged(object sender, EventArgs e)
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
        private void startGame_Click(object sender, EventArgs e)
        {
            switch (stepForm)
            {
                case StepForm.UNLOADMAZE:
                    break;
                case StepForm.LOADEDMAZE:
                    if (FillWallsArray is null || FillWallsArray?.Length == 0)
                        return;
                    int gridWidth = FillWallsArray.GetLength(0);
                    int gridHeight = FillWallsArray.GetLength(1);
                    float cellWidth = (float)pictureMaze.Width / gridWidth;
                    float cellHeight = (float)pictureMaze.Height / gridHeight;
                    Image image = Image.FromFile(@"Resources\mario.png");

                    Bitmap bit = new Bitmap(image);
                    bit.MakeTransparent();

                    pictureBox2.Image = bit;
                    pictureBox2.Size = Size.Round(new SizeF(Convert.ToInt32(cellWidth), Convert.ToInt32(cellHeight)));
                    pictureMaze.Controls.Add(pictureBox2);
                    pictureBox2.BackColor = Color.Transparent;
                    pictureBox2.Location = new Point(0, 0);
                    pictureBox2.Enabled = true;
                    pictureBox2.Visible = true;

                    pictureMaze.Invalidate();
                    pictureBox2.Invalidate();
                    stepForm = StepForm.BEGANPASS;
                    break;
                case StepForm.BEGANPASS:
                    break;
                case StepForm.ENDPASS:
                    break;
                default:
                    break;
            }


        }
    }
}

