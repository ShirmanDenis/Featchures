namespace AviaSalesApp.View
{
    partial class RegisterForm
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
            this.components = new System.ComponentModel.Container();
            this.txBxTicketId = new System.Windows.Forms.TextBox();
            this.dataGridPassanger = new System.Windows.Forms.DataGridView();
            this.passengerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isRegisteredDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.passengerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridTickets = new System.Windows.Forms.DataGridView();
            this.ticketIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planeSeatIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passangerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridSeats = new System.Windows.Forms.DataGridView();
            this.planeSeatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonFindTicket = new System.Windows.Forms.Button();
            this.PlaneSeatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlaneSeat_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeatClass_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPassanger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTickets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSeats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planeSeatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txBxTicketId
            // 
            this.txBxTicketId.Location = new System.Drawing.Point(116, 6);
            this.txBxTicketId.Name = "txBxTicketId";
            this.txBxTicketId.Size = new System.Drawing.Size(100, 20);
            this.txBxTicketId.TabIndex = 1;
            this.txBxTicketId.Validating += new System.ComponentModel.CancelEventHandler(this.txBxTicketId_Validating);
            // 
            // dataGridPassanger
            // 
            this.dataGridPassanger.AllowUserToAddRows = false;
            this.dataGridPassanger.AllowUserToDeleteRows = false;
            this.dataGridPassanger.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridPassanger.AutoGenerateColumns = false;
            this.dataGridPassanger.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPassanger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPassanger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.passengerIDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.passportDataGridViewTextBoxColumn,
            this.isRegisteredDataGridViewCheckBoxColumn});
            this.dataGridPassanger.DataSource = this.passengerBindingSource;
            this.dataGridPassanger.Location = new System.Drawing.Point(461, 42);
            this.dataGridPassanger.Name = "dataGridPassanger";
            this.dataGridPassanger.Size = new System.Drawing.Size(346, 112);
            this.dataGridPassanger.TabIndex = 2;
            // 
            // passengerIDDataGridViewTextBoxColumn
            // 
            this.passengerIDDataGridViewTextBoxColumn.DataPropertyName = "Passenger_ID";
            this.passengerIDDataGridViewTextBoxColumn.HeaderText = "Passenger_ID";
            this.passengerIDDataGridViewTextBoxColumn.Name = "passengerIDDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // passportDataGridViewTextBoxColumn
            // 
            this.passportDataGridViewTextBoxColumn.DataPropertyName = "Passport";
            this.passportDataGridViewTextBoxColumn.HeaderText = "Passport";
            this.passportDataGridViewTextBoxColumn.Name = "passportDataGridViewTextBoxColumn";
            // 
            // isRegisteredDataGridViewCheckBoxColumn
            // 
            this.isRegisteredDataGridViewCheckBoxColumn.DataPropertyName = "IsRegistered";
            this.isRegisteredDataGridViewCheckBoxColumn.HeaderText = "IsRegistered";
            this.isRegisteredDataGridViewCheckBoxColumn.Name = "isRegisteredDataGridViewCheckBoxColumn";
            // 
            // passengerBindingSource
            // 
            this.passengerBindingSource.DataSource = typeof(AviaSalesApp.Passenger);
            // 
            // dataGridTickets
            // 
            this.dataGridTickets.AllowUserToAddRows = false;
            this.dataGridTickets.AllowUserToDeleteRows = false;
            this.dataGridTickets.AutoGenerateColumns = false;
            this.dataGridTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTickets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ticketIDDataGridViewTextBoxColumn,
            this.flightIDDataGridViewTextBoxColumn,
            this.planeSeatIDDataGridViewTextBoxColumn,
            this.passangerIDDataGridViewTextBoxColumn,
            this.priceIDDataGridViewTextBoxColumn});
            this.dataGridTickets.DataSource = this.ticketBindingSource;
            this.dataGridTickets.Location = new System.Drawing.Point(15, 42);
            this.dataGridTickets.Name = "dataGridTickets";
            this.dataGridTickets.Size = new System.Drawing.Size(440, 270);
            this.dataGridTickets.TabIndex = 3;
            // 
            // ticketIDDataGridViewTextBoxColumn
            // 
            this.ticketIDDataGridViewTextBoxColumn.DataPropertyName = "Ticket_ID";
            this.ticketIDDataGridViewTextBoxColumn.HeaderText = "Ticket_ID";
            this.ticketIDDataGridViewTextBoxColumn.Name = "ticketIDDataGridViewTextBoxColumn";
            // 
            // flightIDDataGridViewTextBoxColumn
            // 
            this.flightIDDataGridViewTextBoxColumn.DataPropertyName = "Flight_ID";
            this.flightIDDataGridViewTextBoxColumn.HeaderText = "Flight_ID";
            this.flightIDDataGridViewTextBoxColumn.Name = "flightIDDataGridViewTextBoxColumn";
            // 
            // planeSeatIDDataGridViewTextBoxColumn
            // 
            this.planeSeatIDDataGridViewTextBoxColumn.DataPropertyName = "PlaneSeat_ID";
            this.planeSeatIDDataGridViewTextBoxColumn.HeaderText = "PlaneSeat_ID";
            this.planeSeatIDDataGridViewTextBoxColumn.Name = "planeSeatIDDataGridViewTextBoxColumn";
            // 
            // passangerIDDataGridViewTextBoxColumn
            // 
            this.passangerIDDataGridViewTextBoxColumn.DataPropertyName = "Passanger_ID";
            this.passangerIDDataGridViewTextBoxColumn.HeaderText = "Passanger_ID";
            this.passangerIDDataGridViewTextBoxColumn.Name = "passangerIDDataGridViewTextBoxColumn";
            // 
            // priceIDDataGridViewTextBoxColumn
            // 
            this.priceIDDataGridViewTextBoxColumn.DataPropertyName = "Price_ID";
            this.priceIDDataGridViewTextBoxColumn.HeaderText = "Price_ID";
            this.priceIDDataGridViewTextBoxColumn.Name = "priceIDDataGridViewTextBoxColumn";
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataSource = typeof(AviaSalesApp.Ticket);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 11F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticket Id:";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(732, 13);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridSeats
            // 
            this.dataGridSeats.AllowUserToAddRows = false;
            this.dataGridSeats.AllowUserToDeleteRows = false;
            this.dataGridSeats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridSeats.AutoGenerateColumns = false;
            this.dataGridSeats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSeats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSeats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlaneSeatName,
            this.PlaneSeat_ID,
            this.SeatClass_ID});
            this.dataGridSeats.DataSource = this.planeSeatBindingSource;
            this.dataGridSeats.Location = new System.Drawing.Point(461, 162);
            this.dataGridSeats.Name = "dataGridSeats";
            this.dataGridSeats.ReadOnly = true;
            this.dataGridSeats.Size = new System.Drawing.Size(346, 150);
            this.dataGridSeats.TabIndex = 5;
            // 
            // planeSeatBindingSource
            // 
            this.planeSeatBindingSource.DataSource = typeof(AviaSalesApp.PlaneSeat);
            // 
            // buttonFindTicket
            // 
            this.buttonFindTicket.Location = new System.Drawing.Point(380, 13);
            this.buttonFindTicket.Name = "buttonFindTicket";
            this.buttonFindTicket.Size = new System.Drawing.Size(75, 23);
            this.buttonFindTicket.TabIndex = 6;
            this.buttonFindTicket.Text = "Find";
            this.buttonFindTicket.UseVisualStyleBackColor = true;
            this.buttonFindTicket.Click += new System.EventHandler(this.buttonFindTicket_Click);
            // 
            // PlaneSeatName
            // 
            this.PlaneSeatName.DataPropertyName = "PlaneSeatName";
            this.PlaneSeatName.HeaderText = "PlaneSeatName";
            this.PlaneSeatName.Name = "PlaneSeatName";
            this.PlaneSeatName.ReadOnly = true;
            // 
            // PlaneSeat_ID
            // 
            this.PlaneSeat_ID.DataPropertyName = "PlaneSeat_ID";
            this.PlaneSeat_ID.HeaderText = "PlaneSeat_ID";
            this.PlaneSeat_ID.Name = "PlaneSeat_ID";
            this.PlaneSeat_ID.ReadOnly = true;
            // 
            // SeatClass_ID
            // 
            this.SeatClass_ID.DataPropertyName = "SeatClass_ID";
            this.SeatClass_ID.HeaderText = "SeatClass_ID";
            this.SeatClass_ID.Name = "SeatClass_ID";
            this.SeatClass_ID.ReadOnly = true;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 324);
            this.Controls.Add(this.buttonFindTicket);
            this.Controls.Add(this.dataGridSeats);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridTickets);
            this.Controls.Add(this.dataGridPassanger);
            this.Controls.Add(this.txBxTicketId);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPassanger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTickets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSeats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planeSeatBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txBxTicketId;
        private System.Windows.Forms.DataGridView dataGridPassanger;
        private System.Windows.Forms.DataGridViewTextBoxColumn passengerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isRegisteredDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource passengerBindingSource;
        private System.Windows.Forms.DataGridView dataGridTickets;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticketIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planeSeatIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passangerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridSeats;
        private System.Windows.Forms.BindingSource planeSeatBindingSource;
        private System.Windows.Forms.Button buttonFindTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlaneSeatName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlaneSeat_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeatClass_ID;
    }
}