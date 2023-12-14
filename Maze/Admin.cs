using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Maze
{
    public partial class Admin : Form
    {
        private Point[,] gridArray; // Массив для хранения координат

        public Admin()
        {
            InitializeComponent();

        }

        private void createPattern_Click(object sender, EventArgs e)
        {
            int gridWidth = (int)width.Value;
            int gridHeight = (int)height.Value;

            // Инициализация массива для координат
            gridArray = new Point[gridWidth, gridHeight];

            // Создание Bitmap для рисования сетки
            if (pictureBox1.Image == null || pictureBox1.Image.Width != pictureBox1.Width || pictureBox1.Image.Height != pictureBox1.Height)
            {
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose(); // Освобождение ресурсов старого изображения
                }
                pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            }

            // Получение Graphics из PictureBox
            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                g.Clear(pictureBox1.BackColor); // Чистка для прорисовки новой сетки

                // Расчет размера каждой клетки с учетом остатка
                float cellWidth = (float)pictureBox1.Width / gridWidth;
                float cellHeight = (float)pictureBox1.Height / gridHeight;

                // Рисование сетки и заполнение массива координат
                for (int i = 0; i < gridWidth; i++)
                {
                    for (int j = 0; j < gridHeight; j++)
                    {
                        // Рассчитать координаты верхнего левого угла текущей клетки
                        int x = (int)(i * cellWidth);
                        int y = (int)(j * cellHeight);
                        int nextX = (int)((i + 1) * cellWidth);
                        int nextY = (int)((j + 1) * cellHeight);

                        // Сохранение координат клетки в массив
                        gridArray[i, j] = new Point(x, y);

                        // Рисование прямоугольника (клетки)
                        g.DrawRectangle(Pens.Black, x, y, nextX - x, nextY - y);
                    }
                }
            }

            // Обновление PictureBox для отображения нарисованной сетки
            pictureBox1.Invalidate();
        }

        private void Generate_Click(object sender, EventArgs e)
        {

            //int gridWidth = gridArray.GetLength(0);
            //int gridHeight = gridArray.GetLength(1);
            //bool[,] maze = GenerateMaze(gridWidth, gridHeight);
            //pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //DrawMaze(maze);
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
    }
}
