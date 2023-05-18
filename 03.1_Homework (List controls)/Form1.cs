using Microsoft.VisualBasic.ApplicationServices;

namespace _03._1_Lesson__List_controls_
{
    public partial class Form1 : Form
    {
        List<Car> cars = null;
        public Form1()
        {
            InitializeComponent();
            cars = new List<Car>()
            {
                new Car("Opel Astra", "Black", 2014, "SD 48294",    "83JFB57RKE8F4HE2"),
                new Car("Reno Megan", "White", 2021, "DJ 34920",    "3458UF983FFH4UF4"),
                new Car("Reno Scenic", "Red", 2019, "EI 81638",     "2KF9K5GJ2394592F"),
                new Car("Suzuki Jimni", "Green", 2022, "EL 91058",  "28U48FN3UFMFI5FG"),
                new Car("VW Golf", "Blue", 2017, "UZ 69632",        "2I0DMBAKFG58944R"),
                new Car("Mercedese Vito", "Gray", 2009, "IN 90482", "20DKALKHNY583G4E"),
                new Car("Toyota Corrola", "Orange", 2016, "OJ 18403", "209FJI4982F45923D")
            };

            listBoxCars.DataSource = cars.ToList();
            comboBoxModelToFind.DataSource = cars.ToList();
            comboBoxModelToFind.DisplayMember = "ModelAndNumber";
        }
        private void UpdateCarsComboList()
        {
            listBoxCars.DataSource = null;
            listBoxCars.DataSource = cars.ToList();
        }
        private void UpdateCarsComboBox()
        {
            comboBoxModelToFind.DataSource = null;
            comboBoxModelToFind.DataSource = cars.ToList();
        }
        private void RemoveCarBtnClick(object sender, EventArgs e)
        {
            if (listBoxCars.SelectedIndex == -1)
            {
                MessageBox.Show("Please, select user to remove!"); return;
            }

            cars.RemoveAt(listBoxCars.SelectedIndex);

            UpdateCarsComboList();
            UpdateCarsComboBox();
        }

        private void ClearFields()
        {
            textBoxYear.Clear();
            textBoxNumber.Clear();
            textBoxVIN.Clear();
            comboBoxModel.ResetText();
            comboBoxColor.ResetText();
        }
        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            if (comboBoxModel.SelectedIndex != -1 &&
                comboBoxColor.SelectedIndex != -1 &&
                textBoxYear.Text != string.Empty &&
                textBoxNumber.Text != string.Empty &&
                textBoxVIN.Text != string.Empty)
            {
                cars.Add(new Car(comboBoxModel.Text, comboBoxColor.Text, int.Parse(textBoxYear.Text), textBoxNumber.Text, textBoxVIN.Text));
                UpdateCarsComboList();
                UpdateCarsComboBox();
                ClearFields();
                MessageBox.Show("Success!");
            }
            else
                MessageBox.Show("First, fill in all the details!");
        }

        private void buttonShowDetail_Click(object sender, EventArgs e)
        {
            MessageBox.Show(comboBoxModelToFind.SelectedItem.ToString());
        }
    }
    public class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public string ModelAndNumber { get => $"{Model} {Number}"; }
        public int Year { get; set; }
        public string Number { get; set; }
        public string VINCode { get; set; }
        public Car(string model, string color, int year, string number, string vinCode)
        {
            Model = model;
            Color = color;
            Year = year;
            Number = number;
            VINCode = vinCode;
        }
        public override string ToString()
        {
            return $"{Color} {Model} - {Year} " +
                $"Number: {Number}. VIN: {VINCode}.";
        }
    }
}