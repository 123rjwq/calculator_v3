using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lots_of_games_v3
{
    public partial class Form1 : Form
    {
        // Переменные для управления перетаскиванием формы и отслеживания состояния игры
        private Point pos;// Позиция мыши при нажатии
        private bool dragging, lose = false;// Флаги для перетаскивания и проигрыша
        private int countCoins = 0; // Счетчик монет
        private int[] gameScores = new int[10]; // Массив для хранения счетов последних 10 игр
        private int gameCount = 0; // Счетчик игр


        public Form1()
        {
            InitializeComponent();

            // Привязка обработчиков событий мыши к элементам управления
            road.MouseDown += MouseClickDown;
            road.MouseUp += MouseClickUp;
            road.MouseMove += MouseClickMove;

            road2.MouseDown += MouseClickDown;
            road2.MouseUp += MouseClickUp;
            road2.MouseMove += MouseClickMove;

            // Настройка видимости элементов управления
            labelLose.Visible = false;
            button_restart.Visible = false;

            // Включение предварительного просмотра клавиш для обработки нажатий
            KeyPreview = true;
        }

        private void MouseClickDown(object sender, MouseEventArgs e)
        {
            // Начало перетаскивания формы
            dragging = true;
            pos.X = e.X;
            pos.Y = e.Y;
        }

        private void MouseClickUp(object sender, MouseEventArgs e)
        {
            // Остановка перетаскивания
            dragging = false;
        }

        // Перемещение формы при перетаскивании
        private void MouseClickMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point currPoint = PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(currPoint.X - pos.X, currPoint.Y - pos.Y + road.Top);
            }
        }

        // Обработка нажатия клавиши Escape для закрытия формы
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }


        // Основное тело игры (передвижение карты, соперников, монет)
        private void timer_Tick(object sender, EventArgs e)
        {
            int speed = 10;// Скорость движения дорог и автомобилей
            road.Top += speed;
            road2.Top += speed;

            // Скорость движения автомобилей-соперников
            int carSpeed = 7;
            machine_opponent1.Top += carSpeed;
            machine_opponent2.Top += carSpeed;
            machine_opponent3.Top += carSpeed;
            machine_opponent4.Top += carSpeed;

            // Скорость движения монет
            coin.Top += speed - 3;

            // Генерация монет
            Coin_generation();

            if (road.Top >= 640)
            {
                road.Top = 0;
                road2.Top = -640;
            }

            if (machine_opponent1.Top >= 750)
            {
                machine_opponent1.Top = -161;
                machine_opponent1.Left = RandomNumber1();

            }

            if (machine_opponent2.Top >= 860)
            {
                machine_opponent2.Top = -501;
                machine_opponent2.Left = RandomNumber1();
            }

            if (machine_opponent3.Top >= 960)
            {
                machine_opponent3.Top = -150;
                machine_opponent3.Left = RandomNumber2();
            }

            if (machine_opponent4.Top >= 1060)
            {
                machine_opponent4.Top = -650;
                machine_opponent4.Left = RandomNumber2();
            }

            // Условие проигрыша и вывод меню перезапуска
            if (player.Bounds.IntersectsWith(machine_opponent4.Bounds)
                || player.Bounds.IntersectsWith(machine_opponent3.Bounds)
                || player.Bounds.IntersectsWith(machine_opponent2.Bounds)
                || player.Bounds.IntersectsWith(machine_opponent1.Bounds))
            {
                timer.Enabled = false;
                labelLose.Visible = true;
                button_restart.Visible = true;
                lose = true;

                // Вывод результатов последних 10 игр
                DisplayGameResults();
            }

            // Проверка пересечения с монетами для увеличения счета
            if (player.Bounds.IntersectsWith(coin.Bounds))
            {
                countCoins += 1;
                labelCoins.Text = "Счет: " + countCoins.ToString();
                Coin_generation();
            }

        }

        // Генерация случайных чисел для определения позиции автомобилей-соперников
        private int RandomNumber1()
        {
            List<int> numbers = new List<int> { 181, 307 };

            Random random = new Random();
            int randomIndex = random.Next(0, numbers.Count);
            int randomNumber = numbers[randomIndex];

            return randomNumber;

        }

        private int RandomNumber2()
        {
            List<int> numbers2 = new List<int> { 437, 562 };

            Random random = new Random();
            int randomIndex2 = random.Next(0, numbers2.Count);
            int randomNumber2 = numbers2[randomIndex2];

            return randomNumber2;

        }

        private int RandomNumber3()
        {
            List<int> numbers2 = new List<int> { 181, 307, 437, 562 };

            Random random = new Random();
            int randomIndex2 = random.Next(0, numbers2.Count);
            int randomNumber2 = numbers2[randomIndex2];

            return randomNumber2;

        }

        // Генерация монет в случайных позициях
        private void Coin_generation()
        {
            if (coin.Top >= 640)
            {
                coin.Top = -300;
                coin.Left = RandomNumber3();
            }
        }

        // Обработка нажатий клавиш для управления движением игрока
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (lose) return; // Если игра закончена, игнорировать нажатия

            int speed = 50; // Скорость движения игрока

            // Перемещение игрока влево или вправо
            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && player.Left > 185)
            {
                player.Left -= speed;
            }
            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && player.Right < 660)
            {
                player.Left += speed;
            }
        }

        // Обработчики событий клика для элементов управления, которые в данном случае пусты
        private void pictureBox1_Click(object sender, EventArgs e) {}
        private void machine_opponent3_Click(object sender, EventArgs e) {}

        // Обработчик события клика по кнопке перезапуска, сброс игры
        private void button_restart_Click(object sender, EventArgs e)
        {
            // Сохранение результата текущей игры
            gameScores[gameCount % 10] = countCoins;
            gameCount++;

            // Сброс игры
            machine_opponent4.Top = -650;
            machine_opponent3.Top = -501;
            machine_opponent2.Top = -361;
            machine_opponent1.Top = -161;
            labelLose.Visible = false;
            button_restart.Visible = false;
            timer.Enabled = true;
            lose = false;
            countCoins = 0;
            labelCoins.Text = "Счет: " + countCoins.ToString();
            coin.Top = -600;
        }
        private void DisplayGameResults()
        {
            // Сортировка результатов игр
            Array.Sort(gameScores);
            Array.Reverse(gameScores);

            // Формирование сообщения с результатами
            StringBuilder sb = new StringBuilder("Результаты последних 10 игр:\n");
            for (int i = 0; i < 10; i++)
            {
                sb.AppendLine($"{i + 1}. {gameScores[i]}");
            }

            // Вывод сообщения
            MessageBox.Show(sb.ToString(), "Результаты");
        }

    }
}
