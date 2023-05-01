namespace mis_221_pa_5_caanthony112
{
    public class UserUtility
    {
        private User[] users;

        public UserUtility(User[] users) {
            this.users = users;
        }

        public void GetUsers() {
            User.SetCount(0);
            System.Console.WriteLine("Please enter your desired username or STOP to stop(Words only please)");
            string userInput = Console.ReadLine();
            while(userInput.ToUpper() != "STOP"){
                users[User.GetCount()] = new User();
                users[User.GetCount()].SetUserName(userInput);

                System.Console.WriteLine("Please enter your desired password");
                users[User.GetCount()].SetPassword(Console.ReadLine());

                User.IncCount();

                Save();
                System.Console.WriteLine("Please enter your desired username or STOP to stop(Words only please)");
                userInput = Console.ReadLine();
            }
        }

        public void Save() {
            StreamWriter outFile = new StreamWriter("users.txt");
            for(int i = 0; i < User.GetCount(); i++) {
                outFile.WriteLine(users[i].ToFile());
            }
            outFile.Close();
        }

        private int Find(string searchVal, string searchPass){
            for(int i = 0; i < User.GetCount(); i++) {
                if(users[i].GetUserName().ToUpper() == searchVal && users[i].GetPassword().ToUpper() == searchPass) {
                    return 0;
                }
            }
            return -1;
        }

        public void CheckUser() {
            System.Console.WriteLine("Please enter youre UserName");
            string searchVal = Console.ReadLine();
            System.Console.WriteLine("Please enter youre password");
            string searchPass  = Console.ReadLine();
            int foundIndex = Find(searchVal, searchPass);
            if(foundIndex == -1){
                SayInvalid();
            }
            else {
                PauseAction();
            }
        }

        public void GetUsersFromFile() {
            StreamReader inFile = new StreamReader("users.txt");

            User.SetCount(0);
            string line = inFile.ReadLine();
            while(line != null){
                string[] temp = line.Split("#");
                users[User.GetCount()] = new User(temp[0], temp[1]);
                User.IncCount();
                line = inFile.ReadLine();
            }
            inFile.Close();
        }

        public void SayInvalid() {
            System.Console.WriteLine("Invalid!");
            PauseAction();
        }

        public void PauseAction() {
            System.Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }
}