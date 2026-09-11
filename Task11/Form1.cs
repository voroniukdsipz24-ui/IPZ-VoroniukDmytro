using System;
using System.Drawing;
using System.Windows.Forms;

namespace CinemaBooking
{
    /// <summary>
    /// Форма-система бронювання місць у залі (кінотеатр/аудиторія).
    /// Схема залу будується динамічно з кнопок у сітці: клік по кнопці
    /// перемикає місце між станами "вільно" і "заброньовано" та оновлює
    /// підсумкову вартість обраних місць.
    /// </summary>
    public partial class MainForm : Form
    {
        // Розмір залу.
        private const int Rows = 6;    // ряди A..F
        private const int Cols = 10;   // місця 1..10

        // Геометрія кнопок-місць.
        private const int SeatWidth = 42;
        private const int SeatHeight = 34;
        private const int GapX = 6;
        private const int GapY = 6;
        private const int GridStartX = 40; // відступ під підписи рядів
        private const int GridStartY = 24; // відступ під підписи номерів місць

        // Ціни за ціновими зонами, грн.
        private const decimal PriceEconomy = 80m;
        private const decimal PriceStandard = 110m;
        private const decimal PriceVip = 150m;

        // Кольори для вільних місць (за зоною) та для заброньованих.
        private static readonly Color ColorFreeEconomy = Color.PaleGreen;
        private static readonly Color ColorFreeStandard = Color.LightGreen;
        private static readonly Color ColorFreeVip = Color.MediumSeaGreen;
        private static readonly Color ColorBooked = Color.Tomato;

        // Інформація про кожне місце зберігається у Button.Tag.
        private class SeatInfo
        {
            public int Row;
            public int Col;
            public decimal Price;
            public bool IsBooked;
            public Color FreeColor;
        }

        // Одна спільна підказка для всіх місць (замість створення нової на кожну кнопку).
        private readonly ToolTip seatToolTip = new ToolTip();

        public MainForm()
        {
            InitializeComponent();
            BuildHall();
            UpdateTotals();
        }

        /// <summary>
        /// Динамічно створює схему залу: підписи рядів/місць та кнопки-місця.
        /// </summary>
        private void BuildHall()
        {
            // Підписи рядів (A, B, C, ...) зліва від кожного ряду кнопок.
            for (int row = 0; row < Rows; row++)
            {
                Label lblRow = new Label
                {
                    Text = ((char)('A' + row)).ToString(),
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    Location = new Point(6, GridStartY + row * (SeatHeight + GapY)),
                    Size = new Size(GridStartX - 10, SeatHeight)
                };
                pnlHall.Controls.Add(lblRow);
            }

            // Підписи номерів місць зверху кожної колонки.
            for (int col = 0; col < Cols; col++)
            {
                Label lblCol = new Label
                {
                    Text = (col + 1).ToString(),
                    AutoSize = false,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 8F),
                    Location = new Point(GridStartX + col * (SeatWidth + GapX), 4),
                    Size = new Size(SeatWidth, 18)
                };
                pnlHall.Controls.Add(lblCol);
            }

            // Кнопки-місця.
            for (int row = 0; row < Rows; row++)
            {
                decimal price = GetPriceForRow(row);
                Color freeColor = GetFreeColorForRow(row);

                for (int col = 0; col < Cols; col++)
                {
                    var seat = new SeatInfo
                    {
                        Row = row,
                        Col = col,
                        Price = price,
                        IsBooked = false,
                        FreeColor = freeColor
                    };

                    Button btnSeat = new Button
                    {
                        Text = (col + 1).ToString(),
                        Location = new Point(GridStartX + col * (SeatWidth + GapX), GridStartY + row * (SeatHeight + GapY)),
                        Size = new Size(SeatWidth, SeatHeight),
                        BackColor = freeColor,
                        FlatStyle = FlatStyle.Flat,
                        Tag = seat,
                        UseVisualStyleBackColor = false
                    };
                    btnSeat.FlatAppearance.BorderColor = Color.DimGray;
                    btnSeat.FlatAppearance.BorderSize = 1;

                    string rowLetter = ((char)('A' + row)).ToString();
                    btnSeat.Text = rowLetter + (col + 1);
                    seatToolTip.SetToolTip(btnSeat, $"Місце {rowLetter}{col + 1} — {price:N0} грн ({GetZoneName(row)})");

                    btnSeat.Click += SeatButton_Click;

                    pnlHall.Controls.Add(btnSeat);
                }
            }
        }

        /// <summary>
        /// Визначає ціну місця залежно від ряду: перший/останній ряд — економ,
        /// другий/передостанній — стандарт, середні ряди (найкращий огляд) — VIP.
        /// </summary>
        private decimal GetPriceForRow(int row)
        {
            if (row == 0 || row == Rows - 1)
            {
                return PriceEconomy;
            }
            else if (row == 1 || row == Rows - 2)
            {
                return PriceStandard;
            }
            else
            {
                return PriceVip;
            }
        }

        private Color GetFreeColorForRow(int row)
        {
            if (row == 0 || row == Rows - 1)
            {
                return ColorFreeEconomy;
            }
            else if (row == 1 || row == Rows - 2)
            {
                return ColorFreeStandard;
            }
            else
            {
                return ColorFreeVip;
            }
        }

        private string GetZoneName(int row)
        {
            if (row == 0 || row == Rows - 1)
            {
                return "економ";
            }
            else if (row == 1 || row == Rows - 2)
            {
                return "стандарт";
            }
            else
            {
                return "VIP";
            }
        }

        /// <summary>
        /// Обробник кліку по місцю: перемикає стан вільно/заброньовано.
        /// </summary>
        private void SeatButton_Click(object sender, EventArgs e)
        {
            Button btnSeat = (Button)sender;
            SeatInfo seat = (SeatInfo)btnSeat.Tag;

            if (!seat.IsBooked)
            {
                seat.IsBooked = true;
                btnSeat.BackColor = ColorBooked;
            }
            else
            {
                seat.IsBooked = false;
                btnSeat.BackColor = seat.FreeColor;
            }

            UpdateTotals();
        }

        /// <summary>
        /// Перераховує кількість обраних місць та їхню сумарну вартість.
        /// </summary>
        private void UpdateTotals()
        {
            int selectedCount = 0;
            decimal totalPrice = 0m;

            foreach (Control control in pnlHall.Controls)
            {
                if (control is Button btnSeat && btnSeat.Tag is SeatInfo seat)
                {
                    if (seat.IsBooked)
                    {
                        selectedCount++;
                        totalPrice += seat.Price;
                    }
                }
            }

            lblSelectedCount.Text = $"Обрано місць: {selectedCount}";
            lblTotalPrice.Text = $"Сума: {totalPrice:N0} грн";
        }

        private void btnClearSelection_Click(object sender, EventArgs e)
        {
            foreach (Control control in pnlHall.Controls)
            {
                if (control is Button btnSeat && btnSeat.Tag is SeatInfo seat)
                {
                    seat.IsBooked = false;
                    btnSeat.BackColor = seat.FreeColor;
                }
            }

            UpdateTotals();
        }
    }
}
