namespace KFC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Menu m = new Menu();
        Form2 form=new Form2();

        private void button1_Click(object sender, EventArgs e)
        {
            decimal total = 0;

            string[] name = { "Duet Kombo", "Basket", "Hot-Dog", "Kombo menu", "Fresher menu", "Sanders", "Longer", "Longer Menu" };
            decimal[] price = { 13.9m, 7.90m, 2.70m, 5.50m, 4.50m, 2.80m, 1.00m, 2.20m };
            if (numericUpDown1.Value > 0)
            {
                m.Name = name[0];
                m.Price = price[0];
                total = total + m.Price * numericUpDown1.Value;
                form.label38.Text = name[0];
                form.label7.Text = price[0].ToString()+" "+"azn";
                form.label6.Text=numericUpDown1.Value.ToString() + " " + "ədəd";
                form.label8.Text=  total.ToString() + " " + "azn";


            }
            if (numericUpDown2.Value > 0)
            {
                m.Name = name[1];
                m.Price = price[1];
                total = total + m.Price * numericUpDown2.Value;
                form.label37.Text = name[1];
                form.label10.Text = price[1].ToString() + " " + "azn";
                form.label9.Text = numericUpDown2.Value.ToString() + " " + "ədəd";
                form.label11.Text =  total.ToString() + " " + "azn";

            }
            if (numericUpDown3.Value > 0)
            {
                m.Name = name[2];
                m.Price = price[2];
                total = total + m.Price * numericUpDown3.Value;
                form.label36.Text = name[2];
                form.label16.Text = price[2].ToString() + " " + "azn";
                form.label17.Text = numericUpDown3.Value.ToString() + " " + "ədəd";
                form.label15.Text =  total.ToString() + " " + "azn";
            }
            if (numericUpDown4.Value > 0)
            {
                m.Name = name[3];
                m.Price = price[3];
                total = total + m.Price * numericUpDown4.Value;
                form.label35.Text= name[3];
                form.label13.Text = price[3].ToString() + " " + "azn";
                form.label14.Text = numericUpDown4.Value.ToString() + " " + "ədəd";
                form.label12.Text =  total.ToString() + " " + "azn";
            }
            if (numericUpDown5.Value > 0)
            {
                m.Name = name[4];
                m.Price = price[4];
                total = total + m.Price * numericUpDown5.Value;
                form.label34.Text = name[4];
                form.label22.Text = price[4].ToString() + " " + "azn";
                form.label23.Text = numericUpDown5.Value.ToString() + " " + "ədəd";
                form.label21.Text =  total.ToString() + " " + "azn";
            }
            if (numericUpDown6.Value > 0)
            {
                m.Name = name[5];
                m.Price = price[5];
                total = total + m.Price * numericUpDown6.Value;
                form.label33.Text = name[5];
                form.label19.Text = price[5].ToString() + " " + "azn";
                form.label20.Text = numericUpDown6.Value.ToString() + " " + "ədəd";
                form.label18.Text =  total.ToString() + " " + "azn";
            }
            if (numericUpDown7.Value > 0)
            {
                m.Name = name[6];
                m.Price = price[6];
                total = total + m.Price * numericUpDown7.Value;
                form.label32.Text = name[6];
                form.label28.Text = price[6].ToString() + " " + "azn";
                form.label29.Text = numericUpDown7.Value.ToString() + " " + "ədəd";
                form.label27.Text =  total.ToString() + " " + "azn";
            }
            if (numericUpDown8.Value > 0)
            {
                m.Name = name[7];
                m.Price = price[7];
                total = total + m.Price * numericUpDown8.Value;
                form.label31.Text = name[7];
                form.label25.Text = price[7].ToString() + " " + "azn";
                form.label26.Text = numericUpDown8.Value.ToString() + " " + "ədəd";
                form.label24.Text = total.ToString() + " " + "azn";
            }
            if (numericUpDown1.Value > 0 || numericUpDown2.Value > 0
               || numericUpDown3.Value > 0 || numericUpDown4.Value > 0
               || numericUpDown5.Value > 0 || numericUpDown6.Value > 0
               || numericUpDown7.Value > 0 || numericUpDown8.Value > 0) 

            {
                form.Show();
            }
            if (numericUpDown1.Value == 0 && numericUpDown2.Value == 0 
                && numericUpDown3.Value == 0 && numericUpDown4.Value == 0
                && numericUpDown5.Value == 0 && numericUpDown6.Value == 0 
                && numericUpDown7.Value == 0 && numericUpDown8.Value == 0)

            {
                MessageBox.Show("Zehmet olmasa menu secimi edin");
            }
            form.label30.Text = $"Ümumi: {total.ToString()} AZN";

        }
    }
}