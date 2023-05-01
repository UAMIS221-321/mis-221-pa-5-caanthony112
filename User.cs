namespace mis_221_pa_5_caanthony112
{
    public class User
    {
        private string userName;

        private string password;

        static private int count;

        public User() {

        }

        public User(string userName, string password) {
            this.userName = userName;
            this.password = password;
        }

        public void SetUserName(string userName) {
            this.userName = userName;
        }

        public string GetUserName() {
            return userName;
        }

        public void SetPassword(string password){
            this.password = password;
        }

        public string GetPassword() {
            return password;
        }

        static public void SetCount(int count) {
            User.count = count;
        }

        static public int GetCount() {
            return User.count;
        }

        static public void IncCount() {
            User.count++;
        }

        public string ToFile(){
            return $"{userName}#{password}";
        }
    }
}
