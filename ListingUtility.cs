namespace mis_221_pa_5_caanthony112
{
    public class ListingUtility
    {
        private Listing[] listings;

        public ListingUtility(Listing[] listings) {
            this.listings = listings;
        }

        public void GetAllListings() {
            Listing.SetCount(0);
            System.Console.WriteLine("Please enter the Listing ID or STOP to stop");
            string userInput = Console.ReadLine();
            while(userInput.ToUpper() != "STOP"){
                listings[Listing.GetCount()] = new Listing();
                listings[Listing.GetCount()].SetListingId(userInput);

                System.Console.WriteLine("Please enter the Trainer name");
                listings[Listing.GetCount()].SetTrainerName(Console.ReadLine());

                System.Console.WriteLine("Please enter the date of session");
                listings[Listing.GetCount()].SetSessionDate(int.Parse(Console.ReadLine()));

                System.Console.WriteLine("Please enter the time of session");
                listings[Listing.GetCount()].SetSessionTime(int.Parse(Console.ReadLine()));

                System.Console.WriteLine("Please enter the cost of session");
                listings[Listing.GetCount()].SetSessionCost(int.Parse(Console.ReadLine()));

                // System.Console.WriteLine("Is the listing taken? Yes or no");
                // listings[Listing.GetCount()].IfListingTaken(Console.ReadLine());

                Listing.IncCount();

                Save();

                System.Console.WriteLine("Please enter the listing ID or STOP to stop");
                userInput = Console.ReadLine();
            }

        }

        public void Save() {
            StreamWriter outFile = new StreamWriter("listings.txt");

            for(int i = 0; i < Listing.GetCount(); i++) {
                outFile.WriteLine(listings[i].ToFile());
            }
            outFile.Close();
        }
        private int Find(string searchVal) {
            for(int i = 0; i < Listing.GetCount(); i++){
                if(listings[i].GetListingId().ToUpper() == searchVal) {
                    return i;
                }
            }
            return -1;
        }
        
        // why is this private?

        public void EditListing() {
            System.Console.WriteLine("What is the Listing ID that you would like to edit?");
            string searchVal = Console.ReadLine();
            int foundIndex = Find(searchVal);
            if(foundIndex != -1){
                System.Console.WriteLine("Please enter the new listing ID");
                listings[foundIndex].SetListingId(Console.ReadLine());
                System.Console.WriteLine("Please enter the new trainer name");
                listings[foundIndex].SetTrainerName(Console.ReadLine());
                System.Console.WriteLine("Please enter the new date of session");
                listings[foundIndex].SetSessionDate(int.Parse(Console.ReadLine()));
                System.Console.WriteLine("Please enter the new time of session");
                listings[foundIndex].SetSessionTime(int.Parse(Console.ReadLine()));
                System.Console.WriteLine("Please enter the new cost of session");
                listings[foundIndex].SetSessionCost(int.Parse(Console.ReadLine()));
                // System.Console.WriteLine("Is the listing taken? Yes or no");
                // listings[foundIndex].IfListingTaken(Console.ReadLine());

                Save();
            }
            else {
                System.Console.WriteLine("Listing not found");
            }
        }

        public void GetListingsFromFile() {
            StreamReader inFile = new StreamReader("listings.txt");

            Listing.SetCount(0);
            string line = inFile.ReadLine();
            while(line != null){
                string[] temp = line.Split("#");
                listings[Listing.GetCount()] = new Listing(temp[0], temp[1], int.Parse(temp[2]), int.Parse(temp[3]), int.Parse(temp[4])); //, temp[5])
                Listing.IncCount();
                line = inFile.ReadLine();
            }
            inFile.Close();
        }

        public void DeleteListing(){
            
        }
    }
}