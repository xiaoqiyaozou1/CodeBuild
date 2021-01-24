
namespace CodeBuild
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileInfo = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutputFile = new System.Windows.Forms.TextBox();
            this.btnOutputFileSelect = new System.Windows.Forms.Button();
            this.lable2 = new System.Windows.Forms.Label();
            this.txtNameSpace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checCtr = new System.Windows.Forms.CheckBox();
            this.checkService = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件选择：";
            // 
            // txtFileInfo
            // 
            this.txtFileInfo.Location = new System.Drawing.Point(126, 38);
            this.txtFileInfo.Name = "txtFileInfo";
            this.txtFileInfo.ReadOnly = true;
            this.txtFileInfo.Size = new System.Drawing.Size(383, 23);
            this.txtFileInfo.TabIndex = 1;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(534, 38);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(79, 23);
            this.btnSelectFile.TabIndex = 2;
            this.btnSelectFile.Text = "文件夹选择";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "输出文件夹：";
            // 
            // txtOutputFile
            // 
            this.txtOutputFile.Location = new System.Drawing.Point(126, 93);
            this.txtOutputFile.Name = "txtOutputFile";
            this.txtOutputFile.ReadOnly = true;
            this.txtOutputFile.Size = new System.Drawing.Size(383, 23);
            this.txtOutputFile.TabIndex = 4;
            // 
            // btnOutputFileSelect
            // 
            this.btnOutputFileSelect.Location = new System.Drawing.Point(534, 93);
            this.btnOutputFileSelect.Name = "btnOutputFileSelect";
            this.btnOutputFileSelect.Size = new System.Drawing.Size(105, 23);
            this.btnOutputFileSelect.TabIndex = 5;
            this.btnOutputFileSelect.Text = "输出文件夹选择";
            this.btnOutputFileSelect.UseVisualStyleBackColor = true;
            this.btnOutputFileSelect.Click += new System.EventHandler(this.btnOutputFileSelect_Click);
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Location = new System.Drawing.Point(37, 151);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(68, 17);
            this.lable2.TabIndex = 6;
            this.lable2.Text = "命名空间：";
            // 
            // txtNameSpace
            // 
            this.txtNameSpace.Location = new System.Drawing.Point(126, 151);
            this.txtNameSpace.Name = "txtNameSpace";
            this.txtNameSpace.Size = new System.Drawing.Size(383, 23);
            this.txtNameSpace.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "生成文件选择：";
            // 
            // checCtr
            // 
            this.checCtr.AutoSize = true;
            this.checCtr.Location = new System.Drawing.Point(126, 253);
            this.checCtr.Name = "checCtr";
            this.checCtr.Size = new System.Drawing.Size(63, 21);
            this.checCtr.TabIndex = 9;
            this.checCtr.Text = "控制器";
            this.checCtr.UseVisualStyleBackColor = true;
            // 
            // checkService
            // 
            this.checkService.AutoSize = true;
            this.checkService.Location = new System.Drawing.Point(229, 253);
            this.checkService.Name = "checkService";
            this.checkService.Size = new System.Drawing.Size(63, 21);
            this.checkService.TabIndex = 10;
            this.checkService.Text = "服务层";
            this.checkService.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(534, 253);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "开始生成";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "服务类名：";
            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(126, 195);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(383, 23);
            this.txtServiceName.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 334);
            this.Controls.Add(this.txtServiceName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.checkService);
            this.Controls.Add(this.checCtr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameSpace);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.btnOutputFileSelect);
            this.Controls.Add(this.txtOutputFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.txtFileInfo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CodeBuild";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileInfo;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutputFile;
        private System.Windows.Forms.Button btnOutputFileSelect;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.TextBox txtNameSpace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checCtr;
        private System.Windows.Forms.CheckBox checkService;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServiceName;
    }
}

