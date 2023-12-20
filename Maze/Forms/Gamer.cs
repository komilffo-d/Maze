using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
using RadioButton = System.Windows.Forms.RadioButton;

namespace Maze
{
    public partial class Gamer : Form
    {
        private protected enum EStepForm : sbyte
        {
            UNLOADMAZE = 1,
            LOADEDMAZE,
            BEGANPASS,
            ENDPASS

        }
        private bool _isValid = true;
        public List<string> errorList = new List<string>();

        SolidBrush wallBrush = new SolidBrush(Color.Orange);
        List<PictureBox> pictureBoxes = new List<PictureBox>();
        private bool[,] FillWallsArray;
        Image backgroundCellImage = null;
        private string backgroundCellFileName = @"Resources\halloween.jpg";
        private Point? startPoint = null;
        private Point? endPoint = null;
        private uint gridWidth;
        private uint gridHeight;
        private EStepForm _stepForm = EStepForm.UNLOADMAZE;
        private protected EStepForm StepForm
        {
            get { return _stepForm; }
            set
            {
                _stepForm = value;
                StepFormPropertyChanged();
            }
        }
        private void StepFormPropertyChanged()
        {
            switch (StepForm)
            {
                case EStepForm.UNLOADMAZE:
                    label3.Visible = true;
                    ModePassGroupBox.Visible = true;
                    pictureMaze.Image = null;
                    pictureMaze.Invalidate();
                    pictureBox2.Enabled = false;
                    pictureBox2.Visible = false;
                    FillWallsArray = null;
                    startPoint = null;
                    endPoint = null;
                    gridWidth = default;
                    gridHeight = default;
                    label4.Visible = false;
                    label5.Visible = false;
                    startGame.Visible = false;
                    startGame.Enabled = false;
                    algorithmGroupBox.Visible = false;
                    trackBarSpeed.Visible = false;
                    trackBarSpeed.Enabled = false;
                    radioButtonHands.Checked = true;
                    ThemeGroupBox.Enabled = true;
                    radioButtonHalloween.Checked = true;
                    ThemeRadioButtons_CheckedChanged(radioButtonHalloween, null);
                    ModeRadioButtons_CheckedChanged(radioButtonHands, null);
                    break;
                case EStepForm.LOADEDMAZE:
                    label3.Visible = true;
                    ModePassGroupBox.Visible = true;
                    pictureBox2.Enabled = false;
                    pictureBox2.Visible = false;
                    gridWidth = (uint)FillWallsArray.GetLength(1);
                    gridHeight = (uint)FillWallsArray.GetLength(0);
                    startGame.Visible = true;
                    startGame.Enabled = true;
                    ThemeGroupBox.Enabled = true;
                    trackBarSpeed.Enabled = true;
                    ThemeRadioButtons_CheckedChanged(radioButtonHalloween, null);
                    ThemeRadioButtons_CheckedChanged(radioButtonNewYear, null);
                    ThemeRadioButtons_CheckedChanged(radioButtonSea, null);
                    ThemeRadioButtons_CheckedChanged(radioButtonForest, null);
                    ModeRadioButtons_CheckedChanged(radioButtonHands, null);
                    break;
                case EStepForm.BEGANPASS:
                    label3.Visible = false;
                    ModePassGroupBox.Visible = false;
                    label4.Visible = false;
                    algorithmGroupBox.Visible = false;
                    startGame.Visible = false;
                    startGame.Enabled = false;
                    trackBarSpeed.Visible = false;
                    ThemeGroupBox.Enabled = false;
                    trackBarSpeed.Enabled = false;
                    pictureMaze.Focus();
                    if (radioButtonAuto.Checked)
                        AutoPassMaze();
                    break;
                case EStepForm.ENDPASS:
                    StepForm = EStepForm.LOADEDMAZE;
                    break;

            }
        }

        public Gamer()
        {
            InitializeComponent();
        }
        private void clearAll()
        {

            StepForm = EStepForm.UNLOADMAZE;
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

            float cellWidth = (float)pictureMaze.Width / gridWidth;
            float cellHeight = (float)pictureMaze.Height / gridHeight;

            int cellRowIndex = Convert.ToInt32(Math.Floor(pictureBox2.Top / cellHeight));
            int cellColumnIndex = Convert.ToInt32(Math.Floor(pictureBox2.Left / cellWidth));

            if (e.KeyCode == Keys.Left && pictureBox2.Location.X > 0 && cellColumnIndex > 0 && FillWallsArray[cellRowIndex, cellColumnIndex - 1] == false)
            {
                MoveCharacter(cellRowIndex, cellColumnIndex - 1);
                return;
            }

            else if (e.KeyCode == Keys.Right && pictureBox2.Right < pictureMaze.Width && cellColumnIndex < FillWallsArray.GetLength(1) && FillWallsArray[cellRowIndex, cellColumnIndex + 1] == false)
            {
                MoveCharacter(cellRowIndex, cellColumnIndex + 1);
                return;
            }

            else if (e.KeyCode == Keys.Up && pictureBox2.Location.Y > 0 && cellRowIndex > 0 && FillWallsArray[cellRowIndex - 1, cellColumnIndex] == false)
            {
                MoveCharacter(cellRowIndex - 1, cellColumnIndex);
                return;
            }

            else if (e.KeyCode == Keys.Down && pictureBox2.Bottom < pictureMaze.Height && cellRowIndex < FillWallsArray.GetLength(0) && FillWallsArray[cellRowIndex + 1, cellColumnIndex] == false)
            {
                MoveCharacter(cellRowIndex + 1, cellColumnIndex);
                return;
            }

            if ((cellRowIndex, cellColumnIndex + 1) == (endPoint?.X, endPoint?.Y))
                MoveCharacter(cellRowIndex, cellColumnIndex + 1);
        }
        private void MoveCharacter(int cellRowIndex, int cellColumnIndex)
        {

            if (FillWallsArray is null || FillWallsArray?.Length == 0)
                return;
            float cellWidth = (float)pictureMaze.Width / gridWidth;
            float cellHeight = (float)pictureMaze.Height / gridHeight;
            pictureBox2.Left = Convert.ToInt32(cellColumnIndex * cellWidth + 0.5f);
            pictureBox2.Top = Convert.ToInt32(cellRowIndex * cellHeight + 0.5f);

            if ((cellRowIndex, cellColumnIndex) == (endPoint?.X, endPoint?.Y))
            {
                MessageBox.Show("Лабиринт пройден!");
                StepForm = EStepForm.ENDPASS;
            }
        }

        public bool Validate(XmlDocument document, XmlSchemaSet schema)
        {
            ValidationEventHandler eventHandler = new ValidationEventHandler(ValidationEventHandler);
            document.Schemas = schema;
            document.Validate(eventHandler);
            return _isValid;
        }

        private void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            _isValid = false;
            errorList.Add(e.Message);
        }
        private bool[,] ReadMatrixFromXml(string filePath)
        {

            _isValid = true;
            int rows = 0;
            int cols = 0;
            bool[,] matrix;
            try
            {



                using (XmlReader XMLReader = XmlReader.Create(filePath))
                {
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

                }
                XmlSchemaSet schemaSet = new XmlSchemaSet();
                schemaSet.Add(null, $@"{Environment.CurrentDirectory}\Resources\ruleMaze.xsd");
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(filePath);
                Validate(xmlDocument, schemaSet);

                if (!_isValid || rows < 7 || rows > 21 || cols < 7 || cols > 21)
                    return null;
            }
            catch
            {
                return null;
            }

            using (XmlReader XMLReader = XmlReader.Create(filePath))
            {
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
                        startPoint = new Point(int.Parse(location[0]), int.Parse(location[1]));
                    }
                    else if (XMLReader.NodeType == XmlNodeType.Element && XMLReader.Name == "EndPoint")
                    {
                        string[] location = XMLReader.ReadElementContentAsString().Split(':');
                        endPoint = new Point(int.Parse(location[0]), int.Parse(location[1]));
                    }
                }
            }
            return matrix;
        }
        private void DrawPath(Point item)
        {
            if (FillWallsArray != null && pictureMaze.Image != null)
            {

                Control[] pictureMazes = pictureMaze.Controls.Find($"pictureBox_{item.X}-{item.Y}", true);
                foreach (Control pictureMazeControl in pictureMazes)
                {
                    PictureBox picture = pictureMazeControl as PictureBox;
                    pictureMaze.Controls.Remove(picture);
                    pictureBoxes.Remove(picture);
                    pictureMaze.Invalidate();
                }



            }
        }
        private async void DrawMaze()
        {
            if (FillWallsArray is null || FillWallsArray?.Length == 0)
                return;

            float cellWidth = (float)pictureMaze.Width / gridWidth;
            float cellHeight = (float)pictureMaze.Height / gridHeight;

            Pen wallPen = new Pen(Color.Black);
            SolidBrush cellBrush = new SolidBrush(Color.White);
            SolidBrush startPointBrush = new SolidBrush(Color.GreenYellow);

            SolidBrush endPointBrush = new SolidBrush(Color.Red);

            pictureMaze.Image = null;
            pictureMaze.BackColor = Color.White;
            pictureMaze.Update();
            await Task.Run(() =>
            {
                pictureMaze.Image = new Bitmap(pictureMaze.Width, pictureMaze.Height);

                using (Graphics g = Graphics.FromImage(pictureMaze.Image))
                {

                    g.Clear(Color.White);
                    foreach (PictureBox picture in pictureBoxes)
                    {
                        lock (picture)
                        {
                            pictureMaze.Invoke(new Action(() => pictureMaze.Controls.Remove(picture)));
                        };
                    }
                    pictureBoxes.Clear();
                    for (int row = 0; row < gridHeight; row++)
                    {
                        for (int col = 0; col < gridWidth; col++)
                        {
                            int x = (int)(col * cellWidth);
                            int y = (int)(row * cellHeight);

                            int nextX = (int)((col + 1) * cellWidth);
                            int nextY = (int)((row + 1) * cellHeight);



                            if (FillWallsArray != null && FillWallsArray[row, col] == true)
                            {
                                g.FillRectangle(wallBrush, x, y, cellWidth, cellHeight);
                            }
                            else
                            {

                                PictureBox picture = new PictureBox()
                                {
                                    Name = $"pictureBox_{row}-{col}",
                                    Size = new Size((int)cellWidth, (int)cellHeight),
                                    SizeMode = PictureBoxSizeMode.StretchImage,
                                    Visible = true,
                                    Image = backgroundCellImage
                                };
                                float scaleX = cellWidth / (int)cellWidth, scaleY = cellHeight / (int)cellHeight;
                                picture.Scale(new SizeF(scaleX, scaleY));
                                picture.Location = new Point(x, y);
                                picture.SendToBack();
                                lock (picture)
                                {
                                    pictureMaze.Invoke(new Action(() => pictureMaze.Controls.Add(picture)));
                                    picture.Invoke(new Action(() => picture.SendToBack()));
                                    pictureBoxes.Add(picture);
                                }
                            }

                        }
                    }
                    if (startPoint != null)
                    {
                        int x = (int)(startPoint?.Y * cellWidth);
                        int y = (int)(startPoint?.X * cellHeight);
                        g.FillRectangle(startPointBrush, x, y, cellWidth, cellHeight);
                    }

                    if (endPoint != null)
                    {
                        int x = (int)(endPoint?.Y * cellWidth);
                        int y = (int)(endPoint?.X * cellHeight);
                        g.FillRectangle(endPointBrush, x, y, cellWidth, cellHeight);
                    }
                }
            });


            var backgroundImage = Image.FromFile(backgroundCellFileName);
            pictureBox2.BackgroundImage = backgroundImage;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;

            pictureMaze.Invalidate();
            pictureBox2.Invalidate();

        }
        private void outputMazeFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выбор только из каталога Resources!");
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "XML файлы (*.xml)|*.xml";
            openFileDialog.InitialDirectory = $@"{Environment.CurrentDirectory}\Resources";
            openFileDialog.FileOk += (senderIn, eIn) =>
            {
                string[] files = openFileDialog.FileNames;

                foreach (string file in files)
                {
                    if (Path.GetDirectoryName(file) != $@"{Environment.CurrentDirectory}\Resources")
                    {
                        eIn.Cancel = true;
                        break;
                    }
                }
            };


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FillWallsArray = ReadMatrixFromXml(openFileDialog.FileName);
                if (FillWallsArray is null)
                    MessageBox.Show("Неправильный формат XML файла");
                else
                {
                    StepForm = EStepForm.LOADEDMAZE;
                    MessageBox.Show("Лабиринт успешно загружен из файла!");
                }

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

            Control.ControlCollection modes = ModePassGroupBox.Controls;

            foreach (RadioButton rdb in modes)
            {
                rdb.MouseUp += ModeRadioButtons_CheckedChanged;
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
                        backgroundCellFileName = @"Resources\halloween.jpg";
                        break;
                    case "radioButtonForest":
                        wallBrush = new SolidBrush(Color.Green);
                        backgroundCellFileName = @"Resources\forest.jpg";
                        break;
                    case "radioButtonNewYear":
                        wallBrush = new SolidBrush(Color.Blue);
                        backgroundCellFileName = @"Resources\new_year.png";
                        break;
                    case "radioButtonSea":
                        wallBrush = new SolidBrush(Color.Aqua);
                        backgroundCellFileName = @"Resources\sea.jpg";
                        break;
                }
                backgroundCellImage = Image.FromFile(backgroundCellFileName);
                DrawMaze();
            }
        }
        private void ModeRadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton.Checked == true)
            {
                switch (radioButton.Name)
                {
                    case "radioButtonHands":
                        label4.Visible = false;
                        algorithmGroupBox.Visible = false;
                        trackBarSpeed.Visible = false;
                        break;
                    case "radioButtonAuto":
                        label4.Visible = true;
                        algorithmGroupBox.Visible = true;
                        trackBarSpeed.Visible = true;

                        break;
                }
            }
        }
        private void startGame_Click(object sender, EventArgs e)
        {
            if (FillWallsArray is null || FillWallsArray?.Length == 0)
                return;
            float cellWidth = (float)pictureMaze.Width / gridWidth;
            float cellHeight = (float)pictureMaze.Height / gridHeight;
            Image image = Image.FromFile(@"Resources\mario.png");

            Bitmap bit = new Bitmap(image);
            bit.MakeTransparent();
            pictureBox2.Image = bit;
            pictureBox2.Size = Size.Round(new SizeF(Convert.ToInt32(cellWidth), Convert.ToInt32(cellHeight)));
            pictureMaze.Controls.Add(pictureBox2);
            int X = Convert.ToInt32(startPoint?.Y * cellWidth + 0.5f);
            int Y = Convert.ToInt32((startPoint?.X) * cellHeight + 0.5f);
            pictureBox2.Location = new Point(X, Y);
            pictureBox2.Enabled = true;
            pictureBox2.Visible = true;
            pictureBox2.BringToFront();
            pictureMaze.Invalidate();
            pictureBox2.Invalidate();
            StepForm = EStepForm.BEGANPASS;
        }
        private async void AutoPassMaze()
        {
            int[,] intArray = new int[gridHeight, gridWidth];

            for (int i = 0; i < gridHeight; i++)
            {
                for (int j = 0; j < gridWidth; j++)
                {
                    intArray[i, j] = FillWallsArray[i, j] ? 1 : 0;
                }
            }

            if (radioButtonWave.Checked)
            {
                var searcher = new WaveResolver(WaveResolver.SearchMethod.Path4);
                var start = new WaveResolver.Point((int)startPoint?.X, (int)startPoint?.Y + 1);
                var end = new WaveResolver.Point((int)endPoint?.X, (int)endPoint?.Y - 1);
                var path = searcher.Search(intArray, start, end);
                await Task.Delay(1000 / trackBarSpeed.Value);
                MoveCharacter((int)startPoint?.X, (int)startPoint?.Y + 1);
                DrawPath(new Point((int)startPoint?.X, (int)startPoint?.Y+1));
                for (int i = 0; i < path.Length; i++)
                {

                    await Task.Delay(1000 / trackBarSpeed.Value);
                    MoveCharacter(path[i].X, path[i].Y);
                    DrawPath(new Point(path[i].X, path[i].Y));

                }
                await Task.Delay(1000 / trackBarSpeed.Value);
                MoveCharacter((int)endPoint?.X, (int)endPoint?.Y);
                DrawPath(new Point((int)endPoint?.X, (int)endPoint?.Y));
            }
            else if (radioButton1Hands.Checked)
            {
                var path = HandSolver.SolveMaze(intArray, new int[] { (int)startPoint?.X, (int)startPoint?.Y }, new int[] { (int)endPoint?.X, (int)endPoint?.Y - 1 });

                for (int i = 0; i < path.GetLength(0); i++)
                {

                    await Task.Delay(1000 / trackBarSpeed.Value);
                    MoveCharacter(path[i, 0], path[i, 1]);
                    DrawPath(new Point(path[i, 0], path[i, 1]));

                }
                await Task.Delay(1000 / trackBarSpeed.Value);
                MoveCharacter((int)endPoint?.X, (int)endPoint?.Y);
                DrawPath(new Point((int)endPoint?.X, (int)endPoint?.Y));
            }




        }

    }

}

