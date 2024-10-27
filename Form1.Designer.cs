namespace CS311_Project3_JAR
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            picturePizza = new PictureBox();
            cboSize = new ComboBox();
            lblSize = new Label();
            grpCrust = new GroupBox();
            rdoRegular = new RadioButton();
            rdoThick = new RadioButton();
            rdoThin = new RadioButton();
            ckbPep = new CheckBox();
            ckbSausage = new CheckBox();
            ckbCanBac = new CheckBox();
            ckbSpicy = new CheckBox();
            lblToppings = new Label();
            txtBoxSummary = new RichTextBox();
            lblSummary = new Label();
            lblSubTotal = new Label();
            lblTax = new Label();
            lblTotal = new Label();
            txtBoxSubTotal = new TextBox();
            txtBoxTax = new TextBox();
            txtBoxTotal = new TextBox();
            btnCalculate = new Button();
            ((System.ComponentModel.ISupportInitialize)picturePizza).BeginInit();
            grpCrust.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(30, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(83, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "J's Pizza";
            // 
            // picturePizza
            // 
            picturePizza.Image = Properties.Resources.pizza1;
            picturePizza.Location = new Point(30, 48);
            picturePizza.Name = "picturePizza";
            picturePizza.Size = new Size(150, 96);
            picturePizza.SizeMode = PictureBoxSizeMode.AutoSize;
            picturePizza.TabIndex = 1;
            picturePizza.TabStop = false;
            // 
            // cboSize
            // 
            cboSize.FormattingEnabled = true;
            cboSize.Items.AddRange(new object[] { "Small", "Medium", "Large", "X-Large", "Ginormous" });
            cboSize.Location = new Point(217, 48);
            cboSize.Name = "cboSize";
            cboSize.Size = new Size(153, 23);
            cboSize.TabIndex = 2;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSize.Location = new Point(217, 30);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(83, 15);
            lblSize.TabIndex = 3;
            lblSize.Text = "Choose a Size:";
            // 
            // grpCrust
            // 
            grpCrust.Controls.Add(rdoRegular);
            grpCrust.Controls.Add(rdoThick);
            grpCrust.Controls.Add(rdoThin);
            grpCrust.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpCrust.Location = new Point(409, 30);
            grpCrust.Name = "grpCrust";
            grpCrust.Size = new Size(97, 100);
            grpCrust.TabIndex = 4;
            grpCrust.TabStop = false;
            grpCrust.Text = "Crust:";
            // 
            // rdoRegular
            // 
            rdoRegular.AutoSize = true;
            rdoRegular.Location = new Point(18, 72);
            rdoRegular.Name = "rdoRegular";
            rdoRegular.Size = new Size(65, 19);
            rdoRegular.TabIndex = 2;
            rdoRegular.TabStop = true;
            rdoRegular.Text = "Regular";
            rdoRegular.UseVisualStyleBackColor = true;
            // 
            // rdoThick
            // 
            rdoThick.AutoSize = true;
            rdoThick.Location = new Point(18, 47);
            rdoThick.Name = "rdoThick";
            rdoThick.Size = new Size(54, 19);
            rdoThick.TabIndex = 1;
            rdoThick.TabStop = true;
            rdoThick.Text = "Thick";
            rdoThick.UseVisualStyleBackColor = true;
            // 
            // rdoThin
            // 
            rdoThin.AutoSize = true;
            rdoThin.Location = new Point(18, 22);
            rdoThin.Name = "rdoThin";
            rdoThin.Size = new Size(49, 19);
            rdoThin.TabIndex = 0;
            rdoThin.TabStop = true;
            rdoThin.Text = "Thin";
            rdoThin.UseVisualStyleBackColor = true;
            // 
            // ckbPep
            // 
            ckbPep.AutoSize = true;
            ckbPep.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ckbPep.Location = new Point(542, 54);
            ckbPep.Name = "ckbPep";
            ckbPep.Size = new Size(80, 19);
            ckbPep.TabIndex = 5;
            ckbPep.Text = "Pepperoni";
            ckbPep.UseVisualStyleBackColor = true;
            // 
            // ckbSausage
            // 
            ckbSausage.AutoSize = true;
            ckbSausage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ckbSausage.Location = new Point(542, 79);
            ckbSausage.Name = "ckbSausage";
            ckbSausage.Size = new Size(70, 19);
            ckbSausage.TabIndex = 6;
            ckbSausage.Text = "Sausage";
            ckbSausage.UseVisualStyleBackColor = true;
            // 
            // ckbCanBac
            // 
            ckbCanBac.AutoSize = true;
            ckbCanBac.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ckbCanBac.Location = new Point(542, 104);
            ckbCanBac.Name = "ckbCanBac";
            ckbCanBac.Size = new Size(111, 19);
            ckbCanBac.TabIndex = 7;
            ckbCanBac.Text = "Canadian Bacon";
            ckbCanBac.UseVisualStyleBackColor = true;
            // 
            // ckbSpicy
            // 
            ckbSpicy.AutoSize = true;
            ckbSpicy.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            ckbSpicy.Location = new Point(542, 129);
            ckbSpicy.Name = "ckbSpicy";
            ckbSpicy.Size = new Size(138, 19);
            ckbSpicy.TabIndex = 8;
            ckbSpicy.Text = "Spicy Italian Sausage";
            ckbSpicy.UseVisualStyleBackColor = true;
            // 
            // lblToppings
            // 
            lblToppings.AutoSize = true;
            lblToppings.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblToppings.Location = new Point(533, 30);
            lblToppings.Name = "lblToppings";
            lblToppings.Size = new Size(59, 15);
            lblToppings.TabIndex = 9;
            lblToppings.Text = "Toppings:";
            // 
            // txtBoxSummary
            // 
            txtBoxSummary.Location = new Point(30, 182);
            txtBoxSummary.Name = "txtBoxSummary";
            txtBoxSummary.Size = new Size(436, 135);
            txtBoxSummary.TabIndex = 10;
            txtBoxSummary.Text = "";
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSummary.Location = new Point(30, 164);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(95, 15);
            lblSummary.TabIndex = 11;
            lblSummary.Text = "Order Summary:";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblSubTotal.Location = new Point(482, 177);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(95, 25);
            lblSubTotal.TabIndex = 12;
            lblSubTotal.Text = "SubTotal:";
            // 
            // lblTax
            // 
            lblTax.AutoSize = true;
            lblTax.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblTax.Location = new Point(530, 206);
            lblTax.Name = "lblTax";
            lblTax.Size = new Size(47, 25);
            lblTax.TabIndex = 13;
            lblTax.Text = "Tax:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblTotal.Location = new Point(517, 235);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(60, 25);
            lblTotal.TabIndex = 14;
            lblTotal.Text = "Total:";
            // 
            // txtBoxSubTotal
            // 
            txtBoxSubTotal.Location = new Point(583, 179);
            txtBoxSubTotal.Name = "txtBoxSubTotal";
            txtBoxSubTotal.Size = new Size(144, 23);
            txtBoxSubTotal.TabIndex = 15;
            // 
            // txtBoxTax
            // 
            txtBoxTax.Location = new Point(583, 208);
            txtBoxTax.Name = "txtBoxTax";
            txtBoxTax.Size = new Size(144, 23);
            txtBoxTax.TabIndex = 16;
            // 
            // txtBoxTotal
            // 
            txtBoxTotal.Location = new Point(583, 237);
            txtBoxTotal.Name = "txtBoxTotal";
            txtBoxTotal.Size = new Size(144, 23);
            txtBoxTotal.TabIndex = 17;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(482, 266);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(245, 51);
            btnCalculate.TabIndex = 18;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 335);
            Controls.Add(btnCalculate);
            Controls.Add(txtBoxTotal);
            Controls.Add(txtBoxTax);
            Controls.Add(txtBoxSubTotal);
            Controls.Add(lblTotal);
            Controls.Add(lblTax);
            Controls.Add(lblSubTotal);
            Controls.Add(lblSummary);
            Controls.Add(txtBoxSummary);
            Controls.Add(lblToppings);
            Controls.Add(ckbSpicy);
            Controls.Add(ckbCanBac);
            Controls.Add(ckbSausage);
            Controls.Add(ckbPep);
            Controls.Add(grpCrust);
            Controls.Add(lblSize);
            Controls.Add(cboSize);
            Controls.Add(picturePizza);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "J's Pizza";
            ((System.ComponentModel.ISupportInitialize)picturePizza).EndInit();
            grpCrust.ResumeLayout(false);
            grpCrust.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private PictureBox picturePizza;
        private ComboBox cboSize;
        private Label lblSize;
        private GroupBox grpCrust;
        private RadioButton rdoRegular;
        private RadioButton rdoThick;
        private RadioButton rdoThin;
        private CheckBox ckbPep;
        private CheckBox ckbSausage;
        private CheckBox ckbCanBac;
        private CheckBox ckbSpicy;
        private Label lblToppings;
        private RichTextBox txtBoxSummary;
        private Label lblSummary;
        private Label lblSubTotal;
        private Label lblTax;
        private Label lblTotal;
        private TextBox txtBoxSubTotal;
        private TextBox txtBoxTax;
        private TextBox txtBoxTotal;
        private Button btnCalculate;
    }
}
