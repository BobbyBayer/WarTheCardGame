namespace WarTheCardGame
{
    partial class WarZoneForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarZoneForm));
            infoLabel = new Label();
            FormTimerEvent = new System.Windows.Forms.Timer(components);
            yourDeckPic = new PictureBox();
            yourDeckCountLabel = new Label();
            opponentDeckPic = new PictureBox();
            opponentDeckCountLabel = new Label();
            drawCardButton = new Button();
            yourDiscardPileLabel = new Label();
            opponentDiscardPileLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)yourDeckPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)opponentDeckPic).BeginInit();
            SuspendLayout();
            // 
            // infoLabel
            // 
            infoLabel.Anchor = AnchorStyles.Top;
            infoLabel.AutoSize = true;
            infoLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            infoLabel.ForeColor = SystemColors.ActiveCaption;
            infoLabel.Location = new Point(566, 0);
            infoLabel.Name = "infoLabel";
            infoLabel.Size = new Size(61, 32);
            infoLabel.TabIndex = 0;
            infoLabel.Text = "Info";
            infoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormTimerEvent
            // 
            FormTimerEvent.Enabled = true;
            FormTimerEvent.Interval = 20;
            FormTimerEvent.Tick += FormTimer;
            // 
            // yourDeckPic
            // 
            yourDeckPic.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            yourDeckPic.Image = (Image)resources.GetObject("yourDeckPic.Image");
            yourDeckPic.Location = new Point(0, 498);
            yourDeckPic.Name = "yourDeckPic";
            yourDeckPic.Size = new Size(100, 200);
            yourDeckPic.TabIndex = 1;
            yourDeckPic.TabStop = false;
            // 
            // yourDeckCountLabel
            // 
            yourDeckCountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            yourDeckCountLabel.AutoSize = true;
            yourDeckCountLabel.Font = new Font("Showcard Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            yourDeckCountLabel.Location = new Point(0, 648);
            yourDeckCountLabel.Name = "yourDeckCountLabel";
            yourDeckCountLabel.Size = new Size(41, 44);
            yourDeckCountLabel.TabIndex = 2;
            yourDeckCountLabel.Text = "0";
            // 
            // opponentDeckPic
            // 
            opponentDeckPic.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            opponentDeckPic.Image = (Image)resources.GetObject("opponentDeckPic.Image");
            opponentDeckPic.Location = new Point(1233, 0);
            opponentDeckPic.Name = "opponentDeckPic";
            opponentDeckPic.Size = new Size(100, 200);
            opponentDeckPic.TabIndex = 3;
            opponentDeckPic.TabStop = false;
            // 
            // opponentDeckCountLabel
            // 
            opponentDeckCountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            opponentDeckCountLabel.AutoSize = true;
            opponentDeckCountLabel.Font = new Font("Showcard Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            opponentDeckCountLabel.Location = new Point(1293, 0);
            opponentDeckCountLabel.Name = "opponentDeckCountLabel";
            opponentDeckCountLabel.Size = new Size(40, 44);
            opponentDeckCountLabel.TabIndex = 4;
            opponentDeckCountLabel.Text = "0";
            // 
            // drawCardButton
            // 
            drawCardButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            drawCardButton.Location = new Point(10, 470);
            drawCardButton.Name = "drawCardButton";
            drawCardButton.Size = new Size(75, 23);
            drawCardButton.TabIndex = 5;
            drawCardButton.Text = "Draw Card";
            drawCardButton.UseVisualStyleBackColor = true;
            drawCardButton.Click += drawCardButton_Click;
            // 
            // yourDiscardPileLabel
            // 
            yourDiscardPileLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            yourDiscardPileLabel.AutoSize = true;
            yourDiscardPileLabel.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            yourDiscardPileLabel.Location = new Point(100, 668);
            yourDiscardPileLabel.Name = "yourDiscardPileLabel";
            yourDiscardPileLabel.Size = new Size(157, 23);
            yourDiscardPileLabel.TabIndex = 6;
            yourDiscardPileLabel.Text = "Discard pile: 0";
            // 
            // opponentDiscardPileLabel
            // 
            opponentDiscardPileLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            opponentDiscardPileLabel.AutoSize = true;
            opponentDiscardPileLabel.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            opponentDiscardPileLabel.Location = new Point(1173, 200);
            opponentDiscardPileLabel.Name = "opponentDiscardPileLabel";
            opponentDiscardPileLabel.Size = new Size(157, 23);
            opponentDiscardPileLabel.TabIndex = 7;
            opponentDiscardPileLabel.Text = "Discard pile: 0";
            // 
            // WarZoneForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1333, 698);
            Controls.Add(opponentDiscardPileLabel);
            Controls.Add(yourDiscardPileLabel);
            Controls.Add(drawCardButton);
            Controls.Add(opponentDeckCountLabel);
            Controls.Add(opponentDeckPic);
            Controls.Add(yourDeckCountLabel);
            Controls.Add(yourDeckPic);
            Controls.Add(infoLabel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "WarZoneForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WarZoneForm";
            WindowState = FormWindowState.Maximized;
            Paint += FormPaint;
            MouseDown += FormMouseDown;
            MouseMove += FormMouseMove;
            MouseUp += FormMouseUp;
            ((System.ComponentModel.ISupportInitialize)yourDeckPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)opponentDeckPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label infoLabel;
        private System.Windows.Forms.Timer FormTimerEvent;
        private PictureBox yourDeckPic;
        private Label yourDeckCountLabel;
        private PictureBox opponentDeckPic;
        private Label opponentDeckCountLabel;
        private Button drawCardButton;
        private Label yourDiscardPileLabel;
        private Label opponentDiscardPileLabel;
    }
}