namespace mis_221_pa_5_caanthony112
{
    public class ReportRepo
    {
        
        private Booking[] bookings;
        public void PreviousSessions() {
            string curr = bookings[0].GetCustomerEmail();
            int sessionId = bookings[0].GetSessionId();
            string customerName = bookings[0].GetCustomerName();
            int trainingDate = bookings[0].GetTrainingDate();
            int trainerId = bookings[0].GetTrainerId();
            string trainerName = bookings[0].GetTrainerName();
            for(int i = 1; i < Booking.GetCount(); i++) {
                if(bookings[i].GetCustomerEmail() == curr){
                    curr = bookings[i].GetCustomerEmail();
                    sessionId = bookings[i].GetSessionId();
                    customerName = bookings[i].GetCustomerName();
                    trainingDate = bookings[i].GetTrainingDate();
                    trainerId = bookings[i].GetTrainerId();
                    trainerName = bookings[i].GetTrainerName();
                }
                else {
                    ProcessBreak(ref curr, ref sessionId, ref customerName, ref trainingDate, ref trainerId, ref trainerName, bookings[i]);
                }
            }
            ProcessBreak(curr, sessionId, customerName, trainingDate, trainerId, trainerName);
        }

        public void ProcessBreak(ref string curr, ref int sessionId, ref string customerName, ref int trainingDate, ref int trainerId, ref string trainerName, Booking newBooking){
            System.Console.WriteLine($"{sessionId}\t{customerName}\t{curr}\t{trainingDate}\t{trainerId}\t{trainerName}");
            curr = newBooking.GetCustomerEmail();
            sessionId = newBooking.GetSessionId();
            customerName = newBooking.GetCustomerName();
            trainingDate = newBooking.GetTrainingDate();
            trainerId = newBooking.GetTrainerId();
            trainerName = newBooking.GetTrainerName();
        }

        public void ProcessBreak(string curr, int sessionId, string customerName, int trainingDate, int trainerId, string trainerName){
            System.Console.WriteLine($"{sessionId}\t{customerName}\t{curr}\t{trainingDate}\t{trainerId}\t{trainerName}");
        }

        public void DateByCustomer() {
            string cust = bookings[0].GetCustomerName();
            int date = bookings[0].GetTrainingDate();
            for(int i = 1; i < Booking.GetCount(); i++) {
                if(bookings[i].GetCustomerName() == cust) {
                    cust = bookings[i].GetCustomerName();
                    date = bookings[i].GetTrainingDate();
                    System.Console.WriteLine();
                }
                else {
                    Break();
                }
            }
        }

        public void Break(){

        }
    }
}