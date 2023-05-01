using mis_221_pa_5_caanthony112;

Trainer[] trainers = new Trainer[999];
TrainerUtility trainingUtility = new TrainerUtility(trainers);

Listing[] listings = new Listing[999];
ListingUtility listingUtility = new ListingUtility(listings);

Booking[] bookings = new Booking[999];
BookingUtility bookingUtility = new BookingUtility(bookings);

ReportUtility reportUtility = new ReportUtility(bookings);

ReportRepo reportRepo = new ReportRepo();

User[] users = new User[999];
UserUtility userUtility = new UserUtility(users);

MenuUtility menuUtility = new MenuUtility(trainingUtility, listingUtility, bookingUtility, reportUtility, reportRepo, userUtility);

// main
// menuUtility.LoginMenu();
menuUtility.IntroMenu();
menuUtility.PauseAction();
int userChoice = GetUserChoice();
while(userChoice!=5) { 
    RouteEm(userChoice, menuUtility);
    userChoice = GetUserChoice();
}


// end main

static int GetUserChoice() { 
    InteractiveMenu();
    string userChoice = Console.ReadLine();
    if(IsValidChoice(userChoice)) {
        return int.Parse(userChoice);
}
else return 0;
}

static void InteractiveMenu() {
    Console.Clear();
    Console.WriteLine("===========================================");
    Console.WriteLine("|             WELCOME TO THE              |");
    Console.WriteLine("|          ONLINE BOOKING SYSTEM          |");
    Console.WriteLine("===========================================");
    Console.WriteLine("|  Enter 1 to Manage Trainer Data         |");
    Console.WriteLine("|  Enter 2 to Manage Listing Data         |");
    Console.WriteLine("|  Enter 3 to Manage Customer Booking Data|");
    Console.WriteLine("|  Enter 4 to Run Reports                 |");
    Console.WriteLine("|  Enter 5 to Exit                        |");
    Console.WriteLine("===========================================");
    }

static bool IsValidChoice(string userChoice) {
    if(userChoice=="1" || userChoice=="2" || userChoice=="3" || userChoice=="4" || userChoice=="5") {
        return true;
    }
    return false;
}

static void RouteEm(int menuChoice, MenuUtility menuUtility) {
    if(menuChoice==1) {
       menuUtility.TrainerMenu();
    }
    else if(menuChoice==2) {
        menuUtility.ListingMenu();
    }
    else if(menuChoice==3) {
        menuUtility.BookingMenu();
    }
    else if(menuChoice==4) {
        menuUtility.ReportMenu();
    }
    else if(menuChoice!=5) {
        menuUtility.SayInvalid();
    }
}

// ask about why when you add trainers. The file resets when you start adding again instead of adding more into it


