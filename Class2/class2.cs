namespace Class2
{
    public partial class class2 : Form
    {
        public class2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Car car1 = new Car("01-12-XA", "BMW", "Benz", "BMW", 12, "AXSW2");
            Car car2 = new Car();
            car2.plate = "01-12-XA";
            car2.manufactor = "BMW";
            car2.model = "Benz";
            car2.brand = "BMW";
            car2.price = 12;
            car2.chipset = "AXSW2";
            Car car3 = new Car
            {
                plate = "HE-00-LP",
                manufactor = "Toyota",
                model = "Corrola",
                brand = "Toyota",
                price = 25000,
                chipset = "AXSW3"
            };
            var carlist = new List<Car>();
            carlist.Add(car1);
            carlist.Add(car2);
            carlist.Add(car3);

            var carlistbmw = new List<Car> {car1,car2};

            foreach (var c in carlist)
            {
                Console.WriteLine(c.ToString);
                string textin = c.brand + "-" + c.model;
                listBox1.Items.Add(textin);
            }
        }
        

    }
}
