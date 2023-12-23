namespace jj;
public static  class NotificationServices{
    public static void Sendsms(string msg){
    Console.WriteLine(msg+"deposited sms");
    }
     public  static  void Sendemail(string msg){
    Console.WriteLine("deposited by email");
     }

     public static  void Sendwp(string msg){
    Console.WriteLine("deposited by wp");
}
}