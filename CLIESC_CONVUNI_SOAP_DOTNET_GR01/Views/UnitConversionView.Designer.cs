namespace CLIESC_CONVUNI_SOAP_DOTNET_GR01.Views
{
    partial class UnitConversionView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            UnitConversionTypeSelect = new ComboBox();
            ConversionUnitSourceSelect = new ComboBox();
            ConversionUnitDestinationSelect = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ConversionUnitValueTextBox = new TextBox();
            SubmitButton = new Button();
            ConversionUnitResultTextBox = new TextBox();
            label6 = new Label();
            ErrorTextBox = new Label();
            LogoutButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(109, 60);
            label1.Name = "label1";
            label1.Size = new Size(179, 21);
            label1.TabIndex = 0;
            label1.Text = "Conversión de Unidades";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 106);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 1;
            label2.Text = "Tipo de conversión";
            // 
            // UnitConversionTypeSelect
            // 
            UnitConversionTypeSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            UnitConversionTypeSelect.FormattingEnabled = true;
            UnitConversionTypeSelect.Location = new Point(218, 103);
            UnitConversionTypeSelect.Name = "UnitConversionTypeSelect";
            UnitConversionTypeSelect.Size = new Size(121, 23);
            UnitConversionTypeSelect.TabIndex = 2;
            UnitConversionTypeSelect.SelectedValueChanged += ConversionTypeSelect_SelectedValueChanged;
            // 
            // UnitConversionSourceSelect
            // 
            ConversionUnitSourceSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            ConversionUnitSourceSelect.FormattingEnabled = true;
            ConversionUnitSourceSelect.Location = new Point(60, 167);
            ConversionUnitSourceSelect.Name = "UnitConversionSourceSelect";
            ConversionUnitSourceSelect.Size = new Size(121, 23);
            ConversionUnitSourceSelect.TabIndex = 3;
            // 
            // UnitConversionDestinationSelect
            // 
            ConversionUnitDestinationSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            ConversionUnitDestinationSelect.FormattingEnabled = true;
            ConversionUnitDestinationSelect.Location = new Point(218, 167);
            ConversionUnitDestinationSelect.Name = "UnitConversionDestinationSelect";
            ConversionUnitDestinationSelect.Size = new Size(121, 23);
            ConversionUnitDestinationSelect.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 145);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 5;
            label3.Text = "Origen";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(218, 145);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 6;
            label4.Text = "Destino";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 207);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 7;
            label5.Text = "Valor";
            // 
            // UnitConversionValueTextBox
            // 
            ConversionUnitValueTextBox.Location = new Point(60, 236);
            ConversionUnitValueTextBox.Name = "UnitConversionValueTextBox";
            ConversionUnitValueTextBox.Size = new Size(121, 23);
            ConversionUnitValueTextBox.TabIndex = 8;
            ConversionUnitValueTextBox.KeyPress += ConversionValueTextBox_KeyPress;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(157, 287);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(75, 23);
            SubmitButton.TabIndex = 9;
            SubmitButton.Text = "Convertir";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // UnitConversionResultTextBox
            // 
            ConversionUnitResultTextBox.Location = new Point(218, 236);
            ConversionUnitResultTextBox.Name = "UnitConversionResultTextBox";
            ConversionUnitResultTextBox.ReadOnly = true;
            ConversionUnitResultTextBox.Size = new Size(121, 23);
            ConversionUnitResultTextBox.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(218, 207);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 11;
            label6.Text = "Resultado";
            // 
            // ErrorTextBox
            // 
            ErrorTextBox.ForeColor = Color.Red;
            ErrorTextBox.Location = new Point(12, 333);
            ErrorTextBox.Name = "ErrorTextBox";
            ErrorTextBox.Size = new Size(371, 36);
            ErrorTextBox.TabIndex = 12;
            ErrorTextBox.Text = "Mensaje de error";
            ErrorTextBox.TextAlign = ContentAlignment.TopCenter;
            ErrorTextBox.Visible = false;
            // 
            // LogoutButton
            // 
            LogoutButton.Location = new Point(308, 12);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(75, 23);
            LogoutButton.TabIndex = 13;
            LogoutButton.Text = "Cerrar sesión";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // UnitConversionView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 378);
            Controls.Add(LogoutButton);
            Controls.Add(ErrorTextBox);
            Controls.Add(label6);
            Controls.Add(ConversionUnitResultTextBox);
            Controls.Add(SubmitButton);
            Controls.Add(ConversionUnitValueTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(ConversionUnitDestinationSelect);
            Controls.Add(ConversionUnitSourceSelect);
            Controls.Add(UnitConversionTypeSelect);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UnitConversionView";
            Text = "Conversión de Unidades";
            FormClosed += UnitConversionView_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox UnitConversionTypeSelect;
        private ComboBox ConversionUnitSourceSelect;
        private ComboBox ConversionUnitDestinationSelect;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox ConversionUnitValueTextBox;
        private Button SubmitButton;
        private TextBox ConversionUnitResultTextBox;
        private Label label6;
        private Label ErrorTextBox;
        private Button LogoutButton;
    }
}