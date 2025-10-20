static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription) => Convert.ToDateTime(appointmentDateDescription);

    public static bool HasPassed(DateTime appointmentDate) =>  appointmentDate < DateTime.Now;


    public static bool IsAfternoonAppointment(DateTime appointmentDate) => appointmentDate.Hour >= 12 && appointmentDate.Hour < 18;

    public static string Description(DateTime appointmentDate)
        => $"You have an appointment on {appointmentDate.ToString("M/d/yyyy h:mm:ss tt")}.";

    public static DateTime AnniversaryDate() =>  new DateTime(DateTime.Now.Year, 09,15,0,0,0);
}
