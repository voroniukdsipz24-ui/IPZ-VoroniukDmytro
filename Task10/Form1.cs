using System;
using System.Windows.Forms;

namespace MobileTariffSelector
{
    /// <summary>
    /// Проста модель тарифного плану.
    /// </summary>
    public class Tariff
    {
        public string Name { get; }
        public decimal PricePerMonth { get; }
        public int InternetGb { get; }         // ігнорується, якщо UnlimitedInternet == true
        public bool UnlimitedInternet { get; }
        public int MinutesToOtherOperators { get; }
        public int Sms { get; }

        public Tariff(string name, decimal pricePerMonth, int internetGb, bool unlimitedInternet,
                       int minutesToOtherOperators, int sms)
        {
            Name = name;
            PricePerMonth = pricePerMonth;
            InternetGb = internetGb;
            UnlimitedInternet = unlimitedInternet;
            MinutesToOtherOperators = minutesToOtherOperators;
            Sms = sms;
        }

        public string InternetLabel => UnlimitedInternet ? "Безліміт" : $"{InternetGb} ГБ";
    }

    /// <summary>
    /// Форма підбору тарифу мобільного зв'язку. Тарифи нижче — спрощені й
    /// орієнтовні, побудовані на основі загальнодоступної інформації про
    /// лінійку "Все разом" Київстар станом на середину 2026 року.
    /// Реальні умови варто перевіряти на офіційному сайті kyivstar.ua,
    /// оскільки вони можуть змінюватись.
    /// </summary>
    public partial class MainForm : Form
    {
        // Тарифи відсортовані за зростанням ціни — це важливо для логіки підбору.
        private readonly Tariff[] tariffs = new Tariff[]
        {
            new Tariff("Все разом Комфорт",          220m, 10, false, 100,  50),
            new Tariff("Все разом Активний",         300m, 20, false, 1200, 100),
            new Tariff("Все разом Крутий",           450m, 0,  true,  600,  200),
            new Tariff("Все разом Топовий Контракт", 750m, 0,  true,  1500, 1500),
        };

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnFindTariff_Click(object sender, EventArgs e)
        {
            decimal neededGb = nudInternet.Value;
            decimal neededMinutes = nudMinutes.Value;
            decimal neededSms = nudSms.Value;

            Tariff recommended = ChooseTariff(neededGb, neededMinutes, neededSms);

            FillTariffTable(neededGb, neededMinutes, neededSms, recommended);
            ShowRecommendation(recommended, neededGb, neededMinutes, neededSms);
        }

        /// <summary>
        /// Підбирає найвигідніший (найдешевший з достатніх) тариф за простими правилами if/else.
        /// Якщо жоден тариф повністю не покриває потреби користувача, пропонується
        /// найповніший (найдорожчий) тариф як найближчий варіант.
        /// </summary>
        private Tariff ChooseTariff(decimal gb, decimal minutes, decimal sms)
        {
            if (gb <= tariffs[0].InternetGb && minutes <= tariffs[0].MinutesToOtherOperators && sms <= tariffs[0].Sms)
            {
                return tariffs[0]; // Все разом Комфорт
            }
            else if (gb <= tariffs[1].InternetGb && minutes <= tariffs[1].MinutesToOtherOperators && sms <= tariffs[1].Sms)
            {
                return tariffs[1]; // Все разом Активний
            }
            else if (minutes <= tariffs[2].MinutesToOtherOperators && sms <= tariffs[2].Sms)
            {
                // Починаючи з цього тарифу інтернет безлімітний, тому його не перевіряємо.
                return tariffs[2]; // Все разом Крутий
            }
            else
            {
                // Найповніший тариф пропонується завжди, навіть якщо потреби (наприклад, SMS)
                // перевищують і його пакет — у такому разі знадобляться додаткові пакети.
                return tariffs[3]; // Все разом Топовий Контракт
            }
        }

        /// <summary>
        /// Перевіряє, чи покриває конкретний тариф задані потреби користувача.
        /// </summary>
        private bool IsSuitable(Tariff t, decimal gb, decimal minutes, decimal sms)
        {
            bool internetOk;
            if (t.UnlimitedInternet)
            {
                internetOk = true;
            }
            else if (t.InternetGb >= gb)
            {
                internetOk = true;
            }
            else
            {
                internetOk = false;
            }

            bool minutesOk = t.MinutesToOtherOperators >= minutes;
            bool smsOk = t.Sms >= sms;

            if (internetOk && minutesOk && smsOk)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void FillTariffTable(decimal gb, decimal minutes, decimal sms, Tariff recommended)
        {
            lvTariffs.Items.Clear();

            foreach (Tariff t in tariffs)
            {
                bool suitable = IsSuitable(t, gb, minutes, sms);

                var item = new ListViewItem(t.Name);
                item.SubItems.Add(t.PricePerMonth.ToString("N0") + " грн");
                item.SubItems.Add(t.InternetLabel);
                item.SubItems.Add(t.MinutesToOtherOperators.ToString());
                item.SubItems.Add(t.Sms.ToString());
                item.SubItems.Add(suitable ? "✓ так" : "✗ ні");

                if (t == recommended)
                {
                    item.Font = new System.Drawing.Font(lvTariffs.Font, System.Drawing.FontStyle.Bold);
                    item.BackColor = System.Drawing.Color.Honeydew;
                }

                lvTariffs.Items.Add(item);
            }
        }

        private void ShowRecommendation(Tariff recommended, decimal gb, decimal minutes, decimal sms)
        {
            bool fullyCovers = IsSuitable(recommended, gb, minutes, sms);

            if (fullyCovers)
            {
                lblRecommendation.Text =
                    $"Рекомендований тариф: \"{recommended.Name}\" за {recommended.PricePerMonth:N0} грн/міс. " +
                    "Він повністю покриває заявлені потреби.";
                lblRecommendation.ForeColor = System.Drawing.Color.DarkGreen;
            }
            else
            {
                lblRecommendation.Text =
                    $"Найближчий варіант: \"{recommended.Name}\" за {recommended.PricePerMonth:N0} грн/міс. " +
                    "Втім, ваші потреби перевищують навіть цей пакет — можуть знадобитися додаткові послуги.";
                lblRecommendation.ForeColor = System.Drawing.Color.DarkOrange;
            }
        }
    }
}
