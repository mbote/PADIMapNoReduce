namespace Client
{
    partial class ClientForm
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SelectOutput = new System.Windows.Forms.Button();
            this.SelectInput = new System.Windows.Forms.Button();
            this.ChooseClass = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.MapFunction = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SplitsNr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OutputFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InputFile = new System.Windows.Forms.TextBox();
            this.btSubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.InitializeButton = new System.Windows.Forms.Button();
            this.WorkerURL = new System.Windows.Forms.TextBox();
            this.openMapClass = new System.Windows.Forms.OpenFileDialog();
            this.openInputFile = new System.Windows.Forms.OpenFileDialog();
            this.openOutputFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SelectOutput);
            this.groupBox4.Controls.Add(this.SelectInput);
            this.groupBox4.Controls.Add(this.ChooseClass);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.MapFunction);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.SplitsNr);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.OutputFolder);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.InputFile);
            this.groupBox4.Controls.Add(this.btSubmit);
            this.groupBox4.Location = new System.Drawing.Point(12, 106);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(415, 165);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Submit Job";
            // 
            // SelectOutput
            // 
            this.SelectOutput.Location = new System.Drawing.Point(287, 85);
            this.SelectOutput.Name = "SelectOutput";
            this.SelectOutput.Size = new System.Drawing.Size(122, 23);
            this.SelectOutput.TabIndex = 17;
            this.SelectOutput.Text = "Select Output Folder";
            this.SelectOutput.UseVisualStyleBackColor = true;
            this.SelectOutput.Click += new System.EventHandler(this.SelectOutput_Click);
            // 
            // SelectInput
            // 
            this.SelectInput.Location = new System.Drawing.Point(305, 33);
            this.SelectInput.Name = "SelectInput";
            this.SelectInput.Size = new System.Drawing.Size(104, 25);
            this.SelectInput.TabIndex = 16;
            this.SelectInput.Text = "Select File to Map";
            this.SelectInput.UseVisualStyleBackColor = true;
            this.SelectInput.Click += new System.EventHandler(this.SelectInput_Click);
            // 
            // ChooseClass
            // 
            this.ChooseClass.Location = new System.Drawing.Point(235, 126);
            this.ChooseClass.Name = "ChooseClass";
            this.ChooseClass.Size = new System.Drawing.Size(84, 25);
            this.ChooseClass.TabIndex = 15;
            this.ChooseClass.Text = "Choose Class";
            this.ChooseClass.UseVisualStyleBackColor = true;
            this.ChooseClass.Click += new System.EventHandler(this.ChooseClass_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Map Function";
            // 
            // MapFunction
            // 
            this.MapFunction.BackColor = System.Drawing.SystemColors.Menu;
            this.MapFunction.Location = new System.Drawing.Point(106, 129);
            this.MapFunction.Name = "MapFunction";
            this.MapFunction.Size = new System.Drawing.Size(123, 20);
            this.MapFunction.TabIndex = 13;
            this.MapFunction.TextChanged += new System.EventHandler(this.MapFunction_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Splits Number";
            // 
            // SplitsNr
            // 
            this.SplitsNr.Location = new System.Drawing.Point(6, 129);
            this.SplitsNr.Name = "SplitsNr";
            this.SplitsNr.Size = new System.Drawing.Size(70, 20);
            this.SplitsNr.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Output";
            // 
            // OutputFolder
            // 
            this.OutputFolder.BackColor = System.Drawing.SystemColors.Menu;
            this.OutputFolder.Location = new System.Drawing.Point(6, 87);
            this.OutputFolder.Name = "OutputFolder";
            this.OutputFolder.Size = new System.Drawing.Size(275, 20);
            this.OutputFolder.TabIndex = 9;
            this.OutputFolder.TextChanged += new System.EventHandler(this.OutputFolder_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "File";
            // 
            // InputFile
            // 
            this.InputFile.BackColor = System.Drawing.SystemColors.Menu;
            this.InputFile.Location = new System.Drawing.Point(6, 36);
            this.InputFile.Name = "InputFile";
            this.InputFile.Size = new System.Drawing.Size(293, 20);
            this.InputFile.TabIndex = 6;
            this.InputFile.TextChanged += new System.EventHandler(this.InputFile_TextChanged);
            // 
            // btSubmit
            // 
            this.btSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSubmit.Location = new System.Drawing.Point(334, 126);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(75, 25);
            this.btSubmit.TabIndex = 4;
            this.btSubmit.Text = "SUBMIT";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.InitializeButton);
            this.groupBox1.Controls.Add(this.WorkerURL);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 69);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Initialize worker contact";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Worker URL";
            // 
            // InitializeButton
            // 
            this.InitializeButton.Location = new System.Drawing.Point(315, 39);
            this.InitializeButton.Name = "InitializeButton";
            this.InitializeButton.Size = new System.Drawing.Size(87, 23);
            this.InitializeButton.TabIndex = 1;
            this.InitializeButton.Text = "Initialize";
            this.InitializeButton.UseVisualStyleBackColor = true;
            this.InitializeButton.Click += new System.EventHandler(this.InitializeButton_Click);
            // 
            // WorkerURL
            // 
            this.WorkerURL.Location = new System.Drawing.Point(6, 43);
            this.WorkerURL.Name = "WorkerURL";
            this.WorkerURL.Size = new System.Drawing.Size(293, 20);
            this.WorkerURL.TabIndex = 0;
            // 
            // openMapClass
            // 
            this.openMapClass.FileName = "openFileDialog1";
            // 
            // openInputFile
            // 
            this.openInputFile.FileName = "openFileDialog1";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 283);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MapFunction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SplitsNr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OutputFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InputFile;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button InitializeButton;
        private System.Windows.Forms.TextBox WorkerURL;
        private System.Windows.Forms.Button ChooseClass;
        private System.Windows.Forms.OpenFileDialog openMapClass;
        private System.Windows.Forms.Button SelectInput;
        private System.Windows.Forms.Button SelectOutput;
        private System.Windows.Forms.OpenFileDialog openInputFile;
        private System.Windows.Forms.FolderBrowserDialog openOutputFolder;
    }
}