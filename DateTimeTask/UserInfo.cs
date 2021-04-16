namespace DateTimeTask
{
    public class UserInfo
    {
        private int year;
        private int month;
        private int days;
        public int Days
        {
            get { return days; }
            set {
                if(value > 0 && value <= 31)
                {
                    days = value;
                }else{
                    throw new System.ArgumentOutOfRangeException();
                }
                }
        }
        
        public int Month
        {
            get { return month; }
            set {
                if(value > 0 && value <= 12)
                {
                    month = value;
                }else{
                    throw new System.ArgumentOutOfRangeException();
                }
                }
        }
        
        public int Year
        {
            get { return year; }
            set {
                if(value > 0)
                {
                    year = value;
                }else{
                    throw new System.ArgumentOutOfRangeException();
                }
                }
        }
        
    }
}