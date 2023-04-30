namespace mis_221_pa_5_caanthony112
{
    public class TrainerUtility
    {
        private Trainer[] trainers;

        public TrainerUtility(Trainer[] trainers) {
            this.trainers = trainers;
        }

        public void GetAllTrainers() {
            Trainer.SetCount(0);
            System.Console.WriteLine("Please enter the Trainer ID or 0 to stop");
            int userInput = int.Parse(Console.ReadLine());
            while(userInput!= 0){
                trainers[Trainer.GetCount()] = new Trainer();
                trainers[Trainer.GetCount()].SetTrainerID(userInput);

                System.Console.WriteLine("Please enter the Trainer name");
                trainers[Trainer.GetCount()].SetTrainerName(Console.ReadLine());

                System.Console.WriteLine("Please enter the mailing address");
                trainers[Trainer.GetCount()].SetMailingAddress(Console.ReadLine());

                System.Console.WriteLine("Please enter the trainer email address");
                trainers[Trainer.GetCount()].SetTrainerEmail(Console.ReadLine());

                Trainer.IncCount();

                Save();

                System.Console.WriteLine("Please enter the trainer ID or 0 to stop");
                userInput = int.Parse(Console.ReadLine());
            }

        }

        public void Save() {
            StreamWriter outFile = new StreamWriter("trainers.txt");

            for(int i = 0; i < Trainer.GetCount(); i++) {
                outFile.WriteLine(trainers[i].ToFile());
            }
            outFile.Close();
        }

        private int Find(int searchNum) {
            for(int i = 0; i < Trainer.GetCount(); i++) {
                if(trainers[i].GetTrainerID() == searchNum) {
                    return i;
                }
            }
            return -1;
        }

        public void EditTrainer() {
            System.Console.WriteLine("What is the Trainer Identification of the trainer you would like to edit?");
            int searchNum = int.Parse(Console.ReadLine());

            int foundIndex = Find(searchNum);
            if(foundIndex != -1) {
                System.Console.WriteLine("Please enter the correct Trainer ID");
                trainers[foundIndex].SetTrainerID(int.Parse(Console.ReadLine()));
                System.Console.WriteLine("Please enter the correct trainer name");
                trainers[foundIndex].SetTrainerName(Console.ReadLine());
                System.Console.WriteLine("Please enter the correct mailing address");
                trainers[foundIndex].SetMailingAddress(Console.ReadLine());
                System.Console.WriteLine("Please enter the correct trainer email address");
                trainers[foundIndex].SetTrainerEmail(Console.ReadLine());

                Save();
            }
            else {
                System.Console.WriteLine("Trainer not found :(");
            }
        }

        public void GetTrainersFromFile(){
            StreamReader inFile = new StreamReader("trainers.txt");

            Trainer.SetCount(0);
            string line = inFile.ReadLine();
            while(line != null) {
                string[] temp = line.Split("#");
                trainers[Trainer.GetCount()]= new Trainer(int.Parse(temp[0]), temp[1], temp[2], temp[3]);
                Trainer.IncCount();
                line = inFile.ReadLine();
            }
            inFile.Close();
        }

        public void DeleteTrainer() {
            
        }

    
    }
}