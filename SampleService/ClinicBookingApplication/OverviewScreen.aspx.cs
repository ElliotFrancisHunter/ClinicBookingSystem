using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClinicBookingApplication
{
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;
    using System.EnterpriseServices;
    

    using ClinicBookingApplication.ClinicBookingService;

    using Microsoft.Ajax.Utilities;

    /// <summary>
    /// The User interface.
    /// </summary>
    public partial class WebForm1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
            {
                return;
            }

            this.MakePatientTable();
            this.MakeStartDateAndTimeTable();
            this.MakeDurationTable();
            this.MakeClinicTable();
            this.MakeUrgencyTable();
            this.MakeAppointmentTypeTable();
            this.MakeCurrentAppointmentsTable();
        }

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

            this.DropDownList1.DataSource = dataTable;
            this.DropDownList1.DataTextField = "Patient Name";
            this.DropDownList1.DataValueField = "PatientNo";
            this.DropDownList1.DataBind();
        }

        public void MakeStartDateAndTimeTable()
        {
            var dataTable = new DataTable();
            dataTable.Columns.Add("AppointmentID");
            dataTable.Columns.Add("StartDateTime");
            var appointmentList = new ClinicBookingService.SampleServiceClient().GetAppointments();

            foreach (var appointment in appointmentList)
            {
                dataTable.Rows.Add(appointment.AppointmentId, appointment.StartDateTime);
            }

            this.DropDownList2.DataSource = dataTable;
            this.DropDownList2.DataTextField = "StartDateTime";
            this.DropDownList2.DataValueField = "AppointmentID";
            this.DropDownList2.DataBind();
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

            this.DropDownList3.DataSource = dataTable;
            this.DropDownList3.DataTextField = "AppointmentLength";
            this.DropDownList3.DataValueField = "DurationID";
            this.DropDownList3.DataBind();

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

            this.DropDownList4.DataSource = dataTable;
            this.DropDownList4.DataTextField = "CodeDescription";
            this.DropDownList4.DataValueField = "ClinicID";
            this.DropDownList4.DataBind();
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

            this.DropDownList5.DataSource = dataTable;
            this.DropDownList5.DataTextField = "UrgencyDescriptor";
            this.DropDownList5.DataValueField = "UrgencyID";
            this.DropDownList5.DataBind();
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

            this.DropDownList6.DataSource = dataTable;
            this.DropDownList6.DataTextField = "TypeDescriptor";
            this.DropDownList6.DataValueField = "AppointmentTypeID";
            this.DropDownList6.DataBind();
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
            this.SearchResultsGrid.DataSource = dataTable;
            this.SearchResultsGrid.DataBind();
        }

        protected void SearchByTagButton_Click(object sender, EventArgs e)
        {
           
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void SearchResultsGrid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}