namespace mis_221_pa_5_caanthony112
{
    public class Booking
    {
        private int sessionId;

        private string customerName;

        private string customerEmail;

        private int trainingDate;

        private int trainerId; 

        private string trainerName;

        private bool isTaken;

        static private int count;

        public Booking() {

        }

        public Booking(int sessionId, string customerName, string customerEmail, int trainingDate, int trainerId, string trainerName, bool isTaken) {
            this.sessionId = sessionId;
            this.customerName = customerName;
            this.customerEmail = customerEmail;
            this.trainingDate = trainingDate;
            this.trainerId = trainerId;
            this.isTaken = isTaken;
        }

        public void SetSessionId(int sessionId) {
            this.sessionId = sessionId;
        }

        public int GetSessionId() {
            return sessionId;
        }

        public void SetCustomerName(string customerName) {
            this.customerName = customerName;
        }

        public string GetCustomerName() {
            return customerName;
        }

        public void SetCustomerEmail(string customerEmail) {
            this.customerEmail = customerEmail;
        }

        public string GetCustomerEmail() {
            return customerEmail;
        }

        public void SetTrainingDate(int trainingDate){
            this.trainingDate = trainingDate;
        }

        public int GetTrainingDate() {
            return trainingDate;
        }

        public void SetTrainerId(int trainerId) {
            this.trainerId = trainerId;
        }

        public int GetTrainerId() {
            return trainerId;
        }

        public void SetTrainerName(string trainerName) {
            this.trainerName = trainerName;
        }

        public string GetTrainerName() {
            return trainerName;
        }

        public bool IfBookingTaken() {
            return true;
        }

        static public void SetCount(int count){
            Booking.count = count;
        }

        static public int GetCount() {
            return Booking.count;
        }

        static public void IncCount() {
            Booking.count++;
        }

        public string ToFile(){
            return $"{sessionId}#{trainerName}#{customerEmail}#{trainingDate}#{trainerId}#{trainerName}#{isTaken}";
        }

        public void SetIsTaken(bool isTaken){
            this.isTaken = isTaken;
        }

    }
}