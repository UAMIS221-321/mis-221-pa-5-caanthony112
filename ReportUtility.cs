namespace mis_221_pa_5_caanthony112
{
    public class ReportUtility
    {

        private Booking[] bookings;

        public ReportUtility(Booking[] bookings) {
            this.bookings = bookings;
        }
        public void GetAllBookingsFromFile() {
            StreamReader inFile = new StreamReader("transactions.txt");
            Booking.SetCount(0);
            string line = inFile.ReadLine();
            while(line != null){
                string[] temp = line.Split("#");
                bookings[Booking.GetCount()] = new Booking(int.Parse(temp[0]), temp[1], temp[2], int.Parse(temp[3]), int.Parse(temp[4]), temp[5]);
                Booking.IncCount();
                line = inFile.ReadLine();
            }

            inFile.Close();
        }
    }
}