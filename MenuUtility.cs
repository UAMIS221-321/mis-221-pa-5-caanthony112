namespace mis_221_pa_5_caanthony112
{
    public class MenuUtility
    {
        private TrainerUtility trainerUtility;

        private ListingUtility listingUtility;

        private BookingUtility bookingUtility;

        private ReportUtility reportUtility;

        private ReportRepo reportRepo;

        public MenuUtility() {

        }

        public MenuUtility(TrainerUtility trainerUtility, ListingUtility listingUtility, BookingUtility bookingUtility, ReportUtility reportUtility, ReportRepo reportRepo){
            this.trainerUtility = trainerUtility;
            this.listingUtility = listingUtility;
            this.bookingUtility = bookingUtility;
            this.reportUtility = reportUtility;
            this.reportRepo = reportRepo;
        }
        public void TrainerMenu() {
            Console.Clear();
            Console.WriteLine("=========================================");
            Console.WriteLine("|           TRAINER MANAGEMENT          |");
            Console.WriteLine("=========================================");
            Console.WriteLine("|    Please choose an option:           |");
            Console.WriteLine("|    1. Add Trainers                    |");
            Console.WriteLine("|    2. Edit Trainers                   |");
            Console.WriteLine("|    3. Delete Trainers                 |");
            Console.WriteLine("=========================================");


            int option = int.Parse(Console.ReadLine());

            switch (option) {
            case 1:
                trainerUtility.GetAllTrainers();
                break;
            case 2:
                trainerUtility.GetTrainersFromFile();
                trainerUtility.EditTrainer();
                break;
            case 3:
                trainerUtility.DeleteTrainer();
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
            }
        }
        public void ListingMenu() {
            Console.Clear();
            Console.WriteLine("=========================================");
            Console.WriteLine("|            LISTING MANAGEMENT         |");
            Console.WriteLine("=========================================");
            Console.WriteLine("|    Please choose an option:           |");
            Console.WriteLine("|    Enter 1 to Add Listings            |");
            Console.WriteLine("|    Enter 2 to Edit Listings           |");
            Console.WriteLine("|    Enter 3 to Delete Listings         |");
            Console.WriteLine("=========================================");

            int option = int.Parse(Console.ReadLine());

            switch(option) {
                case 1:
                    listingUtility.GetAllListings();
                    break;
                case 2:
                    listingUtility.GetListingsFromFile();
                    listingUtility.EditListing();
                    break;
                case 3:
                    listingUtility.DeleteListing();
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            }
        }
        public void BookingMenu()
        {
            Console.Clear();
            Console.WriteLine("=========================================");
            Console.WriteLine("|        CUSTOMER BOOKING SYSTEM        |");
            Console.WriteLine("=========================================");
            Console.WriteLine("|    Please choose an option:           |");
            Console.WriteLine("|    1. View Available Training Session |");
            Console.WriteLine("|    2. Book a Session                  |");
            Console.WriteLine("|    3. Update Status                   |");
            Console.WriteLine("=========================================");
    
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    bookingUtility.AvailableSession();
                    break;
                case 2:
                    bookingUtility.GetAllBookings();
                    break;
                case 3:
                    bookingUtility.GetBookingsFromFile();
                    bookingUtility.EditBooking();
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }

        public void ReportMenu() {
            Console.Clear();
            Console.WriteLine("=========================================");
            Console.WriteLine("|        CUSTOMER REPORT SYSTEM         |");
            Console.WriteLine("=========================================");
            Console.WriteLine("|    Please choose an option:           |");
            Console.WriteLine("|    1. Individual Customer Sessions    |");
            Console.WriteLine("|    2. Historical Customer Sessions    |");
            Console.WriteLine("|    3. Historical Revenue Report       |");
            Console.WriteLine("=========================================");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    reportUtility.GetAllBookingsFromFile();
                    reportRepo.PreviousSessions();
                    break;
                case 2:
                    System.Console.WriteLine("Not done");
                    break;
                case 3:
                    System.Console.WriteLine("Not done");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }

        public void SayInvalid() {
            System.Console.WriteLine("Invalid!");
            PauseAction();
        }

        public void PauseAction() {
            System.Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }

        public void IntroMenu()
        {
            Console.WriteLine("Train like a Champion Fitness!");
            Console.WriteLine(@"
             __        __   _                            _ 
             \ \      / /__| | ___ ___  _ __ ___   ___  | |
              \ \ /\ / / _ \ |/ __/ _ \| '_ ` _ \ / _ \ | |
               \ V  V /  __/ | (_| (_) | | | | | |  __/ |_|
                \_/\_/ \___|_|\___\___/|_| |_| |_|\___| (_)
            ");
        }       
    }
}
    