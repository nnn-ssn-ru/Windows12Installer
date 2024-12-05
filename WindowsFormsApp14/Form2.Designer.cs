namespace WindowsDownload
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Items.AddRange(new object[] {
            "Пользовательское соглашение",
            "",
            "1. Общие положения",
            "",
            "Данное пользовательское соглашение (далее - \"Соглашение\") регулирует отношения ме" +
                "жду вами (далее - \"Пользователь\") и компанией NNN ",
            "(далее - \"Компания\") в связи с использованием خدمات и ресурсов, предоставляемых К" +
                "омпанией. Пользователь, используя услуги Компании,",
            "подтверждает свое согласие с условиями данного Соглашения.",
            "",
            "2. Описание услуг",
            "",
            "Компания NNN предоставляет Пользователям доступ к определенным услугам, платформа" +
                "м и ресурсам. Все услуги предоставляются \"как есть\",",
            "без каких-либо гарантий.",
            "",
            "3. Ограничение ответственности",
            "",
            "Пользователь понимает и согласен с тем, что Компания NNN не несет ответственности" +
                " за любые прямые, косвенные, случайные, штрафные или",
            //resources.GetString("listBox1.Items"),
                "",
            "4. Изменение условий Соглашения",
            "",
            "Компания оставляет за собой право в любое время изменять условия данного Соглашен" +
                "ия. Изменения вступают в силу с момента их опубликования",
            "на сайте Компании, и Пользователь обязуется периодически проверять условия Соглаш" +
                "ения на предмет изменений.",
            "",
            "5. Заключительные положения",
            "",
            "Настоящее Соглашение регулируется законодательством страны, в которой зарегистрир" +
                "ована Компания NNN. Если какое-либо из положений",
            "данного Соглашения будет признано недействительным или не имеющим юридической сил" +
                "ы, остальные положения останутся в силе.",
            "",
            "",
            "",
            "Используя услуги Компании, Пользователь подтверждает, что прочитал, понял и согла" +
            "сен с условиями настоящего Соглашения."});
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(787, 407);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(644, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Я прочитал и согласен";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Пользовательское соглашение";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}