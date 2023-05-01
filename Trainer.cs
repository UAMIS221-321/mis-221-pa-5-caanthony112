namespace mis_221_pa_5_caanthony112
{
    public class Trainer
    {
        private int trainerId;

        private string trainerName;

        private string mailingAddress;

        private string trainerEmail;

        static private int count;

        public Trainer() {

        }

        public Trainer(int trainerId, string trainerName, string mailingAddress, string trainerEmail) {
            this.trainerId = trainerId;
            this.trainerName = trainerName;
            this.mailingAddress = mailingAddress;
            this.trainerEmail = trainerEmail;
        }
// i still do not understand the point of constrcutors... ask about this ^

        public void SetTrainerID(int trainerId) {
            this.trainerId = trainerId;
        }

        public int GetTrainerID() {
            return trainerId;
        }

        public void SetTrainerName(string trainerName) {
            this.trainerName = trainerName;
        }

        public string GetTrainerName() {
            return trainerName;
        }

        public void SetMailingAddress(string mailingAddress) {
            this.mailingAddress = mailingAddress;
        }

        public string GetMailingAddress() {
            return mailingAddress;
        }

        public void SetTrainerEmail(string trainerEmail) {
            this.trainerEmail = trainerEmail;
        }

        public string GetTrainerEmail() {
            return trainerEmail;
        }

        public void ToString(){
            
        }

        public string ToFile(){
            return $"{trainerId}#{trainerName}#{mailingAddress}#{trainerEmail}";
        }

        static public void SetCount(int count) {
            Trainer.count = count;
        }

        static public int GetCount() {
            return Trainer.count;
        }
// ask for some explanation on why I have to return Trainer.Count instead of just count

        static public void IncCount() {
            Trainer.count++;
        }

        static public void DecCount() {
            Trainer.count--;
        }






    }
}