using System;
using System.Drawing;
using System.Windows.Forms;

namespace EcoFootprintCalculator
{
    /// <summary>
    /// Форма-калькулятор, що приблизно оцінює вуглецевий слід (CO2) людини
    /// на основі кількості поїздок на автомобілі та використання побутових
    /// електроприладів. Розрахунок виконано за простими коефіцієнтами і
    /// має ознайомчий, а не науково точний характер.
    /// </summary>
    public partial class MainForm : Form
    {
        // Коефіцієнти викидів CO2 на 1 км пробігу залежно від типу палива (кг CO2/км).
        // Значення орієнтовні та взяті з типових публічних калькуляторів вуглецевого сліду.
        private const double CO2_PER_KM_PETROL = 0.192;   // бензин
        private const double CO2_PER_KM_DIESEL = 0.171;   // дизель
        private const double CO2_PER_KM_LPG = 0.145;      // газ (LPG)
        private const double CO2_PER_KM_ELECTRIC = 0.053; // електромобіль (з урахуванням виробництва електроенергії)

        // Середній коефіцієнт викидів CO2 на 1 кВт*год електроенергії (кг CO2/кВт*год) — орієнтовне значення.
        private const double CO2_PER_KWH = 0.40;

        // Середня кількість тижнів у місяці та днів у місяці для перерахунку.
        private const double WEEKS_PER_MONTH = 4.345;
        private const double DAYS_PER_MONTH = 30.0;

        // Порогові значення для оцінки річного сліду (лише авто + електроприлади), у тоннах CO2.
        private const double THRESHOLD_LOW = 1.5;
        private const double THRESHOLD_MEDIUM = 3.5;

        public MainForm()
        {
            InitializeComponent();
            cmbFuelType.SelectedIndex = 0;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // --- Дані про автомобіль ---
            double tripsPerWeek = (double)nudTripsPerWeek.Value;
            double distancePerTrip = (double)nudDistance.Value;
            double fuelCoefficient = GetFuelCoefficient(cmbFuelType.SelectedItem?.ToString());

            double weeklyDistance = tripsPerWeek * distancePerTrip;
            double carCO2Month = weeklyDistance * fuelCoefficient * WEEKS_PER_MONTH;

            // --- Дані про побутові прилади ---
            double applianceHoursPerDay = (double)nudApplianceHours.Value;
            double appliancePowerKw = (double)nudAppliancePower.Value;

            double dailyKwh = applianceHoursPerDay * appliancePowerKw;
            double applianceCO2Month = dailyKwh * CO2_PER_KWH * DAYS_PER_MONTH;

            // --- Підсумки ---
            double totalCO2Month = carCO2Month + applianceCO2Month;
            double totalCO2Year = totalCO2Month * 12.0;
            double totalCO2YearTons = totalCO2Year / 1000.0;

            lblCarResult.Text = $"Викиди від авто: {carCO2Month:N1} кг CO2/міс.";
            lblApplianceResult.Text = $"Викиди від приладів: {applianceCO2Month:N1} кг CO2/міс.";
            lblTotalMonth.Text = $"Разом за місяць: {totalCO2Month:N1} кг CO2";
            lblTotalYear.Text = $"Разом за рік: {totalCO2YearTons:N2} т CO2";

            ShowAssessment(totalCO2YearTons);
        }

        /// <summary>
        /// Повертає коефіцієнт викидів CO2 на кілометр для обраного типу палива.
        /// </summary>
        private double GetFuelCoefficient(string fuelType)
        {
            if (fuelType == "Бензин")
            {
                return CO2_PER_KM_PETROL;
            }
            else if (fuelType == "Дизель")
            {
                return CO2_PER_KM_DIESEL;
            }
            else if (fuelType == "Газ (LPG)")
            {
                return CO2_PER_KM_LPG;
            }
            else if (fuelType == "Електромобіль")
            {
                return CO2_PER_KM_ELECTRIC;
            }
            else
            {
                return CO2_PER_KM_PETROL;
            }
        }

        /// <summary>
        /// Виводить текстову та кольорову оцінку річного екосліду за простими пороговими значеннями.
        /// </summary>
        private void ShowAssessment(double totalCO2YearTons)
        {
            if (totalCO2YearTons < THRESHOLD_LOW)
            {
                pnlIndicator.BackColor = Color.MediumSeaGreen;
                lblAssessment.ForeColor = Color.DarkGreen;
                lblAssessment.Text = "Низький екослід. Чудовий результат — так тримати!";
            }
            else if (totalCO2YearTons < THRESHOLD_MEDIUM)
            {
                pnlIndicator.BackColor = Color.Goldenrod;
                lblAssessment.ForeColor = Color.DarkOrange;
                lblAssessment.Text = "Середній екослід. Спробуйте частіше користуватись\nгромадським транспортом та економити електроенергію.";
            }
            else
            {
                pnlIndicator.BackColor = Color.IndianRed;
                lblAssessment.ForeColor = Color.DarkRed;
                lblAssessment.Text = "Високий екослід. Варто переглянути звички споживання\nпалива та електроенергії.";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            nudTripsPerWeek.Value = 0;
            nudDistance.Value = 0;
            cmbFuelType.SelectedIndex = 0;
            nudApplianceHours.Value = 0;
            nudAppliancePower.Value = 0;

            lblCarResult.Text = "Викиди від авто: — кг CO2/міс.";
            lblApplianceResult.Text = "Викиди від приладів: — кг CO2/міс.";
            lblTotalMonth.Text = "Разом за місяць: — кг CO2";
            lblTotalYear.Text = "Разом за рік: — т CO2";
            lblAssessment.Text = "Заповніть дані та натисніть \"Розрахувати\".";
            lblAssessment.ForeColor = SystemColors.ControlText;
            pnlIndicator.BackColor = Color.Gainsboro;
        }
    }
}

