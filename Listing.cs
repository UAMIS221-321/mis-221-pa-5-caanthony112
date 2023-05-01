namespace mis_221_pa_5_caanthony112
{
    public class Listing
    {
        private string listingId;

        private string trainerName;

        private int sessionDate;

        private int sessionTime;

        private int sessionCost;

        private bool listingStatus;

        static private int count;

        public Listing() {

        }

        public Listing(string listingId, string trainerName, int sessionDate, int sessionTime, int sessionCost) {  // bool listingStatus
            this.listingId = listingId;
            this.trainerName = trainerName;
            this.sessionDate = sessionDate;
            this.sessionTime = sessionTime;
            this.sessionCost = sessionCost;
            // this.listingStatus = listingStatus;
        }
        // ask for an explanation on Constructors and what they are doing here
        public void SetListingId(string listingId) {
            this.listingId = listingId;
        }

        public string GetListingId() {
            return listingId;
        }

        public void SetTrainerName(string trainerName) {
            this.trainerName = trainerName;
        }

        public string GetTrainerName() {
            return trainerName;
        }

        public void SetSessionDate(int sessionDate) {
            this.sessionDate = sessionDate;
        }

        public int GetSessionDate() {
            return sessionDate;
        }

        public void SetSessionTime(int sessionTime) {
            this.sessionTime = sessionTime;
        }

        public int GetSessionTime() {
            return sessionTime;
        }

        public void SetSessionCost(int sessionCost) {
            this.sessionCost = sessionCost;
        }

        public int GetSessionCost() {
            return sessionCost;
        }

        public bool IfListingTaken() {
            return true;
        }

        static public void SetCount(int count){
            Listing.count = count;
        }

        static public int GetCount() {
            return Listing.count;
        }

        static public void IncCount() {
            Listing.count++;
        }

        public string ToFile(){
            return $"{listingId}#{trainerName}#{sessionDate}#{sessionTime}#{sessionCost}#{listingStatus}";
        }

        static public void DecCount() {
            Listing.count--;
        }
    }
}