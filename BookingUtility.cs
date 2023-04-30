namespace mis_221_pa_5_caanthony112
{
    public class BookingUtility
    {
        private Booking[] bookings;

        public BookingUtility(Booking[] bookings) {
            this.bookings = bookings;
        }

        public void GetAllBookings() {
            Booking.SetCount(0);
            System.Console.WriteLine("Please enter the session id or 0 to stop");
            int userInput = int.Parse(Console.ReadLine());
            while(userInput != 0){
                bookings[Booking.GetCount()] = new Booking();
                bookings[Booking.GetCount()].SetSessionId(userInput);

                System.Console.WriteLine("Please enter the customer name");
                bookings[Booking.GetCount()].SetCustomerName(Console.ReadLine());

                System.Console.WriteLine("Please enter the customer email");
                bookings[Booking.GetCount()].SetCustomerEmail(Console.ReadLine());

                System.Console.WriteLine("Please enter the training date");
                bookings[Booking.GetCount()].SetTrainingDate(int.Parse(Console.ReadLine()));

                System.Console.WriteLine("Please enter the trainer ID");
                bookings[Booking.GetCount()].SetTrainerId(int.Parse(Console.ReadLine()));

                System.Console.WriteLine("Please enter the trainer name");
                bookings[Booking.GetCount()].SetTrainerName(Console.ReadLine());


                // System.Console.WriteLine("Is the listing taken? Yes or no");
                // bookings[Booking.GetCount()].IfListingTaken(Console.ReadLine());

                Booking.IncCount();

                Save();

                System.Console.WriteLine("Please enter the session ID or 0 to stop");
                userInput = int.Parse(Console.ReadLine());
            }

        }

        public void Save() {
            StreamWriter outFile = new StreamWriter("transactions.txt");

            for(int i = 0; i < Booking.GetCount(); i++) {
                outFile.WriteLine(bookings[i].ToFile());
            }
            outFile.Close();
        }

         private int Find(int searchVal) {
            for(int i = 0; i < Booking.GetCount(); i++){
                if(bookings[i].GetSessionId() == searchVal) {
                    return i;
                }
            }
            return -1;
        }

        public void EditBooking() {
            System.Console.WriteLine("What is the session ID that you would like to edit?");
            int searchVal = int.Parse(Console.ReadLine());
            int foundIndex = Find(searchVal);
            if(foundIndex != -1){
                System.Console.WriteLine("Please enter the customer name");
                bookings[foundIndex].SetCustomerName(Console.ReadLine());

                System.Console.WriteLine("Please enter the customer email");
                bookings[foundIndex].SetCustomerEmail(Console.ReadLine());

                System.Console.WriteLine("Please enter the training date");
                bookings[foundIndex].SetTrainingDate(int.Parse(Console.ReadLine()));

                System.Console.WriteLine("Please enter the trainer ID");
                bookings[foundIndex].SetTrainerId(int.Parse(Console.ReadLine()));

                System.Console.WriteLine("Please enter the trainer name");
                bookings[foundIndex].SetTrainerName(Console.ReadLine());

                Save();
            }
            else {
                System.Console.WriteLine("Booking not found");
            }
        }

        public void GetBookingsFromFile() {
            StreamReader inFile = new StreamReader("transactions.txt");

            Booking.SetCount(0);
            string line = inFile.ReadLine();
            while(line != null){
                string[] temp = line.Split("#");
                bookings[Booking.GetCount()] = new Booking(int.Parse(temp[0]), temp[1], temp[2], int.Parse(temp[3]), int.Parse(temp[4]), temp[5]); //, temp[5])
                Booking.IncCount();
                line = inFile.ReadLine();
            }
            inFile.Close();
        }

        public void AvailableSession(){
            
        }
    }
}