// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OverviewScreen.aspx.cs" company="ServelecHsc">
//   Elliot Hunter 
// </copyright>
// <summary>
//   The User interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace ClinicBookingApplication
{
    using System;
    using System.Data;
    using System.Globalization;
    using System.Runtime.Serialization;
    using System.Web.UI;
    using ClinicBookingApplication.ClinicBookingService;

    /// <summary>
    /// The User interface.
    /// </summary>
    public partial class WebForm1 : Page
    {
        /// <summary>
        /// A function that creates a data table for all patients. This is displayed in a drop down.
        /// </summary>
        public void MakePatientTable()
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("PatientNo");
            dataTable.Columns.Add("Patient Name");
            var patientList = new SampleServiceClient().GetPatients();

            foreach (var patient in patientList)
            {
                dataTable.Rows.Add(patient.PatientId, string.Join(" ", patient.FirstName, patient.Surname));
            }

            this.PatientDropDownList.DataSource = dataTable;
            this.PatientDropDownList.DataTextField = "Patient Name";
            this.PatientDropDownList.DataValueField = "PatientNo";
            this.PatientDropDownList.DataBind();
        }

        /// <summary>
        /// Creates data table for all appointment durations stored on database.
        /// </summary>
        public void MakeDurationTable()
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("DurationID");
            dataTable.Columns.Add("AppointmentLength");
            var durationList = new SampleServiceClient().GetAllAppointmentDurationData();

            foreach (var duration in durationList)
            {
                dataTable.Rows.Add(duration.DurationId, duration.AppointmentLength);
            }

            this.DurationDropDownList.DataSource = dataTable;
            this.DurationDropDownList.DataTextField = "AppointmentLength";
            this.DurationDropDownList.DataValueField = "DurationID";
            this.DurationDropDownList.DataBind();
        }

        /// <summary>
        /// Creates data table for all clinics stored on database.
        /// </summary>
        public void MakeClinicTable()
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("ClinicID");
            dataTable.Columns.Add("CodeDescription");
            var clinicList = new SampleServiceClient().GetClinics();

            foreach (var clinic in clinicList)
            {
                dataTable.Rows.Add(clinic.ClinicId, clinic.CodeDescription);
            }

            this.ClinicDropDownList.DataSource = dataTable;
            this.ClinicDropDownList.DataTextField = "CodeDescription";
            this.ClinicDropDownList.DataValueField = "ClinicID";
            this.ClinicDropDownList.DataBind();
        }

        /// <summary>
        /// Creates data table for list of specialties linked to clinics ///TODO ACTUALLY MAKE THIS FUNCTION AS DESIRED ///
        /// </summary>
        public void MakeClinicSpecialtyTable()
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("ClinicSpecialtyID");
            dataTable.Columns.Add("Clinic");
            dataTable.Columns.Add("Specialty");

            var clinicSpecialtyList = new SampleServiceClient().GetClinicSpecialties();

            foreach (var clinicSpecialty in clinicSpecialtyList)
            {
                dataTable.Rows.Add(clinicSpecialty.ClinicSpecialtyId, clinicSpecialty.Clinic, clinicSpecialty.Specialty);
            }
        }

        /// <summary>
        /// Creates data table for all appointment urgencies stored on database.
        /// </summary>
        public void MakeUrgencyTable()
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("UrgencyID");
            dataTable.Columns.Add("UrgencyDescriptor");
            var urgencyList = new SampleServiceClient().GetUrgencies();

            foreach (var urgency in urgencyList)
            {
                dataTable.Rows.Add(urgency.UrgencyId, urgency.UrgencyDescriptor);
            }

            this.UrgencyDropDownList.DataSource = dataTable;
            this.UrgencyDropDownList.DataTextField = "UrgencyDescriptor";
            this.UrgencyDropDownList.DataValueField = "UrgencyID";
            this.UrgencyDropDownList.DataBind();
        }

        /// <summary>
        /// Creates data table for all appointment types stored on database.
        /// </summary>
        public void MakeAppointmentTypeTable()
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("AppointmentTypeID");
            dataTable.Columns.Add("TypeDescriptor");
            var appointmentTypeList = new SampleServiceClient().GetAppointmentTypes();

            foreach (var type in appointmentTypeList)
            {
                dataTable.Rows.Add(type.AppointmentTypeId, type.TypeDescriptor);
            }

            this.AppointmentTypeDropDownList.DataSource = dataTable;
            this.AppointmentTypeDropDownList.DataTextField = "TypeDescriptor";
            this.AppointmentTypeDropDownList.DataValueField = "AppointmentTypeID";
            this.AppointmentTypeDropDownList.DataBind();
        }

        /// <summary>
        /// Function that builds the data table that stores all appointments stored in database ready for display on frontend.
        /// </summary>
        public void MakeCurrentAppointmentsTable()
        {
            var dataTable = new DataTable();
            var appointments = new SampleServiceClient().GetAppointments();
            dataTable.Columns.AddRange(new[]
                                           {
                                               new DataColumn("AppointmentID", typeof(string)),
                                               new DataColumn("IsActive", typeof(bool)),
                                               new DataColumn("PatientID", typeof(string)),
                                               new DataColumn("StartDateTime", typeof(string)),
                                               new DataColumn("DurationID", typeof(string)),
                                               new DataColumn("ClinicID", typeof(string)),
                                               new DataColumn("SpecialtyID", typeof(string))
                                           });
             
            foreach (var appointment in appointments)
            {
                dataTable.Rows.Add(
                    appointment.AppointmentId,
                    appointment.IsActive,
                    string.Join(" ", appointment.Patient.FirstName, appointment.Patient.Surname),
                    appointment.StartDateTime,
                    appointment.Duration.AppointmentLength,
                    appointment.Clinic.CodeDescription,
                    appointment.Specialty.CodeDescription);
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

        /// <summary>
        /// All functions handled on loading the page.
        /// </summary>
        /// <param name="sender">
        /// The sender object that performs actions.
        /// </param>
        /// <param name="e">
        /// The event that acts as a trigger. In this case loading a page.
        /// </param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
            {
                return;
            }

            const string ScriptRef = "waitFunction";
            var scriptType = this.GetType();
            var manager = Page.ClientScript;

            manager.RegisterStartupScript(scriptType, ScriptRef, string.Empty);
            this.MakePatientTable();
            this.MakeDurationTable();
            this.MakeClinicTable();
            this.MakeUrgencyTable();
            this.MakeAppointmentTypeTable();
            this.MakeCurrentAppointmentsTable();
        }

        /// <summary>
        /// The function that handles all actions taken when button is clicked, in this case creating a new appointment and adding it to the database.
        /// </summary>
        /// <param name="sender">
        /// The object that performs required actions.
        /// </param>
        /// <param name="e">
        /// The trigger. Clicking the button.
        /// </param>
        protected void NewAppointmentButtonClick(object sender, EventArgs e)
        {
            string[] formats = { "dd/MM/yyyy HH:mm:ss", "dd MM yyyy HH:mm:ss" };
            var input = this.DateTimeTextBox.Text;
            try
            {
                DateTime textBoxDateTime;
                DateTime.TryParseExact(
                    input,
                    formats,
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out textBoxDateTime);
            }
            catch (Exception)
            {
                throw;
            }              
            new SampleServiceClient().SetAppointment(
                true,
                this.PatientDropDownList.SelectedValue,
                Convert.ToDateTime(this.DateTimeTextBox.Text),
                this.DurationDropDownList.SelectedValue,
                this.ClinicDropDownList.SelectedValue,
                this.UrgencyDropDownList.SelectedValue,
                this.AppointmentTypeDropDownList.SelectedValue);

            this.MakeCurrentAppointmentsTable();
        }

        /// <summary>
        /// Functions carried out once value in drop down is changed.
        /// </summary>
        /// <param name="sender">
        /// The sender object that performs required actions.
        /// </param>
        /// <param name="e">
        /// The events that acts as a trigger.
        /// </param>
        protected void DropDownList1SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Function that handles any actions taken when index of grid changed.
        /// </summary>
        /// <param name="sender">
        /// The object that initiates actions.
        /// </param>
        /// <param name="e">
        /// The event trigger.
        /// </param>
        protected void SearchResultsGridSelectedIndexChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Function that handles any actions taken when contents of text box is changed.
        /// </summary>
        /// <param name="sender">
        /// The object that initiates actions.
        /// </param>
        /// <param name="e">
        /// The event trigger.
        /// </param>
        protected void DateTimeTextBoxTextChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Function that handles any actions taken when contents of search box is changed.
        /// </summary>
        /// <param name="sender">
        /// The object that initiates actions.
        /// </param>
        /// <param name="e">
        /// The event trigger.
        /// </param>
        protected void SearchByTagTextBoxTextChanged(object sender, EventArgs e)
        {
        }
    }
}