namespace Wcf.WindowsFormsClient
{
    partial class Form1
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
            this.buttonGetData = new System.Windows.Forms.Button();
            this.listViewResult = new System.Windows.Forms.ListView();
            this.buttonRemoveItem = new System.Windows.Forms.Button();
            this.buttonEditItem = new System.Windows.Forms.Button();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGetData
            // 
            this.buttonGetData.Location = new System.Drawing.Point(12, 479);
            this.buttonGetData.Name = "buttonGetData";
            this.buttonGetData.Size = new System.Drawing.Size(483, 23);
            this.buttonGetData.TabIndex = 0;
            this.buttonGetData.Text = "Get Data";
            this.buttonGetData.UseVisualStyleBackColor = true;
            this.buttonGetData.Click += new System.EventHandler(this.buttonGetData_Click);
            // 
            // listViewResult
            // 
            this.listViewResult.HideSelection = false;
            this.listViewResult.Location = new System.Drawing.Point(12, 13);
            this.listViewResult.Name = "listViewResult";
            this.listViewResult.Size = new System.Drawing.Size(483, 460);
            this.listViewResult.TabIndex = 1;
            this.listViewResult.UseCompatibleStateImageBehavior = false;
            this.listViewResult.View = System.Windows.Forms.View.List;
            // 
            // buttonRemoveItem
            // 
            this.buttonRemoveItem.Location = new System.Drawing.Point(12, 564);
            this.buttonRemoveItem.Name = "buttonRemoveItem";
            this.buttonRemoveItem.Size = new System.Drawing.Size(483, 23);
            this.buttonRemoveItem.TabIndex = 2;
            this.buttonRemoveItem.Text = "Remove Selected Item";
            this.buttonRemoveItem.UseVisualStyleBackColor = true;
            this.buttonRemoveItem.Click += new System.EventHandler(this.buttonRemoveItem_Click);
            // 
            // buttonEditItem
            // 
            this.buttonEditItem.Location = new System.Drawing.Point(12, 506);
            this.buttonEditItem.Name = "buttonEditItem";
            this.buttonEditItem.Size = new System.Drawing.Size(483, 23);
            this.buttonEditItem.TabIndex = 3;
            this.buttonEditItem.Text = "Edit Item";
            this.buttonEditItem.UseVisualStyleBackColor = true;
            this.buttonEditItem.Click += new System.EventHandler(this.buttonEditItem_Click);
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Location = new System.Drawing.Point(12, 535);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(483, 23);
            this.buttonAddItem.TabIndex = 4;
            this.buttonAddItem.Text = "Add Item";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 597);
            this.Controls.Add(this.buttonAddItem);
            this.Controls.Add(this.buttonEditItem);
            this.Controls.Add(this.buttonRemoveItem);
            this.Controls.Add(this.listViewResult);
            this.Controls.Add(this.buttonGetData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonGetData;
        private System.Windows.Forms.ListView listViewResult;
        private System.Windows.Forms.Button buttonRemoveItem;
        private System.Windows.Forms.Button buttonEditItem;
        private System.Windows.Forms.Button buttonAddItem;
    }
}

