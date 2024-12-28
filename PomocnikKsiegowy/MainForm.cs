using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using ViesInfo;
using Padi.Vies;

namespace PomocnikKsiegowy
{
    /// <summary>
    /// Główna klasa formularza aplikacji Pomocnik Księgowy.
    /// Zarządza logiką interfejsu użytkownika oraz obsługuje różne funkcje, takie jak obliczenia paliwa, przeliczenia brutto-netto, generowanie grzbietów itp.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Zarządza obliczeniami związanymi z paliwem.
        /// </summary>
        private FuelManager fuelManager = new FuelManager();

        /// <summary>
        /// Obiekt przechowujący dane paliwa.
        /// </summary>
        private Fuel fuel;

        /// <summary>
        /// Klasa do obliczeń wartości połowicznych.
        /// </summary>
        private Half toHalf = new Half();

        /// <summary>
        /// Zarządza obliczeniami kalkulatora.
        /// </summary>
        private CalculatorManager calculatorManager = new CalculatorManager();

        /// <summary>
        /// Obiekt przechowujący dane kalkulatora.
        /// </summary>
        private Calculator calculator = new Calculator();

        /// <summary>
        /// Zarządza opisami operacji.
        /// </summary>
        private DescriptionManager descriptionManager = new DescriptionManager();

        /// <summary>
        /// Formularz zarządzania opisami.
        /// </summary>
        private DescriptionForm descriptionForm;

        /// <summary>
        /// Zarządza obliczeniami brutto i netto.
        /// </summary>
        private BruttoNetto bruttoNetto = new BruttoNetto();

        /// <summary>
        /// Klasa do zmiany tekstu na wielkie litery.
        /// </summary>
        private TextToUpper textToUpper = new TextToUpper();

        /// <summary>
        /// Zarządza operacjami na plikach PDF.
        /// </summary>
        private FileManager save = new FileManager();

        /// <summary>
        /// Lista obrazów używanych w zakładkach.
        /// </summary>
        private ImageList imageList;

        /// <summary>
        /// Lista grzbietów do wygenerowania.
        /// </summary>
        private List<Spine> Spines;

        /// <summary>
        /// Lista kontrolek grzbietów.
        /// </summary>
        private List<AddSpines> addedSpines = new List<AddSpines>();

        /// <summary>
        /// Zarządza podpowiedziami dla zakładek.
        /// </summary>
        private ToolTipsForTabs toolTipsForTabs = new ToolTipsForTabs();

        /// <summary>
        /// Tablica tekstów podpowiedzi dla zakładek.
        /// </summary>
        private string[] toolTipsTabs;

        /// <summary>
        /// Ścieżka folderu do zapisu plików Excel.
        /// </summary>
        private string excelFolderPath;

        /// <summary>
        /// Nazwa pliku Excel.
        /// </summary>
        private string fileName;

        /// <summary>
        /// Ścieżka do pliku Excel.
        /// </summary>
        private string excelFilePath;

        /// <summary>
        /// Inicjalizuje komponenty formularza i ustawia domyślne wartości.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            this.TopMost = true;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            SetIcons();

            toolStripStatusLabel.Text = "";

            // Ustawienia pól tylko do odczytu
            txtFuelResult.ReadOnly = true;
            txtFuel50Result.ReadOnly = true;
            txtBruttoCal.ReadOnly = true;
            txtNettoCal2.ReadOnly = true;
            txtToUpperResult.ReadOnly = true;
            txtFuelHalfNetto.ReadOnly = true;
            txtResultCurrency.ReadOnly = true;

            //VIES
            txtNameVies.ReadOnly = true;
            txtAdress.ReadOnly = true;
            lblIsActive.Visible = false;

            dtpExchangeRate.CustomFormat = "yyyy MM dd";

            // Ścieżki dla plików Excel
            excelFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Excel");

            fileName = $"PlikExcel_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";

            excelFilePath = Path.Combine(excelFolderPath, fileName);
        }

        /// <summary>
        /// Obsługuje kliknięcie przycisku obliczania paliwa.
        /// </summary>
        private void btnCalculateFuel(object sender, EventArgs e)
        {
            try
            {
                fuel = new Fuel();

                if(!double.TryParse(txtFuelVAT.Text, out double vat))
                {
                    MessageBox.Show("Podaj prawidłową wartość VAT!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                fuel.Vat = vat;

                if (!double.TryParse(txtFuelNetto.Text, out double netto))
                {
                    MessageBox.Show("Podaj prawidłową wartość Netto!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                fuel.Netto = netto;

                if (rb25.Checked)
                    fuel.Multiplier = 0.20;

                if (rb75.Checked)
                    fuel.Multiplier = 0.75;

                if (chbLeasing.Checked)
                    fuel.Leasing = true;

                txtFuelResult.Text = fuelManager.CalculateFuel(fuel);

                txtFuelHalfNetto.Text = (fuel.Netto / 2).ToString();

                AddToClipboard(txtFuelResult.Text, lblFuelResult.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Obsługuje kliknięcie przycisku do obliczania paliwa przy użyciu 50% wartości.
        /// Pobiera wartość netto i mnożnik, a następnie oblicza wynik.
        /// </summary>
        private void btnCalculateFuel50_Click(object sender, EventArgs e)
        {
            double multiplier = 0;

            if (rb020.Checked)
                multiplier = 0.20;

            if (rb075.Checked)
                multiplier = 0.75;

            if (rb50.Checked)
                multiplier = 0.50;

            if (!double.TryParse(txtFuel50Value.Text, out double value))
            {
                MessageBox.Show("Podaj prawidłową wartość!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtFuel50Result.Text = toHalf.ToHalf(value, multiplier).ToString();  

            AddToClipboard(txtFuel50Result.Text, lblFuel50Result.Text);
        }

        /// <summary>
        /// Obsługuje kliknięcie cyfry na klawiaturze kalkulatora.
        /// Dodaje wartość cyfry do aktualnego pola tekstowego kalkulatora.
        /// </summary>
        private void btnNumber(object sender, EventArgs e)
        {
            txtResultCalculator.Text += (sender as Button).Text;

            txtResultCalculator.Focus();
        }

        /// <summary>
        /// Obsługuje kliknięcie operatora (np. +, -, *, /) na klawiaturze kalkulatora.
        /// Ustawia wybrany operator w kalkulatorze.
        /// </summary>
        private void btnOperator_Click(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;

            calculator.Operators = Convert.ToChar(clicked.Text);

            if (!double.TryParse(txtResultCalculator.Text, out double resuktCalculator))
            {
                MessageBox.Show("Podaj prawidłową wartość!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            calculator.StorageNumber = resuktCalculator;

            txtResultCalculator.Text = "";

            txtResultCalculator.Focus();
        }

        /// <summary>
        /// Oblicza wynik na podstawie wprowadzonych liczb i wybranego operatora.
        /// Wynik jest wyświetlany w polu kalkulatora.
        /// </summary>
        private void btnResultCalculator_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtResultCalculator.Text, out double wynikKalkulator))
            {
                MessageBox.Show("Podaj prawidłową wartość!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            calculator.SecondNumber = wynikKalkulator;

            txtResultCalculator.Text =  calculatorManager.Oblicz(calculator).ToString();

            txtResultCalculator.Focus();

            AddToClipboard(txtResultCalculator.Text, "Wynik");
        }

        /// <summary>
        /// Czyści aktualne wartości w kalkulatorze i resetuje stan.
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            calculator.Operators = null;

            calculator.StorageNumber = 0.0;

            calculator.StorageNumber = 0.0;

            txtResultCalculator.Text = "";

            txtResultCalculator.Focus();
        }

        /// <summary>
        /// Obsługuje zmianę zakładki w kontrolce TabControl.
        /// Ustawia fokus na odpowiednie pole w zależności od wybranej zakładki.
        /// </summary>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                switch (tabControl1.SelectedIndex)
                {
                    case 0: 
                        txtFuelVAT.Focus();
                        break;
                    case 1: 
                        txtFuel50Value.Focus();
                        break;
                    case 2: 
                        txtResultCalculator.Focus();
                        break;
                    case 3: 
                        txtClipboard.Focus();
                        break;
                    case 5: 
                        txtNettoCal.Focus();
                        break;
                    case 6: 
                        txtToUpperLetters.Focus();
                        break;
                    case 7:
                        txtnumberOfSpines.Focus();
                        break;
                    case 9:
                        txtNIP.Focus();
                        break;
                }
            }
        }

        /// <summary>
        /// Wczytuje opisy z pliku wskazanego w <see cref="descriptionManager"/>.
        /// Wypełnia kontrolkę <see cref="lbDescriptions"/> załadowanymi danymi.
        /// </summary>
        /// <param name="sender">Obiekt wywołujący zdarzenie.</param>
        /// <param name="e">Argumenty zdarzenia.</param>
        public void btnLoadDescriptions_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(descriptionManager.descritpionPath))
            {
                MessageBox.Show("Brak ścieżki! Ustaw ścieżkę przed wczytaniem opisów.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                List<string> data = descriptionManager.LoadDescriptons();

                lbDescriptions.Items.Clear();
                foreach (var item in data)
                {
                    lbDescriptions.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Obsługuje zdarzenie naciśnięcia klawisza na kontrolce <see cref="lbDescriptions"/>.
        /// Kopiuje zaznaczoną wartość do schowka, jeśli wciśnięto Ctrl+C.
        /// </summary>
        private void lbDescriptions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.C)
            {
                string s = lbDescriptions.SelectedItem.ToString();

                AddToClipboard(s);             
            }
        }

        /// <summary>
        /// Obsługuje kliknięcie przycisku dodania ścieżki pliku opisów.
        /// Otwiera okno dialogowe pozwalające na wybranie pliku opisów.
        /// </summary>
        private void btnAddPath_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(descriptionManager.descritpionPath))
            {
                MessageBox.Show("Brak ścieżki! Ustaw ścieżkę przed wczytaniem opisów.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                descriptionForm = new DescriptionForm(this, descriptionManager);

                descriptionForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        /// <summary>
        /// Obsługuje kliknięcie przycisku konwersji brutto na netto.
        /// Oblicza wartość netto na podstawie podanej wartości brutto i wybranej stawki VAT.
        /// </summary>
        private void btnBruttoToNetto_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtBruttoCal2.Text, out double brutto))
            {
                MessageBox.Show("Proszę wprowadzić poprawną liczbę Brutto.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SetMulti();

            txtNettoCal2.Text = bruttoNetto.BruttoNaNetto(brutto, SetMulti()).ToString();

            double netto = double.Parse(txtNettoCal2.Text); 
            txtVetCal2.Text = bruttoNetto.ustalVat(brutto, netto).ToString();

            AddToClipboard(txtNettoCal2.Text, lblNettoCal2.Text);
        }

        /// <summary>
        /// Obsługuje kliknięcie przycisku konwersji netto na brutto.
        /// Oblicza wartość brutto na podstawie podanej wartości netto i wybranej stawki VAT.
        /// </summary>
        private void btnNettoToBrutto_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNettoCal.Text, out double netto))
            {
                MessageBox.Show("Proszę wprowadzić poprawną liczbę w polu Netto.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SetMulti();

            txtBruttoCal.Text = bruttoNetto.NettoNaBrutto(netto, SetMulti()).ToString();

            double brutto = double.Parse(txtBruttoCal.Text); // Wartość wyliczona powinna być poprawna
            txtVatKal.Text = bruttoNetto.ustalVat(brutto, netto).ToString();

            AddToClipboard(txtBruttoCal.Text, lblBruttoCal.Text);
        }

        /// <summary>
        /// Ustawia mnożnik VAT na podstawie wybranego radiobuttona.
        /// </summary>
        /// <returns>Wybrana wartość mnożnika VAT.</returns>
        private double SetMulti()
        {
            double multiplier = 0;

            if (rate23.Checked)
                multiplier = 0.23;
            if (rate8.Checked)
                multiplier = 0.08;
            if (rate5.Checked)
                multiplier = 0.05;

            return multiplier;
        }

        /// <summary>
        /// Obsługuje kliknięcie przycisku zmiany tekstu na wielkie litery.
        /// Wynik jest wyświetlany w odpowiednim polu tekstowym.
        /// </summary>
        private void btnChangeToUpper_Click(object sender, EventArgs e)
        {
            txtToUpperResult.Text = textToUpper.ChangeToUpper(txtToUpperLetters.Text);

            AddToClipboard(txtToUpperResult.Text);
        }

        /// <summary>
        /// Obsługuje kliknięcie przycisku wczytania pliku PDF.
        /// Otwiera okno dialogowe do wyboru pliku PDF.
        /// </summary>
        private void btnLoadPDF_Click(object sender, EventArgs e)
        {
            save.Open();

            toolStripStatusLabel.Text = "Plik został wczytany.";
        }

        /// <summary>
        /// Obsługuje kliknięcie przycisku zapisu pliku PDF.
        /// Zapisuje zmodyfikowany plik PDF w wybranej lokalizacji.
        /// </summary>
        private void btnSavePDF_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(save.PdfFilePath))
            {
                MessageBox.Show("Plik PDF nie został wczytany.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                save.Save();

                toolStripStatusLabel.Text = "Plik został zapisany.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Ustawia ikony na pasku tabControl.
        /// </summary>
        private void SetIcons()
        {
            imageList = new ImageList();

            imageList.Images.Add("paliwo", Properties.Resources.gas_pump_alt);
            imageList.Images.Add("paliwo_alt", Properties.Resources.gas_pump_alt__1_);
            imageList.Images.Add("kalkulator", Properties.Resources.calculator);
            imageList.Images.Add("kopiowanie", Properties.Resources.duplicate);
            imageList.Images.Add("pdf", Properties.Resources.file_pdf);
            imageList.Images.Add("brutto_netto", Properties.Resources.calculator_money);
            imageList.Images.Add("skrocona", Properties.Resources.id_badge);
            imageList.Images.Add("excel", Properties.Resources.file_excel);
            imageList.Images.Add("euro", Properties.Resources.euro);
            imageList.Images.Add("eu", Properties.Resources.european_union);

            tabControl1.ImageList = imageList;

            for (int i = 0; i < imageList.Images.Count; i++)
            {
                tabControl1.TabPages[i].ImageIndex = i;
            }
        }

        /// <summary>
        /// Rysuje zakładki w <see cref="TabControl"/>, dostosowując ich wygląd do aktualnie aktywnej zakładki.
        /// </summary>
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tabControl = sender as TabControl;

            bool isActiveTab = e.Index == tabControl.SelectedIndex;

            Color backgroundColor = isActiveTab ? Color.LightBlue : Color.White;

            Color textColor = isActiveTab ? Color.Black : Color.Gray;

            using (SolidBrush backgroundBrush = new SolidBrush(backgroundColor))
            {
                e.Graphics.FillRectangle(backgroundBrush, e.Bounds);
            }

            if (tabControl.ImageList != null && e.Index < tabControl.ImageList.Images.Count)
            {
                Image image = tabControl.ImageList.Images[e.Index];

                int padding = 5;

                int x = e.Bounds.Left + (e.Bounds.Width - image.Width) / 2;

                int y = e.Bounds.Top + padding + (e.Bounds.Height - image.Height - 2 * padding) / 2;

                e.Graphics.DrawImage(image, x, y);
            }

            string tabText = tabControl.TabPages[e.Index].Text;

            using (SolidBrush textBrush = new SolidBrush(textColor))
            {
                StringFormat stringFormat = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Far
                };

                Rectangle textBounds = new Rectangle(e.Bounds.Left, e.Bounds.Top + e.Bounds.Height / 2, e.Bounds.Width, e.Bounds.Height / 2);
                
                e.Graphics.DrawString(tabText, tabControl.Font, textBrush, textBounds, stringFormat);
            }

            e.DrawFocusRectangle();
        }

        /// <summary>
        /// Kopiuje podany tekst do schowka i wyświetla komunikat w pasku stanu.
        /// </summary>
        /// <param name="toCopy">Tekst do skopiowania.</param>
        /// <param name="nazwa">Nazwa elementu, którego dotyczy skopiowany tekst.</param>
        private void AddToClipboard(string toCopy, string nazwa)
        {
            toolStripStatusLabel.Text = $"{nazwa} ({toCopy}) - dodano do schowka";

            Clipboard.SetData(DataFormats.StringFormat, toCopy);
        }

        /// <summary>
        /// Kopiuje podany tekst do schowka i wyświetla komunikat w pasku stanu.
        /// </summary>
        /// <param name="toCopy">Tekst do skopiowania.</param>
        private void AddToClipboard(string toCopy)
        {
            toolStripStatusLabel.Text = "Skopiowano.";  

            Clipboard.SetData(DataFormats.StringFormat, toCopy);
        }

        /// <summary>
        /// Obsługuje zdarzenie naciśnięcia klawisza na kontrolce <see cref="txtClipboard"/>.
        /// Kopiuje zawartość pola tekstowego do schowka po wciśnięciu Ctrl+C.
        /// </summary>
        private void txtClipboard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.C)
            {
                AddToClipboard(txtClipboard.Text, lblClipboard.Text);
            }
        }

        private void txtClipboard2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.C)
            {
                AddToClipboard(txtClipboard2.Text, lblClipboard.Text);
            }
        }

        /// <summary>
        /// Obsługuje kliknięcie przycisku generowania grzbietów.
        /// Tworzy nowy formularz, w którym można dodać szczegóły grzbietów.
        /// </summary>
        private void btnGenerateSpine_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtnumberOfSpines.Text, out int numberOfSpines))
            {
                MessageBox.Show("Podaj prawidłową wartość!", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CreateSpineForm(numberOfSpines);
        }

        /// <summary>
        /// Tworzy formularz umożliwiający dodanie szczegółów grzbietów.
        /// </summary>
        /// <param name="controlsCount">Liczba grzbietów do wygenerowania.</param>
        private void CreateSpineForm(int controlsCount)
        {
            Form spineForm = new Form
            {
                Name = "DodajGrzbietyForm",
                Text = "Dodaj Grzbiety",
                Width = 350,
                Height = 400,
                Icon = Properties.Resources.logo
        };

            Panel scrollablePanel = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true 
            };

            spineForm.Controls.Add(scrollablePanel);

            int controlWidth = 280;

            int controlHeight = 195;

            int offset = 10;

            Spines = new List<Spine>();

            for (int i = 0; i < controlsCount; i++)
            {
                AddSpines addSpines = new AddSpines
                {
                    Size = new Size(controlWidth, controlHeight),
                    Location = new Point(10, i * (controlHeight + offset)),
                    
                };

                addSpines.SetGroupBoxName($"Grzbiet {i + 1}");

                addedSpines.Add(addSpines);

                scrollablePanel.Controls.Add(addSpines);   

                if (i == controlsCount - 1)
                {
                    int endButtonY = addSpines.Bottom + offset;

                    Button endButton = new Button
                    {
                        Text = "Zatwierdź",
                        Size = new Size(150, 40)
                    };

                    endButton.Location = new Point((spineForm.Width - endButton.Width - 20) / 2, endButtonY);

                    endButton.Click += (sender, e) =>
                    {
                        Spines = addSpines.CreateSpines(addedSpines);

                        addSpines.CreateExcelFile(excelFolderPath, excelFilePath, Spines, toolStripStatusLabel);

                    };

                    scrollablePanel.Controls.Add(endButton);
                }
            }

            spineForm.Show();
        }

        /// <summary>
        /// Aktualizuje podpowiedź dla aktywnej zakładki w kontrolce TabControl.
        /// </summary>
        private void UpdateToolTip()
        {
            int selectedIndex = tabControl1.SelectedIndex;

            toolTipsTabs = toolTipsForTabs.GetToolTips();

            string toolTipText = (selectedIndex >= 0 && selectedIndex < toolTipsTabs.Length)
                ? toolTipsTabs[selectedIndex]
                : "Domyślna podpowiedź";

            Point toolTipLocation = infoIcon.Location;

            toolTip1.Show(toolTipText, this, toolTipLocation.X, toolTipLocation.Y, 3000); 
        }

        /// <summary>
        /// Wyświetla podpowiedź, gdy mysz znajduje się nad ikoną informacyjną.
        /// </summary>
        private void infoIcon_MouseHover(object sender, EventArgs e)
        {
            UpdateToolTip();
        }

        private void infoIcon_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(this);
        }

        /// <summary>
        /// Otwiera okno dialogowe umożliwiające wybór pliku opisów.
        /// </summary>
        private void AddPath_Click(object sender, EventArgs e)
        {
            descriptionManager.OpenFile();

            toolStripStatusLabel.Text = "Plik został wczytany.";
        }

        /// <summary>
        /// Obsługuje kliknięcie przycisku sprawdzania kursu waluty.
        /// Pobiera kurs wybranej waluty z API NBP dla określonej daty.
        /// </summary>
        private async void btnFindRate_Click(object sender, EventArgs e)
        {
            string currencyCode = cbCurrancy.SelectedItem.ToString();

            DateTime selectedDate = dtpExchangeRate.Value;

            string formattedDate = selectedDate.ToString("yyyy-MM-dd");

            GetCurrency currency = new GetCurrency();
  
            try
            {
                string rate = await currency.GetCurrencyRate(currencyCode, formattedDate);

                txtResultCurrency.Text = rate;

                AddToClipboard(rate);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Obsługuje kliknięcie przycisku weryfikacji NIP w systemie VIES.
        /// Pobiera informacje o firmie i status aktywności NIP.
        /// Wyjątkowo nie posiada oddzielnej metody, bo jest na tyle mały i połączony z UI, że przenoszenie kodu nie ma dla mnie sensu.
        /// </summary>
        private void btnFindVIES_Click(object sender, EventArgs e)
        {
            string vatNumber = cbCountryCode.SelectedItem?.ToString()?.Trim() + txtNIP.Text?.Trim();

            var info = new ViesClient().GetCompany(vatNumber);

            var result = ViesManager.IsValid(vatNumber);

            txtNameVies.Text = info.Name;

            txtAdress.Text = info.Address;

            if (result.IsValid)
            {
                lblIsActive.Visible = true;

                lblIsActive.Text = "Kontrahent jest aktywny";
            }
            else
            {
                lblIsActive.Visible = true;

                lblIsActive.ForeColor = Color.Red;

                lblIsActive.Text = "Kontrahent nie jest aktywny";
            }
        }
    }
}

