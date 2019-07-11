
namespace ClinicBookingApplication
{
    using System;
    using System.Data;
    using System.Web.UI;
    using ClinicBookingApplication.ClinicBookingService;

    /// <summary>
    /// The User interface.
    /// </summary>
    public partial class WebForm1 : Page
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
            {
                return;
            }

            this.MakePatientTable();
            this.MakeDurationTable();
            this.MakeClinicTable();
            this.MakeUrgencyTable();
            this.MakeAppointmentTypeTable();
            this.MakeCurrentAppointmentsTable();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void MakePatientTable()
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("PatientNo");
            dataTable.Columns.Add("Patient Name");
            var patientList = new ClinicBookingService.SampleServiceClient().GetPatients();

            foreach (var patient in patientList)
            {
                dataTable.Rows.Add(patient.PatientId, string.Join(" ", patient.FirstName, patient.Surname));
            }

            this.PatientDropDownList.DataSource = dataTable;
            this.PatientDropDownList.DataTextField = "Patient Name";
            this.PatientDropDownList.DataValueField = "PatientNo";
            this.PatientDropDownList.DataBind();
        }

        public void MakeDurationTable()
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("DurationID");
            dataTable.Columns.Add("AppointmentLength");
            var durationList = new ClinicBookingService.SampleServiceClient().GetAllAppointmentDurationData();

            foreach (var duration in durationList)
            {
                dataTable.Rows.Add(duration.DurationId, duration.AppointmentLength);
            }

            this.DurationDropDownList.DataSource = dataTable;
            this.DurationDropDownList.DataTextField = "AppointmentLength";
            this.DurationDropDownList.DataValueField = "DurationID";
            this.DurationDropDownList.DataBind();

        }

        public void MakeClinicTable()
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("ClinicID");
            dataTable.Columns.Add("CodeDescription");
            var clinicList = new ClinicBookingService.SampleServiceClient().GetClinics();

            foreach (var clinic in clinicList)
            {
                dataTable.Rows.Add(clinic.ClinicId, clinic.CodeDescription);
            }

            this.ClinicDropDownList.DataSource = dataTable;
            this.ClinicDropDownList.DataTextField = "CodeDescription";
            this.ClinicDropDownList.DataValueField = "ClinicID";
            this.ClinicDropDownList.DataBind();
        }

        public void MakeUrgencyTable()
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("UrgencyID");
            dataTable.Columns.Add("UrgencyDescriptor");
            var urgencyList = new ClinicBookingService.SampleServiceClient().GetUrgencies();

            foreach (var urgency in urgencyList)
            {
                dataTable.Rows.Add(urgency.UrgencyId, urgency.UrgencyDescriptor);
            }

            this.UrgencyDropDownList.DataSource = dataTable;
            this.UrgencyDropDownList.DataTextField = "UrgencyDescriptor";
            this.UrgencyDropDownList.DataValueField = "UrgencyID";
            this.UrgencyDropDownList.DataBind();
        }

        public void MakeAppointmentTypeTable()
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("AppointmentTypeID");
            dataTable.Columns.Add("TypeDescriptor");
            var appointmentTypeList = new ClinicBookingService.SampleServiceClient().GetAppointmentTypes();

            foreach (var type in appointmentTypeList)
            {
                dataTable.Rows.Add(type.AppointmentTypeId, type.TypeDescriptor);
            }

            this.AppointmentTypeDropDownList.DataSource = dataTable;
            this.AppointmentTypeDropDownList.DataTextField = "TypeDescriptor";
            this.AppointmentTypeDropDownList.DataValueField = "AppointmentTypeID";
            this.AppointmentTypeDropDownList.DataBind();
        }

        public void MakeCurrentAppointmentsTable()
        {
            var dataTable = new DataTable();
            var appointments = new ClinicBookingService.SampleServiceClient().GetAppointments();
            dataTable.Columns.AddRange(new DataColumn[6]
                                           {
                                               new DataColumn("AppointmentID", typeof(string)),
                                               new DataColumn("IsActive", typeof(bool)),
                                               new DataColumn("PatientID", typeof(string)),
                                               new DataColumn("StartDateTime", typeof(string)),
                                               new DataColumn("DurationID", typeof(string)),
                                               new DataColumn("ClinicID", typeof(string)),
                                           });
             
            foreach (var appointment in appointments)
            {
                dataTable.Rows.Add(
                    appointment.AppointmentId,
                    appointment.IsActive,
                    string.Join(" ", appointment.Patient.FirstName, appointment.Patient.Surname),
                    appointment.StartDateTime,
                    appointment.Duration.AppointmentLength,
                    appointment.Clinic.CodeDescription);
            }
            ////foreach (var appointment in appointments)
            ////{
            ////    if (appointment.IsActive == false)
            ////    {
                    
            ////    }
            ////}
            this.SearchResultsGrid.DataSource = dataTable;
            this.SearchResultsGrid.DataBind();
        }

        protected void NewAppointmentButtonClick(object sender, EventArgs e)
        {
            var createdAppointment = new AppointmentDataContract
                                         {
                                             IsActive        = true,
                                             Patient         = new Patient { PatientId = this.PatientDropDownList.SelectedValue },
                                             StartDateTime   = Convert.ToDateTime(this.DateTimeTextBox.Text),
                                             Duration        = new AppointmentDuration { DurationId = this.DurationDropDownList.SelectedValue },
                                             Clinic          = new Clinic { CodeDescription = this.ClinicDropDownList.SelectedValue },
                                             Urgency         = new AppointmentUrgency { UrgencyId = this.UrgencyDropDownList.SelectedValue },
                                             AppointmentType = new AppointmentType { AppointmentTypeId = this.AppointmentTypeDropDownList.SelectedValue }
                                         };

        }

        protected void SearchResultsGrid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DateTimeTextBoxTextChanged(object sender, EventArgs e)
        {
            var inputDateTime = Convert.ToDateTime(this.DateTimeTextBox.Text);
        }

        protected void DateTimeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void SearchByTagTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}