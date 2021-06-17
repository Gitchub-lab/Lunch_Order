
namespace Lab1_LunchOrder
{
    partial class frmLunchOrder
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.lblOrderTotalText = new System.Windows.Forms.Label();
            this.lblTaxText = new System.Windows.Forms.Label();
            this.lblSubTotalText = new System.Windows.Forms.Label();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpOrderTotal = new System.Windows.Forms.GroupBox();
            this.chkBreadSticks = new System.Windows.Forms.CheckBox();
            this.chkBaconBits = new System.Windows.Forms.CheckBox();
            this.grpAddonsSalad = new System.Windows.Forms.GroupBox();
            this.chkCroutons = new System.Windows.Forms.CheckBox();
            this.grpAddonsPizza = new System.Windows.Forms.GroupBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkSausage = new System.Windows.Forms.CheckBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.grpAddonsHamb = new System.Windows.Forms.GroupBox();
            this.chkFrenchFries = new System.Windows.Forms.CheckBox();
            this.chkKetchup = new System.Windows.Forms.CheckBox();
            this.chkLettuce = new System.Windows.Forms.CheckBox();
            this.rbtnSalad = new System.Windows.Forms.RadioButton();
            this.rbtnPizza = new System.Windows.Forms.RadioButton();
            this.rbtnHamb = new System.Windows.Forms.RadioButton();
            this.grpMainCourse = new System.Windows.Forms.GroupBox();
            this.grpOrderTotal.SuspendLayout();
            this.grpAddonsSalad.SuspendLayout();
            this.grpAddonsPizza.SuspendLayout();
            this.grpAddonsHamb.SuspendLayout();
            this.grpMainCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.Color.Maroon;
            this.btnExit.Location = new System.Drawing.Point(644, 573);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(145, 59);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.Maroon;
            this.btnPlaceOrder.Location = new System.Drawing.Point(644, 397);
            this.btnPlaceOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(145, 59);
            this.btnPlaceOrder.TabIndex = 9;
            this.btnPlaceOrder.Text = "&Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // lblOrderTotalText
            // 
            this.lblOrderTotalText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOrderTotalText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrderTotalText.ForeColor = System.Drawing.Color.Maroon;
            this.lblOrderTotalText.Location = new System.Drawing.Point(149, 174);
            this.lblOrderTotalText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderTotalText.Name = "lblOrderTotalText";
            this.lblOrderTotalText.Size = new System.Drawing.Size(136, 40);
            this.lblOrderTotalText.TabIndex = 2;
            this.lblOrderTotalText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTaxText
            // 
            this.lblTaxText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTaxText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTaxText.ForeColor = System.Drawing.Color.Maroon;
            this.lblTaxText.Location = new System.Drawing.Point(149, 117);
            this.lblTaxText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaxText.Name = "lblTaxText";
            this.lblTaxText.Size = new System.Drawing.Size(136, 40);
            this.lblTaxText.TabIndex = 1;
            this.lblTaxText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubTotalText
            // 
            this.lblSubTotalText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubTotalText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubTotalText.ForeColor = System.Drawing.Color.Maroon;
            this.lblSubTotalText.Location = new System.Drawing.Point(149, 61);
            this.lblSubTotalText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTotalText.Name = "lblSubTotalText";
            this.lblSubTotalText.Size = new System.Drawing.Size(136, 40);
            this.lblSubTotalText.TabIndex = 0;
            this.lblSubTotalText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrderTotal.AutoSize = true;
            this.lblOrderTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrderTotal.Location = new System.Drawing.Point(40, 187);
            this.lblOrderTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(79, 17);
            this.lblOrderTotal.TabIndex = 2;
            this.lblOrderTotal.Text = "Order Total:";
            // 
            // lblTax
            // 
            this.lblTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTax.Location = new System.Drawing.Point(58, 128);
            this.lblTax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(61, 17);
            this.lblTax.TabIndex = 1;
            this.lblTax.Text = "Tax (5%):";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubTotal.Location = new System.Drawing.Point(58, 72);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(62, 17);
            this.lblSubTotal.TabIndex = 0;
            this.lblSubTotal.Text = "Subtotal:";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.ForeColor = System.Drawing.Color.Maroon;
            this.btnReset.Location = new System.Drawing.Point(644, 480);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(145, 59);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grpOrderTotal
            // 
            this.grpOrderTotal.BackColor = System.Drawing.Color.Gainsboro;
            this.grpOrderTotal.Controls.Add(this.lblOrderTotalText);
            this.grpOrderTotal.Controls.Add(this.lblTaxText);
            this.grpOrderTotal.Controls.Add(this.lblSubTotalText);
            this.grpOrderTotal.Controls.Add(this.lblOrderTotal);
            this.grpOrderTotal.Controls.Add(this.lblTax);
            this.grpOrderTotal.Controls.Add(this.lblSubTotal);
            this.grpOrderTotal.Location = new System.Drawing.Point(136, 386);
            this.grpOrderTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpOrderTotal.Name = "grpOrderTotal";
            this.grpOrderTotal.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpOrderTotal.Size = new System.Drawing.Size(368, 262);
            this.grpOrderTotal.TabIndex = 2;
            this.grpOrderTotal.TabStop = false;
            this.grpOrderTotal.Text = "Order Total";
            // 
            // chkBreadSticks
            // 
            this.chkBreadSticks.AutoSize = true;
            this.chkBreadSticks.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkBreadSticks.Location = new System.Drawing.Point(31, 179);
            this.chkBreadSticks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkBreadSticks.Name = "chkBreadSticks";
            this.chkBreadSticks.Size = new System.Drawing.Size(99, 21);
            this.chkBreadSticks.TabIndex = 2;
            this.chkBreadSticks.Text = "Bread sticks";
            this.chkBreadSticks.UseVisualStyleBackColor = true;
            this.chkBreadSticks.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // chkBaconBits
            // 
            this.chkBaconBits.AutoSize = true;
            this.chkBaconBits.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkBaconBits.Location = new System.Drawing.Point(31, 114);
            this.chkBaconBits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkBaconBits.Name = "chkBaconBits";
            this.chkBaconBits.Size = new System.Drawing.Size(90, 21);
            this.chkBaconBits.TabIndex = 1;
            this.chkBaconBits.Text = "Bacon Bits";
            this.chkBaconBits.UseVisualStyleBackColor = true;
            this.chkBaconBits.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // grpAddonsSalad
            // 
            this.grpAddonsSalad.BackColor = System.Drawing.Color.DarkKhaki;
            this.grpAddonsSalad.Controls.Add(this.chkBreadSticks);
            this.grpAddonsSalad.Controls.Add(this.chkBaconBits);
            this.grpAddonsSalad.Controls.Add(this.chkCroutons);
            this.grpAddonsSalad.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpAddonsSalad.Location = new System.Drawing.Point(531, 72);
            this.grpAddonsSalad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpAddonsSalad.Name = "grpAddonsSalad";
            this.grpAddonsSalad.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpAddonsSalad.Size = new System.Drawing.Size(363, 238);
            this.grpAddonsSalad.TabIndex = 3;
            this.grpAddonsSalad.TabStop = false;
            this.grpAddonsSalad.Text = "Add-on items ($.25/each)";
            this.grpAddonsSalad.Visible = false;
            // 
            // chkCroutons
            // 
            this.chkCroutons.AutoSize = true;
            this.chkCroutons.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkCroutons.Location = new System.Drawing.Point(31, 56);
            this.chkCroutons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkCroutons.Name = "chkCroutons";
            this.chkCroutons.Size = new System.Drawing.Size(83, 21);
            this.chkCroutons.TabIndex = 0;
            this.chkCroutons.Text = "Croutons";
            this.chkCroutons.UseVisualStyleBackColor = true;
            this.chkCroutons.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // grpAddonsPizza
            // 
            this.grpAddonsPizza.BackColor = System.Drawing.Color.DarkSalmon;
            this.grpAddonsPizza.Controls.Add(this.chkOlives);
            this.grpAddonsPizza.Controls.Add(this.chkSausage);
            this.grpAddonsPizza.Controls.Add(this.chkPepperoni);
            this.grpAddonsPizza.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpAddonsPizza.Location = new System.Drawing.Point(531, 74);
            this.grpAddonsPizza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpAddonsPizza.Name = "grpAddonsPizza";
            this.grpAddonsPizza.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpAddonsPizza.Size = new System.Drawing.Size(363, 238);
            this.grpAddonsPizza.TabIndex = 2;
            this.grpAddonsPizza.TabStop = false;
            this.grpAddonsPizza.Text = "Add-on items ($.50/each)";
            this.grpAddonsPizza.Visible = false;
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkOlives.Location = new System.Drawing.Point(31, 179);
            this.chkOlives.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(63, 21);
            this.chkOlives.TabIndex = 2;
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // chkSausage
            // 
            this.chkSausage.AutoSize = true;
            this.chkSausage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkSausage.Location = new System.Drawing.Point(31, 114);
            this.chkSausage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkSausage.Name = "chkSausage";
            this.chkSausage.Size = new System.Drawing.Size(77, 21);
            this.chkSausage.TabIndex = 1;
            this.chkSausage.Text = "Sausage";
            this.chkSausage.UseVisualStyleBackColor = true;
            this.chkSausage.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkPepperoni.Location = new System.Drawing.Point(31, 56);
            this.chkPepperoni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(89, 21);
            this.chkPepperoni.TabIndex = 0;
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            this.chkPepperoni.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // grpAddonsHamb
            // 
            this.grpAddonsHamb.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.grpAddonsHamb.Controls.Add(this.chkFrenchFries);
            this.grpAddonsHamb.Controls.Add(this.chkKetchup);
            this.grpAddonsHamb.Controls.Add(this.chkLettuce);
            this.grpAddonsHamb.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpAddonsHamb.Location = new System.Drawing.Point(531, 74);
            this.grpAddonsHamb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpAddonsHamb.Name = "grpAddonsHamb";
            this.grpAddonsHamb.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpAddonsHamb.Size = new System.Drawing.Size(363, 238);
            this.grpAddonsHamb.TabIndex = 1;
            this.grpAddonsHamb.TabStop = false;
            this.grpAddonsHamb.Text = "Add-on items ($.75/each)";
            // 
            // chkFrenchFries
            // 
            this.chkFrenchFries.AutoSize = true;
            this.chkFrenchFries.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkFrenchFries.Location = new System.Drawing.Point(31, 179);
            this.chkFrenchFries.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkFrenchFries.Name = "chkFrenchFries";
            this.chkFrenchFries.Size = new System.Drawing.Size(97, 21);
            this.chkFrenchFries.TabIndex = 2;
            this.chkFrenchFries.Text = "French fries";
            this.chkFrenchFries.UseVisualStyleBackColor = true;
            this.chkFrenchFries.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // chkKetchup
            // 
            this.chkKetchup.AutoSize = true;
            this.chkKetchup.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkKetchup.Location = new System.Drawing.Point(31, 114);
            this.chkKetchup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkKetchup.Name = "chkKetchup";
            this.chkKetchup.Size = new System.Drawing.Size(203, 21);
            this.chkKetchup.TabIndex = 1;
            this.chkKetchup.Text = "Ketchup, mustard, and mayo";
            this.chkKetchup.UseVisualStyleBackColor = true;
            this.chkKetchup.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // chkLettuce
            // 
            this.chkLettuce.AutoSize = true;
            this.chkLettuce.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkLettuce.Location = new System.Drawing.Point(31, 56);
            this.chkLettuce.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkLettuce.Name = "chkLettuce";
            this.chkLettuce.Size = new System.Drawing.Size(198, 21);
            this.chkLettuce.TabIndex = 0;
            this.chkLettuce.Text = "Lettuce, tomato, and onions";
            this.chkLettuce.UseVisualStyleBackColor = true;
            this.chkLettuce.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // rbtnSalad
            // 
            this.rbtnSalad.AutoSize = true;
            this.rbtnSalad.BackColor = System.Drawing.Color.DarkKhaki;
            this.rbtnSalad.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtnSalad.Location = new System.Drawing.Point(31, 178);
            this.rbtnSalad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnSalad.Name = "rbtnSalad";
            this.rbtnSalad.Size = new System.Drawing.Size(102, 21);
            this.rbtnSalad.TabIndex = 2;
            this.rbtnSalad.TabStop = true;
            this.rbtnSalad.Text = "Salad - $4.95";
            this.rbtnSalad.UseVisualStyleBackColor = false;
            this.rbtnSalad.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // rbtnPizza
            // 
            this.rbtnPizza.AutoSize = true;
            this.rbtnPizza.BackColor = System.Drawing.Color.DarkSalmon;
            this.rbtnPizza.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtnPizza.Location = new System.Drawing.Point(31, 112);
            this.rbtnPizza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnPizza.Name = "rbtnPizza";
            this.rbtnPizza.Size = new System.Drawing.Size(100, 21);
            this.rbtnPizza.TabIndex = 1;
            this.rbtnPizza.TabStop = true;
            this.rbtnPizza.Text = "Pizza - $5.95";
            this.rbtnPizza.UseVisualStyleBackColor = false;
            this.rbtnPizza.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // rbtnHamb
            // 
            this.rbtnHamb.AutoSize = true;
            this.rbtnHamb.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.rbtnHamb.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtnHamb.Location = new System.Drawing.Point(31, 56);
            this.rbtnHamb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnHamb.Name = "rbtnHamb";
            this.rbtnHamb.Size = new System.Drawing.Size(140, 21);
            this.rbtnHamb.TabIndex = 0;
            this.rbtnHamb.TabStop = true;
            this.rbtnHamb.Text = "Hamburger - $6.95";
            this.rbtnHamb.UseVisualStyleBackColor = false;
            this.rbtnHamb.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // grpMainCourse
            // 
            this.grpMainCourse.BackColor = System.Drawing.Color.Tan;
            this.grpMainCourse.Controls.Add(this.rbtnSalad);
            this.grpMainCourse.Controls.Add(this.rbtnPizza);
            this.grpMainCourse.Controls.Add(this.rbtnHamb);
            this.grpMainCourse.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpMainCourse.Location = new System.Drawing.Point(135, 72);
            this.grpMainCourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpMainCourse.Name = "grpMainCourse";
            this.grpMainCourse.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpMainCourse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpMainCourse.Size = new System.Drawing.Size(324, 240);
            this.grpMainCourse.TabIndex = 0;
            this.grpMainCourse.TabStop = false;
            this.grpMainCourse.Text = "Main Course";
            // 
            // frmLunchOrder
            // 
            this.AcceptButton = this.btnPlaceOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(1038, 677);
            this.Controls.Add(this.grpAddonsHamb);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.grpAddonsPizza);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grpOrderTotal);
            this.Controls.Add(this.grpAddonsSalad);
            this.Controls.Add(this.grpMainCourse);
            this.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "frmLunchOrder";
            this.Text = "Lunch Order";
            this.grpOrderTotal.ResumeLayout(false);
            this.grpOrderTotal.PerformLayout();
            this.grpAddonsSalad.ResumeLayout(false);
            this.grpAddonsSalad.PerformLayout();
            this.grpAddonsPizza.ResumeLayout(false);
            this.grpAddonsPizza.PerformLayout();
            this.grpAddonsHamb.ResumeLayout(false);
            this.grpAddonsHamb.PerformLayout();
            this.grpMainCourse.ResumeLayout(false);
            this.grpMainCourse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Label lblOrderTotalText;
        private System.Windows.Forms.Label lblTaxText;
        private System.Windows.Forms.Label lblSubTotalText;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grpOrderTotal;
        private System.Windows.Forms.CheckBox chkBreadSticks;
        private System.Windows.Forms.CheckBox chkBaconBits;
        private System.Windows.Forms.GroupBox grpAddonsSalad;
        private System.Windows.Forms.CheckBox chkCroutons;
        private System.Windows.Forms.RadioButton rbtnSalad;
        private System.Windows.Forms.RadioButton rbtnPizza;
        private System.Windows.Forms.RadioButton rbtnHamb;
        private System.Windows.Forms.GroupBox grpMainCourse;
        private System.Windows.Forms.GroupBox grpAddonsPizza;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkSausage;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.GroupBox grpAddonsHamb;
        private System.Windows.Forms.CheckBox chkFrenchFries;
        private System.Windows.Forms.CheckBox chkKetchup;
        private System.Windows.Forms.CheckBox chkLettuce;
    }
}

