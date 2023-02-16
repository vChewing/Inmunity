namespace Inmunity_WinNT {
partial class MainWindow {
  /// <summary>
  ///  Required designer variable.
  /// </summary>
  private System.ComponentModel.IContainer components = null;

  /// <summary>
  ///  Clean up any resources being used.
  /// </summary>
  /// <param name="disposing">true if managed resources should be disposed;
  /// otherwise, false.</param>
  protected override void Dispose(bool disposing) {
    if (disposing && (components != null)) {
      components.Dispose();
    }
    base.Dispose(disposing);
  }

#region Windows Form Designer generated code

  /// <summary>
  ///  Required method for Designer support - do not modify
  ///  the contents of this method with the code editor.
  /// </summary>
  private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.txtField1 = new System.Windows.Forms.TextBox();
            this.btnInmunify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtField1
            // 
            this.txtField1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtField1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtField1.Location = new System.Drawing.Point(11, 13);
            this.txtField1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtField1.Multiline = true;
            this.txtField1.Name = "txtField1";
            this.txtField1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtField1.Size = new System.Drawing.Size(282, 140);
            this.txtField1.TabIndex = 0;
            // 
            // btnInmunify
            // 
            this.btnInmunify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInmunify.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInmunify.Location = new System.Drawing.Point(203, 161);
            this.btnInmunify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInmunify.Name = "btnInmunify";
            this.btnInmunify.Size = new System.Drawing.Size(90, 27);
            this.btnInmunify.TabIndex = 1;
            this.btnInmunify.Text = "Inmunify";
            this.btnInmunify.UseVisualStyleBackColor = true;
            this.btnInmunify.Click += new System.EventHandler(this.btnInmunify_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 201);
            this.Controls.Add(this.btnInmunify);
            this.Controls.Add(this.txtField1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainWindow";
            this.Text = "Inmunity";
            this.ResumeLayout(false);
            this.PerformLayout();

  }

#endregion

  private TextBox txtField1;
  private Button btnInmunify;
}
}