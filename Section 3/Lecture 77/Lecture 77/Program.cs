//Method overloading
var medicalAppointment = new MedicalAppointment("John Smith", new DateTime(2023, 4, 3));

//overwrite month and day
//medicalAppointment.Reschedule(5, 1);
medicalAppointment.OverwriteMonthAndDay(5, 1);

//adds a given number of months and days
//medicalAppointment.Reschedule(1, 2); 
medicalAppointment.MoveByMonthsAndDays(1, 2);

Console.ReadKey();

class MedicalAppointment
{
    private string _patientName;
    private DateTime _date;

    public MedicalAppointment(string patientName, DateTime date)
    {
        _patientName = patientName;
        _date = date;
    }

    public void Reschedule(DateTime date)
    {
        _date = date;
    }

    //as long as the compiler can tell the difference by type, count, or order of parameters, it is fine
    //always make sure overridden methods are distinguishable 
    //public void Reschedule(int month, int day)
    //{
    //    _date = new DateTime(_date.Year, month, day);
    //}
    public void OverwriteMonthAndDay(int month, int day)
    {
        _date = new DateTime(_date.Year, month, day);
    }

    //public void Reschedule(int monthsToAdd, int daysToAdd)
    //{
    //    _date = new DateTime(_date.Year, _date.Month + monthsToAdd, _date.Day + daysToAdd);
    //}
    public void MoveByMonthsAndDays(int monthsToAdd, int daysToAdd)
    {
        _date = new DateTime(_date.Year, _date.Month + monthsToAdd, _date.Day + daysToAdd);
    }
}