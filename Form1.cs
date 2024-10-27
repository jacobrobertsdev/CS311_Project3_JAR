namespace CS311_Project3_JAR
{
    public partial class Form1 : Form
    {

        // Store all options and prices in a Dictionary
        private Dictionary<string, double> options = new Dictionary<string, double>
        {
            {"Small", 2.00},
            {"Medium", 5.00},
            {"Large", 10.00},
            {"X-Large", 15.00},
            {"Ginormous", 20.00},
            {"Pepperoni", 2.00},
            {"Sausage", 2.00},
            {"Canadian Bacon", 2.00},
            {"Spicy Italian Sausage", 2.00}
        };

        public Form1()
        {
            InitializeComponent();
        }

        // Calculate button calls Summarize() on Click event
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Summarize();
        }

        // Summaraize calculates subtotal, tax, total and displays the order summary
        private void Summarize()
        {

            // Order Summary
            // Store currently selected size from ComboBox
            String size = cboSize.GetItemText(cboSize.SelectedItem);

            // Store currently selected Crust option from radio button group
            String crust = grpCrust.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;

            // Create a collection of the checkboxes that are currently selected
            IEnumerable<CheckBox> toppings = this.Controls.OfType<CheckBox>().Where(cb => cb.Checked);

            // Output string for the Order Summary textbox
            String summaryOutput = $"You ordered a {size} pizza with {crust} crust and the following toppings:" + Environment.NewLine;

            // Loop over the collection of checkboxes appending the text values to the output string
            foreach(CheckBox topping in toppings)
            {
                summaryOutput += $"-{topping.Text}" + Environment.NewLine;
            }

            // Set the text of the order summary textbox to the output string
            txtBoxSummary.Text = summaryOutput;


            // Order Total Logic
            // Initialize variables
            double subTotal = 0, tax, total;

            // Loop over toppings collection looking up associated price in dictionary. Add each to subTotal
            foreach (CheckBox topping in toppings)
            {
                if(options.TryGetValue(topping.Text, out double toppingPrice))
                {
                    subTotal += toppingPrice;
                }
            }

            // Lookup selected size in dictionary, adding associated price to subTotal
            if(options.TryGetValue(size, out double sizePrice)){
                subTotal += sizePrice;
            }

            // Tax calculation
            tax = subTotal * 0.06;

            // Order total calculation
            total = subTotal + tax;

            // Update textboxes to display final totals (currency format)
            txtBoxSubTotal.Text = subTotal.ToString("C");
            txtBoxTax.Text = tax.ToString("C");
            txtBoxTotal.Text = total.ToString("C");
        }
    }
}
